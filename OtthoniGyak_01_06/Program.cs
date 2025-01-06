using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtthoniGyak_01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int SumCount = 0;
            int SumTotal = 0;
            int parosCount = 0;
            int foatloCount = 0;
            int legisebb = 100;


            int[,] matrix = new int[10, 10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 51);

                    if (matrix[i,j]%2==0)
                    {
                        parosCount++;
                    }

                    if (matrix[i,j]<legisebb)
                    {
                        legisebb = matrix[i, j];
                    }

                    SumTotal += matrix[i, j];
                    SumCount++;

                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"A mátrix elemeinek összege: {SumTotal}, Átlaguk: {SumTotal/SumCount}");

            Console.WriteLine($"{parosCount}db páros elem található a mátrixban");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                foatloCount+=matrix[i,i];
            }
            Console.WriteLine($"A főátló elemeinek összege: {foatloCount}");

            Console.WriteLine($"Legkisebb elem: {legisebb}");

            //legkisebb elem #2
            /*
            int smallest = matrix[0,0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < smallest)
                    {
                        smallest = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"A legkisebb szám ismét: {smallest}");
            */

            Console.WriteLine("Melyik számot keressük a mátrixban? ");
            int find=Convert.ToInt32(Console.ReadLine());
            int FindCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==find)
                    {
                        FindCount++;
                        Console.WriteLine($"A keresett elem {FindCount}. előfordulása: {i},{j} helyen");
                    }
                }
            }
            if (FindCount>0)
            {
                Console.WriteLine($"A keresett szám: {find}, {FindCount} esetben szerepelt a mátrixban");
            }
            else
            {
                Console.WriteLine($"A keresett szám nem szerepel a mátrixban :(");
            }

            Console.WriteLine();
            string[][] tomboktombje = new string[4][];

            tomboktombje[0] = new string[] {"alam","pizza","körte","rántotthús"};
            tomboktombje[1] = new string[] { "Január", "Február", "Március", "Április", "Május", "Június", "Július", "Augusztus", "Szeptember", "Okróber", "November", "Dercember" };
            tomboktombje[2] = new string[] {"Tulipá","Rózsa","Nárcisz"};
            tomboktombje[3] = new string[] {"1","2","3","4","5"};

            Console.WriteLine();
            for (int i = 0; i < tomboktombje.Length; i++)
            {
                for (int j = 0; j < tomboktombje[i].Length; j++)
                {
                    Console.Write($"{tomboktombje[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (var item in tomboktombje)
            {
                foreach (var valami in item)
                {
                    Console.Write($"{valami} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int[,] szinhaz = new int[30, 20];
            for (int i = 0; i < szinhaz.GetLength(0); i++)
            {
                for (int j = 0; j < szinhaz.GetLength(1); j++)
                {
                    szinhaz[i, j] = rnd.Next(0, 2);
                    Console.Write($"{szinhaz[i, j]} ");
                }    
                Console.WriteLine();
            }


            Console.WriteLine("Hány db széket szeretnél lefoglalni? ");
            int szekSzam = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int szabadi = 0;
            int szabadj = 0;
            int szabadCount = 0;


            for (int i = 0; i < szinhaz.GetLength(0); i++)
            {
                for (int j = 0; j < szinhaz.GetLength(1); j++)
                {
                    if (szinhaz[i,j]==1)
                    {
                        count++;
                        if (count==szekSzam)
                        {
                            szabadi = i+1;
                            szabadj = j + 1;
                            szabadCount++;
                            Console.WriteLine($"Van {szekSzam}db szabad szék egymás mellett: A {szabadi}. sorban, a {szabadj-szekSzam+1}-{szabadj}. székek között");
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
            if (szabadCount == 0)
            {
                Console.WriteLine($"Sajnos nincs {szekSzam}db szabad szék egymás mellett :(");
            }
        }
    }
}
