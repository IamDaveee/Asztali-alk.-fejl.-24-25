using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *tomb: Homogén adatok tárolása
             *típusa, neve, eleme
             *előre rögzített számú elemet tárol
             *elemek indexeni segítségével érhetjük el
             *indexezés 0-tól
             *összetett adatszerkezet
             *deklarálása:
             *típusa[] tombneve=new típusa[elemszám];
             *
             */
            int[] szamok = new int[3];
            //elemek értékének megadása
            szamok[0] = 12;
            szamok[1] = 56;
            Console.WriteLine(szamok[2]);
            szamok[2] = szamok[0];
            Console.WriteLine(szamok[2]);

            int[] szamok2 = new int[3] { 11, 22, 33 };
            Console.WriteLine($"Az 1. szám {szamok2[0]}, A 2 szám: {szamok2[1]}, a 3. szám: {szamok2[2]}");

            //kezdőértékkel rendelkező tömbök
            string[] nev = { "E", "V", "G", "P" };
            Console.WriteLine($"Tömb hossza: {nev.Length}");
            Console.WriteLine(szamok2.Max());

            /*
             *Ciklusok:
             *1.:for-számláló, növekményes, speciális előtesztelő
             *Akkor jó, ha tudom hányszor kell végrehajtani a ciklusmagban megjelenítetteket
             *általános forma:
             *CIKLUS cv:kezdőérték-től végérték-ig lépésszám
             *      ciklusmag utasítása(i)
             *      több utasítás esetén blokkok {}
             *CIKLUS VÉGE.
             *
             *for (int i=0;i<lenght;i++)
             *{
             *      //utasítások
             *}
             *
             *i:ciklusváltozó - int típis, de a for ciklus sajátja
             */

            for (int i = 0; i < 3; i++) //0,1,2
            {
                Console.WriteLine(szamok[i]);
            }
            
            for (int i = 0; i < nev.Length; i++)
            {
                Console.WriteLine($"{i+1}.elem: {nev[i]}");
            }

            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
            for (char i = 'Z'; i >= 'A'; i--)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= 100; i+=2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            //Véletlen számok - Random osztály
            Random rnd = new Random();
            int[] szamok3 = new int[100];
            for (int i = 0; i < szamok3.Length; i++)
            {
                szamok3[i] = rnd.Next(100, 1000);
                Console.Write($"{szamok3[i]} ");
            }
            Console.WriteLine();
            //Jelenítsük meg a számok3 tömb elemeinek az összegét
            int összeg = 0;
            for (int i = 0; i < szamok3.Length; i++)
            {
                összeg = összeg + szamok3[i];
            }
            Console.WriteLine($"A Számok összege: {összeg}");
            Console.WriteLine($"A számok összege: {szamok3.Sum()}");
            Console.WriteLine($"A számok átlaga: {összeg/szamok3.Length}");
            Console.WriteLine($"A számok átlaga: {Math.Round((double)szamok3.Sum()/szamok3.Length,3)}");
            Console.WriteLine($"A számok átlaga: {szamok3.Average()}");

            //foreach - nincs indexelés; változóba íródik az érték
            foreach (int item in szamok3)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
