using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace crypto1
{
    internal class ShannonEntropy
    {
        public double CalcShannonEntropy(string s)
        {
            var map = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!map.ContainsKey(c))
                    map.Add(c, 1);
                else
                    map[c] += 1;
            }

            var result = 0.0;
            var len = s.Length;

            foreach (var item in map)
            {
                var i = (double)item.Value / len;
                result -= i * Math.Log(i, 2);
            }
            return result;
        }

        public double AmountOfInformation(string message, double shannonEntropy)
        {
            var result = message.Length * shannonEntropy;
            return result;
        }

        public double AmountOfInformationWithMistake(double entropy, string message, double p)
        {
            var result = (-p * Math.Log(p, 2) - (1 - p) * Math.Log((1 - p), 2)) * message.Length;
            return result;
        }

        public void CharFrequency(string message)
        {
            string result = string.Empty;
            double sum = 0;
            var length = message.Length;
            while (message.Length > 0)
            {
                double count = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    if (message[0] == message[i])
                    {
                        count++;
                    }
                }
                result += message[0] + " = " + Math.Round(count/length, 4) * 100 + "%\n";
                sum += count / length;
                message = message.Replace(message[0].ToString(), string.Empty);
            }
            Console.WriteLine(result + $"Frequency sum = {sum}\n");
        }

    }
}