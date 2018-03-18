using System;
using System.Text;
using System.Numerics;


namespace SumOfStringNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "759483679423876984679287593746589743986", b = "98679679546798546987438967489674679346794";
            Console.WriteLine(Add(a, b));
        }

        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
