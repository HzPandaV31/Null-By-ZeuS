using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Null
{
    class Connection
    {
        //firebase Connection settings
        public static string key = "FIREBASE KEY";
        public static string BasePath = "FIREBASE PATH";

        public static string Decrypt(string text)
        {
            //dont touch here
            string hash = "";

            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(Encoding.Default.GetBytes(hash));
                using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = triple.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

                    byte[] veri = Convert.FromBase64String(Encoding.Default.GetString(result));
                    string anametin = ASCIIEncoding.ASCII.GetString(veri);

                    return anametin;
                }
            }

            
        }

        public static FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = Decrypt(key),
            BasePath = BasePath
        };

        public static IFirebaseClient db = new FireSharp.FirebaseClient(config);
    }
}
