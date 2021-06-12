using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Gamal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxP.Text = "11";
            textBoxQ.Text = "7";
            textBoxP2.Text = "547";
            textBoxQ2.Text = "91";
            textBoxX2.Text = "14";
        }

        char[] characters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
                                         'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                                         'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '1', '2', '3', '4', '5', '6', '7',
                                         '8', '9', '0' };

        long p, q, n, fi, e, d;
        int pg, gg, xg;


        private void InitializeRSA()
        {
            p = Convert.ToInt32(textBoxP.Text);
            q = Convert.ToInt32(textBoxQ.Text);

            n = p * q;
            fi = RSA.Eiler(p, q);
            e = RSA.getE(fi);
            d = RSA.getD(e, fi);
        }

        private void buttonEncrypt2_Click(object sender, EventArgs e)
        {
            pg = Convert.ToInt32(textBoxP2.Text);
            gg = Convert.ToInt32(textBoxQ2.Text);
            xg = Convert.ToInt32(textBoxX2.Text);

            DateTime start1 = DateTime.Now;
            textBoxEncrypted2.Text = Gamal.Crypt(pg, gg, xg, textBoxOriginal2.Text);
            TimeSpan procTime1 = DateTime.Now - start1;
            textBox2.Text += "Потраченное время на зашифровку: " + procTime1.TotalSeconds.ToString() + " sec";
        }

        private void textBoxP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDecrypt2_Click(object sender, EventArgs e)
        {
            pg = Convert.ToInt32(textBoxP2.Text);
            xg = Convert.ToInt32(textBoxX2.Text);

            DateTime start2 = DateTime.Now;
            textBoxDecrypted2.Text = Gamal.Decrypt(pg, xg, textBoxEncrypted2.Text);
            TimeSpan procTime2 = DateTime.Now - start2;
            textBox2.Text += " Потраченное время на расшифровку: " + procTime2.TotalSeconds.ToString() + " sec";
        }

        private void textBoxQ2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs args)
        {
            InitializeRSA();
            DateTime start2 = DateTime.Now;
            decodedMes = RSA.Decode(encodedMes, d, n, characters);
            textBoxDecrypted.Text = decodedMes;
            TimeSpan procTime2 = DateTime.Now - start2;
            textBox1.Text += " Потраченное время на расшифровку: " + procTime2.TotalSeconds.ToString() + " sec";

        }

        private void button1_Click(object sender, EventArgs args)
        {
            InitializeRSA();
            if (RSA.IsPrimary(p) && RSA.IsPrimary(q))
            {
                DateTime start1 = DateTime.Now;
                encodedMes = RSA.Encode(textBoxOriginal.Text.ToUpper(), e, n, characters);
                foreach (string item in encodedMes)
                    textBoxEncrypted.Text += item;
                TimeSpan procTime1 = DateTime.Now - start1;
                textBox1.Text += "Потраченное время на зашифровку: " + procTime1.TotalSeconds.ToString() + " sec";
            }
            else
            {
                MessageBox.Show(" p and q should be primary!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        string message, decodedMes;
        List<string> encodedMes;

    }
}
