using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgoza.Balázs_Dávid._02_04
{
    class Program
    {

        static void Sztringek()
        {
            Console.WriteLine("Kérek egy legalább 5 karakterből álló modatot: ");
            string mondat = Convert.ToString(Console.ReadLine());
            //
            Console.WriteLine();
            int count = 0;
            foreach (var item in mondat)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"A mondat {count} db szóközt tartalmaz.");
            //
            Console.WriteLine();
            Console.WriteLine($"A szóköz cseréje * karakterre: {mondat.Replace(' ', '*')}");
            //
            Console.WriteLine();
            Console.WriteLine(mondat.Contains("szép") ? "A mondatban szerepel a 'szép' szó." : "A mondatban NEM szerepel a 'szép' szó.");
            //
            Console.WriteLine();
            Console.WriteLine($"A mondat csupa nagybetűvel: {mondat.ToUpper()}");
            //
            Console.WriteLine();
            Console.WriteLine($"A mondat első 5 karaktere: {mondat.Substring(0, 5)}, utolsó 5 karaktere: {mondat.Substring(mondat.Length - 5)}");
            //
            Console.WriteLine();
            Console.WriteLine(mondat.EndsWith(".") ? "A mondat ponttal végződik" : $"A mondat nem ponttal végződik, utolsó karakter: {mondat[mondat.Length - 1]}");
            //
            Console.WriteLine();
            string cukor = "cukor";
            Console.WriteLine($"Az összefűzött mkondat: {mondat.Insert(mondat.Length, cukor)}");
            //
            Console.WriteLine();
            string[] darabok = mondat.Split(' ');
            Console.WriteLine("A mondat egyes darabjai: ");
            foreach (var item in darabok)
            {
                Console.WriteLine(item);
            }
            //
            Console.WriteLine();
            string nev = "Balázs Dávid";
            Console.WriteLine($"A mondat a saját neemmel az elején: {mondat.Insert(0, nev)}");
            //
            Console.WriteLine();
            Console.WriteLine($"A mondat az utolsó karakter nélkül: {mondat.Remove(mondat.Length - 1)}");
            //
            Console.WriteLine();
            Console.WriteLine(mondat.Contains('*') ? $"A * karakter első előfordulási helye: {mondat.IndexOf("*")}, utolsó előfordulási helye: {mondat.LastIndexOf("*")}" : $"A * karakter nem szerepel a mondatban.");
            //
            Console.WriteLine();
            string utoloSzó = darabok[darabok.Length - 1];
            Console.WriteLine($"Az utolsó szó első karaktere: {utoloSzó[0]}");
        }

        static List<string> gyumolcsok = new List<string> { "eper", "kiwi", "ananász", "görögdinnye", "citrom", "gránátalma" };

        static List<int> szamLista = new List<int>();
        static Random rnd = new Random();

        static int BetuDarab()
        {
            int count = 0;
            string aktualis = "";
            foreach (var item in gyumolcsok)
            {
                aktualis = item;
                count += aktualis.Length;
            }
            return count;
        }

        static string Leghosszabb()
        {
            string aktualis = "";
            int aktualisSzam = 0;
            int leghosszabbSzam = 0;
            string leghosszabb = "";
            foreach (var item in gyumolcsok)
            {
                aktualis = item;
                aktualisSzam = aktualis.Length;
                if (aktualisSzam>leghosszabbSzam)
                {
                    leghosszabbSzam = aktualisSzam;
                    leghosszabb = item;
                }
            }
            return leghosszabb;
        }

        static void Feltoltes()
        {
            int total = 0;
            do
            {
                int random = rnd.Next(100,1000);
                total = szamLista.Sum();
                
                if (total+random<=2500)
                {
                    szamLista.Add(random);
                }
                else
                {
                    break;
                }
                
            } while (total<2500);
        }

        static void Kiir()
        {
            Console.WriteLine("A számok lista elemei: ");
            foreach (var item in szamLista)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int Osszeg()
        {
            int sum = 0;
            foreach (var item in szamLista)
            {
                if (item%2==0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        static void Vizsgalat()
        {
            int sum = Osszeg();
            if (sum>2500)
            {
                Console.WriteLine("A lista páros elemeinek összege nagyobb mint 2500");
            }
            if (sum==2500)
            {
                Console.WriteLine("A lista páros elemeinek összege pontosan 2500");
            }
            if (sum<2500)
            {
                Console.WriteLine("A lista páros elemeinek összege kisebb mint 2500");
            }
        }

        static int Darab()
        {
            int darab = szamLista.Count();
            return darab;
        }

        static void ListaTolt()
        {
            for (int i = 0; i < 25; i++)
            {
                szamLista.Add(rnd.Next(100,110));
            }
        }

        static int HaromDarab()
        {
            int count = 0;
            foreach (var item in szamLista)
            {
                if (item%3==0)
                {
                    count++;
                }
            }
            return count;
        }

        static bool BenneVan()
        {
            Console.WriteLine("Melyik elemet keressük a listában? ");
            int szam = Convert.ToInt32(Console.ReadLine());
            return szamLista.Contains(szam);
        }

        static void Main(string[] args)
        {
            Sztringek();
            Console.WriteLine($"A listában szereplő nevek karaktereinek összege: {BetuDarab()}");
            Console.WriteLine($"A leghosszabb nevű gyümi a listában: {Leghosszabb()}");
            Feltoltes();
            Kiir();
            Console.WriteLine($"A lista páros elemeinek összege: {Osszeg()}");
            Vizsgalat();
            Console.WriteLine($"A listában szereplő elemek darabszáma: {Darab()}");
            ListaTolt();
            Kiir();
            Console.WriteLine();
            Console.WriteLine($"A listában {HaromDarab()} db 3-al osztható szám van.");
            Console.WriteLine(BenneVan()?$"A keresett szám szerepel a listában.":"A keresett szám nem szerepel a listában.");
        }
    }
}
