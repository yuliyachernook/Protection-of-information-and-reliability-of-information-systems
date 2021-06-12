using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        static int n = 4;
        OpenFileDialog open = new OpenFileDialog();
        char[,] array = new char[n, n];
        char[,] arrayTransp = new char[n, n];

        public Form1()
        {
            InitializeComponent();

            open.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";


            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = open.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            richTextBox1.Text = fileText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Count"].Points.Clear();
            chart3.Series["Count"].Points.Clear();

            richTextBox3.Text = "";

            long ellapledTicks = DateTime.Now.Ticks;
            int messageLength = richTextBox1.Text.Length;
            int q = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (q < richTextBox1.Text.Length)
                       array[i, j] = Convert.ToChar(richTextBox1.Text[q++]);
                    //else if (q <= richTextBox1.Text.Length && j == 0)
                    //    break;
                    else array[i, j] = '-';
                }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j].ToString();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    richTextBox3.Text += array[j, i];
            }
            richTextBox2.Text += "Частота появления символов исходного сообщения: ";
            var frequencies = ToFrequencyDictionary(richTextBox1.Text);
            foreach (var item in frequencies)
            {
                richTextBox2.Text += $"'{item.Key}' - {item.Value}    ";
                chart1.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            richTextBox2.Text += "Частота появления символов зашифрованного сообщения: ";
            var frequencies2 = ToFrequencyDictionary(richTextBox3.Text);
            foreach (var item in frequencies2)
            {
                richTextBox2.Text += $"'{item.Key}' - {item.Value}    ";
                chart3.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            ellapledTicks = DateTime.Now.Ticks - ellapledTicks;
            richTextBox2.Text += "Затрачено времени: " + ellapledTicks + " мс";
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
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
            int q = 0;
            char tmp;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (q < richTextBox3.Text.Length)
                        arrayTransp[i, j] = Convert.ToChar(richTextBox3.Text[q++]);
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = arrayTransp[i, j];
                    arrayTransp[i, j] = arrayTransp[j, i];
                    arrayTransp[j, i] = tmp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (arrayTransp[i,j] != '-')
                    richTextBox4.Text += arrayTransp[i, j];

            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        


        List<CharNum> listCharNumFirst;

        List<CharNum> listCharNumSecond;
        private void button4_Click(object sender, EventArgs e)
        {
            chart2.Series["Count"].Points.Clear();
            chart4.Series["Count"].Points.Clear();
            richTextBox3.Text = "";

            long ellapledTicks = DateTime.Now.Ticks;
            string firstKey = "yulia";
            // Второй ключ, количество строк
            string secondKey = "chernok";
            // Предложение которое шифруем
            string stringUser = richTextBox1.Text;

            string fill = " ";

            for (int i = stringUser.Length; i < firstKey.Length * secondKey.Length; i++)
            {
                stringUser += fill;
            }
            string newText = "";
            // Матрица в которой производим шифрование
            char[,] matrix = new char[secondKey.Length, firstKey.Length];

            // Счетчик символов в строке
            int countSymbols = 0;

            // Переводим строки в массивы типа char
            char[] charsFirstKey = firstKey.ToCharArray();
            char[] charsSecondKey = secondKey.ToCharArray();
            char[] charStringUser = stringUser.ToCharArray();

            // Создаем списки в которых будут храниться символы и порядковые номера символов
            listCharNumFirst =
                new List<CharNum>(firstKey.Length);

            listCharNumSecond =
                new List<CharNum>(secondKey.Length);

            // Заполняем символами из ключей
            listCharNumFirst = FillListKey(charsFirstKey);
            listCharNumSecond = FillListKey(charsSecondKey);

            // Заполняем порядковыми номерами
            listCharNumFirst = FillingSerialsNumber(listCharNumFirst);
            listCharNumSecond = FillingSerialsNumber(listCharNumSecond);

            // Заполнение матрицы строкой пользователя
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    matrix[i, j] = charStringUser[countSymbols++];
                }
            }


            countSymbols = 0;
            // Заполнение матрицы с учетом шифрования. 
            // Переставляем столбцы по порядку следования в первом ключе. 
            // Затем переставляем строки по порядку следования во втором ключа. 
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    matrix[listCharNumSecond[i].NumberInWord,
                       listCharNumFirst[j].NumberInWord] = charStringUser[countSymbols++];
                }
            }

            for (int i = 0; i < listCharNumFirst.Count; i++)
            {
                for (int j = 0; j < listCharNumSecond.Count; j++)
                {
                    newText += matrix[j, i];
                }
            }
            //return newText;
            richTextBox3.Text = newText;
            richTextBox2.Text += "Частота появления символов исходного сообщения: ";
            var frequencies = ToFrequencyDictionary(richTextBox1.Text);
            foreach (var item in frequencies)
            {
                richTextBox2.Text += $"'{item.Key}' - {item.Value}    ";
                chart2.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);
            }

            richTextBox2.Text += "Частота появления символов зашифрованного сообщения: ";
            var frequencies2 = ToFrequencyDictionary(richTextBox3.Text);
            foreach (var item in frequencies2)
            {
                richTextBox2.Text += $"'{item.Key}' - {item.Value}    ";
                chart4.Series["Count"].Points.AddXY(item.Key.ToString(), item.Value);

            }

            ellapledTicks = DateTime.Now.Ticks - ellapledTicks;
            richTextBox2.Text += "Затрачено времени: " + ellapledTicks + " мс";
        }

        public static int GetNumberInThealphabet(char s)
        {
            string str = @"AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            int number = str.IndexOf(s) / 2;

            return number;
        }

        /// <summary>
        /// Заполнение символами списка с ключом.
        /// </summary>
        /// <param name="chars">массив символов.</param>
        /// <returns>Список символов.</returns>
        private static List<CharNum> FillListKey(char[] chars)
        {
            List<CharNum> listKey = new List<CharNum>(chars.Length);

            for (int i = 0; i < chars.Length; i++)
            {
                CharNum charNum = new CharNum()
                {
                    Ch = chars[i],
                    NumberInWord = GetNumberInThealphabet(chars[i])
                };

                listKey.Add(charNum);
            }
            return listKey;
        }
        /// <summary>
        /// Отображение ключа.
        /// </summary>
        /// <param name="listCharNum">Список в котором содержатся символы с порядковыми номерами.</param>
        private static void ShowKey(List<CharNum> listCharNum, string message)
        {
            Console.WriteLine(message);

            foreach (var i in listCharNum)
            {
                Console.Write(i.Ch + " ");
            }
            Console.WriteLine();

            foreach (var i in listCharNum)
            {
                Console.Write(i.NumberInWord + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Заполнение символов ключей, порядковыми номерами.
        /// </summary>
        /// <param name="listCharNum"></param>
        /// <returns></returns>
        private static List<CharNum> FillingSerialsNumber(List<CharNum> listCharNum)
        {
            int count = 0;

            var result = listCharNum.OrderBy(a =>
                a.NumberInWord);

            foreach (var i in result)
            {
                i.NumberInWord = count++;
            }

            return listCharNum;
        }
        class CharNum
        {
            #region Fields
            /// <summary>
            /// Символ.
            /// </summary>
            private char _ch;
            /// <summary>
            /// Порядковый номер зависящий от алфавита.
            /// </summary>
            private int _numberInWord;
            #endregion Fieds

            #region Properties
            /// <summary>
            /// Символ.
            /// </summary>
            public char Ch
            {
                get { return _ch; }
                set
                {
                    if (_ch == value)
                        return;
                    _ch = value;
                }
            }
            /// <summary>
            /// Порядковый номер в строке, зависящий от алфавита.
            /// </summary>
            public int NumberInWord
            {
                get { return _numberInWord; }
                set
                {
                    if (_numberInWord == value)
                        return;
                    _numberInWord = value;
                }
            }
            #endregion Properties
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            richTextBox4.Text = "";
            string firstKey = "yulia";
            // Второй ключ, количество строк
            string secondKey = "chernok";
            string text = richTextBox3.Text;
            char[,] newMatrix = new char[secondKey.Length, firstKey.Length];
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            foreach (CharNum index in listCharNumFirst)
            {
                list1.Add(index.NumberInWord);
            }
            foreach (CharNum index in listCharNumSecond)
            {
                list2.Add(index.NumberInWord);
            }
            int k = 0;

            for (int i = 0; i < firstKey.Length; i++)
            {
                int x = list1.IndexOf(i);
                for (int j = 0; j < secondKey.Length; j++)
                {
                    int y = list2.IndexOf(j);
                    //MessageBox.Show(text[k].ToString());
                    newMatrix[y, x] = text[k];
                    k++;
                }
            }

            string oldText = "";

            for (int i = 0; i < secondKey.Length; i++)
            {
                for (int j = 0; j < firstKey.Length; j++)
                {
                    oldText += newMatrix[i, j];
                }
            }
            richTextBox4.Text = oldText;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
