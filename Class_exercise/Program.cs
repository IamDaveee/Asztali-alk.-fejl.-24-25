using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_exercise
{
    class Program
    {
        class Szamol
        {
            int szam1, szam2;

            public Szamol(int szam1, int szam2)
            {
                this.szam1 = szam1;
                this.szam2 = szam2;
            }

            public int Elvegez()
            {
                Console.WriteLine("Kérek egy műveleti jelet: ");
                string jel = Convert.ToString(Console.ReadLine());
                int ertek = 0;
                switch (jel)
                {
                    case "-":
                        ertek = szam1 - szam2;
                        break;
                    case "+":
                        ertek = szam1 + szam2;
                        break;
                    case "*":
                        ertek = szam1 * szam2;
                        break;
                    case "/":
                        ertek = szam1 / szam2;
                        break;
                }
                return ertek;
            }


            public void Beker()
            {
                Console.WriteLine("Kérem az 1. számot: ");
                int szam1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem az 2. számot: ");
                int szam2 = Convert.ToInt32(Console.ReadLine());

                this.szam1 = szam1;
                this.szam2 = szam2;
            }
        }

        class Negyszog
        {
            public int a, b;

            public Negyszog(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public int Kerület()
            {
                int kerulet = 0;
                if (a==b)
                {
                    kerulet = 4 * a;
                }
                else
                {
                    kerulet = (a + b) * 2;
                }

                return kerulet;
            }

            public int Terület()
            {
                int terület = 0;
                if (a == b)
                {
                    terület = a * a;
                }
                else
                {
                    terület = a * b;
                }
                return terület;
            }

        }

        static void Main(string[] args)
        {
            Szamol sz = new Szamol(0,0);
            sz.Beker();
            Console.WriteLine(sz.Elvegez());

            Negyszog n = new Negyszog(5,10);
            bool negyszog = false;
            if (n.a==n.b)
            {
                negyszog = true;
            }
            Console.WriteLine(negyszog?$"A beírt számok alapján ez egy Négyzet":$"A beírt számok alapján ez egy Téglalap");

            Console.WriteLine($"A négyszög Kerülete: {n.Kerület()}");
            Console.WriteLine($"A négyszög Trülete: {n.Terület()}");
        }
    }
}
