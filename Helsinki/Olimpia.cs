using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki
{
    class Olimpia
    {
        //adattagok
        public int helyezes, sportolokSzama, pontszam;
        public string sportag, versenyszam;

        //konstruktor - fájl adatai kezeli
        public Olimpia(string sor)
        {
            string[] egysor = sor.Split(' ');
            helyezes = Convert.ToInt32(egysor[0]);
            sportolokSzama = Convert.ToInt32(egysor[1]);
            sportag = egysor[2];
            versenyszam = egysor[3];
            switch (helyezes)
            {
                case 1: pontszam = 7; break;
                case 2: pontszam = 5; break;
                case 3: pontszam = 4; break;
                case 4: pontszam = 3; break;
                case 5: pontszam = 2; break;
                case 6: pontszam = 1; break;
                default:
                    break;
            }
        }

        //metódus - függvény (return); eljárás
        public void Kiir()
        {
            //adattagokat kezeli
            Console.WriteLine($"{sportag} {versenyszam} {sportolokSzama} fő {helyezes}. helyezést ért el.");
        }

        //függvény - visszaadja az 1-2 helyezés esetén, hogy érmet kaptak
        public string Erem(int helyezes)
        {
            string eredm = "";
            if (helyezes<4)
            {
                eredm = "Érmet kaptak";
            }
            return eredm;
        }
    }
}
