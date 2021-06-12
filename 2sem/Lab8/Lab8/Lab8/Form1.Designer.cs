namespace RSA_Gamal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDecrypt2 = new System.Windows.Forms.Button();
            this.buttonEncrypt2 = new System.Windows.Forms.Button();
            this.textBoxDecrypted2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEncrypted2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOriginal2 = new System.Windows.Forms.TextBox();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxDecrypted);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxEncrypted);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxOriginal);
            this.tabPage1.Controls.Add(this.textBoxQ);
            this.tabPage1.Controls.Add(this.textBoxP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(531, 223);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 80);
            this.textBox1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(18, 223);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(276, 80);
            this.textBoxDecrypted.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Расшифрованное сообщение";
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(331, 86);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(276, 80);
            this.textBoxEncrypted.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Зашифрованное сообщение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Исходное сообщение";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(15, 86);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(276, 80);
            this.textBoxOriginal.TabIndex = 4;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(191, 18);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(100, 22);
            this.textBoxQ.TabIndex = 3;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(34, 18);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "q";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "p";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxX2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.buttonDecrypt2);
            this.tabPage2.Controls.Add(this.buttonEncrypt2);
            this.tabPage2.Controls.Add(this.textBoxDecrypted2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxEncrypted2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxOriginal2);
            this.tabPage2.Controls.Add(this.textBoxQ2);
            this.tabPage2.Controls.Add(this.textBoxP2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "El-Gamal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "x";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(348, 16);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 22);
            this.textBoxX2.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(530, 221);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 80);
            this.textBox2.TabIndex = 25;
            // 
            // buttonDecrypt2
            // 
            this.buttonDecrypt2.Location = new System.Drawing.Point(330, 267);
            this.buttonDecrypt2.Name = "buttonDecrypt2";
            this.buttonDecrypt2.Size = new System.Drawing.Size(139, 34);
            this.buttonDecrypt2.TabIndex = 24;
            this.buttonDecrypt2.Text = "Decrypt";
            this.buttonDecrypt2.UseVisualStyleBackColor = true;
            this.buttonDecrypt2.Click += new System.EventHandler(this.buttonDecrypt2_Click);
            // 
            // buttonEncrypt2
            // 
            this.buttonEncrypt2.Location = new System.Drawing.Point(330, 221);
            this.buttonEncrypt2.Name = "buttonEncrypt2";
            this.buttonEncrypt2.Size = new System.Drawing.Size(139, 34);
            this.buttonEncrypt2.TabIndex = 23;
            this.buttonEncrypt2.Text = "Encrypt";
            this.buttonEncrypt2.UseVisualStyleBackColor = true;
            this.buttonEncrypt2.Click += new System.EventHandler(this.buttonEncrypt2_Click);
            // 
            // textBoxDecrypted2
            // 
            this.textBoxDecrypted2.Location = new System.Drawing.Point(17, 221);
            this.textBoxDecrypted2.Multiline = true;
            this.textBoxDecrypted2.Name = "textBoxDecrypted2";
            this.textBoxDecrypted2.Size = new System.Drawing.Size(276, 80);
            this.textBoxDecrypted2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Расшифрованное сообщение";
            // 
            // textBoxEncrypted2
            // 
            this.textBoxEncrypted2.Location = new System.Drawing.Point(330, 84);
            this.textBoxEncrypted2.Multiline = true;
            this.textBoxEncrypted2.Name = "textBoxEncrypted2";
            this.textBoxEncrypted2.Size = new System.Drawing.Size(276, 80);
            this.textBoxEncrypted2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Зашифрованное сообщение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Исходное сообщение";
            // 
            // textBoxOriginal2
            // 
            this.textBoxOriginal2.Location = new System.Drawing.Point(14, 84);
            this.textBoxOriginal2.Multiline = true;
            this.textBoxOriginal2.Name = "textBoxOriginal2";
            this.textBoxOriginal2.Size = new System.Drawing.Size(276, 80);
            this.textBoxOriginal2.TabIndex = 17;
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(190, 16);
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(100, 22);
            this.textBoxQ2.TabIndex = 16;
            this.textBoxQ2.TextChanged += new System.EventHandler(this.textBoxQ2_TextChanged);
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(33, 16);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(100, 22);
            this.textBoxP2.TabIndex = 15;
            this.textBoxP2.TextChanged += new System.EventHandler(this.textBoxP2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "g";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "p";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Lab8";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDecrypt2;
        private System.Windows.Forms.Button buttonEncrypt2;
        private System.Windows.Forms.TextBox textBoxDecrypted2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEncrypted2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOriginal2;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxX2;
    }
}

