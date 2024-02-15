using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace BloatyNosy
{
    internal class ModsParser
    {
        private static FileInfo fi;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public string ReadString(string selection, string Key, string vDefault = "")
        {
            StringBuilder sb = new StringBuilder(1024);

            // Get ini file
            GetPrivateProfileString(selection, Key, vDefault, sb, 1024, fi.FullName);
            return sb.ToString();
        }

        public List<string> ReadSelections()
        {
            List<string> temp = new List<string>();
            string sLine = string.Empty;

            if (!fi.Exists)
            {
                return temp;
            }

            using (StreamReader sr = new StreamReader(fi.FullName))
            {
                while (!sr.EndOfStream)
                {
                    // Get and trim line
                    sLine = sr.ReadLine().Trim();
                    // Check for opening and closeing tags
                    if (sLine.StartsWith("[") && (sLine.EndsWith("]")))
                    {
                        // Add to collection
                        temp.Add(sLine.Substring(1, sLine.Length - 2));
                    }
                }
                sr.Close();
            }
            return temp;
        }

        public ModsParser(string Filename)
        {
            fi = new FileInfo(Filename);
        }
    }
}