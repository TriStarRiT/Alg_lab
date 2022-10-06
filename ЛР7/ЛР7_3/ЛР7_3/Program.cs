using System;
using System.Diagnostics;

namespace ЛР7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Stopwatch();
            w.Start();
            int[] masX = new int[15];
            int[] masY = new int[10];
            int[,] masnew = new int[5, 5];
            int a = 0, b = 0, c=0, d=0;
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                masX[i] = random.Next(0,10);
                Console.Write(masX[i]+"; ");
            }
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                masY[i] = random.Next(20, 30);
                Console.Write(masY[i] + "; ");
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i>=a) && (j >= b))
                    {
                        masnew[i, j] = masX[c];
                        c++;
                    }
                    else
                    {
                        masnew[i, j] = masY[d];
                        d++;
                    }
                }
                a++;
                b++;
            }
            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(masnew[i,j]+"    ");
                }
                Console.WriteLine("");
            }
            w.Stop();
            Console.WriteLine("");
            Console.WriteLine("Время, потраченное на выполнение программы:" + w.Elapsed);
        }
    }
}
