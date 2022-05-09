using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;

namespace AssociateSFF
{
    public static class Program
    {
        public const string REGISTRY_ASSOCIATION_SUCCESS = "FileAssociationSuccess";

        static void Main(string[] args)
        {
            string exe_path = $@"{Path.GetDirectoryName(Environment.GetCommandLineArgs()[0])}\FileSplitter.exe";
            RegistryKey format_key = Registry.ClassesRoot.CreateSubKey("FileSplitter.FileSplitterFragment.1");
            format_key.SetValue("", "FileSplitter file fragment");
            format_key.CreateSubKey("CurVer")
                .SetValue("", "FileSplitter.FileSplitterFragment.1");
            format_key.CreateSubKey("shell")
                .CreateSubKey("Open")
                    .CreateSubKey("command")
                        .SetValue("", $"\"{exe_path}\" \"%1\"");

            Registry.ClassesRoot.CreateSubKey(".sff")
                .SetValue("", "FileSplitter.FileSplitterFragment.1");

            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);

            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Jono99\FileSplitter", REGISTRY_ASSOCIATION_SUCCESS, 1);
        }

        [DllImport("shell32.dll")]
        extern static void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
    }
}
