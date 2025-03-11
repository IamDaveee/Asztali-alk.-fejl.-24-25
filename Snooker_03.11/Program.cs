using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snooker_03._11
{
    class Program
    {
        static List<adat> Lista = new List<adat>();
        struct adat
        {
            public int helyezes, nyeremeny;
            public string nev, orszag;
        }

        static void Feladat2()
        {
            StreamReader sr = new StreamReader("snooker.txt", Encoding.Default);
            string elsoSor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adat temp = new adat();
                temp.helyezes = Convert.ToInt32(egysor[0]);
                temp.nev = egysor[1];
                temp.orszag = egysor[2];
                temp.nyeremeny = Convert.ToInt32(egysor[3]);
                Lista.Add(temp);
            }
            sr.Close();
        }
        static void Feladat3()
        {
            Console.WriteLine($"A világranglistában {Lista.Count} versenyző szerepel");
        }
        static void Feladat4()
        {
            double sum = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                sum += Lista[i].nyeremeny;
            }
            Console.WriteLine($"A versenyzők átlagosan {sum/Lista.Count:0.00} nyereményre tettek szert");
        }

        static double Feladat5()
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].orszag=="Anglia")
                {
                    sum += Lista[i].nyeremeny;
                    count++;
                }
            }
            double avg =sum/ count;
            return avg;
        }

        static void Feladat6()
        {
            int max = 0;
            int maxi = 0;

            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].orszag=="Kína")
                {
                    if (Lista[i].nyeremeny>max)
                    {
                        max = Lista[i].nyeremeny;
                        maxi = i;
                    }
                }
            }
            Console.WriteLine($"A legjobban kereső Kínai versenyző: \n\tNév: {Lista[maxi].nev}\n\tHelyezés: {Lista[maxi].helyezes}\n\tNyeremény: {Lista[maxi].nyeremeny*380} Ft");
        }

        static bool Feladat7()
        {
            bool van = false;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].orszag=="Norvégia")
                {
                    van = true;
                }
            }
            return van;
        }

        static void Feladat8()
        {
            StreamWriter sw = new StreamWriter("anglia.txt");
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].orszag=="Anglia")
                {
                    sw.WriteLine($"{Lista[i].nev}\t{Lista[i].helyezes}\t{Lista[i].nyeremeny}");
                }
            }
            sw.Close();
        }
        
        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();
            Feladat4();
            Console.WriteLine($"Az Angliai versenyzők átlagosan {Feladat5():0.00} bevételre tettek szert");
            Feladat6();
            Console.WriteLine(Feladat7()?$"A top 100 ban van Norvég játékos":$"A top 100 ban nincs Norvég játékos");
            Feladat8();
        }
    }
}
