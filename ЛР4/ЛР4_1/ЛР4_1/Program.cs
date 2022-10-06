using System;

namespace ЛР4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 7];
            int a = 6, b=0;
            string week="икгр", work="no";
            mas[0, 0] = 0;
            mas[0, 1] = 0;
            for (int i=0; i < 5; i++)
            {
                mas[0, i + 2] = i+1;
            }
            for (int i = 1; i < 4; i++)
                {
                for (int j = 0; j < 7; j++)
                {
                    mas[i, j] = a;
                    a++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                mas[4 , i] = a;
                a++;
            }
            mas[4, 4] = 0;
            mas[4, 5] = 0;
            mas[4, 6] = 0;
            Console.WriteLine("Введите число");
            int day = int.Parse(Console.ReadLine());
            if ((day < 1) || (day > 30))
            {
                Console.WriteLine("В сентябре 2021 года нет такого числа");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (mas[i, j] == day)
                        {
                            b = j;
                        }
                    }
                }
                if (b == 0)
                {
                    week = "понедельник";
                    work = "рабочий";
                }
                if (b == 1)
                {
                    week = "вторник";
                    work = "рабочий";
                }
                if (b == 2)
                {
                    week = "среда";
                    work = "рабочий";
                }
                if (b == 3)
                {
                    week = "четверг";
                    work = "рабочий";
                }
                if (b == 4)
                {
                    week = "пятница";
                    work = "рабочий";
                }
                if (b == 5)
                {
                    week = "суббота";
                    work = "нерабочий";
                }
                if (b == 6)
                {
                    week = "воскресенье";
                    work = "нерабочий";
                }
                Console.WriteLine(day + " сентября 2021 года - это " + week + ", " + work + " день.");
            }
        }
    }
}
