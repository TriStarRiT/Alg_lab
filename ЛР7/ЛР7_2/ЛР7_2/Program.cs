using System;

namespace ЛР7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[4, 4];
            Random random = new Random();
            int min = 100000;
            int minStrok=0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mas[i, j] = random.Next(0,10);
                    Console.Write(mas[i, j]+"    ");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < 4; i++)
            {
                if (mas[i,i] < min)
                {
                    min=mas[i, i];
                    minStrok = i;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine("Введите число");
            int K = int.Parse(Console.ReadLine());
            if (min < K)
            {
                K = min;
                for (int i = 0; i < 4; i++)
                {
                        mas[minStrok, i]++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(mas[i, j] + "    ");
                }
                Console.WriteLine("");
            }
        }
    }
}
