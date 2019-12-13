using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //сумма злементов массива

            int[] numbers1 = { 4, 7, 13, 20, 33, 23, 54 };
            int[] numbers2 = { 56, 12, 14, 44, 43, 21, 333 };

            int s1 = 0;
            int s2 = 0;

                foreach (int el1 in numbers1)
                foreach (int el in numbers2)


                {
                    s1 += el1;
                    s2 += el;
                }

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            {

                //Console.WriteLine();



                Console.ReadKey();
            }
            */
            Random x = new Random();
            int n = 3;

            int[,] mas = new int[n, n];

            int[][] MyMas = new int[4][];
            MyMas[0] = new int[5];
            MyMas[1] = new int[4];
            MyMas[2] = new int[2];
            MyMas[3] = new int[3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    mas[i, j] = x.Next(10); // случайные числа от нуля до 9
            }
            Console.WriteLine("Двумерный прямоугольный массив");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write(" " + mas[i, j]);
            }
            
            for (int i = 0; i < MyMas.Length; i++)
            {
                for (int j = 0; j < MyMas[i].Length; j++)
                    MyMas[i][j] = x.Next(9); // случайные числа от нуля до 9
            }
            Console.WriteLine("Двумерный ступенчатый массив");
            for (int i = 0; i < MyMas.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < MyMas[i].Length; j++)
                    Console.Write(" " + MyMas[i][j]);
            }
            
            Console.ReadKey(); 
        }
    }
}
