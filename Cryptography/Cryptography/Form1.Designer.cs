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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(739, 389);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(10, 28);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(293, 171);
            this.txtPlainText.TabIndex = 1;
            this.txtPlainText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
    }
}

