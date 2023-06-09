﻿using System.Text;

namespace NoteDotNetCoreUseReverseEngineering.Models.MD5Service
{
    public static class MD5Extensions
    {
        public static string ToMD5(this string str)
        {
            using (var cryptoMD5 = System.Security.Cryptography.MD5.Create())
            {
                //將字串編碼成 UTF8 位元組陣列
                var bytes = Encoding.UTF8.GetBytes(str);

                //取得雜湊值位元組陣列
                var hash = cryptoMD5.ComputeHash(bytes);
                // MD5CryptoServiceProvider crypto_MD5 = new MD5CryptoServiceProvider();

                //取得 MD5
                var md5 = BitConverter.ToString(hash)
                  .Replace("-", String.Empty)
                  .ToLower();

                return md5;
            }
        }
    }
}
