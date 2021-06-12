using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Gamal
{
    public static class RSA
    {
        public static bool IsPrimary(long a)
        {
            if (a < 2)
                return false;

            if (a == 2)
                return true;

            for (long i = 2; i < a; i++)
                if (a % i == 0)
                    return false;

            return true;
        }

        public static long Eiler(long a, long b) //функция Эйлера
        {
            return (a - 1) * (b - 1);
        }

        public static long getE(long fi) //1 < e < fi(n)
        {
            long e = fi - 1;

            for (long i = 2; i < fi; i++)
                if ((fi % i == 0) && (e % i == 0)) //если имеют общие делители
                {
                    e--;
                    i = 1;
                }

            return e;
        }

        public static long getD(long e, long fi)
        {
            long d = 10;

            while (true)
            {
                if ((e * d) % fi == 1)
                    break;
                else
                    d++;
            }

            return d;
        }

        public static List<string> Encode(string s, long e, long n, char[] alphabet)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(alphabet, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        public static string Decode(List<string> input, long d, long n, char[] alphabet)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += alphabet[index].ToString();
            }

            return result;
        }

    }
}
