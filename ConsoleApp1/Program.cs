using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Változók: név, adattípus
            értékadás=
            adattipusok:
                Egyszerű típusok:
                    -byte (0-255)
             */

            

            byte a = 0, b = 0;
            //int egész számok
            int c = 0;
            a = 5;
            b = 249;
            c = a + b;
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"c értéke: {c}");

            //hatványozás: Math.Pow

            Console.WriteLine($"a^b= {Math.Pow(a,b)}");

            //float
            float d = (float)a / 12;
            double e =d *56;
            Console.WriteLine($"d= {d} e= {e}");
            //Kerekítés
            Console.WriteLine($"e kerekített értéke: {Math.Round(e, 2)}");
            Console.WriteLine($"e kerekített értéke: {e:0.00}");
            //Dátum
            DateTime szuldat; //2024.09.10 11:24:36
            //Szöveges ttípus
            string adat = "2024-09-10";
            //Szöveg típus feldarabolás = Split()
            //tömb: összetett adatszerkezet
            string[] tomb = adat.Split('-'); //2024|09|10
            //tömb szelet index:                0.  1. 2.
            Console.WriteLine($"{tomb[0]}.{tomb[1]}.{tomb[2]}");
            //Típuskonverzió
            szuldat = Convert.ToDateTime(adat);
            Console.WriteLine(szuldat);
            Console.WriteLine($"{szuldat.Year}.{szuldat.Month:00}.{szuldat.Day}");
            
           
            
            /*karakter típus: char
                1 karakter tárolására

            strint(szöveg) > ""; karakter >''
            */
            char betu = 'z';
            Console.WriteLine(betu);
            //logikai típus
            bool logikai = true;
            Console.WriteLine(logikai);
            logikai = a > b;
            Console.WriteLine(logikai);
            //összehasonlító operátorok
            //ÉS && VAGY || TAGADÁS !
            logikai = logikai || !logikai && a > b;
            Console.WriteLine(logikai);
            //konstans, állandó érték
            const int állandó = 9999;
            Console.WriteLine(c * állandó);
            //elolvasás képernyőről, azaz kommunikáció a felhasdználóval

            /*
            Console.Write("Kérek egy kicsi számot (byte): ");
            a = Convert.ToByte(Console.ReadLine());
            Console.Write("Kérek egy kicsi számot (int): ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Mi a neved? (sting): ");
            adat = Console.ReadLine();
            Console.Write("osztályazonosítód? (betű): ");
            betu = Convert.ToChar(Console.ReadLine());
            Console.Write("Hogy vagy? (true/false): ");
            logikai = Convert.ToBoolean(Console.ReadLine());
            */



            /*

            //elágazás: egyágú:(IF) 2ágú: (IF,ELSE), többágú/egymásba ágyazott: (IF,ELSE,IF), sokágú: (switch - case)
            if (logikai==true)
            {
                //igaz ág utasításai
                Console.WriteLine("Jól vagyok");
            }//if vége
            if (c*12>250)
            {
                Console.WriteLine("Igaz");
            } //If vége
            else
            {
                Console.WriteLine("Nem Igaz");
            }//Else vége
            //Ternáris operátor
            Console.WriteLine(c*12>2500?"igaz":"nem igaz");

            //Kérjünk be egy számot
            //Döntsd el hogy pozití, negatív vagy 0

            //Többágú/beágyatzott

            Console.WriteLine("Kérek egy számot: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c==0)
            {
                Console.WriteLine($"A Szám:{c}, 0");
            }
            else
            {
                if (c>0)
                {
                    Console.WriteLine($"A Szám: {c}, Pozitív");
                }
                else
                {
                    Console.WriteLine($"A Szám:{c}, Negatív");
                }
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("1. kör kerülete"); 
            Console.WriteLine("2. A nevem Nagy betűvel");
            Console.WriteLine("3. kiskorú/nagykorú");
            Console.WriteLine("4. Vége");
            a = Convert.ToByte(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Kör sugara: ");
                        e = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Kör Kerülete: {2*e*Math.PI}");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Mi a neved? ");
                        adat = Convert.ToString(Console.ReadLine());
                        Console.WriteLine($"NAgybetűvel: {adat.ToUpper()}");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Hány éves vagy? ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(c<18?"Kiskorú":"Nagykorú");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Vége");
                        Console.Beep();
                    }
                    break;
                default:
                    Console.WriteLine("Csak 1 és 4 közötti számot ír be!!!");
                    break;
            }


            */


            Console.Clear();
            int x = 0;

            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.WriteLine("5.");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Hogy hívnak? ");
                        string name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Írj be egy betűt: ");
                        string karakter = Convert.ToString(Console.ReadLine());
                        if (karakter == "a" || karakter == "A")
                        {
                            Console.WriteLine($"Üdv {name}");
                        }
                        else
                        {
                            if (karakter=="b"||karakter=="B")
                            {
                                Console.WriteLine("Milyen magas vagy, MÉTERBEN? ");
                                double magassag = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Hány kiló vagy? ");
                                double suly = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"A Te DMI értéked: {suly/Math.Pow(magassag,2)}");
                            }
                            else
                            {
                                Console.WriteLine("Kérlek írj a vagy A vagy b vagy B-t");
                            }
                        }
                    }
                    break;
                case 2:
                    {

                    }
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
