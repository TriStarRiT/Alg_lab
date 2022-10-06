using System;
using System.Diagnostics;

namespace ЛР8
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Stopwatch();
            w.Start();
            int[,] masM = new int[5, 5];
            int[] masB = new int[17];
            int j,a;
            Random random = new Random();
            int min = 100000;
            for (int i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    masM[i, j] = random.Next(20, 30);
                    Console.Write(masM[i, j]+";  ");
                }
                Console.WriteLine("");
            }
            for (int i=0; i < 17; i++)
            {
                masB[i] = random.Next(-10, 10);
                Console.Write(masB[i]+"; ");
            }
            Console.WriteLine("");
            j = 4;
            for (int i = 0; i < 5; i++)
            {
                if (masM[i, j] < min)
                {
                    min = masM[i, j];
                }
                j--;
            }
            Console.WriteLine(min);
            for (int i = 0; i < 17; i++)
            {
                if (masB[i] < 0)
                {
                    masB[i] = min;
                }
            }
            for (int i = 0; i < 17; i++)
            {
                Console.Write(masB[i] + "; ");
            }
            Console.WriteLine("");
            min = -1;
            for (int i = 0; i < 17; i++)
            {
                for (j = 0; j < 16; j++)
                {
                    if (masB[j] > masB[j + 1])
                    {
                        a = masB[j];
                        masB[j] = masB[j + 1];
                        masB[j + 1] = a;
                    }
                }
            }
            for (int i = 0; i < 17; i++)
            {
                Console.Write(masB[i] + "; ");
            }
            Console.WriteLine("");
            w.Stop();

            Console.WriteLine("");
            Console.WriteLine("Время, потраченное на выполнение программы:" + w.Elapsed);
        }
    }
}
