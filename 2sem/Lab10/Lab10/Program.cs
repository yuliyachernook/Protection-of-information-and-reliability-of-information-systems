﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Lab10
{
    class Program
    {
        static void Main()
        {
            Rsa.CheckCorrectly();
            Rsa.CheckInCorrectly();
            ElGamal.CheckCorrectly();
            ElGamal.CheckInCorrectly();
        }
    }

    public static class Rsa
    {
        public static void CheckCorrectly()
        {
            var p = 7;
            var q = 13;
            var pathToSource = "Source.txt";
            var pathToEds = "RSA.txt";
            var result = Create(p, q, pathToSource, pathToEds);
            var veryify = Verify(result.d, result.n, pathToEds, pathToSource);
            Console.WriteLine("Проверка на корректность RSA - " + veryify);
        }

        public static void CheckInCorrectly()
        {
            var p = 7;
            var q = 13;
           
            var pathToSource = "Source.txt";
            var pathToFakeSource = "FakeSource.txt";
            var pathToEds = "RSA.txt";
            DateTime start1 = DateTime.Now;
            var result = Create(p, q, pathToSource, pathToEds);
            var veryify = Verify(result.d, result.n, pathToEds, pathToFakeSource);
            Console.WriteLine("Электронно цифровая подпись на основе RSA действительна? - " + veryify);
            TimeSpan procTime1 = DateTime.Now - start1;
            Console.WriteLine("Потраченное время на проверку: " + procTime1.TotalSeconds.ToString() + " sec");
            Console.WriteLine("___________________________________________________________________________");
        }

        private static readonly char[] Characters = { '#', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };

        private static (long d, long n) Create(long p, long q, string sourceFilePathTextBox, string signFilePathTextBox)
        {
            var hash = File.ReadAllText(sourceFilePathTextBox).GetHashCode().ToString();
            var n = p * q;
            var m = (p - 1) * (q - 1);
            var d = Calculate_d(m);
            var e = Calculate_e(d, m);

            var result = RSA_Encode(hash, e, n);

            var sw = new StreamWriter(signFilePathTextBox);
            foreach (var item in result)
            {
                sw.WriteLine(item);
            }
            sw.Close();

            return (d, n);
        }

        private static bool Verify(long d, long n, string signFilePathTextBox, string sourceFilePathTextBox)
        {
            var input = new List<string>();

            var sr = new StreamReader(signFilePathTextBox);

            while (!sr.EndOfStream)
            {
                input.Add(sr.ReadLine());
            }

            sr.Close();

            var result = RSA_Decode(input, d, n);

            var hash = File.ReadAllText(sourceFilePathTextBox).GetHashCode().ToString();

            if (result.Equals(hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<string> RSA_Encode(string s, long e, long n)
        {
            var result = new List<string>();

            foreach (var t in s)
            {
                var index = Array.IndexOf(Characters, t);
                var bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);
                var bn = new BigInteger((int)n);
                bi %= bn;
                result.Add(bi.ToString());
            }

            return result;
        }

        private static string RSA_Decode(List<string> input, long d, long n)
        {
            var result = "";
            var bn = new BigInteger((int)n);
            foreach (var item in input)
            {
                var bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);
                bi = bi % bn;

                var index = Convert.ToInt32(bi.ToString());

                result += Characters[index].ToString();
            }

            return result;
        }

        private static long Calculate_d(long m)
        {
            var d = m - 1;

            for (long i = 2; i <= m; i++)
            {
                if (m % i == 0 && d % i == 0)
                {
                    d--;
                    i = 1;
                }
            }

            return d;
        }

        private static long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if (e * d % m == 1)
                {
                    break;
                }
                else
                {
                    e++;
                }
            }
            return e;
        }
    }

    public static class ElGamal
    {
        public static void CheckCorrectly()
        {
            var str = "Hello world";
            var hash = CalculateMd5Hash(str).ToString();
            var sign = ElGamalClass.EnCrypt(hash);
            var verify = ElGamalClass.DeCrypt(sign) == CalculateMd5Hash(str).ToString();
            Console.WriteLine("Проверка на корректность ElGamal - " + verify);
        }
        public static void CheckInCorrectly()
        {
            var str = "Hello world";
            var fakeStr = "Hello world";
            DateTime start1 = DateTime.Now;
            var hash = CalculateMd5Hash(str).ToString();
            var sign = ElGamalClass.EnCrypt(hash);
            var verify = ElGamalClass.DeCrypt(sign) == CalculateMd5Hash(fakeStr).ToString();
            Console.WriteLine("Электронно цифровая подпись на основе ElGamal действительна ? -" + verify);
            TimeSpan procTime1 = DateTime.Now - start1;
            Console.WriteLine("Потраченное время на проверку: " + procTime1.TotalSeconds.ToString() + " sec");
            Console.WriteLine("___________________________________________________________________________");

        }
        private static BigInteger CalculateMd5Hash(string input)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);
            return new BigInteger(hash.Concat(new byte[] { 0 }).ToArray());
        }
    }

    public static class ElGamalClass
    {
        private static int Power(int a, int b, int n)
        {
            var tmp = a;
            var sum = tmp;
            for (var i = 1; i < b; i++)
            {
                for (var j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }

                tmp = sum;
            }

            return tmp;
        }

        private static int Mul(int a, int b, int n)
        {
            var sum = 0;

            for (var i = 0; i < b; i++)
            {
                sum += a;

                if (sum >= n)
                {
                    sum -= n;
                }
            }

            return sum;
        }

        public static string EnCrypt(string str)
        {
            return Crypt(593, 123, 8, str);
        }

        public static string DeCrypt(string str)
        {
            return Decrypt(593, 8, str);
        }


        /*****************************************************
        p - простое число
        0 < g < p-1
        0 < x < p-1
        m - шифруемое сообщение m < p
        *****************************************************/
        // 593, 123, 8
        private static string Crypt(int p, int g, int x, string inString)
        {
            var result = "";
            var y = Power(g, x, p);
            var rand = new Random();
            foreach (int code in inString)
                if (code > 0)
                {
                    var k = rand.Next() % (p - 2) + 1; // 1 < k < (p-1) 
                    var a = Power(g, k, p);
                    var b = Mul(Power(y, k, p), code, p);
                    result += a + " " + b + " ";
                }

            return result;
        }

        private static string Decrypt(int p, int x, string inText)
        {
            var result = "";

            var arr = inText.Split(' ').Where(xx => xx != "").ToArray();
            for (var i = 0; i < arr.Length; i += 2)
            {
                var a = int.Parse(arr[i]);
                var b = int.Parse(arr[i + 1]);

                if (a != 0 && b != 0)
                {
                    //wcout<<a<<" "<<b<<endl; 

                    var deM = Mul(b, Power(a, p - 1 - x, p),
                        p); // m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p - 
                    var m = (char)deM;
                    result += m;
                }
            }

            return result;
        }
    }
}