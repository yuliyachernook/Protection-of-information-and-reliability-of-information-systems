using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace crypto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //source data
            string latStr = "";
            using (StreamReader sr = new StreamReader(@"lattext.txt"))
            {
                latStr = sr.ReadToEnd();
            }
            string rusStr = "";
            using (StreamReader sr = new StreamReader(@"kirtext.txt"))
            {
                rusStr = sr.ReadToEnd();
            }

            Console.OutputEncoding = Encoding.UTF8;
            //task 1
            ShannonEntropy shannon = new ShannonEntropy();

            string patternRU = @"[A-Za-z0-9\xE0\xE8\xE9\xF9\xF2\xEC\x27\s+\W_]";
            string patternIT = @"[А-Яа-я0-9\s+\W_]";
            string patternBIN = @"\s+";
            string target = "";

            Regex regexRU = new Regex(patternRU, RegexOptions.IgnoreCase);
            Regex regexIT = new Regex(patternIT, RegexOptions.IgnoreCase);
            Regex regexBIN = new Regex(patternBIN);

            string resultRU = regexRU.Replace(rusStr, target);
            string resultIT = regexIT.Replace(latStr, target);
            var resultBIN = string.Join("", Encoding.ASCII.GetBytes(resultIT).Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));

            Console.WriteLine("ITALIAN LETTER FREQUENCY");
            shannon.CharFrequency(resultIT.ToLower());
            Console.WriteLine("RUSSIAN LETTER FREQUENCY");
            shannon.CharFrequency(resultRU.ToLower());
            Console.WriteLine("BINARY FREQUENCY");
            shannon.CharFrequency(resultBIN.ToLower());


            Console.WriteLine("RUS Shannon entropy: " + shannon.CalcShannonEntropy(resultRU.ToLower()));
            Console.WriteLine("IT Shannon entropy: " + shannon.CalcShannonEntropy(resultIT.ToLower()));

            //task 2
            StringBuilder builder = new StringBuilder();
            foreach (char a in resultBIN)
                builder.Append(Convert.ToString(a, 2));
            
            Console.WriteLine("BIN Shannon entropy: " + shannon.CalcShannonEntropy(builder.ToString()) + "\n");

            //task 3
            string name = "Chernook Yuliya Sergeevna";
            Console.WriteLine(name.Length);
            string patternName = @"\s+";
            Regex regexName = new Regex(patternName);
            string resultName = regexName.Replace(name, target);
            double shann = shannon.CalcShannonEntropy(resultIT.ToLower());
            Console.WriteLine(resultName);

            Console.WriteLine($"FIO amount of information: {shannon.AmountOfInformation(resultName, shann)}");
            byte[] bytes = Encoding.ASCII.GetBytes(resultName);
            string ASCII = "";
            foreach (var b in bytes)
                ASCII += b;

            Console.WriteLine("ASCII:" + ASCII);

            Console.WriteLine("ASCII FIO amount of information: " + shannon.AmountOfInformation(ASCII, shann));

            //task4
            Console.WriteLine("Error 0,1: " + shannon.AmountOfInformationWithMistake(shann, resultName, 0.1));
            Console.WriteLine("Error 0,5: " + shannon.AmountOfInformationWithMistake(shann, resultName, 0.5));
            Console.WriteLine("Error 1: " + shannon.AmountOfInformationWithMistake(shann, resultName, 1));

            Console.ReadLine();
        }

        private static void setlocale(object lC_ALL, string v)
        {
            throw new NotImplementedException();
        }
    }
}