using System;

namespace ЛР3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double y;
            for (double i=0.2; i<=2; i = i + 0.2)
            {
                y = Math.Log10(i) + (1 / i);
                Console.WriteLine("y" + a + "=" + i);
                Console.WriteLine("x" + a + "=" + y);
                Console.WriteLine();
                a++;
            } 
        }
    }
}
