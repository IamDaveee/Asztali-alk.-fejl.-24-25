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

            Console.WriteLine($"a^b= {Math.Pow(a, b)}");

            //float
            float d = (float)a / 12;
            double e = d * 56;
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


            /*

            int x = 0;

            Console.WriteLine("1. Feladat");
            Console.WriteLine("2. Feladat");
            Console.WriteLine("3. Feladat");
            Console.WriteLine("4. Feladat");
            Console.WriteLine("5. Feladat");
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
                            if (karakter == "b" || karakter == "B")
                            {
                                Console.WriteLine("Milyen magas vagy, MÉTERBEN? ");
                                double magassag = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Hány kiló vagy? ");
                                double suly = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"A Te DMI értéked: {suly / Math.Pow(magassag, 2)}");
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
                        Console.WriteLine("Írd be az első számot: ");
                        int elsoSzam = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Írd be a második számot: ");
                        int masodikSzam = Convert.ToInt32(Console.ReadLine());
                        if (elsoSzam > masodikSzam)
                        {
                            Console.WriteLine($"Az első bevitt szám: {elsoSzam}, a második: {masodikSzam}, a helyes sorrend: {masodikSzam},{elsoSzam}");
                        }
                        else
                        {
                            Console.WriteLine($"Az első bevitt szám: {elsoSzam}, a második: {masodikSzam}, a helyes sorrend: {elsoSzam},{masodikSzam}");
                        }
                        
                    }
                    break;
                default:
                    break;

                case 3:
                    {
                        Console.WriteLine("Kérem az 1. számot: ");
                        int elso = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Kérem az 2. számot: ");
                        int masodik = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Kérem az 3. számot: ");
                        int harmadik = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Kérem az 4. számot: ");
                        int negyedik = Convert.ToInt32(Console.ReadLine());

                        int elsoMin = Math.Min(elso, masodik);
                        int elsoMax = Math.Max(elso, masodik);

                        int masodikMin = Math.Min(harmadik, negyedik);
                        int masodikMax = Math.Max(harmadik, negyedik);

                        Console.WriteLine($"A számok sorrendben: {elso},{masodik},{harmadik},{negyedik}. Az első 2 szám minimuma: {elsoMin}, maximumuk: {elsoMax}, és ennek a kettőneka különbsége: {elsoMax-elsoMin}, a Második 2 szám minimuma: {masodikMin}, maximuma: {masodikMax}, és ennek a kettőnek a különbsége: {masodikMax-masodikMin}");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Hány fokos a víz? ");
                        double homerseklet = Convert.ToDouble(Console.ReadLine());
                        

                        if (homerseklet>100)
                        {
                            Console.WriteLine("A víz halmazállapota: Gőz");
                        }
                        if (homerseklet<0)
                        {
                            Console.WriteLine("A víz halmazállapota: Jég");
                        }
                        if (homerseklet>0 && homerseklet<100)
                        {
                            Console.WriteLine("A víz halmazállapota: Folyékony");
                        }
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Mekkora a terület Szélessége, méterben: ");
                        double szélesség = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Mekkora a terület Magassága, méterben: ");
                        double magasság = Convert.ToDouble(Console.ReadLine());

                        double négyzetméter = szélesség * magasság;
                        double négyzetcm = négyzetméter * 10000;
                        double csempeterület = 20 * 20;
                        double csempedarab =Math.Ceiling(négyzetcm / csempeterület);

                        Console.WriteLine($"{csempedarab}-ra lesz szükség a terület lefedéséhez");
                    }
                    break;
            }


            */


            //Console.ReadKey();


            Console.Clear();
            int y = 0;
            Console.WriteLine("1. Feladat");
            Console.WriteLine("2. Feladat");
            Console.WriteLine("3. Feladat");
            Console.WriteLine("4. Feladat");
            Console.WriteLine("5. Feladat");
            Console.WriteLine("6. Feladat");
            Console.WriteLine("7. Feladat");
            Console.WriteLine("8. Feladat");
            Console.WriteLine("9. Feladat");
            Console.WriteLine("10. Feladat");
            Console.WriteLine("11. Feladat");
            Console.WriteLine("12. Feladat");
            Console.WriteLine("13. Feladat");
            Console.WriteLine("14. Feladat");

            y = Convert.ToInt32(Console.ReadLine());
            switch (y)
            {
                case 1:
                    {
                        Console.WriteLine("Kérek egy számot: ");
                        int szam = Convert.ToInt32(Console.ReadLine());
                        if (szam==0)
                        {
                            Console.WriteLine("A szám 0");
                        }
                        if (szam<0)
                        {
                            Console.WriteLine("A szám negatív");
                        }
                        if (szam>0)
                        {
                            Console.WriteLine("A szám pozitív");
                        }
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Írd be a háromszög 1. oldalát: ");
                        double aoldal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Írd be a háromszög 2. oldalát: ");
                        double boldal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Írd be a háromszög 3. oldalát: ");
                        double coldal = Convert.ToDouble(Console.ReadLine());
                        double apower = Math.Pow(aoldal, 2);
                        double cpower = Math.Pow(coldal, 2);
                        double bpower = Math.Pow(boldal, 2);

                        if (apower+bpower==cpower)
                        {
                            Console.WriteLine("A Háromszög derékszögű");
                        }
                        else
                        {
                            Console.WriteLine("A Háromszög NEM derékszögű");
                        }
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Írjd be az 1. számot: ");
                        double szam1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Írjd be az 2. számot: ");
                        double szam2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"A 2 szám Összege: {szam1+szam2}, Különbségük: {szam1-szam2}, Átlaguk: {(szam1+szam2)/2}, Szorzatuk: {szam1*szam2}, Hányadosuk: {szam1/szam2}");
                    }
                    break;

                case 4:
                    {
                        bool igaz = true;
                        Console.WriteLine(igaz);
                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Kérek egy számot: ");
                        int szam = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Kérem az 1. számot: ");
                        double oldal1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kérem az 2. számot: ");
                        double oldal2 = Convert.ToDouble(Console.ReadLine());
                        if (szam>-20 && szam <40)
                        {
                            double kerület = (oldal1 + oldal2) * 2;
                            Console.WriteLine($"A Téglalap kerülete: {kerület}");
                        }
                        else
                        {
                            double terület = oldal1 * oldal2;
                            Console.WriteLine($"A Téglalap területe: {terület}");
                        }
                    }
                    break;

                case 6:
                    {
                        Console.WriteLine("Kérem az 1. számot: ");
                        double szam1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kérem az 2. számot: ");
                        double szam2 = Convert.ToDouble(Console.ReadLine());

                        if (szam1==szam2)
                        {
                            Console.WriteLine("A 2 szám egyenlő");
                        }
                        if (szam1>szam2)
                        {
                            Console.WriteLine($"Az 1. szám osztva 2-vel: {szam1/2}, a második szám osztva 3-al: {szam2/3}");
                        }
                        else
                        {
                            Console.WriteLine($"Az 1. szám osztva 3-vel: {szam1 / 3}, a második szám osztva 2-al: {szam2/2}");
                        }
                    }
                    break;

                case 7:
                    {
                        Console.WriteLine("Írj be egy egész számot: ");
                        int szam = Convert.ToInt32(Console.ReadLine());
                        if (szam % 2 == 0)
                        {
                            Console.WriteLine("A szám páros");
                        }
                        else
                        {
                            Console.WriteLine("A szám páratlan");
                        }
                    }
                    break;

                case 8:
                    {
                        Console.WriteLine("Kérem az 1. számot");
                        double szam1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kérem az 2. számot");
                        double szam2 = Convert.ToDouble(Console.ReadLine());

                        if (szam1>szam2)
                        {
                            Console.WriteLine(szam1);
                        }
                        else
                        {
                            Console.WriteLine(szam2);
                        }
                    }
                    break;

                case 9:
                    {
                        Console.WriteLine("Kérem az 1. számot");
                        double szam1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kérem az 2. számot");
                        double szam2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kérem az 3. számot");
                        double szam3 = Convert.ToDouble(Console.ReadLine());

                        if (szam1 > szam2 && szam1>szam3)
                        {
                            Console.WriteLine(szam1);
                        }
                        if (szam2 > szam1 && szam2 >szam3)
                        {
                            Console.WriteLine(szam2);
                        }
                        if (szam3 > szam1 && szam3>szam2)
                        {
                            Console.WriteLine(szam3);
                        }
                    }
                    break;

                case 10:
                    {

                    }
                    break;
            }


            Console.ReadKey();
        }
    }
}
