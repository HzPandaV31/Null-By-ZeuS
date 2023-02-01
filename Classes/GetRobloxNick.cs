using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Null.Classes
{
    internal class GetRobloxNick
    {
        static string rblxpath = @"%LOCALAPPDATA%\Roblox\logs\";
        public static string RobloxNick()
        {
            try
            {
                rblxpath = Environment.ExpandEnvironmentVariables(rblxpath);
                DirectoryInfo dinfo = new DirectoryInfo(rblxpath);
                FileInfo[] File1 = dinfo.GetFiles("*.log");

                foreach (FileInfo file in File1)
                {
                    string rawtext = File.ReadAllText(file.FullName);
                    string ara = "UserName%22%3a%22";
                    string ara1 = "%22%2c%22DisplayName";

                    if (rawtext.Contains("UserName"))
                    {
                        int sonuc = rawtext.IndexOf(ara, 0, rawtext.Length);
                        int sonuc1 = rawtext.IndexOf(ara1, 0, rawtext.Length);

                        string Username = rawtext.Substring(sonuc + 17, sonuc1 - sonuc - 17);
                        return Username;
                    }

                }
                return null;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                return null;
            }
        }
    }
}
