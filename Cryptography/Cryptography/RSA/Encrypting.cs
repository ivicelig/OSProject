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
    static class Encrypting
    {
        
        
        static public byte[] Encrypt(byte[] clearText)
        {
            try
            {
                if (clearText.Length > 128)
                {
                    throw new ByteSize("String is too large");
                }
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
                if (ReadWrite.DoesFileExist(@"..\..\..\Files\public_key.txt") && ReadWrite.DoesFileExist(@"..\..\..\Files\private_keyRSA.txt"))
                {
                    TextReader textReader = new StreamReader(@"..\..\..\Files\public_keyRSA.txt");

                    string readXMLString = textReader.ReadToEnd();
                    textReader.Close();
                    rsa.FromXmlString(readXMLString);

                    byte[] encryptedText = rsa.Encrypt(clearText, false);
                    return encryptedText;
                }
                else
                {

                    TextWriter textWriter = new StreamWriter(@"..\..\..\Files\public_keyRSA.txt");
                    string publicKey = rsa.ToXmlString(false);
                    textWriter.Write(publicKey);
                    textWriter.Close();
                    textWriter = new StreamWriter(@"..\..\..\Files\private_keyRSA.txt");
                    string privateKey = rsa.ToXmlString(true);
                    textWriter.Write(privateKey);
                    textWriter.Close();

                    byte[] encryptedText = rsa.Encrypt(clearText, false);
                    CFiles.CreateFile("encrypted_Text_RSA");
                    string encryptedTextInString = System.Convert.ToBase64String(encryptedText);
                    ReadWrite.WriteToFile(encryptedTextInString, "encrypted_Text_RSA");
                    return encryptedText;




                }

            }
            catch (ByteSize e)
            {
                MessageBox.Show("Lenght of string is to large.");
                return new byte[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Generic error!");
                return new byte[0];
            }
           
           
                
         }

    }
}

public class ByteSize : Exception
{
    public ByteSize(string message)
       : base(message)
    {
    }
}