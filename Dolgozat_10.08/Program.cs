using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_10._08
{
    class Program
    {
        static void Main(string[] args)
        {

            
            const string hercegnő= "Jázmin";
            Console.WriteLine($"A hercegnő neve: {hercegnő}");
            Console.WriteLine("Választott herceg: ");
            string herceg = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{hercegnő}, a közelgő bálon {herceg} herceggel táncolna szívesen.");

            Console.WriteLine("1. herceg neve: ");
            string nev1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("1. herceg ereje: ");
            int ero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. herceg neve: ");
            string nev2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("2. herceg ereje: ");
            int ero2 = Convert.ToInt32(Console.ReadLine());
            if (ero1==ero2)
            {
                Console.WriteLine("A 2 herceg egyenlő erős.");
            }
            if (ero1>ero2)
            {
                Console.WriteLine($"{nev1} erősebb mint {nev2}");
            }
            else
            {
                Console.WriteLine($"{nev2} erősebb mint {nev1}");
            }

            

            


            double liszt = 25; //dkg
            double tojás = 2; //db
            double tej = 3; //dl
            double cukor = 2; //dkg

            double lisztKész =Math.Ceiling(liszt * 10 / 100);
            double tojásKész = Math.Ceiling(tojás*10/10);
            double tejKész = tej * 10 / 10;
            double cukorKész =Math.Ceiling( cukor * 10 / 100);

            Console.WriteLine($"A palacsintákhoz szükséges alapanyagok:\n \t{lisztKész}kg liszt\n\t{tojásKész} kosár tojás\n\t{tejKész} liter tej\n\t{cukorKész} kg cukor");

            Console.WriteLine("x koordináta: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y koordináta: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double d = Math.Sqrt(Math.Pow((x - 5), 2)+Math.Pow((y+5),2));

            if (d<55)
            {
                Console.WriteLine("A landolás biztonságos");
            }
            if (d>55)
            {
                Console.WriteLine("A landolás NEM biztonságos");
            }

            


            

            const double v = 100*3.6;
            Console.WriteLine("Mekkora utat kell megtennie? (m) ");
            double s = Convert.ToDouble(Console.ReadLine());
            double sVáltva = s / 1000;


            double t = s*v/10000;

            Console.WriteLine($"A meneküléshez {t} másodpercre van szükség.");


            

            bool logikai = true;

            Console.WriteLine("Kérem az 1. számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a 2. számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            logikai=!((szam1<=21)&&(szam1>=5)) || (szam2==1)&&!(szam1==szam2);
            if (logikai==true)
            {
                Console.WriteLine("Jaffar feleségül szeretné venni Jázmint");
            }
            if (logikai==false)
            {
                Console.WriteLine("Jaffar cselédet akar csinálni Jázminból");
            }
        }
    }
}
