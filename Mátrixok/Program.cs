using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrixok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            /*

            //egydimenziós töbm: vektor
            int[] szamok = new int[15];
            
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(10,100);
                Console.Write($"{szamok[i]} ");
            }
            Console.WriteLine();

            //Kezdőértékkel rendelkező szöveges tömbök
            string[] viragok = { "rózs", "viola", "ibolya", "gerbera" };

            foreach (var item in viragok)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            */

            //mátrix - kétdimenziós tömb
            //sor - oszlop
            //homogén adatszerkezet, azonos típus

            //deklarálás
            int[,] sz = new int[4,4];
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    sz[i, j] = rnd.Next(100, 1000);
                    //kiíratom
                    //Console.Write($"{sz[i, j]} ");
                }
                //Console.WriteLine();
            }

            /*
            //kezdőértékkel rendelkező mátrix
            string[,] napok = { {"H","hétfő"},{"K","kedd"},{"SZ","szerda"},{"CS","csütörtök"} };
            for (int i = 0; i < napok.GetLength(0); i++)
            {
                for (int j = 0; j < napok.GetLength(1); j++)
                {
                    Console.Write($"{napok[i,j]} ");
                }
                Console.WriteLine();
            }

            foreach (var item in napok)
            {
                Console.WriteLine(item);
            }


            //mátrix elemeinek összege
            double osszeg = 0;
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    osszeg += sz[i, j];
                }
            }
            Console.WriteLine($"A mátrix elemeinek összege: {osszeg}");
            Console.WriteLine($"A mátrix elemeinek átlaga: {osszeg/sz.Length}");


            Console.ReadKey();

            

            //T tulajdonság - van-e páros elem a sorozatban
            bool vane = false;
            int cv = 0;
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    if (sz[i,j]%2==0)
                    {
                        vane = true;
                    }
                }
            }
            Console.WriteLine(vane?"Van benne páros.":"Nincs benne páros.");
            //Van-e páros elem? - megszámlálás tétele
            int db = 0;
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    if (sz[i,j]%2==0)
                    {
                        db++;
                    }
                }
            }
            //Van páros
            Console.WriteLine(db>0?"Van benne páros elem.":"Nincs benne páros elem");

            Console.WriteLine($"{db} db páros szám van a mátrixban");
            Console.WriteLine($"{sz.Length-db}");


            int minindex1 = 0;
            int minindex2 = 0;
            int relativ = 10000;
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    if (sz[i,j]<relativ)
                    {
                        minindex1 = i;
                        minindex2 = j;
                        relativ = sz[i, j];
                    }
                }
            }
            Console.WriteLine($"A legkisebb elem: {relativ}, helye: {minindex1}, {minindex2}");
            Console.ReadKey();

            int min = sz[0, 0];
            int minindex3 = 0;
            int minindex4 = 0;
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    if (sz[i,j]<min)
                    {
                        min = sz[i, j];
                        minindex3=i;
                        minindex4 = j;
                    }
                }
            }
            Console.WriteLine($"A legkisebb: {min}, helye: {minindex3},{minindex4}");

            Console.WriteLine("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            bool bennevan = false;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < sz.GetLength(0); i++)
            {
                for (int j = 0; j < sz.GetLength(1); j++)
                {
                    if (sz[i,j]==szam)
                    {
                        bennevan = true;
                        index1 = i;
                        index2 = j;
                    }
                }
            }
            if (bennevan==true)
            {
                Console.WriteLine($"A megadott szám szerepel a mátrixban, helye: {index1}, {index2}");
            }


            */


            int elsomax = sz.GetLength(0);
            int[] szamok1 = new int[elsomax];
            for (int i = 0; i < elsomax; i++)
            {
                
                szamok1[i] = sz[i, i];
                Console.Write($"{szamok1[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"A főátló elemeinek összege: {szamok1.Sum()}");
        }
    }
}
