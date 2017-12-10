using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace Cryptography
{
    public partial class Form1 : Form
    {
        RijndaelManaged aes = new RijndaelManaged();
        
        public Form1()
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadText_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Files");
            theDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);

            

            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                txtEncryptedText.Text = String.Empty;
                txtDecryptedText.Text = String.Empty;
                using (StreamReader sr = new StreamReader(theDialog.FileName))
                {
                    txtPlainText.Text = sr.ReadToEnd();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtPlainText.Text.Length == 0)
            {
                MessageBox.Show("Niste unijeli tekst za kriptiranje!");
            }
            else
            {
                byte[] stringToEncrypt = System.Text.Encoding.UTF8.GetBytes(txtPlainText.Text);
                byte[] encryptedString = RSA.Encrypting.Encrypt(stringToEncrypt);
                txtEncryptedText.Text = System.Convert.ToBase64String(encryptedString);
            }
        }

        private void txtEncryptedText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                string encryptedText = CWRFiles.ReadWrite.ReadFromFile("encrypted_Text_RSA");
            if (encryptedText != null)
            {
                byte[] stringToDecrypt = System.Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = RSA.Decrypting.decrypting(stringToDecrypt);
                txtDecryptedText.Text = System.Text.Encoding.UTF8.GetString(decryptedBytes);
            }
            else
            {
                txtDecryptedText.Text = String.Empty;
            }
                

            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Files");
            theDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);



            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                txtEncryptedText.Text = String.Empty;
                txtDecryptedText.Text = String.Empty;
                using (StreamReader sr = new StreamReader(theDialog.FileName))
                {
                    txtPlain.Text = sr.ReadToEnd();
                }
            }
        }

        private void btnEncryptAES_Click(object sender, EventArgs e)
        {
            if (txtPlain.Text.Length == 0)
            {
                MessageBox.Show("Ne postoji sadržaj za kriptiranje!");
            }
            else
            {
                
                byte[] encryptedAESText = AES.Encryption.Encrypt(txtPlain.Text);
                byte[] IV = System.Convert.FromBase64String(CWRFiles.ReadWrite.ReadFromFile("AES_IV"));
                MessageBox.Show(System.Convert.ToBase64String(encryptedAESText));
                txtEncryptedAES.Text = System.Convert.ToBase64String(encryptedAESText);
                CWRFiles.CFiles.CreateFile("AES_Encrypted");
                CWRFiles.ReadWrite.WriteToFile(System.Convert.ToBase64String(encryptedAESText), "AES_Encrypted");

                

            }
        }

        private void btnDecryptAES_Click(object sender, EventArgs e)
        {

            string encryptedText = CWRFiles.ReadWrite.ReadFromFile("AES_Encrypted");
            if (encryptedText != null)
            {
                byte[] IV = System.Convert.FromBase64String(CWRFiles.ReadWrite.ReadFromFile("AES_IV"));
                byte[] base64ByteToDecrypt = System.Convert.FromBase64String(encryptedText);
                string decrypted = AES.Decryption.Decrypt(base64ByteToDecrypt);
                txtDecryptedAES.Text = decrypted;
            }
            else
            {
                txtDecryptedAES.Text = String.Empty;
            }
            
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string privateKey = CWRFiles.ReadWrite.ReadFromFile("private_keyRSA");
            rsa.FromXmlString(privateKey);
            Signature.Signature signature = new Signature.Signature(rsa);
            string message = CWRFiles.ReadWrite.ReadFromFile("plain_text");
            byte[] messagetoByte = System.Text.Encoding.UTF8.GetBytes(message);
            byte[] hashForSignature = Signature.Hash.ComputeHashForMessage(messagetoByte);
            byte[] signature1 = signature.CreateSignature(hashForSignature);
            CWRFiles.ReadWrite.WriteToFile (System.Convert.ToBase64String(signature1),"signature");
            txtSignature.Text = System.Convert.ToBase64String(signature1);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string message = CWRFiles.ReadWrite.ReadFromFile("plain_text");
            byte[] messagetoByte = System.Text.Encoding.UTF8.GetBytes(message);
            byte[] hashValue = Signature.Hash.ComputeHashForMessage(messagetoByte);
            txtHash.Text = System.Convert.ToBase64String(hashValue);
            CWRFiles.ReadWrite.WriteToFile(System.Convert.ToBase64String(hashValue),"hash");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string privateKey = CWRFiles.ReadWrite.ReadFromFile("private_keyRSA");
            rsa.FromXmlString(privateKey);
            Signature.Signature signature = new Signature.Signature(rsa);
            string message = CWRFiles.ReadWrite.ReadFromFile("plain_text");
            byte[] messagetoByte = System.Text.Encoding.UTF8.GetBytes(message);
            byte[] hashValue = Signature.Hash.ComputeHashForMessage(messagetoByte);
            string Hash = System.Convert.ToBase64String(hashValue);

            
            string signatureFromFile = CWRFiles.ReadWrite.ReadFromFile("signature");
            byte[] byteHash = System.Convert.FromBase64String(Hash);
            byte[] byteSignature = System.Convert.FromBase64String(signatureFromFile);
            if (signature.veritifySignature(byteHash,byteSignature))
            {
                MessageBox.Show("Potpis je ispravan!");
            }
            else
            {
                MessageBox.Show("Potpis nije ispravan!");
            }

        }
    }
   
}

