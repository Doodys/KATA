using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZerosInFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 101; //jakakolwiek silnia (w tym przypadku 101!)
            Console.WriteLine(TrailingZeros(n));
        }

        public static int TrailingZeros(int n)
        {
            int Result = 0, AmountOfZeros = 0;
            do
            {
                Result = n / 5;
                AmountOfZeros += Result;
                n = Result;
            } while (Result > 1);
            return AmountOfZeros;
        }
    }
}
