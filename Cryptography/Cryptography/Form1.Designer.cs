namespace Cryptography
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDecryptAES = new System.Windows.Forms.Button();
            this.btnEncryptAES = new System.Windows.Forms.Button();
            this.btnLoadTextAES = new System.Windows.Forms.Button();
            this.txtDecryptedAES = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncryptedAES = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.btnSignature = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.btnLoadText);
            this.tabPage1.Controls.Add(this.txtDecryptedText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEncryptedText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPlainText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(753, 89);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 27);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(753, 58);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 25);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnLoadText
            // 
            this.btnLoadText.Location = new System.Drawing.Point(753, 28);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(75, 24);
            this.btnLoadText.TabIndex = 6;
            this.btnLoadText.Text = "Load text";
            this.btnLoadText.UseVisualStyleBackColor = true;
            this.btnLoadText.Click += new System.EventHandler(this.btnLoadText_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(10, 234);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(293, 171);
            this.txtDecryptedText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted text";
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(380, 28);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(293, 171);
            this.txtEncryptedText.TabIndex = 3;
            this.txtEncryptedText.TextChanged += new System.EventHandler(this.txtEncryptedText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted text";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(10, 28);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(293, 171);
            this.txtPlainText.TabIndex = 1;
            this.txtPlainText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain text";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Tan;
            this.tabPage2.Controls.Add(this.btnDecryptAES);
            this.tabPage2.Controls.Add(this.btnEncryptAES);
            this.tabPage2.Controls.Add(this.btnLoadTextAES);
            this.tabPage2.Controls.Add(this.txtDecryptedAES);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEncryptedAES);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPlain);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1134, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AES";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtHash);
            this.tabPage3.Controls.Add(this.btnSignature);
            this.tabPage3.Controls.Add(this.txtSignature);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1134, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Signature";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDecryptAES
            // 
            this.btnDecryptAES.Location = new System.Drawing.Point(789, 103);
            this.btnDecryptAES.Name = "btnDecryptAES";
            this.btnDecryptAES.Size = new System.Drawing.Size(75, 27);
            this.btnDecryptAES.TabIndex = 17;
            this.btnDecryptAES.Text = "Decrypt";
            this.btnDecryptAES.UseVisualStyleBackColor = true;
            this.btnDecryptAES.Click += new System.EventHandler(this.btnDecryptAES_Click);
            // 
            // btnEncryptAES
            // 
            this.btnEncryptAES.Location = new System.Drawing.Point(789, 72);
            this.btnEncryptAES.Name = "btnEncryptAES";
            this.btnEncryptAES.Size = new System.Drawing.Size(75, 25);
            this.btnEncryptAES.TabIndex = 16;
            this.btnEncryptAES.Text = "Encrypt";
            this.btnEncryptAES.UseVisualStyleBackColor = true;
            this.btnEncryptAES.Click += new System.EventHandler(this.btnEncryptAES_Click);
            // 
            // btnLoadTextAES
            // 
            this.btnLoadTextAES.Location = new System.Drawing.Point(789, 42);
            this.btnLoadTextAES.Name = "btnLoadTextAES";
            this.btnLoadTextAES.Size = new System.Drawing.Size(75, 24);
            this.btnLoadTextAES.TabIndex = 15;
            this.btnLoadTextAES.Text = "Load text";
            this.btnLoadTextAES.UseVisualStyleBackColor = true;
            this.btnLoadTextAES.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDecryptedAES
            // 
            this.txtDecryptedAES.Location = new System.Drawing.Point(46, 248);
            this.txtDecryptedAES.Multiline = true;
            this.txtDecryptedAES.Name = "txtDecryptedAES";
            this.txtDecryptedAES.Size = new System.Drawing.Size(293, 171);
            this.txtDecryptedAES.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Decrypted text";
            // 
            // txtEncryptedAES
            // 
            this.txtEncryptedAES.Location = new System.Drawing.Point(416, 42);
            this.txtEncryptedAES.Multiline = true;
            this.txtEncryptedAES.Name = "txtEncryptedAES";
            this.txtEncryptedAES.Size = new System.Drawing.Size(293, 171);
            this.txtEncryptedAES.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Encrypted text";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(46, 42);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(293, 171);
            this.txtPlain.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Plain text";
            // 
            // txtSignature
            // 
            this.txtSignature.Location = new System.Drawing.Point(18, 201);
            this.txtSignature.Multiline = true;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(331, 164);
            this.txtSignature.TabIndex = 0;
            // 
            // btnSignature
            // 
            this.btnSignature.Location = new System.Drawing.Point(408, 340);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(153, 25);
            this.btnSignature.TabIndex = 1;
            this.btnSignature.Text = "Signature";
            this.btnSignature.UseVisualStyleBackColor = true;
            this.btnSignature.Click += new System.EventHandler(this.btnSignature_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(18, 24);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(331, 152);
            this.txtHash.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check signature";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnDecryptAES;
        private System.Windows.Forms.Button btnEncryptAES;
        private System.Windows.Forms.Button btnLoadTextAES;
        private System.Windows.Forms.TextBox txtDecryptedAES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncryptedAES;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Button btnSignature;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHash;
    }
}

