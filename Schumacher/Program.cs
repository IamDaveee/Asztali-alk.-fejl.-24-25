using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schumacher
{
    class Program
    {
        static void Main(string[] args)
        {
            //példány - az autómatikusan elészített konstruktor használatára
            Schumi példány = new Schumi(new DateTime(2025, 05, 13),"Magyar Nagydíj","11G","Vesztes",100,0,0);

            Console.WriteLine(példány.dátum.Year);

            //lista készítése
            List<Schumi> adatok = new List<Schumi>();

            //beolvasás
            System.IO.File.ReadAllLines("schumacher.csv").Skip(1).ToList().ForEach(x => adatok.Add(new Schumi(x)));
            Console.WriteLine($"3. fealadat: {adatok.Count} sort tartalmaz");

            Console.WriteLine($"4.feladat: {adatok.Where(x=>x.nagydijNeve=="Hungarian Grand Prix"&& x.statusz=="Finished").Count()}");
            Console.WriteLine("Sikeres szereplései");
            
            adatok.Where(x => x.nagydijNeve == "Hungarian Grand Prix" && x.helyezes > 0).ToList().ForEach(x => Console.WriteLine($"{x.dátum.Year}.{x.dátum.Month:00}.{x.dátum.Day:00} - {x.helyezes}.hely"));
            
            adatok.Where(x => x.statusz != "Finished").GroupBy(x => x.statusz).Where(y => y.Count() > 2).ToList().ForEach(y => Console.WriteLine($"{y.Key} - előfordulása: {y.Count()}"));


        }
    }
}
