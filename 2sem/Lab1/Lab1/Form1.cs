using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void ThreeNumsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ThirdNum.Enabled = true;
        }

        private void TwoNumsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ThirdNum.Enabled = false;
        }

        private void NodButton_Click(object sender, EventArgs e)
        {
            if (ThirdNum.Enabled)
            {
                if (!(String.IsNullOrEmpty(FirstNum.Text) || String.IsNullOrEmpty(SecondNum.Text) || String.IsNullOrEmpty(ThirdNum.Text)))
                {
                    NodTextBox.Text = Functions.Nod(Convert.ToInt32(FirstNum.Text), Functions.Nod(Convert.ToInt32(SecondNum.Text), Convert.ToInt32(ThirdNum.Text))).ToString();
                }
            }
            else
            {
                if (!(String.IsNullOrEmpty(FirstNum.Text) || String.IsNullOrEmpty(SecondNum.Text)))
                {
                    NodTextBox.Text = Functions.Nod(Convert.ToInt32(FirstNum.Text), Convert.ToInt32(SecondNum.Text)).ToString();
                }
            }
        }

        private void FindPrimeNumbers_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(NBox.Text) || String.IsNullOrEmpty(MBox.Text)))
            {
                var primeNums = Functions.GetPrimeNumbers(Convert.ToInt32(MBox.Text), Convert.ToInt32(NBox.Text));
                string result = "";

                foreach (var x in primeNums)
                {
                    result += $"{x} ";
                }

                Count.Text = primeNums.Count().ToString();
                PrimeNubersBox.Text = result;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Lab1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
