using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlás_11._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {

                Console.WriteLine("1. Feladat");
                Console.WriteLine("2. Feladat");
                Console.WriteLine("3. Feladat");
                Console.WriteLine("4. Feladat");
                Console.WriteLine("5. Feladat");
                Console.WriteLine("6. Kilépés");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("Kérek egy számot: ");
                            int szam = Convert.ToInt32(Console.ReadLine());
                            if (szam<0 || szam>100)
                            {
                                Console.WriteLine($"A szám: {szam} negatív, vagy nagyobb mint 100");
                            }
                            else
                            {
                                if (szam%2==0)
                                {
                                    Console.WriteLine($"A szám: {szam}, páros");
                                }
                                else
                                {
                                    Console.WriteLine($"A szám: {szam}, páratlan");
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        {
                            int[] szamok = new int[10];
                            int count = 0;
                            for (int i = 0; i < szamok.Length; i++)
                            {
                                Console.WriteLine($"Kérem az {i+1}. számot: ");
                                szamok[i] = Convert.ToInt32(Console.ReadLine());
                                if (szamok[i]%3==0)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine($"A bekért számok összege: {szamok.Sum()}\nA bekért számok átlaga: {szamok.Average()}\nA bekért számok közül '{count}' db 3-al osztható van");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 3:
                        {
                            int[] szamok = new int[10];
                            Random rnd = new Random();
                            for (int i = 0; i < szamok.Length; i++)
                            {
                                szamok[i] = rnd.Next(100);
                                Console.Write($"{szamok[i]} ");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"A lista legkisebb eleme: {szamok.Min()}");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 4:
                        {

                        }
                        break;
                }

            } while (x!=6);


            int[] szamok = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(100,1000);
            }

            /*ennek még az egész loop előtt létre kell jönnie*/
            do
            {

            } while (true);
        }
    }
}
