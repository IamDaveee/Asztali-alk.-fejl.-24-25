using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok
{
    internal class Hianyzas
    {
        public string nev, osztaly;
        public int elso, utolso, orak;

        public Hianyzas(string sor)
        {
            string [] egysor=sor.Split(';');
            nev=egysor[0];
            osztaly=egysor[1];
            elso=Convert.ToInt32(egysor[2]);
            utolso=Convert.ToInt32(egysor[3]);
            orak=Convert.ToInt32(egysor[4]);
        }
    }
}
