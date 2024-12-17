using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Gyak_12._17
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[15, 15];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(101);
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            //feladatok
            //mátrix elemeinek összege:

            int osszeg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    osszeg += matrix[i, j];
                }
            }
            Console.WriteLine($"Az elemek összege: {osszeg}");

            //50-nél nagyobb elemek átlaga
            double osszeg50 = 0, db = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]>50)
                    {
                        osszeg50 += matrix[i, j];
                        db++;
                    }
                }
            }

            Console.WriteLine($"Az 50-nél nagyobb elemek átlaga: {osszeg50/db:0,00}");
            Console.WriteLine($"{db} 50-nél nagyobb elem van a mátrixban.");

            //szélsőérték keresés - min,max

            int min = matrix[0, 0];
            int mini = 0, minj = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]<min)
                    {
                        min = matrix[i, j];
                        mini = i;
                        minj = j;
                    }
                }
            }

            Console.WriteLine($"A legkisebb elem: {min}, helye: {mini}, {minj}");

            int max = matrix[0, 0];
            int maxi = 0, maxj = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]>max)
                    {
                        max = matrix[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            Console.WriteLine($"A mátrix legnagyobb eleme: {max}, helye: {maxi}, {maxj}");

            //elem keresés
            Console.WriteLine("Melyik elemet keressük a mátrixban? ");
            int elem = Convert.ToInt32(Console.ReadLine());
            bool benneVan = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]==elem)
                    {
                        benneVan = true;
                    }
                }
            }

            Console.WriteLine(benneVan?$"A {elem} benne van a mátrixban.":$"{elem} nincs benne a mátrixban");

            //tömbök tömbje
            string[][] tombokTobje = new string[4][];
            tombokTobje[0] = new string[] { "egy", "kettő", "három" };
            tombokTobje[1] = new string[] {"a","b","c","d","e"};
            tombokTobje[2] = new string[] {"szendvics","csoki","nyalóka","rágó"};
            //a felh. adja meg futás közben

            string[] felhasznalo = new string[3];
            for (int i = 0; i < felhasznalo.Length; i++)
            {
                Console.WriteLine($"Add meg az {i+1}. valamit");
                felhasznalo[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine();
            tombokTobje[3] = new string[] {felhasznalo[0], felhasznalo[1], felhasznalo[2]};

            /*
            foreach (var item in tombokTobje)
            {
                foreach (var valami in item)
                {
                    Console.Write($"{valami} ");
                }
                Console.WriteLine();
            }
            */
            for (int i = 0; i < tombokTobje.Length; i++)
            {
                for (int j = 0; j < tombokTobje[i].Length; j++)
                {
                    Console.Write($"{tombokTobje[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
