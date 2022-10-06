using System;

namespace ЛР3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i=12; i<=18; i++)
            {
                result = i * result;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
