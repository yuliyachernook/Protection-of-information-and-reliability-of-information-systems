using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class Functions
    {
        public static int Nod(int x, int y)
        {
            if (y == 0)
                return x;
            else
                if (x > y)
                return Nod(y, x % y);
            else
                return Nod(x, y % x);
        }

        public static IEnumerable<int> GetPrimeNumbers(int min, int max)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                primeNumbers.Add(i);
            }

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                for (int j = 2; j < max; j++)
                    primeNumbers.Remove(primeNumbers[i] * j);
            }

            return primeNumbers.Where(s => s >= min);
        }
    }
}
