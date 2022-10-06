using System;

namespace ЛР8_21
{
    class Program
    {
        string a="", b;
        static void Main(string[] args)
        {
            string a="";
            Console.WriteLine("//Добро пожаловать в калькулятор//");
            while (true)
            {
                string input = Console.ReadLine();
                if ((input=="*") || (input=="/") || (input == "+") || (input == "-"))
                {
                    meth(input);
                }
                else
                {
                    if (input == "=")
                    {
                        break;
                    }
                    else
                    {
                        first(input, a);
                    }
                }

            }

        }
        static void meth(string input)
        {
            input = Console.ReadLine();
            switch (input)
            {
                case "+":
                    Console.Write(" + ");
                    break;
                case "-":
                    Console.Write(" - ");
                    break;
                case "*":
                    Console.Write(" * ");
                    break;
                case "/":
                    Console.Write(" / ");
                    break;
            }
        }
        static void first(string input,string a)
        {
            switch (input)
            {
                case "1":
                    a = a + "1";
                    break;
                case "2":
                    a = a + "2";
                    break;
                case "3":
                    a = a + "3";
                    break;
                case "4":
                    a = a + "4";
                    break;
                case "5":
                    a = a + "5";
                    break;
                case "6":
                    a = a + "6";
                    break;
                case "7":
                    a = a + "7";
                    break;
                case "8":
                    a = a + "8";
                    break;
                case "9":
                    a = a + "9";
                    break;
                case "0":
                    a = a + "0";
                    break;
            }
        }
    }
}

