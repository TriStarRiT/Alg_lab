using System;

namespace ЛР5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double number = double.Parse(Console.ReadLine());
            double a = number + 1;
            double sum=0;
            int n = 0;
            //Предусловие
            while (a >= number)
            {
                n++;
                a = ((2 * n) - 1) * number;
                Console.WriteLine(Math.Pow(2, n));
                a = a / (Math.Pow(2, n));
                Console.WriteLine("a" + 1 + " = " + a);
                sum = sum + a;
            }
            Console.WriteLine("S = "+sum);
            post();

            //Постусловие
            void post()
            {
                Console.WriteLine("Введите число");
                double number = double.Parse(Console.ReadLine());
                double a = number + 1;
                double sum = 0;
                int n = 0;
                do
                {
                    n++;
                    a = ((2 * n) - 1) * number;
                    Console.WriteLine(Math.Pow(2, n));
                    a = a / (Math.Pow(2, n));
                    Console.WriteLine("a" + 1 + " = " + a);
                    sum = sum + a;
                }
                while (a >= number);
                Console.WriteLine("S = " + sum);
            }
        }
    }
}
