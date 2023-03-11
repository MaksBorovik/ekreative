using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace практична_робота
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть розмiр квадратного массива, число n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введiть через пробiл чотирi числа для заповнення масива: ");
            string[] data = Console.ReadLine().Trim().Split();
            Random random = new Random();
            int[,] arr = new int[n, n];
            int[] myArray = new int[4];
            int counter = 0;
            int total = 0;

            for (int i = 0; i < 4; i++)
            {
                myArray[i] = int.Parse(data[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                total = myArray[i] + total;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = myArray[random.Next(0, 4)];
                    Console.Write("  ");
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if ((arr[i, j] + arr[i + 1, j] + arr[i, j + 1] + arr[i + 1, j + 1]) == total) { counter++; }
                }
            }
            Console.WriteLine("Кiлькiсть четвiрок в яких усi елементи рiзнi дорiвнює:" + " " + counter);
            Console.WriteLine();
            Console.WriteLine("Координати четвiрок в яких усi елементи рiзнi, становлять:");
            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if ((arr[i, j] + arr[i + 1, j] + arr[i, j + 1] + arr[i + 1, j + 1]) == total)
                    {
                        Console.Write(" \t " + $"[{i},{j}]  [{i},{j + 1}]");
                        Console.WriteLine(" \t " + $"[{i + 1},{j}]  [{i + 1},{j + 1}]"+";");
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
