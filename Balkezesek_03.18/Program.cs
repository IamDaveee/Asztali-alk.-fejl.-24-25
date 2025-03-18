using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Balkezesek_03._18
{
    class Program
    {
        static int evszam;
        static List<adat> Lista = new List<adat>();
        struct adat
        {
            public string nev, elso, utolso;
            public int suly, magassag;
        }

        static void Feladat2()
        {
            StreamReader sr = new StreamReader("balkezesek.csv", Encoding.Default);
            string elsosor = sr.ReadLine();
            int count = 0;
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adat temp = new adat();
                temp.nev = egysor[0];
                temp.elso = egysor[1];
                temp.utolso = egysor[2];
                temp.suly = Convert.ToInt32(egysor[3]);
                temp.magassag = Convert.ToInt32(egysor[4]);
                Lista.Add(temp);
                count++;
            }
            sr.Close();
            Console.WriteLine($"3. feladat: {count}");
        }

        static void Feladat4()
        {
            List<string> Nevek = new List<string>();
            List<double> Magassagok = new List<double>();
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Convert.ToInt32(Lista[i].utolso.Split('-')[0])==1999)
                {
                    Nevek.Add(Lista[i].nev);
                    Magassagok.Add(Math.Round(Lista[i].magassag*2.54,1));
                }
            }
            Console.WriteLine("4. feladat: ");
            for (int i = 0; i < Nevek.Count; i++)
            {
                Console.WriteLine($"\t{Nevek[i]}, {Magassagok[i]} cm");
            }
        }

        static void Feladat5()
        {
            Console.WriteLine("Kérek egy 1990 és 1999 közötti évszámot! ");
            evszam = Convert.ToInt32(Console.ReadLine());
            while (evszam < 1990 || evszam > 1999)
            {
                Console.WriteLine("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot! ");
                evszam = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Feladat6()
        {
            List<double> Sulyok = new List<double>();

            for (int i = 0; i < Lista.Count; i++)
            {
                if (Convert.ToInt32(Lista[i].utolso.Split('-')[0]) == evszam)
                {
                    Sulyok.Add(Lista[i].suly);
                }
            }
            Console.WriteLine($"6. feladat: {Math.Round(Sulyok.Average(),2)}");
        }

        static void Main(string[] args)
        {
            Feladat2();
            Feladat4();
            Feladat5();
            Feladat6();
        }
    }
}
