using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Köridők_03._17_Otthon
{
    internal class Program
    {
        static List <adattipus> Lista=new List <adattipus>();
        struct adattipus
        {
            public string csapat, versenyzo, palya, korido;
            public int eletkor, kor;
        }

        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("autoverseny.csv", Encoding.Default);
            string firstLine = sr.ReadLine();
            int count = 0;
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adattipus adat = new adattipus();
                adat.csapat = egysor[0];
                adat.versenyzo = egysor[1];
                adat.eletkor = Convert.ToInt32(egysor[2]);
                adat.palya = egysor[3];
                adat.korido = (egysor[4]);
                adat.kor = Convert.ToInt32(egysor[5]);
                Lista.Add(adat);
                count++;
            }
            sr.Close();

            Console.WriteLine($"Az állományban {count} sor talélható");
        }

        static void Feladat4()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].versenyzo == "Fürge Ferenc" && Lista[i].palya == "Gran Prix Circuit")
                {
                    if (Convert.ToString(Lista[i].kor)=="3")
                    {
                        string [] ido = Lista[i].korido.Split(':');
                        List<int> Szamok = new List<int>(); 
                        foreach (var item in ido)
                        {
                            Szamok.Add(Convert.ToInt32(item));
                        }
                        int sum = Szamok[1]*60+Szamok[2];
                        Console.WriteLine($"{sum} másodperc");
                    }
                }
            }
        }

        static void Feladat6()
        {
            Console.WriteLine("Kérem egy versenyző nevét: ");
            string nev = Convert.ToString(Console.ReadLine());
            bool benne = false;
            List<int> Idok = new List<int>();
            int index = 0;
            int mini = 0;
            List<int> IdoLista = new List<int>();
            List<int> IndexLista = new List<int>();
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].versenyzo == nev)
                {
                    benne=true;
                    string[] egysor = Lista[i].korido.Split(':');
                    int sumsor= Convert.ToInt32(egysor[1]) * 60 + Convert.ToInt32(egysor[2]);
                    IdoLista.Add(sumsor);
                    IndexLista.Add(i);
                }
                else
                {
                    continue;
                }
                int min = IdoLista[0];
                for (int j = 0; j < IdoLista.Count; j++)
                {
                    if (IdoLista[j]<min)
                    {
                        min = IdoLista[j];
                        mini = j;
                    }
                }
                index = IndexLista[mini];
            }
            if (benne==true)
            {
                Console.WriteLine($"6.Feladat: {Lista[index].palya} {Lista[index].korido}");
            }
            else
            {
                Console.WriteLine("Nincs ilyen versenyző az állományban");
            }
        }   

        
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat4();
            Feladat6();
        }
    }
}
