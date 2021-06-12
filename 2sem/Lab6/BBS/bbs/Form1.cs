using System;
using System.Windows.Forms;

namespace bbs
{
    public partial class Form1 : Form
    {
        BBS b;
        public Form1()
        {
            InitializeComponent();
            b = new BBS(long.Parse(textBox1.Text), long.Parse(textBox2.Text), long.Parse(textBox3.Text));
            textBox4.ScrollBars = ScrollBars.Vertical;
        }
        //set parametr
        private void button2_Click(object sender, EventArgs e)
        {
            b = new BBS(long.Parse(textBox1.Text), long.Parse(textBox2.Text), long.Parse(textBox3.Text));
            textBox4.Text = "";
        }

        //next num
        private void button1_Click(object sender, EventArgs e)
        {
            WriteLine(b.getRandNum());
        }

        //next bit
        private void button3_Click(object sender, EventArgs e)
        {
            WriteLine(b.getRandBit());
        }

        //loop num
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox5.Text); i++)
            {
                WriteLine(b.getRandNum());
            }
        }

        //loop bit
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox5.Text); i++)
            {
                WriteLine(b.getRandBit());
            }
        }

        //Write
        private void WriteLine(long text)
        {
            textBox4.Text += text;
            textBox4.Text += Environment.NewLine;
        }
        private void WriteLine(int text)
        {
            textBox4.Text += text;
            textBox4.Text += Environment.NewLine;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //bbs class
    public class BBS
    {
        long P;
        long Q;

        long X0;

        long N;

        public BBS(long p, long q, long seed)
        {
            P = p;
            Q = q;
            X0 = seed;
            N = P * Q;
        }
        //Get next random number
        public long getRandNum()
        {
            long nextRandNum = Convert.ToInt64(Math.Pow(X0,2)) % N;
            X0 = nextRandNum;
            return nextRandNum;
        }
        // Get next random bit
        public int getRandBit()
        {
            return Convert.ToInt32(getRandNum() % 2);
        }
    }
}
