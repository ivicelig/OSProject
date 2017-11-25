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
            RSA.Encrypting a = new RSA.Encrypting();
            string ab = "Hello";
            

            a.Encrypt(Encoding.ASCII.GetBytes(ab));
        }
        public string decrypt2()
        {
            RSACryptoServiceProvider test = new RSACryptoServiceProvider();
            string pubKey = test.ToXmlString(false);
            return pubKey;

        }
    }
   
}

