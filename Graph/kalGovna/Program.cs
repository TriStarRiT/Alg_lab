using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 7; //Ввести количество рёбер
            int v = 5; //Ввести количество вершин
            int[,] mas = new int[a, 2];
            mas[0, 0] = 1; mas[0, 1] = 2;
            mas[1, 0] = 1; mas[1, 1] = 3;
            mas[2, 0] = 1; mas[2, 1] = 5;
            mas[3, 0] = 2; mas[3, 1] = 3;
            mas[4, 0] = 2; mas[4, 1] = 4;
            mas[5, 0] = 3; mas[5, 1] = 5;
            mas[6, 0] = 4; mas[6, 1] = 5;

            int[,] otvet = new int[v, a*v];

            int r = 0;
            for (int i = 0; i < v; i++)
            {
                Console.Write(i + 1 + ":");
                for (int j = 0; j < a; j++)
                {
                    for (int w = 0; w < 2; w++)
                    {
                        if (mas[j, w] == i + 1)
                        {
                            Console.Write(" ");
                            switch (w)
                            {
                                case 0:
                                    Console.Write(mas[j, 1]);
                                    otvet[i, r] = mas[j, 1];
                                    r++;
                                    break;
                                case 1:
                                    Console.Write(mas[j, 0]);
                                    otvet[i, r] = mas[j, 0];
                                    r++;
                                    break;
                            }
                        }
                    }
                }
                Console.WriteLine();
                r = 0;
            }
            Console.WriteLine();
            otvet2(otvet, v);
            Console.ReadKey();

            Console.WriteLine("Введите вершину графа, с которой нужно начать обход в ширину");
            int q = int.Parse(Console.ReadLine());
            List<int> visited = new List<int>();
            Queue<int> queue = new Queue<int>();
            visited.Add(q);
            Console.WriteLine(visited[visited.Count-1]);
            while (visited.Count-1 != 4)
            {
                for (int j = 0; j < 3; j++)
                {
                    int o = visited[visited.Count - 1];
                    if (otvet[visited[visited.Count - 1] - 1, j] == 0)
                    {
                        break;
                    }
                    else
                    {
                        queue.Enqueue(otvet[visited[visited.Count - 1] - 1, j]);
                    }
                }
                int l = 0;
                for (int w = 0; w < visited.Count; w++)
                {
                    if (visited[w]==queue.Peek())
                    {
                        queue.Dequeue();
                        break;

                    }
                    else
                    {
                        l++;
                    }
                    if (l == visited.Count)
                    {
                        visited.Add(queue.Dequeue());
                        Console.WriteLine(visited[visited.Count - 1]);
                        break;
                    }
                }
            }
        }
        
        static void otvet2(int[,] otvet, int v)
        {
            for (int j = 0; j < v; j++)
            {
                for (int w = 0; w < 10; w++)
                {
                    Console.Write(otvet[j, w] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
