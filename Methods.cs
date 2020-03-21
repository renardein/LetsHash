using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace LetsHash
{
    class Methods
    {
        private static string GenerateHashString(HashAlgorithm algo, string text)
        {
            algo.ComputeHash(Encoding.UTF8.GetBytes(text));
            var result = algo.Hash;
            return string.Join(
            string.Empty,
            result.Select(x => x.ToString("x2")));
        }
        public static string SHA1(string text)
        {
            var result = default(string);
            using (var algo = new SHA1Managed())
            {
                result = GenerateHashString(algo, text);
            }
            return result;
        }

        public static string SHA256(string text)
        {
            var result = default(string);
            using (var algo = new SHA256Managed())
            {
                result = GenerateHashString(algo, text);
            }
            return result;
        }
        public static string SHA384(string text)
        {
            var result = default(string);
            using (var algo = new SHA384Managed())
            {
                result = GenerateHashString(algo, text);
            }
            return result;
        }
        public static string MD5(string text)
        {
            var result = default(string);
            using (var algo = new MD5CryptoServiceProvider())
            {
                result = GenerateHashString(algo, text);
            }
            return result;
        }
        public static string SHA512(string text)
        {
            var result = default(string);
            using (var algo = new SHA512Managed())
            {
                result = GenerateHashString(algo, text);
            }
            return result;
        }
        public static string GetBase64(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            string base64 = Convert.ToBase64String(buffer);
            return base64;
        }
        public static string GetTextFromBase64(string text)
        {
            byte[] buffer = Convert.FromBase64String(text);
            string res = Encoding.UTF8.GetString(buffer);
            return res;
        }

    }
}
