using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Gamal
{
    public static class Gamal
    {
        private static BigInteger Power(BigInteger a, int b, int n) //Y
        { // a^b mod n
            BigInteger tmp = BigInteger.Pow(a, b);

            return tmp % n;
        }
        public static string Crypt(int p, int g, int x, string inString)
        {
            string result = "";
            BigInteger y = Power(g, x, p);//y=21
            Random rand = new Random();
            Console.WriteLine($"Public key (p,g,y)=({p},{g},{y})");
            Console.WriteLine($"Primary key x={x}");

            int k = rand.Next() % (p - 2) + 1; // 1 < k < (p-1) 
            BigInteger a = Power(g, k, p); //посчитали ai=q^k mod p (273)
            foreach (int code in inString)//передаем строку, считываем каждую букву и берем ее код в аски
            {
                if (code > 0)
                {
                    Console.Write((char)code);

                    BigInteger b = Power((int)Power(y, k, p) * code, 1, p); //считаем bi= (y^k*mi) mod p =544( для N)
                    result += a + " " + b + " ";
                }
            }

            return result;
        }

        public static string Decrypt(int p, int x, string inText)
        {
            string result = "";

            string[] arr = inText.Split(' ').Where(xx => xx != "").ToArray();
            for (int i = 0; i < arr.Length; i += 2)
            {
                int a = int.Parse(arr[i]);
                int b = int.Parse(arr[i + 1]);

                if (a != 0 && b != 0)
                {
                    BigInteger deM = Power(b * BigInteger.Pow(a, p - 1 - x), 1, p);//mi= (bi*(ai)^x)^-1) mod p
                    char m = (char)deM;
                    result += m;
                }
            }

            return result;
        }
    }
}
