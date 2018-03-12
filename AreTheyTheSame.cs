using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 2, 3 };
            int[] b = new int[] { 4, 9, 9 };
            bool r = Comp(a, b);
            Console.WriteLine(r);
        }

        public static bool Comp(int[] a, int[] b)
        {
            foreach (int Number in a) { Console.Write(Number + " "); Console.WriteLine(); }
            foreach (int Number in b) { Console.Write(Number + " "); }
            if (a == null || b == null) { return false; }
            else if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Array.Sort(b);
                    if (IsPresent(b, (a[i] * a[i])) == true) { continue; }
                    else return false;
                }
            }
            return true;
        }
        public static bool IsPresent(int[] Vector, int Number)
        {
            int Left = 0, Right = Vector.Length - 1, Middle;
            while (Left <= Right)
            {
                Middle = (Left + Right) / 2;
                if (Vector[Middle] == Number) { Vector[Middle] = 0; return true; }
                else if (Vector[Middle] > Number) Right = Middle - 1;
                else Left = Middle + 1;
            }
            
            return false;
        }
    }
}
