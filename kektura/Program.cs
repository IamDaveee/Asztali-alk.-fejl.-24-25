using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kektura
{
    class Program
    {

        static List<Kektura> adatok = new List<Kektura>();

        /*
         * static void Feladat2()
        {
            StreamReader sr = new StreamReader("kektura.csv" , Encoding.Default);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                adatok.Add(new Kektura(sr.ReadLine()));
            }
            sr.Close();
        }
        */

        static void Feladat5()
        {
            var minimum = adatok.Select(x => x.hossz).Min();
            int index = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].hossz == minimum)
                {
                    index = i;
                }
            }
            Console.WriteLine($"A legrövidebb szakasz adatai:\n\tKezdete: {adatok[index].indulo}\n\tVége: {adatok[index].veg}\n\tTávolság: {adatok[index].hossz} km");
        }


        static void Main(string[] args)
        {
            File.ReadAllLines("kektura.csv").Skip(1).ToList().ForEach(x => adatok.Add(new Kektura(x)));
            //Feladat2();
            Console.WriteLine($"3. Feladat: Szakaszok száma: {adatok.Count} db");
            Console.WriteLine($"4. feladat: A túra teljes hossza: {adatok.Select(x => x.hossz).Sum()} km");
            Feladat5();
        }
    }
}
