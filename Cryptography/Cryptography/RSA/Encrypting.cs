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
using Cryptography.CWRFiles;

namespace Cryptography.RSA
{
    class Encrypting
    {
        
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
        public byte[] Encrypt(byte[] clearText)
        {
            if (ReadWrite.DoesFileExist(@"..\..\..\Files\public_key.xml") && ReadWrite.DoesFileExist(@"..\..\..\Files\private_keyRSA.xml"))
            {
                TextReader textReader = new StreamReader(@"..\..\..\Files\public_keyRSA.xml");

                string readXMLString = textReader.ReadToEnd();
                textReader.Close();
                rsa.FromXmlString(readXMLString);

                byte[] encryptedText = rsa.Encrypt(clearText, false);
                return encryptedText;
            }
            else
            {

                TextWriter textWriter = new StreamWriter(@"..\..\..\Files\public_keyRSA.xml");
                string publicKey = rsa.ToXmlString(false);
                textWriter.Write(publicKey);
                textWriter.Close();
                textWriter = new StreamWriter(@"..\..\..\Files\private_keyRSAy.xml");
                string privateKey = rsa.ToXmlString(true);
                textWriter.Write(privateKey);
                textWriter.Close();

                byte[] encryptedText = rsa.Encrypt(clearText, false);
                CFiles.CreateFile("encrypted_Text");
                string encryptedTextInString = System.Convert.ToBase64String(encryptedText);
                ReadWrite.WriteToFile(encryptedTextInString, "encrypted_Text");
                return encryptedText;
                


                
            }

           
                
         }

    }
}
