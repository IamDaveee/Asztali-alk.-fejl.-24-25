using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras_Függvény_Gyak
{
    class Program
    {

        static int[] tomb  = new int[25];
        static Random rnd = new Random();

        static void Feladat1()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(100,1000);
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();
        }

        static void Feladat2()
        {
            Console.WriteLine($"A tömb elemeinek összege: {tomb.Max()}, Átalaga: {tomb.Average()}");
        }

        static void Feladat3()
        {
            int max = tomb.Max();
            int hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]==max)
                {
                    hely = i;
                }
            }
            Console.WriteLine($"A tömb legnagyobb eleme: {max} helye: {hely}");
        }

        static void Feladat4()
        {
            Console.WriteLine("Kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam == 0)
            {
                Console.WriteLine("A szám 0");
            }
            if (szam>0)
            {
                Console.WriteLine("A szám nagyobb mint 0");
            }
            else
            {
                Console.WriteLine("A szám kisebb mint 0");
            }
        }

        static void Feladat5()
        {
            List<double> szamok = new List<double> { };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Kérem az {i+1}. számot: ");
                double szam = Convert.ToDouble(Console.ReadLine());
                szamok.Add(szam);
            }
            szamok.Sort();
            double d1 = szamok[0] - szamok[1];
            double d2 = szamok[1] - szamok[2];
            bool szamtani = false;
            if (d1==d2)
            {
                szamtani = true;
            }
            double atlag = Math.Round(szamok.Average(),2);

            Console.WriteLine(szamtani?"A beírt számokból lehet számtani sorozatot alkotni":"A beírt számokból nem lehet számtani sorozatot alkotni");
            Console.WriteLine($"A beírt számok átlaga: {atlag}");
        }

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
        }
    }
}
