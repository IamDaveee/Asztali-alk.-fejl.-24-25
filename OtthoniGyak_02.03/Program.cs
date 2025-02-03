using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtthoniGyak_02._03
{

    /*
      
    Függvények

    Készítsen olyan függvényt, amely

    1.) egy téglalap két oldalának ismeretében kiszámítja a     téglalap területét!
    2.) meghatározza, hogy egy 15 elemu tömbben/listában van-e     hárommal osztható, de öttel nem osztható szám.
    3.) meghatározza, hogy egy 5 elemu, karaktereket     tartalmazó tömbben hányszor szerepel az 'a' betu
    4.) meghatározza egy tömb/lista elemeinek átlagát
    5.) meghatározza a tömb/lista legkisebb elemének sorszámát
    6.) megkeresi a 52-es számot a sorozatban
    7.) amely kiszámolja egy négyzet oldalának ismeretében a     kerületét
    8.) amely meghatározza, hány darab páros szám van a tömbben/listában



    Írjon eljárást, amely feltölt egy 20 elemu két dimenziós tömböt véletlen, 100 és 250 közötti számokkal, majd kiírja oket mátrixos formában szóközzel elválasztva!
    Függvény segítségével határozza meg:
    - a mátrix elemeinek átlagát
    - a mátrix legnagyobb elemét
    */
    internal class Program
    {
        /*
        static int[] tomb = new int[25];
        static Random rnd=new Random();

        static void Feladat1()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(100,1000);
                Console.Write($"{tomb[i]} ");
            }
            Console.WriteLine();
        }

        static void Feladat2()
        {
            int sum = tomb.Sum();
            double avg=tomb.Average();
            Console.WriteLine($"A tömb összege: {sum}, Átlaga: {avg}");
        }

        static void Feladat3()
        {
            int max = tomb.Max();
            int index = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]==max)
                {
                    index = i;
                }
            }
            Console.WriteLine($"A legnagyobb elem: {max}, Helye: {index}");
        }

        static void Feladat4()
        {
            Console.WriteLine("Kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam==0)
            {
                Console.WriteLine("A szám egyenlő 0-val");
            }
            if (szam>0)
            {
                Console.WriteLine("A szám nagyobb mint 0");
            }
            else
            {
                Console.WriteLine("A szám kisebb mint 0");
            }
        }

        static string Feladaat()
        {
            Console.WriteLine("Kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            string alma = "a";

            if (szam == 0)
            {
                alma = "Nulla";
            }
            if (szam > 0)
            {
                alma = "Nagyobb";
            }
            else
            {
                alma = "Kisebb";
            }

            return alma;
        }
        static void Feladat5()
        {
            Console.WriteLine("Kérem az 1. számot");
            double szam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem az 2. számot");
            double szam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem az 3. számot");
            double szam3 = Convert.ToDouble(Console.ReadLine());

            if (szam2-szam1==szam3-szam2)
            {
                Console.WriteLine("Ez egy SzT. sorozat");
            }
            else
            {
                Console.WriteLine("Nem SzT. Sorozat");
            }
            double avg = Math.Round((szam1 + szam2 + szam3) / 3, 2);
           //Console.WriteLine($"A 3 szám átlaga: {Math.Round(avg,5)}");
           Console.WriteLine(avg);
        }

        */

        static double Teglalap()
        {
            Console.WriteLine("Kérem a téglalap egyik oldalát: ");
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kérem a téglalap másik oldalát: ");
            double b=Convert.ToDouble(Console.ReadLine());

            double T = a * b;
            return T;
        }

        static bool Feladat2()
        {
            List<int> lista = new List<int>();
            List<int> lista2 = new List<int>();
            Random rnd= new Random();
            bool van = false;
            int index = 0;

            for (int i = 0; i < 15; i++)
            {
                lista.Add(rnd.Next(10,100));
                if (lista[i]%3==0 && lista[i]%5!=0)
                {
                    van = true;
                    lista2.Add(lista[i]);
                }
            }
            return van;
        }
       
        

        static void Main(string[] args)
        {
            /*
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            //Console.WriteLine($"Az általad választott szám: {Feladaat()} mint 0");
            Feladat5();
            */

            Console.WriteLine($"A téglalap területe: {Teglalap()}");

            Console.WriteLine($"fdabweuidbwi  {Feladat2()}");
        }
    }
}
