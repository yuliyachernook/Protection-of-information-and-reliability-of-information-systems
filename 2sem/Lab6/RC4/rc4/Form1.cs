using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кс4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        byte[] result;

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] key = { 121, 14, 29, 15 };
            RC4 encoder = new RC4(key);

            byte[] testBytes = ASCIIEncoding.ASCII.GetBytes(textBox1.Text);
            result = encoder.Encode(testBytes, testBytes.Length);

            string hexresult = "";
            foreach (byte bt in result)
            {
                hexresult += Convert.ToString(bt, 16);

            }
            textBox2.Text = hexresult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] key = { 121, 14, 29, 15 };
            RC4 decoder = new RC4(key);
            byte[] decryptedBytes = decoder.Decode(result, result.Length);
            string decryptedString = ASCIIEncoding.ASCII.GetString(decryptedBytes);
            textBox3.Text = decryptedString;


        }
    }
}
