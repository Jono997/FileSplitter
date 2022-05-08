using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FileSplitter
{
    internal struct Fragment
    {
        /// <summary>
        /// The version of the FileSplitter Fragment format this fragment is using
        /// </summary>
        internal byte FormatVersion { get; private set; }

        /// <summary>
        /// The ID of this fragment's series
        /// </summary>
        internal long SeriesID { get; private set; }

        /// <summary>
        /// This fragment's position in its series
        /// </summary>
        internal int Position { get; private set; }

        /// <summary>
        /// The total number of fragments in this fragment's series
        /// </summary>
        internal int FragmentCount { get; private set; }

        /// <summary>
        /// The SHA-512 digest of this fragment's payload
        /// </summary>
        internal byte[] FragmentDigest { get; private set; }

        /// <summary>
        /// The SHA-512 digest of the complete payload
        /// </summary>
        internal byte[] SeriesDigest { get; private set; }

        internal byte[] Payload { get; private set; }

        const byte CURRENT_VERSION = 0;
        internal const int HEADER_SIZE = 0x91;

        private static readonly SHA512 SHA = SHA512.Create();

        internal Fragment(long SeriesID, int Position, int FragmentCount, byte[] FragmentDigest, byte[] SeriesDigest, byte[] Payload)
        {
            FormatVersion = CURRENT_VERSION;
            this.SeriesID = SeriesID;
            this.Position = Position;
            this.FragmentCount = FragmentCount;
            this.FragmentDigest = FragmentDigest;
            this.SeriesDigest = SeriesDigest;
            this.Payload = Payload;
        }

        internal Fragment(long SeriesID, int Position, int FragmentCount, byte[] SeriesDigest, byte[] Payload)
            : this(SeriesID, Position, FragmentCount, SHA.ComputeHash(Payload), SeriesDigest, Payload) { }

        /// <summary>
        /// Serialises this Fragment into a byte array and returns it
        /// </summary>
        internal byte[] Serialise()
        {
            byte[] retVal = new byte[HEADER_SIZE + Payload.Length];
            retVal[0] = CURRENT_VERSION;
            BitConverter.GetBytes(SeriesID).CopyTo(retVal, 1);
            BitConverter.GetBytes(Position).CopyTo(retVal, 0x09);
            BitConverter.GetBytes(FragmentCount).CopyTo(retVal, 0x0D);
            FragmentDigest.CopyTo(retVal, 0x11);
            SeriesDigest.CopyTo(retVal, 0x51);
            Payload.CopyTo(retVal, 0x91);
            return retVal;
        }

        /// <summary>
        /// Deseralises a byte array into a Fragment object and returns it
        /// </summary>
        /// <param name="serialised_fragment">A serialised Fragment object</param>
        internal static Fragment Deserialise(byte[] serialised_fragment)
        {
            byte version = serialised_fragment[0];
            long series_id = BitConverter.ToInt64(serialised_fragment, 1);
            int position = BitConverter.ToInt32(serialised_fragment, 9);
            int fragment_count = BitConverter.ToInt32(serialised_fragment, 0x0D);
            byte[] fragment_digest = serialised_fragment.SubArray(0x11, 64);
            byte[] series_digest = serialised_fragment.SubArray(0x51, 64);
            byte[] payload = serialised_fragment.SubArray(0x91);

            return new Fragment(series_id, position, fragment_count, fragment_digest, series_digest, payload);
        }

        /// <summary>
        /// Creates a Fragment Series based on the parameters provided and returns it.
        /// </summary>
        /// <param name="payload">The file to be split</param>
        /// <param name="fragment_size">The maximum size a Fragment should be</param>
        /// <returns>An array of Fragment objects, being the Series created</returns>
        /// <exception cref="FragmentSizeException"></exception>
        internal static Fragment[] MakeSeries(byte[] payload, long fragment_size)
        {
            // Calculate Fragment Count
            if (fragment_size <= HEADER_SIZE)
                throw new FragmentSizeException($"fragment_size cannot be less than {HEADER_SIZE} bytes");
            long fragment_payload_size = fragment_size - HEADER_SIZE;
            int fragment_count = (int)((payload.Length - payload.Length % fragment_payload_size) / fragment_payload_size);
            if (payload.Length % fragment_payload_size > 0)
                fragment_count++;

            // Generate Series ID
            Random rand = new Random();
            int series_upper = rand.Next(int.MinValue, int.MaxValue);
            int series_lower = rand.Next(int.MinValue, int.MaxValue);
            byte[] series_binary = new byte[8];
            BitConverter.GetBytes(series_upper).CopyTo(series_binary, 0);
            BitConverter.GetBytes(series_lower).CopyTo(series_binary, 4);
            long series_id = BitConverter.ToInt64(series_binary, 0);

            byte[] series_digest = SHA.ComputeHash(payload);
            Fragment[] series = new Fragment[fragment_count];
            for (int i = 0; i < fragment_count; i++)
            {
                byte[] fragment_payload;
                if (i == fragment_count - 1)
                    fragment_payload = payload.SubArray(i * fragment_payload_size);
                else
                    fragment_payload = payload.SubArray(i * fragment_payload_size, fragment_payload_size);
                series[i] = new Fragment(series_id, i, fragment_count, series_digest, fragment_payload);
            }
            return series;
        }

        /// <summary>
        /// Joins a Fragment Series into a singular file and returns it
        /// </summary>
        /// <param name="series">The Fragment Series to get the file from</param>
        /// <returns>The file that the Fragment Series was made from</returns>
        /// <exception cref="InvalidFragmentSeriesException">The Fragment Series failed a validation check</exception>
        internal static byte[] GetFileFromSeries(Fragment[] series)
        {
            if (!ValidSeries(series))
                throw new InvalidFragmentSeriesException();

            int payload_length = 0;
            byte[][] fragment_payloads = new byte[series.Length][];
            foreach (Fragment f in series)
            {
                fragment_payloads[f.Position] = f.Payload;
                payload_length += f.Payload.Length;
            }
            byte[] retVal = new byte[payload_length];
            int retVal_i = 0;
            for (int i = 0; i < fragment_payloads.Length; i++)
            {
                fragment_payloads[i].CopyTo(retVal, retVal_i);
                retVal_i += fragment_payloads[i].Length;
            }
            return retVal;
        }

        #region Validation
        /// <summary>
        /// Checks if this Fragment passes the following checks:<br />
        /// - The version is lower than or equal to the highest supported version<br />
        /// - The Series ID, Fragment Count, and Series Digest of the 
        /// Fragment match the ones provided<br />
        /// - The Position is greater than or equal to 0<br />
        /// - The Position is less than Fragment Count<br />
        /// - The Fragment Digest matches the SHA-512 digest of the Fragment's Payload
        /// </summary>
        /// <param name="series_id"></param>
        /// <param name="fragment_count"></param>
        /// <param name="series_digest"></param>
        /// <returns>true if all checks were passed<br />false if a check failed</returns>
        internal bool Valid(long series_id, int fragment_count, byte[] series_digest)
        {
            if (FormatVersion > CURRENT_VERSION) return false;
            if (series_id != SeriesID) return false;
            if (fragment_count != FragmentCount) return false;
            if (!Enumerable.SequenceEqual(series_digest, SeriesDigest)) return false;
            if (Position < 0) return false;
            if (Position >= fragment_count) return false;
            if (!Enumerable.SequenceEqual(SHA.ComputeHash(Payload), FragmentDigest)) return false;
            return true;
        }

        /// <summary>
        /// Checks if this Series passes the following checks:<br />
        /// - The series is greater than 0 Fragments long<br />
        /// - The Fragment Count is the same as the number of Fragments in the Series<br />
        /// - Each Fragment passes its individual validation
        /// (Fragment.Valid returns true)<br />
        /// - There are no missing Fragments from the Series<br />
        /// - The Series Digest matches the SHA-512 digest of the combined payload
        /// </summary>
        /// <param name="series">The fragment series to validate</param>
        /// <returns>true if all checks were passed<br />false if a check failed</returns>
        internal static bool ValidSeries(Fragment[] series)
        {
            if (series.Length == 0) return false;
            long series_id = series[0].SeriesID;
            int fragment_count = series[0].FragmentCount;
            byte[] series_digest = series[0].SeriesDigest;

            if (series.Length != fragment_count) return false;
            byte[][] fragment_payloads = new byte[fragment_count][];
            int payload_length = 0;
            foreach (Fragment f in series)
            {
                if (!f.Valid(series_id, fragment_count, series_digest)) return false;
                fragment_payloads[f.Position] = f.Payload;
                payload_length += f.Payload.Length;
            }

            byte[] final_payload = new byte[payload_length];
            int payload_index = 0;
            foreach (byte[] payload in fragment_payloads)
            {
                if (payload == null) return false;
                payload.CopyTo(final_payload, payload_index);
                payload_index += payload.Length;
            }
            if (!Enumerable.SequenceEqual(series_digest, SHA.ComputeHash(final_payload))) return false;
            return true;
        }
        #endregion
    }


    [Serializable]
    public class FragmentSizeException : Exception
    {
        public FragmentSizeException() { }
        public FragmentSizeException(string message) : base(message) { }
        public FragmentSizeException(string message, Exception inner) : base(message, inner) { }
        protected FragmentSizeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class InvalidFragmentSeriesException : Exception
    {
        public InvalidFragmentSeriesException() { }
        public InvalidFragmentSeriesException(string message) : base(message) { }
        public InvalidFragmentSeriesException(string message, Exception inner) : base(message, inner) { }
        protected InvalidFragmentSeriesException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
