using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Cryptography.RSA
{
    static class Decrypting
    {
        
        static public byte[] decrypting(byte[] cryptedText)
        {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
                TextReader reader = new StreamReader(@"..\..\..\Files\private_keyRSA.txt");
                string privateKey = reader.ReadToEnd();
                reader.Close();
                rsa.FromXmlString(privateKey);
                byte[] results = rsa.Decrypt(cryptedText,false);
                return results;
                
            }


           
            
        }


    
}
