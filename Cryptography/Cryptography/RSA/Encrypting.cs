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
            if (ReadWrite.DoesFileExist(@"..\..\..\Files\public_key.xml") && ReadWrite.DoesFileExist(@"..\..\..\Files\private_key.xml"))
            {
                TextReader textReader = new StreamReader(@"..\..\..\Files\public_key.xml");

                string readXMLString = textReader.ReadToEnd();
                textReader.Close();
                rsa.FromXmlString(readXMLString);

                byte[] encryptedText = rsa.Encrypt(clearText, false);
                return encryptedText;
            }
            else
            {

                TextWriter textWriter = new StreamWriter(@"..\..\..\Files\public_key.xml");
                string publicKey = rsa.ToXmlString(false);
                textWriter.Write(publicKey);
                textWriter.Close();
                textWriter = new StreamWriter(@"..\..\..\Files\private_key.xml");
                string privateKey = rsa.ToXmlString(true);
                textWriter.Write(privateKey);
                textWriter.Close();

                MessageBox.Show(publicKey);
                


                return null;
            
            }

           
                
         }

    }
}
