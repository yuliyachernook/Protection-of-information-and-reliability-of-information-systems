using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            long ellapledTicks = DateTime.Now.Ticks;
            textBox2.Clear();
            textBoxEncrypted.Text = CaesarCipher.Encrypt(textBoxMessage.Text, int.Parse(textBoxSecretKey.Text));
            chart1.Series["Count"].Points.Clear();
            chart3.Series["Count"].Points.Clear();

            textBox2.Text += "Частота появления символов исходного сообщения: ";
            var frequencies = ToFrequencyDictionary(textBoxMessage.Text);
            foreach (var item in frequencies)
            {
                textBox2.Text += $"'{item.Key}' - {item.Value}    ";
                chart1.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            textBox2.Text += "Частота появления символов зашифрованного сообщения: ";
            var frequencies2 = ToFrequencyDictionary(textBoxEncrypted.Text);
            foreach (var item in frequencies2)
            {
                textBox2.Text += $"'{item.Key}' - {item.Value}    ";
                chart3.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }
            ellapledTicks = DateTime.Now.Ticks - ellapledTicks;
            textBox2.Text += "Затрачено времени: " + ellapledTicks + " мс";
        }

        static Dictionary<char, int> ToFrequencyDictionary(string source)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var symbol in source)
            {
                if (result.ContainsKey(symbol))
                    result[symbol]++;
                else
                    result[symbol] = 1;
            }

            return result;
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            textBoxDecrypted.Text = CaesarCipher.Decrypt(textBoxEncrypted.Text, int.Parse(textBoxSecretKey.Text));

        }

        private void buttonDecrypt2_Click_1(object sender, EventArgs e)
        {
            textBoxDecrypted2.Text = VigenereCipher.Decrypt(textBoxEncrypted2.Text, textBoxSecretKey2.Text);

        }

        private void buttonEncrypt2_Click_1(object sender, EventArgs e)
        {
            long ellapledTicks = DateTime.Now.Ticks;
            textBox1.Clear();
            textBoxEncrypted2.Text = VigenereCipher.Encrypt(textBoxMessage2.Text, textBoxSecretKey2.Text);
            chart2.Series["Count"].Points.Clear();
            chart4.Series["Count"].Points.Clear();

            textBox1.Text += "Частота появления символов исходного сообщения: ";
            var frequencies = ToFrequencyDictionary(textBoxMessage2.Text);
            foreach (var item in frequencies)
            {
                textBox1.Text += $"'{item.Key}' - {item.Value}    ";
                chart2.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            textBox1.Text += "Частота появления символов зашифрованного сообщения: ";
            var frequencies2 = ToFrequencyDictionary(textBoxEncrypted2.Text);
            foreach (var item in frequencies2)
            {
                textBox1.Text += $"'{item.Key}' - {item.Value}    ";
                chart4.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }
            ellapledTicks = DateTime.Now.Ticks - ellapledTicks;
            textBox1.Text += "Затрачено времени: " + ellapledTicks + " мс";

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxEncrypted_TextChanged_2(object sender, EventArgs e)
        {

        }

    }
}
