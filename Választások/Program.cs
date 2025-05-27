using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Választások
{
    class Program
    {

        static List<Valasztasok> adatok = new List<Valasztasok>();

        static void Feladat3()
        {
            Console.WriteLine("3. feladat: ");
            Console.WriteLine("Adjon meg egy képviselő jelöltet: ");
            string nev = Convert.ToString(Console.ReadLine());
            string[] nevkulon = nev.Split(' ');
            /*
            bool benne = false;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (nevkulon[0]==adatok[i].vezeteknev && nevkulon[1]==adatok[i].utonev)
                {
                    benne = true;
                }
            }

            if (benne)
            {
                Console.WriteLine(string.Join(", ", adatok.Where(x => x.vezeteknev == nevkulon[0]).Select(y => y.kepviselo)));
            }
            else
            {
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban");
            }
            */

            if (adatok.Any(x=>x.teljesNev==nev))
            {
                Console.WriteLine($"{adatok.Where(x=>x.teljesNev==nev).Sum(y=>y.kepviselo)}");
            }
            else
            {
                Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban");
            }
        }

        static void Feladat5()
        {
            var GYEP = adatok.Where(x => x.part == "GYEP").Sum(y => y.kepviselo);
            var HEP = adatok.Where(x => x.part == "HEP").Sum(y => y.kepviselo);
            var TISZ = adatok.Where(x => x.part == "TISZ").Sum(y => y.kepviselo);
            var ZEP = adatok.Where(x => x.part == "ZEP").Sum(y => y.kepviselo);
            var FÜGG = adatok.Where(x => x.part == "-").Sum(y => y.kepviselo);
            double össz = adatok.Sum(x => x.kepviselo);

            Console.WriteLine();
            Console.WriteLine($"Gyümölcsevők Pártja = {GYEP/össz*100:0.00}%");
            Console.WriteLine($"Húsevők Pártja = {HEP/össz*100:0.00}%");
            Console.WriteLine($"Tejivók Szövetsége = {TISZ/össz*100:0.00}%");
            Console.WriteLine($"Zöldségevők Pártja = {ZEP/össz*100:0.00}%");
            Console.WriteLine($"Független Jelöltek = {FÜGG/össz*100:0.00}%");
        }

        static void Feladat6()
        {
            var legtobb = adatok.Select(x => x.kepviselo).Max();
            Console.WriteLine(string.Join(", ", adatok.Where(x => x.kepviselo == legtobb).Select(y => $"{y.teljesNev}({y.part})")));

        }

        static void Feladat7()
        {
            StreamWriter sw = new StreamWriter("statisztika.txt");
            for (int i = 1; i < 9; i++)
            {
                sw.WriteLine($"{i}.kerület - szavazatok száma {adatok.Where(x=>x.kerulet==i).Sum(y=>y.kepviselo)}");
            }
            sw.Close();
        }
        static void Main(string[] args)
        {
            File.ReadAllLines("szavazatok.txt").ToList().ForEach(x=>adatok.Add(new Valasztasok(x)));
            Console.WriteLine($"2. fealdat: A helyhatósági választáson {adatok.Count} képviselőjelölt indult.");
            Feladat3();
            Console.WriteLine($"A választáson {adatok.Sum(x => x.kepviselo)} állampolgá, a jogosultak {adatok.Sum(x => x.kepviselo)/12345.0*100:0.00}%");
            Feladat5();
            Feladat6();
            Feladat7();
        }
    }
}
