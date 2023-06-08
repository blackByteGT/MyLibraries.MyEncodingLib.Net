using System;
using System.Text;
using System.Security.Cryptography;
using MyLibraries.MyEncodingLib.Enums;

namespace MyLibraries.MyEncodingLib.Classes
{
    /// <summary>
    /// HMAC
    /// </summary>
    static public class MyHMAC
    {
        #region Classes
        /// <summary>
        /// SHA-256
        /// </summary>
        static public class SHA256
        {
            /// <summary>
            /// Зашифрувати (захешувати)
            /// </summary>
            /// <param name="hashedStr">Захешований рядок</param>
            /// <param name="textFormat">Формат вихідного тексту</param>
            /// <param name="secretKey">Секретний ключ</param>
            /// <param name="text">Текс для хешування</param>
            static public void Encrypt(ref string hashedStr, OutputTextFormat textFormat, string secretKey, string text)
            {
                var encoding = new ASCIIEncoding();
                byte[] keyByte = encoding.GetBytes(secretKey);
                byte[] messageBytes = encoding.GetBytes(text);

                using (var hmacsha256 = new HMACSHA256(keyByte))
                {
                    byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);

                    switch (textFormat)
                    {
                        case OutputTextFormat.HEX:
                            {
                                hashedStr = Convert.ToHexString(hashmessage);
                                return;
                            }
                        case OutputTextFormat.Base64:
                            {
                                hashedStr = Convert.ToBase64String(hashmessage);
                                return;
                            }
                    }
                }
            }
        }
        #endregion Classes
    }
}
