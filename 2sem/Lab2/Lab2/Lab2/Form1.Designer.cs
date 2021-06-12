namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.textBoxDecrypted2 = new System.Windows.Forms.TextBox();
            this.textBoxMessage2 = new System.Windows.Forms.TextBox();
            this.textBoxSecretKey2 = new System.Windows.Forms.TextBox();
            this.buttonEncrypt2 = new System.Windows.Forms.Button();
            this.buttonDecrypt2 = new System.Windows.Forms.Button();
            this.textBoxEncrypted2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(11, 49);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(233, 80);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Location = new System.Drawing.Point(11, 150);
            this.textBoxSecretKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSecretKey.Multiline = true;
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(233, 80);
            this.textBoxSecretKey.TabIndex = 1;
            this.textBoxSecretKey.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(250, 47);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(133, 36);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(389, 49);
            this.textBoxEncrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(241, 80);
            this.textBoxEncrypted.TabIndex = 3;
            this.textBoxEncrypted.TextChanged += new System.EventHandler(this.textBoxEncrypted_TextChanged_2);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(250, 93);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(133, 36);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // textBoxDecrypted2
            // 
            this.textBoxDecrypted2.Location = new System.Drawing.Point(389, 148);
            this.textBoxDecrypted2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDecrypted2.Multiline = true;
            this.textBoxDecrypted2.Name = "textBoxDecrypted2";
            this.textBoxDecrypted2.Size = new System.Drawing.Size(241, 80);
            this.textBoxDecrypted2.TabIndex = 5;
            // 
            // textBoxMessage2
            // 
            this.textBoxMessage2.Location = new System.Drawing.Point(11, 47);
            this.textBoxMessage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMessage2.Multiline = true;
            this.textBoxMessage2.Name = "textBoxMessage2";
            this.textBoxMessage2.Size = new System.Drawing.Size(233, 80);
            this.textBoxMessage2.TabIndex = 6;
            // 
            // textBoxSecretKey2
            // 
            this.textBoxSecretKey2.Location = new System.Drawing.Point(11, 148);
            this.textBoxSecretKey2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSecretKey2.Multiline = true;
            this.textBoxSecretKey2.Name = "textBoxSecretKey2";
            this.textBoxSecretKey2.Size = new System.Drawing.Size(233, 80);
            this.textBoxSecretKey2.TabIndex = 7;
            // 
            // buttonEncrypt2
            // 
            this.buttonEncrypt2.Location = new System.Drawing.Point(250, 47);
            this.buttonEncrypt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEncrypt2.Name = "buttonEncrypt2";
            this.buttonEncrypt2.Size = new System.Drawing.Size(133, 36);
            this.buttonEncrypt2.TabIndex = 8;
            this.buttonEncrypt2.Text = "Зашифровать";
            this.buttonEncrypt2.UseVisualStyleBackColor = true;
            this.buttonEncrypt2.Click += new System.EventHandler(this.buttonEncrypt2_Click_1);
            // 
            // buttonDecrypt2
            // 
            this.buttonDecrypt2.Location = new System.Drawing.Point(250, 91);
            this.buttonDecrypt2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDecrypt2.Name = "buttonDecrypt2";
            this.buttonDecrypt2.Size = new System.Drawing.Size(133, 36);
            this.buttonDecrypt2.TabIndex = 9;
            this.buttonDecrypt2.Text = "Расшифровать";
            this.buttonDecrypt2.UseVisualStyleBackColor = true;
            this.buttonDecrypt2.Click += new System.EventHandler(this.buttonDecrypt2_Click_1);
            // 
            // textBoxEncrypted2
            // 
            this.textBoxEncrypted2.Location = new System.Drawing.Point(389, 47);
            this.textBoxEncrypted2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEncrypted2.Multiline = true;
            this.textBoxEncrypted2.Name = "textBoxEncrypted2";
            this.textBoxEncrypted2.Size = new System.Drawing.Size(241, 80);
            this.textBoxEncrypted2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Шифр Цезаря:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текст:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ключ:";
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(389, 150);
            this.textBoxDecrypted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(241, 80);
            this.textBoxDecrypted.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Зашифрованное сообщение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Расшифрованное сообщение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Шифр Виженера:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Текст:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ключ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Зашифрованное сообщение:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Расшифрованное сообщение:";
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.chart1.Annotations;
            this.chart1.Location = new System.Drawing.Point(11, 253);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Name = "Count";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(957, 197);
            this.chart1.TabIndex = 23;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(665, 30);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(260, 200);
            this.textBox2.TabIndex = 25;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1449, 721);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.chart3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxMessage);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSecretKey);
            this.tabPage1.Controls.Add(this.buttonEncrypt);
            this.tabPage1.Controls.Add(this.buttonDecrypt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxEncrypted);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxDecrypted);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1441, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифр Цезаря";
            // 
            // chart3
            // 
            this.chart3.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            this.chart3.DataSource = this.chart3.Annotations;
            this.chart3.Location = new System.Drawing.Point(14, 454);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Name = "Count";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(954, 197);
            this.chart3.TabIndex = 26;
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.chart4);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxMessage2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxSecretKey2);
            this.tabPage2.Controls.Add(this.textBoxDecrypted2);
            this.tabPage2.Controls.Add(this.textBoxEncrypted2);
            this.tabPage2.Controls.Add(this.buttonEncrypt2);
            this.tabPage2.Controls.Add(this.buttonDecrypt2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1441, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Шифр Виженера";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(653, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(260, 200);
            this.textBox1.TabIndex = 26;
            // 
            // chart4
            // 
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea3);
            this.chart4.DataSource = this.chart4.Annotations;
            this.chart4.Location = new System.Drawing.Point(14, 464);
            this.chart4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Name = "Count";
            this.chart4.Series.Add(series3);
            this.chart4.Size = new System.Drawing.Size(936, 197);
            this.chart4.TabIndex = 25;
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.DataSource = this.chart2.Annotations;
            this.chart2.Location = new System.Drawing.Point(14, 248);
            this.chart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Name = "Count";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(936, 197);
            this.chart2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 680);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox textBoxDecrypted2;
        private System.Windows.Forms.TextBox textBoxMessage2;
        private System.Windows.Forms.TextBox textBoxSecretKey2;
        private System.Windows.Forms.Button buttonEncrypt2;
        private System.Windows.Forms.Button buttonDecrypt2;
        private System.Windows.Forms.TextBox textBoxEncrypted2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

