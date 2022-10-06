using System;

namespace ЛР6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] mas = new double[5, 2];
            //double[] x = new double[5];
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("Введите a" + i);
            //    double a = double.Parse(Console.ReadLine());
            //    mas[i, 0] = a;
            //    Console.WriteLine("Введите b" + i);
            //    double b = double.Parse(Console.ReadLine());
            //    mas[i, 1] = b;
            //}
            //for (int i = 0; i <= 4; i++)
            //{
            //    x[i] = mas[i, 1] / mas[i, 0];
            //    i++;
            //    Console.WriteLine("x" + i + " = " + x[i - 1]);
            //    i--;
            //}
            zad2();
        }
        static void zad2()
        {
            double min = 10000000;
            double min2 = 0;
            double[] mas = new double[16];
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine("Введите a" + i);
                mas[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 15; i++)
            {
                if (mas[i] < min)
                {
                    min2 = min;
                    min = mas[i];
                }
            }
            Console.WriteLine("min = " + min);
            Console.WriteLine("min2 = " + min2);
        }
    }
}
