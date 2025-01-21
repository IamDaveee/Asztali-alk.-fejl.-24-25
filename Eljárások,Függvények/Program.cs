using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljárások_Függvények
{
    class Program
    {

        static List<int> szamok = new List<int>();
        //eljaras - visszatérési érték típus nélküli függvény
        //void visszatérési értéke
        //eljárás neve, paramétere, eljárástörzs (utasításokat tartalmaz)
        //eljárás meghívás a nevére (és paramétereire) való hivatkozás

        static void Osszeg()
        {
            Console.WriteLine($"A Lista elemeinek öszege: {szamok.Sum()}");
        }
        static void Atlag()
        {
            Osszeg();
            Console.WriteLine($"A Lista elemeinek átlaga: {szamok.Average()}");
        }
        static void Feltoltes()
        {
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                szamok.Add(rnd.Next(10,100));
            }
        }//Feltöltés

        //Függvény - visszatérési érték típussal rendelkezik
        //Van neve, paramétere és egy visszatérési értéke
        //return
        //meghívása egy kifejezés részeként történik
        //önálló utasításként nem állhat

        //lista elemeinek összege- fv.
        static int listaOsszeg()
        {
            int osszeg = szamok.Sum();
            return osszeg;
        }
        static double ListaAtlaga()
        {
            return szamok.Average();
        }

        static int ListaParos()
        {
            int darab = 0;
            for (int i = 0; i < szamok.Count(); i++)
            {
                if (szamok[i]%2==0)
                {
                    darab++;
                }
            }
            return darab;
        }

        //keresett szám van-e a listában
        static bool Keresett()
        {
            Console.WriteLine("Melyik számot keressük a listában? ");
            int find = Convert.ToInt32(Console.ReadLine());
            bool benne = false;
            for (int i = 0; i < szamok.Count(); i++)
            {
                if (szamok[i]==find)
                {
                    benne = true;
                }
            }
            return benne;
        }

        static bool Contain()
        {
            Console.WriteLine("Melyik számot keressük a listába? ");
            int find = Convert.ToInt32(Console.ReadLine());
            bool van = szamok.Contains(find);
            return van;
        }

        //eljaras - lista legnagyobb eleme és indexe

        static void Legnagyobb()
        {
            Console.WriteLine($"A lista legnagyobb eleme: {szamok.Max()}, helye: {szamok.IndexOf(szamok.Max())}");
        }

        //fv - lista darabszáma

        static int Darabszam()
        {
            return szamok.Count();
        }

        static void Main(string[] args)
        {
            KiIr();
            Feltoltes();
            szamok.Add(20);
            Console.WriteLine($"A lista első eleme: {szamok[0]}");
            Feltoltes();
            Console.WriteLine($"A lista {szamok.Count} db elemből áll");
            KiIr();
            Osszeg();
            Atlag();
            //fv meghívása egy kifejezés részeként
            int eredmény = listaOsszeg();
            listaOsszeg();
            Console.WriteLine($"A lista elemeinek összege: {eredmény}");
            Console.WriteLine($"A lista elemeinek összege: {listaOsszeg()}");
            Console.WriteLine(listaOsszeg()>3000?"Elemek összege több mint 3000":"Elemek összege kisebb mint 3000");
            Console.WriteLine($"A lista elemeinek átlaga: {ListaAtlaga()}");
            Console.WriteLine($"A listában {ListaParos()} db páros elem található.");

            Console.WriteLine($"A keresett szám {Keresett()} a listában");
            Console.WriteLine(Contain()==true?"A keresett szám benne van a listában":"A keresett szám nincs benne a listában");

            Legnagyobb();
            Console.WriteLine($"{Darabszam()} db elem van a listában");

        }//Main

        static void KiIr()
        {
            Console.WriteLine("A lista elemei: ");
            for (int i = 0; i < szamok.Count(); i++)
            {
                Console.Write($"{szamok[i]} ");
            }
            Console.WriteLine();
        }
    }//Program
}//namespace
