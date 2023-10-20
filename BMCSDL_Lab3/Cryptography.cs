using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace BMCSDL_Lab3
{
    public class Cryptography
    {
        public static byte[] HashMD5(string text)
        {
            MD5 md5 = MD5.Create(); //tạo cài đặt hash bằng md5
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));//doi tu string qua bytes va hash bang md5
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2")); //chuoi duoc viet duoi dang 2 ky tu hex
            }
            return hash;//chuoi duoc viet lai duoi dang dec
        }
        public static byte[] HashSHA1(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hash;
        }
        

        public static byte[] AESEnc(string mykey, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] key = new Rfc2898DeriveBytes(mykey, iv, 1000).GetBytes(32);
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return array;
        }

        public static string AESDec(string mykey, byte[] cipherText)
        {
            byte[] iv = new byte[16];
            byte[] key = new Rfc2898DeriveBytes(mykey, iv, 1000).GetBytes(32);
            string plaintext = null;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
               
                aes.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(cryptoStream))
                        {
                            plaintext = sr.ReadToEnd();
                        }
                    }
                }
             
            }
            return plaintext;
        }




    }
}
