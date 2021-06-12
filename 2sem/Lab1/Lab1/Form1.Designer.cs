namespace Lab1
{
    partial class Lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MBox = new System.Windows.Forms.TextBox();
            this.NBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FindPrimeNumbers = new System.Windows.Forms.Button();
            this.TwoNumsCheckBox = new System.Windows.Forms.RadioButton();
            this.ThreeNumsCheckBox = new System.Windows.Forms.RadioButton();
            this.PrimeNubersBox = new System.Windows.Forms.TextBox();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.ThirdNum = new System.Windows.Forms.TextBox();
            this.NodButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NodTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Простые числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "НОД";
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(126, 195);
            this.MBox.Margin = new System.Windows.Forms.Padding(4);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(169, 22);
            this.MBox.TabIndex = 2;
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(126, 226);
            this.NBox.Margin = new System.Windows.Forms.Padding(4);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(169, 22);
            this.NBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Число m:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Число n:";
            // 
            // FindPrimeNumbers
            // 
            this.FindPrimeNumbers.Location = new System.Drawing.Point(62, 265);
            this.FindPrimeNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.FindPrimeNumbers.Name = "FindPrimeNumbers";
            this.FindPrimeNumbers.Size = new System.Drawing.Size(188, 28);
            this.FindPrimeNumbers.TabIndex = 6;
            this.FindPrimeNumbers.Text = "Найти простые числа";
            this.FindPrimeNumbers.UseVisualStyleBackColor = true;
            this.FindPrimeNumbers.Click += new System.EventHandler(this.FindPrimeNumbers_Click);
            // 
            // TwoNumsCheckBox
            // 
            this.TwoNumsCheckBox.AutoSize = true;
            this.TwoNumsCheckBox.Checked = true;
            this.TwoNumsCheckBox.Location = new System.Drawing.Point(20, 42);
            this.TwoNumsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TwoNumsCheckBox.Name = "TwoNumsCheckBox";
            this.TwoNumsCheckBox.Size = new System.Drawing.Size(98, 21);
            this.TwoNumsCheckBox.TabIndex = 7;
            this.TwoNumsCheckBox.TabStop = true;
            this.TwoNumsCheckBox.Text = "Два числа";
            this.TwoNumsCheckBox.UseVisualStyleBackColor = true;
            this.TwoNumsCheckBox.CheckedChanged += new System.EventHandler(this.TwoNumsCheckBox_CheckedChanged);
            // 
            // ThreeNumsCheckBox
            // 
            this.ThreeNumsCheckBox.AutoSize = true;
            this.ThreeNumsCheckBox.Location = new System.Drawing.Point(21, 73);
            this.ThreeNumsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThreeNumsCheckBox.Name = "ThreeNumsCheckBox";
            this.ThreeNumsCheckBox.Size = new System.Drawing.Size(97, 21);
            this.ThreeNumsCheckBox.TabIndex = 8;
            this.ThreeNumsCheckBox.Text = "Три числа";
            this.ThreeNumsCheckBox.UseVisualStyleBackColor = true;
            this.ThreeNumsCheckBox.CheckedChanged += new System.EventHandler(this.ThreeNumsCheckBox_CheckedChanged);
            // 
            // PrimeNubersBox
            // 
            this.PrimeNubersBox.Location = new System.Drawing.Point(333, 195);
            this.PrimeNubersBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrimeNubersBox.Multiline = true;
            this.PrimeNubersBox.Name = "PrimeNubersBox";
            this.PrimeNubersBox.ReadOnly = true;
            this.PrimeNubersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimeNubersBox.Size = new System.Drawing.Size(255, 84);
            this.PrimeNubersBox.TabIndex = 9;
            // 
            // FirstNum
            // 
            this.FirstNum.Location = new System.Drawing.Point(126, 41);
            this.FirstNum.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(51, 22);
            this.FirstNum.TabIndex = 10;
            // 
            // SecondNum
            // 
            this.SecondNum.Location = new System.Drawing.Point(185, 41);
            this.SecondNum.Margin = new System.Windows.Forms.Padding(4);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(51, 22);
            this.SecondNum.TabIndex = 11;
            // 
            // ThirdNum
            // 
            this.ThirdNum.Enabled = false;
            this.ThirdNum.Location = new System.Drawing.Point(244, 41);
            this.ThirdNum.Margin = new System.Windows.Forms.Padding(4);
            this.ThirdNum.Name = "ThirdNum";
            this.ThirdNum.Size = new System.Drawing.Size(51, 22);
            this.ThirdNum.TabIndex = 12;
            // 
            // NodButton
            // 
            this.NodButton.Location = new System.Drawing.Point(126, 71);
            this.NodButton.Margin = new System.Windows.Forms.Padding(4);
            this.NodButton.Name = "NodButton";
            this.NodButton.Size = new System.Drawing.Size(169, 28);
            this.NodButton.TabIndex = 13;
            this.NodButton.Text = "Найти НОД";
            this.NodButton.UseVisualStyleBackColor = true;
            this.NodButton.Click += new System.EventHandler(this.NodButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "НОД:";
            // 
            // NodTextBox
            // 
            this.NodTextBox.Location = new System.Drawing.Point(126, 116);
            this.NodTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NodTextBox.Name = "NodTextBox";
            this.NodTextBox.ReadOnly = true;
            this.NodTextBox.Size = new System.Drawing.Size(169, 22);
            this.NodTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(329, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Количество простых чисел:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(528, 283);
            this.Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(16, 17);
            this.Count.TabIndex = 17;
            this.Count.Text = "0";
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(196)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(626, 353);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NodTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NodButton);
            this.Controls.Add(this.ThirdNum);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.PrimeNubersBox);
            this.Controls.Add(this.ThreeNumsCheckBox);
            this.Controls.Add(this.TwoNumsCheckBox);
            this.Controls.Add(this.FindPrimeNumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Lab1";
            this.ShowIcon = false;
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Lab1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindPrimeNumbers;
        private System.Windows.Forms.RadioButton TwoNumsCheckBox;
        private System.Windows.Forms.RadioButton ThreeNumsCheckBox;
        private System.Windows.Forms.TextBox PrimeNubersBox;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.TextBox SecondNum;
        private System.Windows.Forms.TextBox ThirdNum;
        private System.Windows.Forms.Button NodButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NodTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Count;
    }
}

