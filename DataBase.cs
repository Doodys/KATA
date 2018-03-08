using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurwacoto2
{
    public struct Contacts
    {
        public string x;
        public string y;
        public string z;
        public string v;
        public int f;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array;
            string[] Nazwy = { "Imiê: ", "Nazwisko: ", "Numer telefonu: ", "Email: " };
            char[] Exceptions = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '`', '~', '[', ']', ';', '"', ',', '.', '/', '{', '}', ':', '<', '>', '?'};
            char[] Email = { '@', '.' };
            Contacts p;
            bool Check = true, Check2 = true, Check3 = true;
            p.x = "";
            p.y = "";
            p.z = "";
            p.v = "";
            p.f = 0;

            while (Check3)
            {
                Console.Clear();
                Console.Write("Podaj iloœæ kontaktów do stworzenia: ");
                bool Length = int.TryParse(Console.ReadLine(), out int Num);
                if (Length && Num > 0)
                {
                    Array = new string[Num];
                    for (int i = 0; i < Num; i++)
                    {
                        Console.Clear();
                        p = new Contacts();

                        while (Check)
                        {
                            Console.Clear();
                            Console.WriteLine("U¿ytkownik " + (i + 1) + "\n");
                            Console.Write("Podaj imiê: ");
                            p.x = Console.ReadLine();
                            if (p.x.Length < 3) { Console.Clear(); Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz..."); Console.ReadKey(); }
                            else Check2 = false;
                            if (Check2 == false)
                            {
                                var Chars = p.x.ToCharArray();
                                if (char.IsUpper(Chars[0]))
                                {
                                    for (int k = 0; k < Exceptions.Length; k++)
                                        if (Chars.Contains(Exceptions[k]))
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                            for (int l = 1; l < Chars.Length; l++)
                                                if (char.IsLower(Chars[l]))
                                                    Check = false;
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                    Console.ReadKey();
                                }
                            }
                        }
                        Check = true;
                        Check2 = true;

                        while (Check)
                        {
                            Console.Clear();
                            Console.WriteLine("U¿ytkownik " + (i + 1) + "\n");
                            Console.Write("Podaj nazwisko: ");
                            p.y = Console.ReadLine();
                            var Chars = p.y.ToCharArray();
                            if (char.IsUpper(Chars[0]))
                            {
                                for (int k = 0; k < Exceptions.Length; k++)
                                    if (Chars.Contains(Exceptions[k]))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                        for (int l = 1; l < Chars.Length; l++)
                                            if (char.IsLower(Chars[l]))
                                                Check = false;
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                                Console.ReadKey();
                                                break;
                                            }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                Console.ReadKey();
                            }
                        }
                        Check = true;
                        Check2 = true;

                        while (Check)
                        {
                            Console.Clear();
                            Console.WriteLine("U¿ytkownik " + (i + 1) + "\n");
                            Console.Write("Podaj numer: ");
                            if (int.TryParse(Console.ReadLine(), out p.f) && Convert.ToString(p.f).Length == 9)
                                Check = false;
                            else { Console.Clear(); Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz..."); Console.ReadKey(); }
                        }
                        p.z = String.Empty + p.f;
                        Check = true;

                        while (Check)
                        {
                            Console.Clear();
                            Console.WriteLine("U¿ytkownik " + (i + 1) + "\n");
                            Console.Write("Podaj email: ");
                            p.v = Console.ReadLine();
                            var Chars = p.v.ToCharArray();
                            for (int k = 0; k < Email.Length; k++)
                            {
                                if (Chars.Contains(Email[0]) && Chars.Contains(Email[1])) Check = false;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Wprowadzono b³edne dane!\n\nWciœnij dowolny klawisz...");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                        }

                        string[] Array2 = { p.x, p.y, p.z, p.v };
                        Array[i] = String.Join(" \n", Array2);
                        Check = true;
                        p.f = 0;
                    }

                    Console.Clear();
                    for (int i = 0; i < Num; i++)
                        Console.WriteLine("U¿ytkownik " + (i + 1) + ": \n\n" + Array[i] + "\n");
                    Check3 = false;
                }
                else { Console.Clear(); Console.WriteLine("Wprowadzono niepoprawna iloœæ kontaktów do stworzenia!\n\nWciœnij dowolny klawisz..."); Console.ReadKey(); }
            }
        }
    }
}
