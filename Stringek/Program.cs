using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
    class Program
    {
        static void Main(string[] args)
        {

            //stringek - karakterlánc tárolására lakalmas
            //""között
            string user = "";
            Console.WriteLine(user);
            string szoveg = "egyszer volt, hol nem volt, volt egyszer egy szöveg";

            Console.WriteLine($"A szöveg hossza: {szoveg.Length}");
            Console.WriteLine($"A szöveg első betűje: {szoveg[0]}");
            Console.WriteLine($"A szöveg első betűje {szoveg.First()}");
            Console.WriteLine($"A szöveg utolsó betűje: {szoveg[szoveg.Length-1]}");
            Console.WriteLine($"a szöveg utolsó betűje: {szoveg.Last()}");

            Console.WriteLine($"A szöveg naygbetűsen: {szoveg.ToUpper()}");
            Console.WriteLine($"A szöveg kisbetűsen: {szoveg.ToLower()}");
            Console.WriteLine($"A szöveg iterálása - kiíratás karakterenként: ");
            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.Write($"{szoveg[i]} ");
            }
            Console.WriteLine();
            foreach (var item in szoveg)
            {
                Console.Write($"{item}*");
            }
            Console.WriteLine();

            //Contains - tartalmazás vizsgálat - Igaz (bool) értéket ad vissza, ha a paraméterként adott szöveg/szövegrészletet tartalmazza a szöveg
            //"" vagy ''
            Console.WriteLine(szoveg.Contains("volt") ? "benne van a volt szó" : "nincs benne a volt szó");
            Console.WriteLine($"Mit keressek a szövegben? ");
            user = Console.ReadLine();
            Console.WriteLine(szoveg.Contains(user)?"Benne van a keresett érték":"Nincs benne");
            Console.WriteLine(szoveg.Contains(Console.ReadLine())?"igen":"Nem");

            //EndsWith - Igaz értzéket ad vissza ha a szöveg a megadott szöveg részlettel végződik

            Console.WriteLine(szoveg.EndsWith(".")?"Van pont":"Nincs pont");

            //StartWith - Igaz értzéket ad vissza ha a szöveg a megadott szöveg részlettel kezdődik

            Console.WriteLine(szoveg.StartsWith("a")?"a val kezdődik":"Nem a val kezdődik");

            Console.WriteLine("Milyen szövegkezdést viszgáljak?");
            user = Console.ReadLine().ToUpper();
            Console.WriteLine(szoveg.StartsWith(user)?"Igen":"Nem");

            //IndexOf - A paraméterként megadott karakter vagy szövegrészlet első előfordulási helye
            Console.WriteLine(szoveg.IndexOf("a"));
            Console.WriteLine(szoveg.IndexOf("e")!=-1?$"{szoveg.IndexOf("a")+1}. betűtől":"Nincs benne");

            //LastIndexOf
            Console.WriteLine(szoveg.LastIndexOf("volt"));
            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.Write($"{i+1}. betű: {szoveg[i]}");
            }

            //Replace - karakter csere (Régit cseréli az újra), összes esetben
            Console.WriteLine(szoveg.Replace("Egyszer","Eccer"));

            //substring - részkarakterlánc
            //a megadott indextől kezdve a szöveg karaktereit adja eredményül
            Console.WriteLine($"a szöveg első 4 karaktere: {szoveg.Substring(0,4)}");

            //Split - a szöveg feldarabolása
            string[] darab = szoveg.Split(' ');
            foreach (var item in darab)
            {
                Console.WriteLine(item);
            }

            //Remove - adott indextől kezdve töröl
            Console.WriteLine(szoveg.Remove(5,4)); //5. betűtől, 4 betűt vesz ki
            Console.WriteLine(szoveg.Remove(5));//5 től mindent

            //Trim, trimEnd(), TrimStart()
            user="       adagzfegbfzbaefbe          ";
            Console.WriteLine(user.Trim());

        }
    }
}
