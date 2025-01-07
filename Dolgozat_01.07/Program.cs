using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_01._07
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("Hány soros legyen a mátrix? ");
            int sorSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hány oszlopos legyen a mátrix? ");
            int oszlopSzam = Convert.ToInt32(Console.ReadLine());

            int[,] feladat = new int[sorSzam, oszlopSzam];

            for (int i = 0; i < feladat.GetLength(0); i++)
            {
                for (int j = 0; j < feladat.GetLength(1); j++)
                {
                    Console.WriteLine($"Kérem az {i+1}. sor {j+1}. elemét: ");
                    feladat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine($"A feltöltött mátrix: ");
            for (int i = 0; i < feladat.GetLength(0); i++)
            {
                for (int j = 0; j < feladat.GetLength(1); j++)
                {
                    Console.Write($"{feladat[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //2.

            Random rnd = new Random();
            int[,] matrix = new int[10, 10];
            double parosCount = 0;
            int parosSum = 0;
            int legkisebb = 1000;
            int legkisebbi = 0;
            int legkisebbj = 0;
            bool szerepel = false;
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(100, 1000);
                    Console.Write($"{matrix[i,j]} ");

                    if (matrix[i,j]%2==0)
                    {
                        parosCount++;
                        parosSum += matrix[i, j];
                    }
                    if (matrix[i, j]<legkisebb)
                    {
                        legkisebb = matrix[i, j];
                        legkisebbi = i;
                        legkisebbj = j;
                    }
                    if (matrix[i, j]==999)
                    {
                        szerepel = true;
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"A mátrix páros elemeinek átlaga: {parosSum/parosCount:0.00}");
            Console.WriteLine();

            Console.WriteLine("5-el osztható elemek a mátrixban: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j]%5==0)
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"A mátrix legkisebb eleme: {legkisebb}, utolsó előfordulási helye: {legkisebbi+1}. sor, {legkisebbj+1}. oszlop");
            Console.WriteLine();

            if (szerepel==true)
            {
                Console.WriteLine("A 999-es szám szerepel a mátrixban");
            }
            else
            {
                Console.WriteLine("999-es szám nem szerepel a mátrixban");
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j]>200 && matrix[i, j]<300)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{count}db 200 és 300 közötti érték szerepel a mátrixban");
            Console.WriteLine();


            //4.
            string[][] kedd = new string[3][];
            kedd[0] = new string[4];

            string[] allatok = new string[4];
            for (int i = 0; i < allatok.Length; i++)
            {
                Console.WriteLine($"Melyik a(z) {i+1}. kedvenc állatod? ");
                allatok[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = 0; i < allatok.Length; i++)
            {
                kedd[0][i] = allatok[i];
            }

            kedd[1] = new string[] {"Hétfő","Kedd","Szerda","Csütörtök","Péntek","Szombat","Vasárnap"};
            kedd[2] = new string[] {"Alma","Körte","Barack"};

            Console.WriteLine();
            Console.WriteLine($"A kedd tömb 2. sorának 4. eleme: {kedd[1][3]}");

            Console.WriteLine();
            Console.WriteLine("A kedd tömb elemei: ");
            foreach (var item in kedd)
            {
                foreach (var valami in item)
                {
                    Console.Write($"{valami} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
