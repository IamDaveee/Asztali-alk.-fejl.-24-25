using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kektura
{
    class Kektura
    {
        public string indulo, veg;
        public int emelkedes, lejtes;
        public double hossz;
        public char pecset;

        public Kektura(string sor)
        {
            string[] egysor = sor.Split(';');
            indulo = egysor[0];
            veg = egysor[1];
            hossz = Convert.ToDouble(egysor[2]);
            emelkedes = Convert.ToInt32(egysor[3]);
            lejtes = Convert.ToInt32(egysor[4]);
            pecset = Convert.ToChar(egysor[5]);
        }
    }
}
