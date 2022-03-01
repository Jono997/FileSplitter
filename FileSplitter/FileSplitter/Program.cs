using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSplitter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                TestFragmentValid();
                TestSeriesValid();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        #region Tests
        /// <summary>
        /// Test to see if individual Fragment validation is working correctly
        /// </summary>
        private static void TestFragmentValid()
        {
            Fragment test_fragment = new Fragment(
                1234, 0, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new byte[] { 1 }
            );

            // Valid fragment
            if (!test_fragment.Valid(1234, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 1 failed");

            // Series ID mismatch
            if (test_fragment.Valid(124, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 2 failed");

            // Fragment Count mismatch
            if (test_fragment.Valid(1234, 2, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 3 failed");

            // Series Digest mismatch
            if (test_fragment.Valid(1234, 1, new byte[] { 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 4 failed");

            // Position below 0
            test_fragment = new Fragment(
                1234, -1, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new byte[] { 1 }
            );
            if (test_fragment.Valid(1234, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 5 failed");

            // Position above Fragment Count
            test_fragment = new Fragment(
                1234, 1, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new byte[] { 1 }
            );
            if (test_fragment.Valid(1234, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 6 failed");

            // Fragment Digest mismatch
            test_fragment = new Fragment(
                1234, 0, 1, new byte[] { 9, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new byte[] { 1 }
            );
            if (test_fragment.Valid(1234, 1, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }))
                MessageBox.Show("Test 7 failed");
        }

        private static void TestSeriesValid()
        {
            // Valid series
            Fragment[] test_series = Fragment.MakeSeries(new byte[] { 1, 2, 3, 4, 5 }, 146);
            if (!Fragment.ValidSeries(test_series))
                MessageBox.Show("Test 8 failed");

            // Empty series
            test_series = new Fragment[0];
            if (Fragment.ValidSeries(test_series))
                MessageBox.Show("Test 9 failed");

            // Array size mismatch
            test_series = new Fragment[] { new Fragment(1, 0, 2, new byte[] { 80, 84, 11, 196, 174, 49, 135, 95, 206, 179, 130, 148, 52, 197, 94, 60, 43, 102, 221, 215, 34, 122, 136, 58, 59, 76, 200, 246, 205, 169, 101, 173, 23, 18, 179, 238, 0, 8, 249, 206, 224, 141, 169, 63, 82, 52, 193, 167, 191, 14, 37, 112, 239, 86, 214, 82, 128, 255, 234, 105, 27, 149, 62, 254 }, new byte[] { 1, 2, 3 }) };
            if (Fragment.ValidSeries(test_series))
                MessageBox.Show("Test 10 failed");

            // Invalid fragment
            test_series = new Fragment[] { new Fragment(1, 1, 1, new byte[] { 80, 84, 11, 196, 174, 49, 135, 95, 206, 179, 130, 148, 52, 197, 94, 60, 43, 102, 221, 215, 34, 122, 136, 58, 59, 76, 200, 246, 205, 169, 101, 173, 23, 18, 179, 238, 0, 8, 249, 206, 224, 141, 169, 63, 82, 52, 193, 167, 191, 14, 37, 112, 239, 86, 214, 82, 128, 255, 234, 105, 27, 149, 62, 254 }, new byte[] { 1, 2, 3, 4, 5 }) };
            if (Fragment.ValidSeries(test_series))
                MessageBox.Show("Test 11 failed");

            // Missing fragment
            test_series = new Fragment[]
            {
                new Fragment(1, 0, 3, new byte[] { 80, 84, 11, 196, 174, 49, 135, 95, 206, 179, 130, 148, 52, 197, 94, 60, 43, 102, 221, 215, 34, 122, 136, 58, 59, 76, 200, 246, 205, 169, 101, 173, 23, 18, 179, 238, 0, 8, 249, 206, 224, 141, 169, 63, 82, 52, 193, 167, 191, 14, 37, 112, 239, 86, 214, 82, 128, 255, 234, 105, 27, 149, 62, 254 }, new byte[] { 1, 2 }),
                new Fragment(1, 0, 3, new byte[] { 80, 84, 11, 196, 174, 49, 135, 95, 206, 179, 130, 148, 52, 197, 94, 60, 43, 102, 221, 215, 34, 122, 136, 58, 59, 76, 200, 246, 205, 169, 101, 173, 23, 18, 179, 238, 0, 8, 249, 206, 224, 141, 169, 63, 82, 52, 193, 167, 191, 14, 37, 112, 239, 86, 214, 82, 128, 255, 234, 105, 27, 149, 62, 254 }, new byte[] { 1, 2 }),
                new Fragment(1, 2, 3, new byte[] { 80, 84, 11, 196, 174, 49, 135, 95, 206, 179, 130, 148, 52, 197, 94, 60, 43, 102, 221, 215, 34, 122, 136, 58, 59, 76, 200, 246, 205, 169, 101, 173, 23, 18, 179, 238, 0, 8, 249, 206, 224, 141, 169, 63, 82, 52, 193, 167, 191, 14, 37, 112, 239, 86, 214, 82, 128, 255, 234, 105, 27, 149, 62, 254 }, new byte[] { 5 })
            };
            if (Fragment.ValidSeries(test_series))
                MessageBox.Show("Test 12 failed");

            // Series digest mismatch
            test_series = new Fragment[] { new Fragment(1, 0, 1, new byte[] { 80, 84, 11, 196, 174, 49, 135, 95, 206, 179, 130, 148, 52, 197, 94, 60, 43, 102, 221, 215, 34, 122, 136, 58, 59, 76, 200, 246, 205, 169, 101, 173, 23, 18, 179, 238, 0, 8, 249, 206, 224, 141, 169, 63, 82, 52, 193, 167, 191, 14, 37, 112, 239, 86, 214, 82, 128, 255, 234, 105, 27, 149, 62, 254 }, new byte[] { 1, 2, 3 }) };
            if (Fragment.ValidSeries(test_series))
                MessageBox.Show("Test 13 failed");

        }
        #endregion
    }
}
