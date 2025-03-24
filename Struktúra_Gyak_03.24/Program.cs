using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktúra_Gyak_03._24
{
    internal class Program
    {

        struct adat
        {
            public string nev, osztaly;
            public int elso, utolso, ora;
        }

        static List <adat> Lista = new List <adat>();

        static void Beolvas()
        {
            StreamReader sr = new StreamReader("szeptember.csv",Encoding.Default);
            string elsosor=sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adat valtozo = new adat();
                valtozo.nev = egysor[0];
                valtozo.osztaly = egysor[1];
                valtozo.elso=Convert.ToInt32(egysor[2]);
                valtozo.utolso=Convert.ToInt32(egysor[3]);
                valtozo.ora=Convert.ToInt32(egysor[4]);
                Lista.Add(valtozo);
            }
            sr.Close();
        }

        static void Feladat2()
        {

            int sum = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                sum += Lista[i].ora;
            }
            Console.WriteLine($"Összes mulasztott órák száma: {sum}");
        }

        static void Feladat()
        {
            Console.WriteLine("Kérek egy számot 1-30 között: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek egy nevet: ");
            string nev=Convert.ToString(Console.ReadLine());
            bool hianyzott=false;

            for (int i = 0; i < Lista.Count; i++)
            {
                if (nev == Lista[i].nev)
                {
                    hianyzott = true;
                }
            }

            Console.WriteLine(hianyzott?"Hiányzott":"Nem hiányzott");

            List <string> Nevek = new List <string>();
            List <string> Osztalyok = new List <string>();

            for (int i = 0;i < Lista.Count;i++)
            {
                if (szam == Lista[i].elso)
                {
                    Nevek.Add(Lista[i].nev);
                    Osztalyok.Add(Lista[i].osztaly);
                }
            }

            /*
            for (int i = 0; i < Nevek.Count; i++)
            {
                Console.WriteLine(Nevek[i]);
            }
            foreach (var item in Nevek)
            {
                Console.WriteLine(item);
            }
            */
            
            
            for (int i = 0; i < Nevek.Count; i++)
            {
                Console.WriteLine($"{Nevek[i]}, {Osztalyok[i]}");
            }
        }

       

       

        static void Feladat6()
        {
            List <string> osztalyok= new List <string>();
            List <int> Orak= new List <int>();

            for (int i = 0; i < Lista.Count; i++)
            {
                if (osztalyok.Contains(Lista[i].osztaly))
                {
                    continue;
                }
                else
                {
                    osztalyok.Add(Lista[i].osztaly);
                }
            }

            int sum;
            for (int i = 0; i < osztalyok.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < Lista.Count; j++)
                {
                    if (osztalyok[i] == Lista[j].osztaly)
                    {
                        sum += Lista[j].ora;
                    }
                }
                Orak.Add(sum);
            }

            StreamWriter sw = new StreamWriter("osszesites.csv");
            for (int i = 0; i < osztalyok.Count; i++)
            {
                sw.WriteLine($"{osztalyok[i]};{Orak[i]}");
            }
            sw.Close();
        }



        


        static void Main(string[] args)
        {
            Beolvas();
            Feladat2();
            Feladat();
            Feladat6();
        }
    }
}
