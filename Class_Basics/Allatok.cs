using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Basics
{
    class Allatok
    {
        public int labSzam, kor;
        int Emberkor; //privát
        public string nev;

        public Allatok(string nev, int labSzam, int kor)
        {
            this.nev = nev;
            this.labSzam = labSzam;
            this.kor=kor;
            Emberkor = kor * 7;
        }

        public void AllatKiir()
        {
            Console.WriteLine($"A {labSzam} lábú, {nev} nevű állat, {kor} éves, ({Emberkor}).");
        }
    }
}
