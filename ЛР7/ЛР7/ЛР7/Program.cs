using System;

namespace ЛР7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mas = new double[20];
            int col = 0;
            for (int i=0;i<20; i++)
            {
                Random random = new Random();
                mas[i] = random.NextDouble();
                Console.Write(mas[i]+"; ");
            }
            for (int i = 1; i <= 16; i=i*2)
            {
                i--;
                if (mas[i] < 0.25)
                {
                    col = col + 1;
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(col+ " элементов с номерами 1, 2, 4, 8, 16 имеют значение меньше, чем 0.25");
            Console.ReadKey();
        }
    }
}
