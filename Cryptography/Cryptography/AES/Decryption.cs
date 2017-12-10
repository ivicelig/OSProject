using System;
using System.IO;
using System.Security.Cryptography;

namespace Cryptography.AES
{
    static public class Decryption
    {
        
            static public string Decrypt(byte[] cryptedText)
        {

            string plainText = null;

            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                string stringIV = CWRFiles.ReadWrite.ReadFromFile("AES_IV");
                byte[] IVInByteArray = System.Convert.FromBase64String(stringIV);

                string key = CWRFiles.ReadWrite.ReadFromFile("AES_Key");
                byte[] keyInByteArray = System.Convert.FromBase64String(key);
                rijAlg.Key = keyInByteArray;
                rijAlg.IV =IVInByteArray;
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
