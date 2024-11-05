using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Óra_11._05
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int y = 0;
            do
            {
                Console.WriteLine("1.Feladat");
                Console.WriteLine("2.Feladat");
                Console.WriteLine("3.Feladat");
                Console.WriteLine("4.Feladat");
                Console.WriteLine("5.Kilépés");
                y = Convert.ToInt32(Console.ReadLine());
                switch (y)
                {
                    case 1:
                        {
                            int count = 0;
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("Kérek egy számot: ");
                                int szam = Convert.ToInt32(Console.ReadLine());
                                count += szam;
                            }
                            Console.WriteLine($"A bekért számok összege: {count}");
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            int [] szam = new int[20];
                            for (int i = 0; i < szam.Length; i++)
                            {
                                szam[i] = i+1;
                                Console.Write($"{szam[i]} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Kérek egy számot: ");
                            int szam = Convert.ToInt32(Console.ReadLine());
                            if (szam%3==0)
                            {
                                Console.WriteLine($"A szám: {szam}, osztható 3-al");
                            }
                            else
                            {
                                Console.WriteLine($"A szám: {szam}, NEM osztható 3-al");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        {
                            int[] vektor = new int[20];
                            Random rnd=new Random();
                            int count = 0;
                            for (int i = 0; i < vektor.Length; i++)
                            {
                                
                                vektor[i] = rnd.Next(10, 99);
                                if (vektor[i] % 2 == 0)
                                {
                                    count ++;
                                }
                                Console.Write($"{vektor[i]} ");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"A tömb elemeinek összege: {vektor.Sum()}");
                            Console.WriteLine($"{count} db páros elem van.");
                        }
                        break;
                }

            } while (y!=5);


            */

            Console.WriteLine("Hogy hívnak? ");
            string nev = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Üdvözöllek, {nev}");



            Console.WriteLine("Szereted a sütiket? (i/n)");
            char betu = Convert.ToChar(Console.ReadLine());
            if (betu == 'i')
            {
                Console.WriteLine($"\t Milyen sütiket szeretsz? ");
                Console.WriteLine("\t Torta - T, Keksz - K, Mignon - M, Linzer - L, Pite - P");
                char suti = Convert.ToChar(Console.ReadLine());
                if (suti != 'T' || suti != 't' || suti != 'K' || suti != 'k' || suti != 'M' || suti != 'm' || suti != 'L' || suti != 'l' || suti != 'P' || suti != 'p')
                {
                    Console.WriteLine("Ilyen ízű sütemény nem szerepel a listában");
                }

                Console.WriteLine("Milyen ízben szereted a választott süteményt? ");
                string íz = Console.ReadLine();
                string suti2 = Console.ReadLine().ToLower();
                switch (suti2)
                {
                    case "t":
                        {
                            suti2 = "Torta";
                            Console.WriteLine($"A {íz} {suti2} a kedvenced!");
                        }
                        break;
                    case "k":
                        {
                            suti2 = "Keksz";
                            Console.WriteLine($"A {íz} {suti2} a kedvenced!");
                        }
                        break;
                    case "m":
                        {
                            suti2 = "Mignon";
                            Console.WriteLine($"A {íz} {suti2} a kedvenced!");
                        }
                        break;
                    case "l":
                        {
                            suti2 = "Linzer";
                            Console.WriteLine($"A {íz} {suti2} a kedvenced!");
                        }
                        break;
                    case "p":
                        {
                            suti2 = "Pite";
                            Console.WriteLine($"A {íz} {suti2} a kedvenced!");
                        }
                        break;
                }
            }

            Console.WriteLine("Kérem a gömb sugarát: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double A =Math.Round( 4 * Math.Pow(r, 2) * Math.PI,3);
            double V =Math.Round((4*Math.Pow(r, 3)*Math.PI)/3,3);

            Console.WriteLine($"A kör sugara: {r}\n \t A gömb felszíne: {A}\n \t A gömb térfogata: {V}");


        }
    }
}
