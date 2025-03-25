using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyakorlás_03._25
{
    class Program
    {

        struct adat
        {
            public string nev, születési_dátum, nemzetiség, temp;
            public int rajtszam;
        }
        static List<adat> Lista = new List<adat>();
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("pilotak.csv",Encoding.Default);
            string elsosor = sr.ReadLine();
            int count = 0;
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adat valtozo = new adat();
                valtozo.nev = egysor[0];
                valtozo.születési_dátum = egysor[1];
                valtozo.nemzetiség = egysor[2];
                valtozo.temp = egysor[3];
                if (valtozo.temp=="")
                {
                    
                }
                else
                {
                    valtozo.rajtszam = Convert.ToInt32(valtozo.temp);
                }
                Lista.Add(valtozo);
                count++;
            }
            sr.Close();
            Console.WriteLine($"3. feladat: {count} sort olvastunk be");
            Console.WriteLine($"A Lista első sora: {Lista[0].nev}, Utolso: {Lista[Lista.Count-1].nev}");
        }

        static void Feladat5()
        {
            StreamWriter sw = new StreamWriter("szuletes.txt");

            for (int i = 0; i < Lista.Count; i++)
            {
                if (Convert.ToInt32(Lista[i].születési_dátum.Split('.')[0])<1901)
                {
                    Console.WriteLine($"{Lista[i].nev} ({Lista[i].születési_dátum})");
                    sw.WriteLine($"{Lista[i].nev} ({Lista[i].születési_dátum})");
                }
            }
            sw.Close();
        }

        static void Feladat6()
        {
            int min = Lista[0].rajtszam;
            int index = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].rajtszam<min)
                {
                    if (Lista[i].temp=="")
                    {

                    }
                    else
                    {
                        min = Lista[i].rajtszam;
                        index = i;
                    }
                }
            }
            Console.WriteLine($"{Lista[index].nemzetiség} a legkisebb rajtszámú versenyző");
        }

        static void Main(string[] args)
        {
            Beolvas();
            Feladat5();
            Feladat6();
        }
    }
}
