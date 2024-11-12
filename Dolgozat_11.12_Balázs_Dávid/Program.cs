using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_11._12_Balázs_Dávid
{
    class Program
    {
        static void Main(string[] args)
        {

            string x = "";
            Random rnd = new Random();
            int[] ketjegyu = new int[40];
            for (int i = 0; i < ketjegyu.Length; i++)
            {
                ketjegyu[i] = rnd.Next(10, 100);
            }
            do
            {



                Console.WriteLine("Választási lehetőségek: ");
                Console.WriteLine("A: Tömbös feladat");
                Console.WriteLine("B: A kétjegyű számokat tartalmazó tömb elemei");
                Console.WriteLine("C: Ismétlődő elem keresése és darabszámának meghatározása");
                Console.WriteLine("D: Gömb felszín/térfogat kiszámítása");
                Console.WriteLine("E: Kilépés");

                x = Convert.ToString(Console.ReadLine().ToUpper());
                if (x=="A" || x=="B"||x=="C"||x=="D"||x=="E")
                {
                    switch (x)
                    {
                        case "A":
                            {
                                int tombindex = 0;
                                Console.WriteLine("Hány gyümölcsöt szeretne bekérni?");
                                tombindex = Convert.ToInt32(Console.ReadLine());
                                string[] gyumi = new string[tombindex];
                                for (int i = 0; i < gyumi.Length; i++)
                                {
                                    Console.WriteLine($"Adja meg a(z) {i + 1}. gyümölcsöt: ");
                                    gyumi[i] = Convert.ToString(Console.ReadLine());
                                }

                                Console.WriteLine("Az összegyűjtött gyümölcsök:");
                                foreach (var item in gyumi)
                                {
                                    Console.Write($"{item} ");
                                }
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case "B":
                            {
                                Console.WriteLine("A kétjegyű számokat tartalmazó tömb elemei:");
                                foreach (var item in ketjegyu)
                                {
                                    Console.Write($"{item} ");
                                }
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case "C":
                            {
                                int find = 0;
                                int count = 0;
                                int indexCount = 0;
                                int location = 0;
                                Console.WriteLine("Melyik számot keressem meg a tömbben? ");
                                find = Convert.ToInt32(Console.ReadLine());
                                foreach (var item in ketjegyu)
                                {
                                    if (item==find)
                                    {
                                        count++;
                                        location = indexCount;
                                        indexCount++;
                                    }
                                    else
                                    {
                                        indexCount++;
                                    }
                                }
                                if (count>0)
                                {
                                    Console.WriteLine($"A {find} {count}-szor szerepel a tömbben, legutolsó előfordulási helye: {location+1}.");
                                }
                                else
                                {
                                    Console.WriteLine("Nincs benne!");
                                }
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case "D":
                            {
                                Console.WriteLine("Kérlek add meg a gömb sugarát: ");
                                double r = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("A gömb felszínét (A) vagy a térfogatát (V) szeretné kiszámítani? ");
                                char choice = Convert.ToChar(Console.ReadLine().ToUpper());
                                if (choice=='A'||choice=='V')
                                {
                                    if (choice=='A')
                                    {
                                        double A = Math.Round(4 * Math.Pow(r, 2) * Math.PI, 2);
                                        Console.WriteLine($"A gömb felszíne: {A}cm2");
                                    }
                                    else
                                    {
                                        double V = Math.Round((4 * Math.Pow(r, 3) * Math.PI) / 3, 2);
                                        Console.WriteLine($"A gömb térfogata: {V}cm3");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Rossz betűt adtál meg!");
                                }
                                Console.WriteLine();
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Kérlek a megadott betűkből válassz!");
                }

            } while (x!="E");

        }
    }
}
