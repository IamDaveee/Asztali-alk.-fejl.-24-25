using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrix__Tömbök_tömbje
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            //Mátrix ismétlés
            Console.WriteLine("Hány sora legyen a mátrixnak? ");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hány oszlopa legyen? ");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[sor, oszlop];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1000);
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }

            //Tömbök tömbje - kezdőértékkel való létrehozás

            int[][] tombokTombje = {
                new int[] {11,22},
                new int[] {21,22,23,24},
                new int[] {31,32},
                new int[] {4}
            };

            //adott sor-oszlop
            int[][] tombokTombje2 = new int[3][];

            //egy elemre történő hivatkozás

            Console.WriteLine(matrix[2,2]);
            Console.WriteLine(tombokTombje[0][1]);

            //iterálás tömbök tömbjén
            for (int i = 0; i < tombokTombje.Length; i++)
            {
                for (int j = 0; j < tombokTombje[i].Length; j++)
                {
                    Console.Write($"{tombokTombje[i][j]} ");
                }
                Console.WriteLine();
            }


            */


            
            //1-es feladat
            int[,] matrix = new int[10,10];
            Random rnd = new Random();
            double osszeg = 0;
            int osszegCount = 0;
            int parosCount = 0;
            int foatloCount = 0;
            int referencia = 1000;
            int legkisebb = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 51);
                    Console.Write($"{matrix[i, j]} ");
                    osszeg += matrix[i, j];
                    osszegCount += 1;
                    if (matrix[i,j]%2==0)
                    {
                        parosCount += 1;
                    }
                    if (matrix[i,j]<referencia)
                    {
                        legkisebb = matrix[i, j];
                        referencia = legkisebb;
                    }
                }
                Console.WriteLine();
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    foatloCount += matrix[k, k];
                }
            }
            Console.WriteLine();

            Console.WriteLine($"A mátrix elemeinek összege: {osszeg}, átlaguk: {osszeg/osszegCount}");
            Console.WriteLine($"A mátrixban {parosCount} db páros elem van");
            Console.WriteLine($"A főátlón található elemek összege: {foatloCount}");
            Console.WriteLine($"A mátrix legkisebb eleme: {legkisebb}");
            Console.WriteLine("Melyik számot keressük a mátrixban? ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szamcount = 0;
            int szami = 0;
            int szamj = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==szam)
                    {
                        szamcount += 1;
                        szami = i;
                        szamj = j;
                        Console.WriteLine($"A keresett szám {szamcount}. megjelenése: {szami}, {szamj} helyen van");
                    }
                }
            }
            if (szamcount>0)
            {
                Console.WriteLine($"A keresett szám {szamcount}-szor jelenik meg a mátrixban");
            }
            else
            {
                Console.WriteLine($"A keresett szám nincs benne a mátrixban");
            }

            //2-es feladat
            string[][] tomb= new string[4][];
            tomb[0] = new string[] {"","","",""};
            tomb[1] = new string[] {"Január","Február","Március","Április","Május","Június","Július","Augusztus","Szeptember","Okróber","November","Dercember"};
            tomb[2] = new string[] {"Rózsa","Tulipán","Nárcisz"};
            tomb[3] = new string[] {"1","2","3","4","5"};
            int randomCount = 0;

            //extra - string számok átalakítása, és összeadása
            for (int i = 0; i < tomb[3].Length; i++)
            {
                int aktuális = Convert.ToInt32(tomb[3][i]);
                randomCount += aktuális;
            }
            Console.WriteLine(randomCount);
            //extra

            //extra - felhasználó által megadott ételek behelyettesítése
            string[] etelek = new string[4];
            for (int i = 0; i < etelek.Length; i++)
            {
                Console.WriteLine($"Mi az {i+1}. kedvenc ételed? ");
                string userFood = Convert.ToString(Console.ReadLine());
                etelek[i] = userFood;
            }
            for (int i = 0; i < tomb[0].Length; i++)
            {
                tomb[0][i] = etelek[i];
                //Console.Write($"{tomb[0][i]} ");
            }
            //extra

            foreach (var item in tomb)
            {
                foreach (var valami in item)
                {
                    Console.Write($"{valami} " );
                }
                Console.WriteLine();
            }


            /*
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb[i].Length; j++)
                {
                    Console.Write($"{tomb[i][j]} ");
                }
                Console.WriteLine();
            }
            */


            //3-as feladat
            int[,] szekek = new int[30, 20];
            //Random rnd = new Random();
            for (int i = 0; i < szekek.GetLength(0); i++)
            {
                for (int j = 0; j < szekek.GetLength(1); j++)
                {
                    szekek[i, j] = rnd.Next(0, 2);
                    Console.Write($"{szekek[i,j]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Hány db széket szeretnél egymás mellett foglalni? ");
            int darab = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int utolsoi = 0;
            int utolsoj = 0;
            int szabadcount = 0;
            for (int i = 0; i < szekek.GetLength(0); i++)
            {
                for (int j = 0; j < szekek.GetLength(1); j++)
                {
                    if (szekek[i,j]==1)
                    {
                        count += 1;
                        if (count==darab)
                        {
                            utolsoi = i+1;
                            utolsoj = j+1;
                            szabadcount += 1;
                            Console.WriteLine($"Van még {darab}db szék egymás mellett, a {utolsoi}.sorban, {utolsoj - darab+1}. és a {utolsoj}. szék között");
                            count = 0;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                count = 0;
            }
            if (szabadcount==0)
            {
                Console.WriteLine($"Sajnos nincs {darab}db szabad szék egymás mellett :(");
            }
            
            Console.ReadKey();
        }
    }
}
