using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QLgac
{
    public class Encrypt
    {
        public static string HashString(string passStr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(passStr))
            {
                sb.Append(b.ToString("X3"));
            }
            return sb.ToString();
        }
        public static byte[] GetHash(string passStr)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passStr));
            }
        }
    }
}
