using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Structure_gyak_03._11
{
    class Program
    {
        //saját típus - struktúra létrehozása
        struct adat
        {
            public string varos, nev1, nev2;
            public double ferohely;
        }

        //összetett adatszerkezet - struktúra típusú lista
        static List<adat> adatok = new List<adat>();
        static void Beolvas()
        {
            Console.WriteLine("1.feladat:\tAz adatok beolvasása: ");
            StreamReader sr = new StreamReader("vb2018.txt", Encoding.Default);

            //első sor kezelése
            string elsoSor = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adat segedAdat = new adat();
                segedAdat.varos = egysor[0];
                segedAdat.nev1 = egysor[1];
                segedAdat.nev2 = egysor[2];
                segedAdat.ferohely = Convert.ToDouble(egysor[3]);
                adatok.Add(segedAdat);
            }
            sr.Close();
        }

        static void Kiir()
        {
            Console.WriteLine("2. feladat: \ta beolvasott adatok:");
            Console.WriteLine("\tvaros\tnév1\tnév2\tférőhely");
            for (int i = 0; i < adatok.Count; i++)
            {
                Console.WriteLine($"\t{adatok[i].varos} {adatok[i].nev1} {adatok[i].nev2} {adatok[i].ferohely}");
            }
        }

        static void Legkevesebb()
        {
            double min = adatok[0].ferohely;
            int mini = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].ferohely<min)
                {
                    min = adatok[i].ferohely;
                    mini = i;
                }
            }
            Console.WriteLine($"4. feladat: A legkevesebb férőhely: ");
            Console.WriteLine($"\tVáros: {adatok[mini].varos}");
            Console.WriteLine($"\tStadion neve: {adatok[mini].nev1}");
            Console.WriteLine($"\tFérőhely: {adatok[mini].ferohely}");
        }

        static double Atlag()
        {
            double osszes= 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                osszes += adatok[i].ferohely;
            }
            return osszes / adatok.Count;
        }

        static double Moszkva()
        {
            double osszes = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].varos=="Moszkva")
                {
                    osszes += adatok[i].ferohely;
                }
            }
            return osszes;
        }
        static void Main(string[] args)
        {
            Beolvas();
            Kiir();
            Console.WriteLine($"3. feladat:\n\tStadionok száma: {adatok.Count}");
            Legkevesebb();
            Console.WriteLine($"\n5. feladat: Átlagos férőhelyek száma: {Atlag():0.00}");
            Console.WriteLine($"\n6. feladat: A moszkvai stadionok összesen {Moszkva()} főt");
        }
    }
}
