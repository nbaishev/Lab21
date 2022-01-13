using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab21
{
    class Program
    {
        const int n = 10;
        const int m = 5;
        static bool[,] garden = new bool[n, m];
        static void Main(string[] args)
        {

            ThreadStart threadStart = new ThreadStart(Gardner2);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardner1();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (!garden[i, j])
                    {
                        garden[i, j] = true;
                        Thread.Sleep(20);
                    }
                    else
                        break; 
                }
            }
        }
        static void Gardner2()
        {
            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (!garden[j, i])
                    {
                        garden[j, i] = true;
                        Thread.Sleep(30);
                    }
                    else
                        break;
                }
            }
        }
    }
}
