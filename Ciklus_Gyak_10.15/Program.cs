using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklus_Gyak_10._15
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            int y = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. kerület/terület");
                Console.WriteLine("2. 6db szám műveletei");
                Console.WriteLine("3. Math osztály műveletek");
                Console.WriteLine("4. 25 elemű tömb feladatok");
                Console.WriteLine("5. Kilépés");
                y = Convert.ToInt32(Console.ReadLine());
                switch (y)
                {
                    case 1:
                        {
                            Console.WriteLine("Kör vagy négyzet kerület/terület?");
                            char betu = Convert.ToChar(Console.ReadLine());
                            if (betu=='K'||betu=='k')
                            {
                                Console.WriteLine("Kör kerület/terület");
                                Console.WriteLine("A kör sugara: ");
                                double r = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"kerület: {2*r*Math.PI}");
                                Console.WriteLine($"terület: {Math.Pow(r,2)*Math.PI}");
                            }
                            if (betu == 'n' || betu == 'N')
                            {
                                Console.WriteLine("Néhyzet terület/kerület");
                                Console.WriteLine("A négyzet oldala: ");
                                int a = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"kerület: {4*a}");
                                Console.WriteLine($"terület: {a*a}");
                            }
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Kérek egy számot: ");
                            int szam = Convert.ToInt32(Console.ReadLine());
                            double db = 1, db_plan = 0, osszeg_plan = 0;
                            int[] paros = new int[6];
                            int paros_index = 0;
                            while (db<7)
                            {
                                //írjuk a képernyőre a páros számokat
                                //a páratlanok átlaga
                                if (szam % 2 == 0)
                                {
                                    paros[paros_index] = szam;
                                    paros_index++;
                                }
                                else
                                {
                                    osszeg_plan += szam;
                                    db_plan++;
                                }
                                Console.WriteLine("Kérek egy számot: ");
                                szam = Convert.ToInt32(Console.ReadLine());
                                db++;
                            }
                            Console.WriteLine("A páros számok: ");
                            //foreach (var item in paros)
                            //{
                            //    Console.WriteLine($"{item} ");
                            //}
                            for (int i = 0; i < paros_index; i++)
                            {
                                Console.Write($"{paros[i]} ");
                            }
                            Console.WriteLine($"Páratlan számok átlaga: {osszeg_plan/db_plan}");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Kérek egy számot: ");
                            double szam = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"A szám négyzete: {Math.Pow(szam,2)}");
                            Console.WriteLine($"Négyzetgyök: {Math.Sqrt(szam)}");
                            Console.WriteLine($"Köbgyök: {Math.Pow(szam,1/3)}");
                            Console.WriteLine($"Abszolút érték: {Math.Abs(szam)}");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            int[] tomb= new int[25];
                            Random rnd = new Random();
                            for (int i = 0; i < tomb.Length; i++)
                            {
                                tomb[i] = rnd.Next(10, 100);
                                Console.Write($"{tomb[i]}\t");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"Elemek összege: {tomb.Sum()} ");
                            Console.WriteLine($"Elemek átlaga: {tomb.Average():0.00}");
                            Console.WriteLine($"Legnagyobb elem: {tomb.Max()}");
                            Console.WriteLine($"Legkisebb elem: {tomb.Min()}");
                            Console.WriteLine($"A tömb elemszáma: {tomb.Length}");
                            Console.WriteLine($"A tömb első eleme: {tomb.First()} {tomb[0]}");
                            Console.WriteLine($"A tömb utolsó eleme: {tomb.Last()} {tomb.Length-1}");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (y!=5);


            Console.Clear();

            */

            int x = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. feladat");
                Console.WriteLine("2. feladat");
                Console.WriteLine("3. feladat");
                Console.WriteLine("4. feladat");
                Console.WriteLine("5. feladat");
                Console.WriteLine("6. feladat");
                Console.WriteLine("7. feladat");
                Console.WriteLine("8. Quit");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            int[] szamok = new int[5];
                            for (int i = 0; i < szamok.Length; i++)
                            {
                                Console.WriteLine("Kérek egy számot: ");
                                int szam = Convert.ToInt32(Console.ReadLine());
                                szamok[i] = szam;
                            }
                            Console.WriteLine($"A számok összege: {szamok.Sum()}");
                            Console.ReadKey();
                        }
                        break;

                    case 2:
                        {
                            for (int i = 1; i < 21; i++)
                            {
                                Console.Write($"{i}, ");
                            }
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Kérek egy számot: ");
                            int szam = Convert.ToInt32(Console.ReadLine());
                            if (szam % 3 == 0)
                            {
                                Console.WriteLine($"A bekért szám: {szam}, osztható 3-al");
                            }
                            else
                            {
                                Console.WriteLine($"A bekért szám: {szam}, NEM osztható 3-al");
                            }
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        {
                            int[] vektor = new int[20];
                            Random rnd = new Random();
                            int szamlalo = 0;

                            for (int i = 0; i < vektor.Length; i++)
                            {
                                vektor[i] = rnd.Next(10, 100);
                                if (vektor[i] % 2 == 0)
                                {
                                    szamlalo++;
                                }
                                Console.Write($"{vektor[i]} ");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"A tömb elemeinek összege: {vektor.Sum()}");
                            Console.WriteLine($"{szamlalo} db páros elem van");
                            Console.ReadKey();
                        }
                        break;

                    case 5:
                        {
                            int[] szamok = new int[25];
                            Random rnd = new Random();
                            int[] paros = new int[25];
                            int szamlalo = 0;
                            int[] harommal = new int[25];
                            int szamlalo1 = 0;
                            int kisindex = 1000;
                            bool osztható = false;
                            int indexkereso = 0;

                            for (int i = 0; i < szamok.Length; i++)
                            {
                                szamok[i] = rnd.Next(1000);
                                Console.Write($"{szamok[i]} ");
                                
                                if (szamok[i]<kisindex)
                                {
                                    kisindex = szamok[i];
                                    indexkereso = i;
                                }
                                
                                if (szamok[i]%2==0)
                                {
                                    paros[szamlalo] = szamok[i];
                                    szamlalo++;
                                }
                                if (szamok[i] %3==0)
                                {
                                    harommal[szamlalo1] = szamok[i];
                                    szamlalo1++;
                                }
                                if (szamok[i]%10==0)
                                {
                                    osztható = true;
                                }
                                


                            }
                            Console.WriteLine();
                            for (int i = 0; i < szamlalo; i++)
                            {
                                Console.Write($"{paros[i]} ");
                            }
                            Console.WriteLine();
                            Console.WriteLine($"3-al oszthatók átlaga: {harommal.Average()}");
                            Console.WriteLine($"A legkisebb elem: {szamok.Min()}, Indexe: {indexkereso}");
                            Console.WriteLine($"Van 10-el osztható? {osztható}");
                            Console.WriteLine($"A számok összege: {szamok.Sum()}");
                            Console.ReadKey();
                        }
                        break;
                }

            } while (x!=8);



        }
    }
}
