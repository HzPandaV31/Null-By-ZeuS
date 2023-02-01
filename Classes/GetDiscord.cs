using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Null.Classes
{
    internal class GetDiscord
    {
        static string dcpath = @"%appdata%\discord\Local Storage\leveldb\";
        static Properties.Settings settings = Properties.Settings.Default;
        static WebClient client = new WebClient();
        static public string pnghash;
        static public string banner;
        static public string rawhtml = client.DownloadString("https://discordlookup.com/user/" + UserID());

        public static string Banner()
        {
            try
            {
                
                if (rawhtml.Contains(@"https://cdn.discordapp.com/banners/"))
                {
                    string ara = @"<img src=""https://cdn.discordapp.com/banners/";
                    string ara1 = "?size=512\" loading=\"lazy\" class=\"rounded-3\"";
                    
                    int sonuc = rawhtml.IndexOf(ara, 0, rawhtml.Length);
                    int sonuc1 = rawhtml.IndexOf(ara1, 0, rawhtml.Length);
                    if (sonuc == -1 && sonuc1 == -1)
                    {
                        string ara2 = "try again in ";
                        string ara3 = " seconds or log";

                        int sonuc2 = rawhtml.IndexOf(ara2, 0, rawhtml.Length);
                        int sonuc3 = rawhtml.IndexOf(ara3, 0, rawhtml.Length);

                        string second = rawhtml.Substring(sonuc2 + 12, sonuc3 - sonuc2);

                        return null;
                    }
                    else
                    {
                        banner = rawhtml.Substring(sonuc + 45, sonuc1 - sonuc - 45);

                        string bannerfulllink = "https://cdn.discordapp.com/banners/" + banner + "?size=512";

                        if (banner != null && settings.DcBannerLink != bannerfulllink)
                        {
                            settings.DcBannerLink = bannerfulllink;
                            settings.Save();
                        }
                        return bannerfulllink;
                    }
                }
                return settings.DcBannerLink;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public static string UserID()
        {
            try
            {
                dcpath = Environment.ExpandEnvironmentVariables(dcpath);
                DirectoryInfo dinfo = new DirectoryInfo(dcpath);
                FileInfo[] File1 = dinfo.GetFiles("*.ldb");

                foreach (FileInfo file in File1)
                {
                    string rawtext = File.ReadAllText(file.FullName);

                    if (rawtext.Contains("{\"id\":\""))
                    {
                        string ara = "{\"id\":\"";
                        string ara1 = "\",\"avatar\":";

                        int sonuc = rawtext.IndexOf(ara, 0, rawtext.Length);
                        int sonuc1 = rawtext.IndexOf(ara1, 0, rawtext.Length);

                        string UserID = rawtext.Substring(sonuc + 7, sonuc1 - sonuc - 7);

                        if (UserID == null)
                        {
                            FileInfo[] File2 = dinfo.GetFiles("*.log");

                            foreach (FileInfo file1 in File2)
                            {
                                if (!File.Exists(file1.FullName.TrimEnd('g', 'o', 'l') + "txt"))
                                {
                                    File.Copy(file1.FullName, file1.FullName.TrimEnd('g', 'o', 'l') + "txt");
                                }
                                string rawtext1 = File.ReadAllText(file1.FullName.TrimEnd('g', 'o', 'l') + "txt");

                                if (rawtext1.Contains("{\"_state\":{\""))
                                {
                                    string ara2 = "{\"_state\":{\"";
                                    string ara3 = "\":{}},\"_version\":";

                                    int sonuc2 = rawtext1.IndexOf(ara2, 0, rawtext1.Length);
                                    int sonuc3 = rawtext1.IndexOf(ara3, 0, rawtext1.Length);

                                    string UserID2 = rawtext1.Substring(sonuc2 + 12, sonuc3 - sonuc2 - 12);
                                    File.Delete(file1.FullName.TrimEnd('g', 'o', 'l') + "txt");

                                    if (settings.DcID != UserID2 && UserID2 != null)
                                    {
                                        settings.DcID = UserID2;
                                        settings.Save();
                                    }
                                    return UserID2;
                                }
                                else
                                {
                                    File.Delete(file.FullName.TrimEnd('g', 'o', 'l') + "txt");
                                }
                            }
                        }
                        else
                        {
                            if (settings.DcID != UserID)
                            {
                                settings.DcID = UserID;
                                settings.Save();
                            }
                            return UserID;
                        }
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
        public static string DcFullNick()
        {
            try
            {
                string rawhtml = client.DownloadString("https://discordlookup.com/user/" + settings.DcID);
                string start = "username&quot;:&quot;";
                string end = "&quot;,&quot;discr";
                string starttag = "iminator&quot;:&quot;";

                if (rawhtml.Contains(start))
                {
                    int sonuc = rawhtml.IndexOf(start, 0, rawhtml.Length);
                    int sonuc1 = rawhtml.IndexOf(end, 0, rawhtml.Length);
                    int sonuc2 = rawhtml.IndexOf(starttag, 0, rawhtml.Length);

                    string DcTag = rawhtml.Substring(sonuc2 + 21, 4);
                    string DcNick = rawhtml.Substring(sonuc + 21, sonuc1 - sonuc - 21);
                    return DcNick + "#" + DcTag;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string Pp()
        {
            try
            {
                if (rawhtml.Contains("?size=512&quot;"))
                {
                    string ara = @"https:\/\/cdn.discordapp.com\/avatars\/";
                    string ara1 = "?size=512&quot;";

                    int sonuc = rawhtml.IndexOf(ara, 0, rawhtml.Length);
                    int sonuc1 = rawhtml.IndexOf(ara1, 0, rawhtml.Length);
                    if (sonuc == -1 && sonuc1 == -1)
                    {
                        string ara2 = "try again in ";
                        string ara3 = " seconds or log";

                        int sonuc2 = rawhtml.IndexOf(ara2, 0, rawhtml.Length);
                        int sonuc3 = rawhtml.IndexOf(ara3, 0, rawhtml.Length);

                        string second = rawhtml.Substring(sonuc2 + 12, sonuc3 - sonuc2);

                        return null;
                    }
                    else
                    {
                        pnghash = rawhtml.Substring(sonuc + 59, sonuc1 - sonuc - 59);

                        string imagefulllink = "https://cdn.discordapp.com/avatars/" + settings.DcID + "/" + pnghash;

                        if (pnghash != null && settings.DcImageLink != imagefulllink)
                        {
                            settings.DcImageLink = imagefulllink;
                            settings.Save();
                        }
                        return imagefulllink;
                    }
                }
                return settings.DcImageLink;
            }
            catch (Exception)
            {

                return null;
            }

        }

    }
}
