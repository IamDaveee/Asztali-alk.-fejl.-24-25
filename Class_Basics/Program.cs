using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Basics
{
    class Ember
    {
        //adattagok - hozzáférési szint/láthatóság: public, private, protected
        public string nev;
        public int kor;


        //konstruktor - objektum kezdőértékét állítja be

        public Ember(string nev, int kor)
        {
            //adattag=paraméter
            this.nev = nev;
            this.kor = kor;
        }
        public Ember(){ }

        public Ember(string n)
        {
            nev = n;
            kor = 18;
        }

        //metódus - eljárás, függvény
        public void Kiir()
        {
            Console.WriteLine($"Név: {nev} Életkor: {kor}");
        }

        public int Eletkor()
        {
            return kor;
        }

        public string Korvizsgálat()
        {
            return kor >= 18 ? "Nagykorú" : "Kiskorú";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //példányosítás - objektum létrehozása
            Ember e = new Ember(); //konstuktor - inicializálásért felelős
            e.nev = "Karcsi";
            e.kor = 18;
            Console.WriteLine($"{e.nev} {e.kor} éves");
            e.nev = "Peti";
            e.kor = 20;
            Console.WriteLine($"{e.nev} {e.kor} éves");

            Ember e2 = new Ember("Gizi",15);
            Console.WriteLine($"{e2.nev} {e2.kor} éves");
            Ember e3 = new Ember("Anna");
            Console.WriteLine($"{e3.nev} {e3.kor} éves");

            //metódus meghívása
            e.Kiir();
            e2.Kiir();
            e3.Kiir();

            Console.WriteLine(e.Eletkor()>=18?$"{e.nev} nagykorú":$"{e.nev} kiskorú");

            Console.WriteLine(e2.Korvizsgálat());

            Allatok allatka = new Allatok("George", 4, 7);
            allatka.AllatKiir();
        }
    }
}
