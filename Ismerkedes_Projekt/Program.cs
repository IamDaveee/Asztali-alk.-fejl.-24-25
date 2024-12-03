using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismerkedes_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Szia");
            Console.WriteLine("mia");
            Console.WriteLine("kedd van");
            //escape karakterek
            Console.WriteLine("Szia\nmia");
            Console.WriteLine("Szia\tmia");
            Console.WriteLine(3 + 5);
            //Változók
            int a;
            //értékadás
            a = 12;

            int b = 5;

            Console.WriteLine(a + b);
            Console.WriteLine("a+b={0}", a + b);
            Console.WriteLine("a={0}\nb={1}\na*b={2}", a, b, a * b);
            Console.WriteLine($"a={a}\nb={b}\na*b={a * b}");

            int c = 4, d = 9;

            Console.WriteLine(c / d);
            Console.WriteLine(c % d);

            Console.ReadKey();
        }
    }
}
