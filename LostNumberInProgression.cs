using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 4, 11 }; // jakakolwiek lista pasująca do zadania

            Console.WriteLine(FindMissing(list));
        }

        public static int FindMissing(List<int> list)
        {
            int x = list[1] - list[0], y = 0, z = 0, v = 0, Difference = 0, MyIndex = 0;

            if (list.Count <= 2) { Difference = (list[1] - list[0]) / 2; MyIndex = list.Count - 1; }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if ((i + 1) < list.Count)
                    {
                        if (x == list[i + 1] - list[i]) { z += 1; }
                        else { y += list[i + 1] - list[i]; v += 1; }
                    }

                    if (v == z && x < y) { MyIndex += (i + 1); break; }
                    else if (v == z && x > y) { MyIndex += i; break; }
                    if ((v == 1 && z > 1) || (v > 1 && z == 1)) { MyIndex += (i + 1); break; }
                    else continue;
                }
                if (z > 1) { Difference += x; }
                else if (v > 1) { Difference += y; }
                else if (v == z) { if (x > y) { Difference += y; } else { Difference = +x; } }                
            }
            int LostNumber = list[MyIndex] - Difference;
            return LostNumber;
        }
    }
}
