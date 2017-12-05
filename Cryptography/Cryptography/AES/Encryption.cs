using System;
using System.IO;
using System.Security.Cryptography;

namespace Cryptography.AES
{
    static public class Encryption
    {
        static public byte[] Encrypt(string plainText, byte[] IV)
        {
            
            byte[] encrypted;
            
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                
                //IF file with key doesn't exit, make new secret key and save it to file
                if (!CWRFiles.ReadWrite.DoesFileExist(@"..\..\..\Files\AES_Key.txt"))
                {
                    rijAlg.GenerateKey();
                    byte[] secretKey = rijAlg.Key;
                    string zapis = System.Convert.ToBase64String(secretKey);
                    CWRFiles.CFiles.CreateFile("AES_Key");
                    CWRFiles.ReadWrite.WriteToFile(zapis, "AES_Key");

                }
                string key = CWRFiles.ReadWrite.ReadFromFile("AES_Key");
                byte[] keyInByteArray = System.Convert.FromBase64String(key);
                rijAlg.Key = keyInByteArray;
                rijAlg.IV = IV;
                rijAlg.Padding = PaddingMode.Zeros;



                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key,rijAlg.IV);

             
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


           
            return encrypted;

        }



    }
}
