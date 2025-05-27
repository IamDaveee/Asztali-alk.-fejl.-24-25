using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Választások
{
    class Valasztasok
    {
        public int kerulet, kepviselo;
        public string vezeteknev, utonev, part, teljesNev;

        public Valasztasok(string sor)
        {
            string[] egysor = sor.Split(' ');
            kerulet = Convert.ToInt32(egysor[0]);
            kepviselo = Convert.ToInt32(egysor[1]);
            vezeteknev = egysor[2];
            utonev = egysor[3];
            part = egysor[4];
            teljesNev = vezeteknev + " " + utonev;
        }
    }
}
