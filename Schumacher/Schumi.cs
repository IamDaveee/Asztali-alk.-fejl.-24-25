using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schumacher
{
    class Schumi
    {
        //adattagok - láthstóság, hozzáférés: public, private
        public DateTime dátum;
        public string nagydijNeve, csapat, statusz;
        public int helyezes, befejezettKorok, szerzettPontok;

        public Schumi(DateTime dátum, string nagydijNeve, string csapat, string statusz, int helyezes, int befejezettKorok, int szerzettPontok)
        {
            this.dátum =Convert.ToDateTime(dátum);
            this.nagydijNeve = nagydijNeve;
            this.csapat = csapat;
            this.statusz = statusz;
            this.helyezes = helyezes;
            this.befejezettKorok = befejezettKorok;
            this.szerzettPontok = szerzettPontok;
        }


        //konstruktor - fájlbeolvasást
        public Schumi(string sor)
        {
            string[] egysor = sor.Split(';');
            dátum = Convert.ToDateTime(egysor[0]);
            nagydijNeve = egysor[1];
            helyezes = Convert.ToInt32(egysor[2]);
            befejezettKorok = Convert.ToInt32(egysor[3]);
            szerzettPontok = Convert.ToInt32(egysor[4]);
            csapat = egysor[5];
            statusz= egysor[6];
        }


        //metódus - eljárások, függvények

    }
}
