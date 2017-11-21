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
            List<string> text = ReadingWriteingInFile.ReadingFromFile.readFromFile("test");
          
            foreach (var item in text)
            {
                textBox1.AppendText(item + Environment.NewLine);
                
            }
        }
        public string decrypt2()
        {
            RSACryptoServiceProvider test = new RSACryptoServiceProvider();
            string pubKey = test.ToXmlString(false);
            return pubKey;

        }
    }
   
}

