using System;
using System.IO;
using System.Security.Cryptography;

namespace Cryptography.AES
{
    static public class Decryption
    {
        
            static public string Decrypt(byte[] cryptedText, byte[] IV)
        {

            string plainText = null;

            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {

                
                string key = CWRFiles.ReadWrite.ReadFromFile("AES_Key");
                byte[] keyInByteArray = System.Convert.FromBase64String(key);
                rijAlg.Key = keyInByteArray;
                rijAlg.IV = IV;
                rijAlg.Padding = PaddingMode.Zeros;



                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
                

                using (MemoryStream msDecrypt = new MemoryStream(cryptedText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plainText = srDecrypt.ReadToEnd();
                        }
                      
                    }

                    
                }
            }

            return plainText;



        }



    }
}
