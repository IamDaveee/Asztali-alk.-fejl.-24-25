using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kérek egy számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());

            //Pénznem - c, C
            Console.WriteLine($"Pénznenem formátum két tizedesjeggyel: {szam:c2}");
            Console.WriteLine($"A szám helykitöltéssel: {szam:000000.000}");
            //Tudományos alak - c, C
            Console.WriteLine($"Lebegőpontos alakban: {szam:E}");
            //f, F
            Console.WriteLine($"Fixpontos alakban: {szam:f5}");

            //Csoportosítás
            Console.WriteLine("{0:+### ### ### ####}",123456789);
            //tizedesjegyek
            Console.WriteLine("{0:#.##}", 55.3242);
            //százalék
            Console.WriteLine($"Százalék: {szam:p3}");
            //Round-Trip kerekítés nélkül
            Console.WriteLine($"{0.123456}");
            /*
                 0 - helyörző, csak akkor tölti fel a rendszer ha szükséges
                # - üres helyörző, csak akkor tölti fel a rendszer ha szükséges
                . - pontot jelenít meg, ált. tizedesjegyek
                % - százalékot jelenít meg
                / - vezérlő karakter
                \n - új sor
                \t - tabulátor
                \a - sípolás
             */

            //listák
            //homogén elemek gyűjteménye, amelyek indexeik segítségével érhetünk el

            List<int> lista = new List<int>();

            //elem hozzáadása a listáhot
            lista.Add(23);
            lista.Add(67);
            Console.WriteLine("Mi legyen a lista következő eleme? ");
            int elem = Convert.ToInt32(Console.ReadLine());
            lista.Add(elem);

            Console.WriteLine($"A lista első eleme: {lista[0]}");

            //lista elemeinek kiiratása foreach
            foreach (int item in lista)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            //lista létrehozása gyűjteményinicializáló szintaxissal
            var gyumolcsok = new List<string>()
            {
                "alma",
                "barack",
                "citrom",
                "eper"
            };
            //gyumolcsok lista
            for (int i = 0; i < gyumolcsok.Count; i++)
            {
                Console.Write($"{gyumolcsok[i]} ");
            }
            Console.WriteLine();

            //lista llétrehozása kezdőértékkel
            List<int> szamok = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //lista elemszám - Count
            Console.WriteLine($"A szamok lista {szamok.Count}db elemből áll");

            //Tömb elemeinek hozzáadása alistához
            int[] tomb = { 11, 12, 13, 14, 15, 16 };
            lista.AddRange(tomb);
            szamok.AddRange(tomb);

            //elem beszúrása a listába - Insert(hova, mit)
            //lista elemei 0-tól indexelődnek, 1. elem a 0. indexű

            lista.Insert(0, 999);
            szamok.Insert(2, 999);
            Console.WriteLine("a lista elemei: ");
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nA szamok lista elemei: ");
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write($"{szamok[i]} ");
            }

            //lista elemének eltávolítása - Remove(elem), RemoveAt(index)
            lista.Remove(999);
            szamok.RemoveAt(2);

            Console.WriteLine($"A lista elemei: ");
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nA szamok lista elemei: ");
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write($"{szamok[i]} ");
            }

            //tartalmazás vizsgálat - bool Contains(elem)
            Console.WriteLine(lista.Contains(999)?"999 benne van":"999 Nincs benne");
            Console.WriteLine(szamok.Contains(999)?"999 benne van":"999 Nincs benne");
            //Console.WriteLine(lista.Contains(Convert.ToInt32(Console.ReadLine())) ? "Benne van" : "Nincs benne");

            //lista kapacitása
            Console.WriteLine($"lista kapacitása: {lista.Capacity}");
            Console.WriteLine($"szamok lista kapacitása: {szamok.Capacity}");

            //sorbarendezés
            lista.Sort();
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //fordított rendezés - Reverse()
            lista.Reverse();
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //lista elemeinek összege
            int osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg += lista[i];
            }
            Console.WriteLine($"A lista elemeinek összege: {osszeg}");
            Console.WriteLine($"A lista elemeinek összege: {lista.Sum()}");
            Console.WriteLine($"A lista átlaga: {lista.Average():0.00}");
            Console.WriteLine($"A lista legkisebb eleme: {lista.Min()}");
            Console.WriteLine($"A lista legkisebb elemének helye: {lista.IndexOf(lista.Min())}");
            Console.WriteLine($"A lista legnagyobb eleme: {lista.Max()}");
            Console.WriteLine($"A lista legnagyobb elemének helye: {lista.IndexOf(lista.Max())}");

            //Lista átalakítása tömbbé
            int[] tomblista = new int[lista.Count];
            tomblista = lista.ToArray();
            Console.WriteLine("Tömblista elemei: ");
            for (int i = 0; i < tomblista.Length; i++)
            {
                Console.Write($"{tomblista[i]} ");
            }

            //lista törlése
            lista.Clear();
            Console.WriteLine($"A lista elemszáma: {lista.Count}, kapacitása: {lista.Capacity}");




        }
    }
}
