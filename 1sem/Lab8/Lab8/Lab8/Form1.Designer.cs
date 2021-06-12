namespace Lab8
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.richTextBoxW1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxW2 = new System.Windows.Forms.RichTextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.richTextBoxB1 = new System.Windows.Forms.RichTextBox();
            this.buttonLast = new System.Windows.Forms.Button();
            this.textBoxNow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(104, 65);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(297, 22);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(436, 62);
            this.buttonGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(99, 25);
            this.buttonGen.TabIndex = 1;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // richTextBoxW1
            // 
            this.richTextBoxW1.Location = new System.Drawing.Point(12, 105);
            this.richTextBoxW1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxW1.Name = "richTextBoxW1";
            this.richTextBoxW1.Size = new System.Drawing.Size(300, 299);
            this.richTextBoxW1.TabIndex = 2;
            this.richTextBoxW1.Text = "";
            // 
            // richTextBoxW2
            // 
            this.richTextBoxW2.Location = new System.Drawing.Point(320, 105);
            this.richTextBoxW2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxW2.Name = "richTextBoxW2";
            this.richTextBoxW2.Size = new System.Drawing.Size(300, 299);
            this.richTextBoxW2.TabIndex = 3;
            this.richTextBoxW2.Text = "";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(853, 65);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(300, 22);
            this.textBoxM.TabIndex = 4;
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(632, 65);
            this.textBoxK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(100, 22);
            this.textBoxK.TabIndex = 5;
            this.textBoxK.TextChanged += new System.EventHandler(this.textBoxK_TextChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(670, 122);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(139, 25);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Generate Next";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // richTextBoxB1
            // 
            this.richTextBoxB1.Location = new System.Drawing.Point(853, 105);
            this.richTextBoxB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxB1.Name = "richTextBoxB1";
            this.richTextBoxB1.Size = new System.Drawing.Size(300, 299);
            this.richTextBoxB1.TabIndex = 7;
            this.richTextBoxB1.Text = "";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(670, 151);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(139, 25);
            this.buttonLast.TabIndex = 8;
            this.buttonLast.Text = "Generate Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // textBoxNow
            // 
            this.textBoxNow.Location = new System.Drawing.Point(738, 65);
            this.textBoxNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNow.Name = "textBoxNow";
            this.textBoxNow.Size = new System.Drawing.Size(95, 22);
            this.textBoxNow.TabIndex = 9;
            this.textBoxNow.TextChanged += new System.EventHandler(this.textBoxNow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сообщение";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сжатие и распаковка данных методом Барроуза − Уилера";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1299, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNow);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.richTextBoxB1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.richTextBoxW2);
            this.Controls.Add(this.richTextBoxW1);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.textBoxInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.RichTextBox richTextBoxW1;
        private System.Windows.Forms.RichTextBox richTextBoxW2;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.RichTextBox richTextBoxB1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox textBoxNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

