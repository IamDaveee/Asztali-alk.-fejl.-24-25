using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mátrix_Tömb_Gyak_12._17
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[10, 10];
            Random rnd = new Random();
            int parosCount = 0;
            int findNum = 111;
            int findCount = 0;
            int negativCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-100, 251);
                    if (matrix[i,j]%2==0)
                    {
                        parosCount++;
                    }
                    if (matrix[i,j]==111)
                    {
                        findCount++;
                    }
                    if (matrix[i,j]<0)
                    {
                        negativCount++;
                    }
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            int foatlo = matrix.GetLength(0);
            int foatlomax = matrix[0, 0];
            int foatloSum = 0;

            Console.WriteLine();

            for (int i = 0; i < foatlo; i++)
            {
                if (matrix[i,i]>foatlomax)
                {
                    foatlomax = matrix[i, i];
                }
                foatloSum += matrix[i, i];
            }

            Console.WriteLine($"A főátlón található elemek összege: {foatloSum}");
            Console.WriteLine($"A főátló és a párosok aránya: {foatlo}:{parosCount}");
            Console.WriteLine($"A főátló legnagyobb eleme: {foatlomax}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]%3==0)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                }
            }
            Console.WriteLine();
            if (findCount>0)
            {
                Console.WriteLine($"A {findNum} {findCount} alkalommal szerepel a mátrixban");
            }
            else
            {
                Console.WriteLine($"A {findNum} nem szerepel a mátrixban");
            }

            int smallerCount = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]<foatloSum)
                    {
                        smallerCount++;
                    }
                }
            }

            Console.WriteLine($"{smallerCount} db olyan elem szerepel a mátrixban amely kisebb mint a főátlón szereplő számok összege");

            Console.WriteLine($"{negativCount} db negatív szám található a mátrixban");
            Console.WriteLine();

            string[][] tomb = new string[3][];

            tomb[0] = new string[] { "Anna", "Peti", "Gergő"};
            tomb[1] = new string[] { "Tomi", "Dani", "Bence","Sára","Petra"};
            tomb[2] = new string[] { "Miklós", "Sanyi", "Balázs","Dávid"};

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb[i].Length; j++)
                {
                    Console.Write($"{tomb[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            int[][] uzletek = new int[3][];

            int[] uzlet1 = new int[4];
            int[] uzlet2 = new int[5];
            int[] uzlet3 = new int[3];

            for (int i = 0; i < uzlet1.Length; i++)
            {
                Console.WriteLine($"Mennyi az 1. üzlet {i+1}. napi bevétele? ");
                int napi = Convert.ToInt32(Console.ReadLine());
                uzlet1[i] = napi;
            }
            for (int i = 0; i < uzlet2.Length; i++)
            {
                Console.WriteLine($"Mennyi az 2. üzlet {i + 1}. napi bevétele? ");
                int napi = Convert.ToInt32(Console.ReadLine());
                uzlet2[i] = napi;
            }
            for (int i = 0; i < uzlet3.Length; i++)
            {
                Console.WriteLine($"Mennyi az 3. üzlet {i + 1}. napi bevétele? ");
                int napi = Convert.ToInt32(Console.ReadLine());
                uzlet3[i] = napi;
            }

            
            uzletek[0] = new int[] {uzlet1[0], uzlet1[1], uzlet1[2], uzlet1[3]};
            uzletek[1] = new int[] {uzlet2[0], uzlet2[1], uzlet2[2], uzlet2[3], uzlet2[4] };
            uzletek[2] = new int[] {uzlet3[0], uzlet3[1], uzlet3[2]};
            


            Console.WriteLine();
            foreach (var item in uzletek)
            {
                foreach (var valami in item)
                {
                    Console.Write($"{valami} ");
                }
                Console.WriteLine();
            }
        }
    }
}
