namespace Lab5
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
            this.button1 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.RichTextBox();
            this.encryptedMessage = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.decodeKeyTextBox = new System.Windows.Forms.TextBox();
            this.decryptedMessage = new System.Windows.Forms.RichTextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Чтение данных из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(31, 138);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(270, 100);
            this.message.TabIndex = 1;
            this.message.Text = "";
            this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
            // 
            // encryptedMessage
            // 
            this.encryptedMessage.Location = new System.Drawing.Point(31, 352);
            this.encryptedMessage.Name = "encryptedMessage";
            this.encryptedMessage.Size = new System.Drawing.Size(270, 100);
            this.encryptedMessage.TabIndex = 2;
            this.encryptedMessage.Text = "";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(31, 259);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(185, 37);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(331, 138);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(148, 31);
            this.keyTextBox.TabIndex = 4;
            this.keyTextBox.TextChanged += new System.EventHandler(this.keyTextBox_TextChanged);
            // 
            // decodeKeyTextBox
            // 
            this.decodeKeyTextBox.Location = new System.Drawing.Point(331, 188);
            this.decodeKeyTextBox.Multiline = true;
            this.decodeKeyTextBox.Name = "decodeKeyTextBox";
            this.decodeKeyTextBox.Size = new System.Drawing.Size(148, 31);
            this.decodeKeyTextBox.TabIndex = 5;
            // 
            // decryptedMessage
            // 
            this.decryptedMessage.Location = new System.Drawing.Point(331, 352);
            this.decryptedMessage.Name = "decryptedMessage";
            this.decryptedMessage.Size = new System.Drawing.Size(270, 100);
            this.decryptedMessage.TabIndex = 6;
            this.decryptedMessage.Text = "";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(331, 259);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(185, 37);
            this.decryptButton.TabIndex = 7;
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Исходное сообщение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "DES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(327, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ключевое слово:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Зашифрованное сообщение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(327, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Расшифрованное сообщение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.decryptedMessage);
            this.Controls.Add(this.decodeKeyTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptedMessage);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox message;
        private System.Windows.Forms.RichTextBox encryptedMessage;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox decodeKeyTextBox;
        private System.Windows.Forms.RichTextBox decryptedMessage;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

