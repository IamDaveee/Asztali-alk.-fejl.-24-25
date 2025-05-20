using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Helsinki
{
    class Program
    {
        static List<Olimpia> adatok = new List<Olimpia>();
        static void Feladat2()
        {
            StreamReader sr = new StreamReader("helsinki.txt");
            while (!sr.EndOfStream)
            {
                adatok.Add(new Olimpia(sr.ReadLine()));
            }
            sr.Close();
        }
        static void Feladat4()
        {
            int arany = 0, ezust = 0, bronz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                switch (adatok[i].helyezes)
                {
                    case 1:  arany++;
                        break;
                    case 2: ezust++;
                        break;
                    case 3: bronz++;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"Arany: {arany}\nEzüst: {ezust}\nBronz. {bronz}\nÖsszesen: {arany+ezust+bronz}");
            Console.WriteLine($"Arany: {adatok.Count(x=>x.helyezes==1)}");
            Console.WriteLine($"Ezüst: {adatok.Where(x=>x.helyezes==2).Count()}");
            Console.WriteLine($"Bronz: {adatok.Count(x=>x.helyezes==3)}");
            Console.WriteLine($"Összes: {adatok.Count(x=>x.helyezes<4)}");
        }

        static void Feladat5()
        {
            int ossz = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                ossz += adatok[i].pontszam;
            }
            Console.WriteLine($"Összpontszám. {ossz}");

            Console.WriteLine($"Összpontszám: {adatok.Sum(x=>x.pontszam)}");
        }

        static void Feladat6()
        {
            int uszas = 0, torna = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].sportag=="uszas" && adatok[i].helyezes<4)
                {
                    uszas++;
                }
                if (adatok[i].sportag=="torna" && adatok[i].helyezes<4)
                {
                    torna++;
                }
            }
            if (torna==uszas)
            {
                Console.WriteLine("Az érmek száma egyenlő");
            }
            else
            {
                if (torna>uszas)
                {
                    Console.WriteLine("Torna sportágban volt több érem");
                }
                else
                {
                    Console.WriteLine("Úszás sportágban volt több érem");
                }
            }

            var uszasDb = adatok.Where(x => x.helyezes <= 3 && x.sportag == "uszas").Count();
            var tornaDb = adatok.Where(x => x.helyezes <4 && x.sportag == "torna").Count();
            Console.WriteLine(uszasDb==tornaDb?"Egyenlő":(uszasDb>tornaDb? "Úszásban szereztek több érmet" : "Tornában szereztek több érmet"));
        }

        static void Feladat7()
        {
            StreamWriter sw = new StreamWriter("helsinki2.txt");
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].sportag=="kajakkenu")
                {
                    sw.WriteLine($"{adatok[i].helyezes} {adatok[i].sportolokSzama} {adatok[i].pontszam} kajak-kenu {adatok[i].versenyszam}");
                }
                else
                {
                    sw.WriteLine($"{adatok[i].helyezes} {adatok[i].sportolokSzama} {adatok[i].pontszam} {adatok[i].sportag} {adatok[i].versenyszam}");
                }
            }
            sw.Close();
        }


        static void Main(string[] args)
        {
            //File.ReadAllLines("helsinki.txt").ToList().ForEach(x => adatok.Add(new Olimpia(x)));
            Feladat2();
            Console.WriteLine($"Pontszerző helyezések száma: {adatok.Count()}");
            //Kiir() metódus meghívása objektumokra
            adatok[0].Kiir();//fájl 1. sorának kiirása
            //Erem() fv. meghívása a fájl utolsó sorára
            Console.WriteLine(adatok[adatok.Count-1].Erem(adatok[adatok.Count-1].helyezes));

            //minden sorra ki akarom értékelni a fv-t
            for (int i = 0; i < adatok.Count; i++)
            {
                Console.WriteLine(adatok[i].helyezes);
            }

            //minden sorban Kiir()
            foreach (var item in adatok)
            {
                item.Kiir();
            }
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            var legtobb = adatok.OrderBy(x => x.sportolokSzama).Last();
            Console.WriteLine($"Helyezés: {legtobb.helyezes} sportág: {legtobb.sportag} Versenyszám: {legtobb.versenyszam} Sportolók száma: {legtobb.sportolokSzama}");
            var legtobb2 = adatok.OrderByDescending(x => x.sportolokSzama).First();
            Console.WriteLine($"H: {legtobb2.helyezes}");
        }
    }
}
