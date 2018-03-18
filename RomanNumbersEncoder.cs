using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1954;
            Console.WriteLine(Solution(n));
        }
        public static string Solution(int n)
        {
            string Roman = "";
            string[] Thousand = { "", "M", "MM", "MMM" };
            string[] Hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] Ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] One = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            Roman += Thousand[(n / 1000) % 10];
            Roman += Hundred[(n / 100) % 10];
            Roman += Ten[(n / 10) % 10];
            Roman += One[n % 10];

            return Roman;
        }
    }
}
