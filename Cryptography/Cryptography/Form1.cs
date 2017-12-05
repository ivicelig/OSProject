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
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            RSA.Encrypting a = new RSA.Encrypting();
            string ab = "Hello";
            

            byte[]abc = a.Encrypt(Encoding.ASCII.GetBytes(ab));
            RSA.Decrypting b = new RSA.Decrypting();
            byte[] decrypt = b.decrypting(abc);
            
            string decryptedTextInString = System.Text.Encoding.UTF8.GetString(decrypt);
            MessageBox.Show(decryptedTextInString);
            RijndaelManaged aes = new RijndaelManaged();
            aes.GenerateIV();
            MessageBox.Show("Encrypting with AES!");
            byte[] encrypted =  AES.Encryption.Encrypt("Hello",aes.IV);
            CWRFiles.CFiles.CreateFile("AES_Encrypted");
            CWRFiles.ReadWrite.WriteToFile(System.Convert.ToBase64String(encrypted), "Aes_Encrypted");
            //string zapis = System.Convert.ToBase64String(encrypted, 0, encrypted.Length);
            byte[] zapis = System.Convert.FromBase64String("k2z8iWClS7f0BvlDBIS8BbbpeG087/toCKiUCPcEeu8=");
            string zapis1 = System.Text.Encoding.UTF8.GetString(zapis);

           
            MessageBox.Show(AES.Decryption.Decrypt(encrypted, aes.IV));
            */



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
            if (txtEncryptedText.Text.Length == 0)
            {
                MessageBox.Show("Ne postoji sadržaj za dekriptiranje!");
            }
            else
            {
                byte[] stringToDecrypt = System.Convert.FromBase64String(txtEncryptedText.Text);
                byte[] decryptedBytes = RSA.Decrypting.decrypting(stringToDecrypt);
                txtDecryptedText.Text = System.Text.Encoding.UTF8.GetString(decryptedBytes);

            }
        }
    }
   
}

