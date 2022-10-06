using System;

namespace ЛР1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            a = 1.5;
            b = 0.5;
            Console.WriteLine("Введите чему равен x");
            double x = double.Parse(Console.ReadLine());
            double D1 = Math.Abs(x + (a * a));
            double d1 = Math.Abs(x);
            double D2 = (a * x * Math.Atan(x) - Math.Pow(d1, (1/2))+Math.Log(b+x)+1);
            double Y = D1 * D2;
            Console.WriteLine("При x="+x+ " значение функции Y="+Y);
            double F1 = Math.Pow(a * x * x + x, 1 / 2);
            double F2 = Math.Exp(-a * x);
            double F = F1 + F2;
            Console.WriteLine("При x=" + x + " значение функции F=" + F);
            Console.ReadKey();
        }
    }
}
