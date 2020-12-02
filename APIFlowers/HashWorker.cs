using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace APIFlowers
{
    public class HashWorker
    {
        public static string GetHashString(string stringToHash)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5Data = md5.ComputeHash(Encoding.ASCII.GetBytes(stringToHash));
            return Encoding.ASCII.GetString(md5Data);
        }
    }
}
