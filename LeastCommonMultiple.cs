using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastCommonMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 3, 4 };
            Console.WriteLine(LeastCommonMultipleAggregate(list));
        }
        public static int LeastCommonMultipleAggregate(List<int> nums)
        {
            if (!nums.Any()) { return 1; }
            else { return nums.Aggregate(LeastCommonMultiple); }
        }
        static int LeastCommonMultiple(int a, int b)
        {
            return Math.Abs(a * b) / GreatestCommonDivisor(a, b);
        }
        static int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? a : GreatestCommonDivisor(b, a % b);
        }
    }
}
