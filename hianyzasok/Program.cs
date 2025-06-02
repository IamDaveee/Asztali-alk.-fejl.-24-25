using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hianyzasok
{
    internal class Program
    {
        static List<Hianyzas> adatok = new List<Hianyzas>();
        static string nevBekert;
        static int nap;

        static void Feladat2()
        {
            int sum = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                sum += adatok[i].orak;
            }
            Console.WriteLine($"{sum}");
        }

        static void Feladat3()
        {
            Console.WriteLine("Kérek egy napot 1 és 30 között: ");
            nap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy tanuló nevét: ");
            nevBekert = Convert.ToString(Console.ReadLine());
        }

        static void Feladat4()
        {
            bool hianyzott = false;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].nev == nevBekert)
                {
                    hianyzott = true;
                }
            }

            /*if (hianyzott==true)
            {
                Console.WriteLine("A tanuló hiányzott szeptemberben");
            }
            else{
                Console.WriteLine("tanuló nem hiányzott szeptemberben");
            }*/

            Console.WriteLine(hianyzott ? "A tanuló hiányzott szeptemberben" : "tanuló nem hiányzott szeptemberben");
            //var valami = adatok.Any(x=>x.nev==nevBekert);
            //Console.WriteLine(valami?"A tanuló hiányzott szeptemberben" : "tanuló nem hiányzott szeptemberben");
        }

        static void Feladat5()
        {
            Console.WriteLine(adatok.Any(x => x.elso == nap) ? $"{string.Join("\n",adatok.Where(x => x.elso == nap).Select(y => $"{y.nev} {y.osztaly}"))}" : $"Nem volt hiányzó");
        }



        static void Main(string[] args)
        {
            File.ReadAllLines("szeptember.csv", Encoding.Default).Skip(1).ToList().ForEach(x => adatok.Add(new Hianyzas(x)));
            Feladat2();
            //Console.WriteLine(adatok.Select(x=>x.orak).Sum());
            Feladat3();
            Feladat4();
            Feladat5();
            File.WriteAllLines("osszesites.csv", adatok.GroupBy(x => x.osztaly).OrderBy(y => y.Key).Select(y => $"{y.Key};{y.Sum(x => x.orak)}").ToList(), Encoding.Default);
        }
    }
}
