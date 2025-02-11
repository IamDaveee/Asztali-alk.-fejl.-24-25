using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //fájlkezeléshez

namespace Filekezelés
{
    class Program
    {
        //struktúra neve=típus mező=tulajdonság hozzáférés,láthatósági szint (public, private)
        struct adattipus
        {
            //mezo: hozzáférési szint adattipus meőnév
            public string italNeve;
            public int egysegar;
            public int eladottLiter;
        }

        

        static void BeolvasásStruktúraTipusúListába()
        {
            List<adattipus> Lista = new List<adattipus>();
            int count = 0;
            StreamReader sr = new StreamReader("ital.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                adattipus valtozo = new adattipus();
                valtozo.italNeve = egysor[0];
                valtozo.egysegar = Convert.ToInt32(egysor[1]);
                valtozo.eladottLiter = Convert.ToInt32(egysor[2]);
                Lista.Add(valtozo);
                count++;
            }
            sr.Close();
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine($"{Lista[i].italNeve} {Lista[i].egysegar} Ft/cl {Lista[i].eladottLiter} l");
            }

            Console.WriteLine($"{count} féle ital hapható");
           
            
            StreamWriter sw = new StreamWriter("megoldas.txt");
            
            
            sw.WriteLine($"{count} féle ital hapható");
            sw.WriteLine();



            //italonkénti bevétel: egységár*eladott liter
            int osszbevetel = 0;
            
            for (int i = 0; i < Lista.Count; i++)
            {
                osszbevetel += Lista[i].egysegar * Lista[i].eladottLiter*100;
                Console.WriteLine($"Ital neve: {Lista[i].italNeve}, bevétel: {Lista[i].egysegar*Lista[i].eladottLiter*100}");
                
            }
            Console.WriteLine($"Összbevétel: {osszbevetel}");
            sw.WriteLine($"Összbevétel: {osszbevetel}");
            sw.WriteLine();

            //legdrágább ital - maxkiválasztás egységár
            int legdragabb = Lista[0].egysegar;
            int lindex = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].egysegar>legdragabb)
                {
                    legdragabb = Lista[i].egysegar;
                    lindex = i;
                }
            }
            Console.WriteLine($"A legdrágább ital: {Lista[lindex].italNeve}");
            sw.WriteLine($"A legdrágább ital: {Lista[lindex].italNeve}");
            sw.WriteLine();

            //legnépszerűbb-melyikből fogyott a legtöbb
            int legtobb = Lista[0].eladottLiter;
            lindex = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].eladottLiter>legtobb)
                {
                    legtobb = Lista[i].eladottLiter;
                    lindex = i;
                }
            }
            Console.WriteLine($"A legtöbbet eladott ital: {Lista[lindex].italNeve}");
            sw.WriteLine($"A legtöbbet eladott ital: {Lista[lindex].italNeve}");
            sw.WriteLine();

            //Összes liter
            int osszLiter = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                osszLiter += Lista[i].eladottLiter;
            }
            Console.WriteLine($"Az összes eladott liter: {osszLiter}");
            sw.WriteLine($"Az összes eladott liter: {osszLiter}");
            sw.WriteLine();

            sw.Close();
        }
        static void BeolvasásStrukturaTipusTombbe()
        {
            //egy struktúra típusú tömb deklarálása
            adattipus[] tomb = new adattipus[10];
            int index = 0;
            StreamReader sr = new StreamReader("ital.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                tomb[index].italNeve = egysor[0];
                tomb[index].egysegar = Convert.ToInt32(egysor[1]);
                tomb[index].eladottLiter = Convert.ToInt32(egysor[2]);
                index++;
            }
            sr.Close();
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{tomb[i].italNeve} {tomb[i].egysegar} Ft/cl {tomb[i].eladottLiter} l");
            }
        }
        static void beolvasasListaba()
        {
            List<string> italNeve = new List<string>();
            List<int> egysegar = new List<int>();
            List<int> egyeladottLiter= new List<int>();
            StreamReader sr = new StreamReader("ital.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string[] egysor = sr.ReadLine().Split(';');
                italNeve.Add(egysor[0]);
                egysegar.Add(Convert.ToInt32(egysor[1]));
                egyeladottLiter.Add(Convert.ToInt32(egysor[2]));
            }
            sr.Close();

            for (int i = 0; i < italNeve.Count; i++)
            {
                Console.WriteLine($"{italNeve[i]} {egysegar[i]} Ft/cl {egyeladottLiter[i]} l");
            }

        }
        static void BeolvasasTombokbe()
        {
            string[] italNeve = new string[10];
            int[] egysegar = new int[10];
            int[] eldottLiter = new int[10];
            int index = 0;
            StreamReader sr = new StreamReader("ital.txt", Encoding.Default);
            //egy sorban 3 adat => 3 tömb eltárolni
            //elválasztás ;
            string[] egysor = new string[3];
            while (!sr.EndOfStream)
            {
                egysor = sr.ReadLine().Split(';'); //narancslé | 100 | 5

                italNeve[index] = egysor[0]; //narancslé
                egysegar[index] = Convert.ToInt32(egysor[1]); //100
                eldottLiter[index] = Convert.ToInt32(egysor[2]); //5
                index++;
            }

            sr.Close();

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{italNeve[i]} {egysegar[i]}Ft/cl {eldottLiter[i]} l");
            }

            Console.WriteLine($"{index} fele italból tudsz választani");
            Console.WriteLine($"{italNeve.Length} féle italt tárthatnék.");

        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("cica.txt");
            sw.Write("Első sor");
            sw.WriteLine("Ez még mindig az első sor");
            sw.WriteLine("tarkabarka");
            sw.Close();
            Console.WriteLine("Végre valami új!");
            sw = new StreamWriter(@"C:\Users\balazs.david.420\source\repos\Filekezelés\masik.txt");
            sw.WriteLine("állomány");
            sw.Close();

            StreamWriter sw2 = new StreamWriter("szamok.csv");
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                sw2.Write($"{rnd.Next(10)} ");
            }
            sw2.Close();

            StreamReader sr = new StreamReader("szamok.csv");
            string sor = sr.ReadLine();
            Console.WriteLine($"Az első sor: {sor}");
            sr = new StreamReader("cica.txt");
            sor=sr.ReadLine();
            Console.WriteLine($"A cica.txt első sora: {sor}");
            sor = sr.ReadLine();
            Console.WriteLine(sor);
            sr.Close();

            sr = new StreamReader("ital.txt",Encoding.Default);
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();

            //BeolvasasTombokbe();
            //beolvasasListaba();
            //BeolvasásStrukturaTipusTombbe();
            BeolvasásStruktúraTipusúListába();
        }
    }
}
