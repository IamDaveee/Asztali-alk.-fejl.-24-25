using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljarasok_Fv_Gyak_hosszu
{
    class Program
    {
        static List<int> fibo =new List<int>{};
        static Random rnd = new Random();
        static string szoveg = Szoveg();
        static bool Oszthato()
        {
            Console.WriteLine("Kérem az 1.számot");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a 2. számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            bool oszthato = false;
            if (szam1%szam2==0)
            {
                oszthato = true;
            }
            return oszthato;
        }

        static void Szamtani()
        {
            Console.WriteLine("Mi legyen a számtani sorozat első eleme? ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Menny legyen a számtani sorozat differenciája? ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hány elemből álljon a számtani sor? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            List<int> szamtani = new List<int> {};
            szamtani.Add(a1);
            for (int i = 0; i < n-1; i++)
            {
                szamtani.Add(szamtani[i]+d);
            }
            Console.WriteLine("A számtani sorozat: ");
            foreach (var item in szamtani)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            
        }

        static void Mertani()
        {
            Console.WriteLine("Mi legyena mértani sorozat első eleme? ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mennyi legyen a hányados? ");
            int q = Convert.ToInt32(Console.ReadLine());
            int n = 15;
            List<int> mertani = new List<int> { };
            mertani.Add(a1);
            for (int i = 0; i < n-1; i++)
            {
                mertani.Add(mertani[i]*q);
            }
            foreach (var item in mertani)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Fibo()
        {
            fibo.Add(0);
            fibo.Add(1);
            fibo.Add(2);
            for (int i = 2; i < 19; i++)
            {
                fibo.Add(fibo[i] + fibo[i - 1]);
            }
            foreach (var item in fibo)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Feltolt()
        {
            for (int i = 0; i < 20; i++)
            {
                fibo.Add(rnd.Next(10,100));
            }
            foreach (var item in fibo)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static int Darab()
        {
            double avg = Math.Round(fibo.Average(),0);
            int count = 0;
            foreach (var item in fibo)
            {
                if (item>avg)
                {
                    count++;
                }
            }
            return count;
        }

        static void Legek()
        {
            int max = fibo.Max();
            int min = fibo.Min();
            int maxIndex = fibo.IndexOf(max);
            int minIndex = fibo.IndexOf(min);

            Console.WriteLine($"A legnagyobb elem: {max}, helye: {maxIndex+1}, a legkisebb elem: {min}, helye: {minIndex+1}. A legnagyobb elem szomszédos elemei: {fibo[maxIndex-1]}, {fibo[maxIndex+1]}. A legkisebb elem szomszédos elemei: {fibo[minIndex+1]}");
        }

        static void Barkochba(){
            int random = rnd.Next(1,1001);
            int tipp;
            Console.WriteLine("Gondoltam egy számra 1-1000 között. Találd ki ;)");
            int count = 0;
            do
            {
                Console.WriteLine("Tippelj egyet: ");
                tipp = Convert.ToInt32(Console.ReadLine());
                if (tipp==random)
                {
                    Console.WriteLine($"Eltaláltad, ügyes vagy!!\n Tippjeid száma: {count+1}");
                    break;
                }
                if (tipp>random)
                {
                    Console.WriteLine($"A gondolt szám kisebb mint {tipp}");
                }
                else
                {
                    Console.WriteLine($"A gondolt szám nagyobb mint {tipp}");
                }
                count++;
            } while (tipp!=random);
        }

        static string Szoveg()
        {
            Console.WriteLine("Kérek egy szöveget: ");
            string szoveg = Convert.ToString(Console.ReadLine());
            int hossz = szoveg.Length;
            for (int i = hossz; i > 0; i--)
            {
                Console.Write(szoveg[i-1]);
            }
            Console.WriteLine();
            return szoveg;
        }

        static void Szóköz()
        {
            int count=0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Az előbb megadott szövegben {count} db szóköz van");
        }

        static void Hatvany()
        {
            Console.WriteLine("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{Math.Pow(szam,i)} ");
            }
            Console.WriteLine();
        }

        static void LNKO()
        {
            Console.WriteLine("Kérem az 1.számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az 2.számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            int nagyobb;
            int legnagyobb=0;
            if (szam1==szam2)
            {
                Console.WriteLine("A 2 szám egyenlő");
            }
            if (szam1>szam2)
            {
                nagyobb = szam1;
            }
            else
            {
                nagyobb = szam2;
            }

            for (int i = 1; i < nagyobb; i++)
            {
                if (szam1%i==0 &&szam2%i==0)
                {
                    legnagyobb = i;
                }
            }
            if (legnagyobb==0)
            {
                Console.WriteLine("A 2 számnak nincs közös osztólya.");
            }
            else
            {
                Console.WriteLine($"A 2 szám legnagyobb közös osztólya: {legnagyobb}");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Oszthato()?"Az 1. szám osztható a 2.al":"Az 1. szám nem osztható a 2.al");
            //Szamtani();
            //Mertani();
            //Fibo();
            //Feltolt();
            //Console.WriteLine($"{Darab()} db olyan szám van a listában, amely nagyobb az átlagnál.");
            //Legek();
            //Barkochba();
            //Szóköz();
            //Hatvany();
            //LNKO();
        }
    }
}
