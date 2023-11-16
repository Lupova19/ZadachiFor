using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Таблица с числото {i}");
                for (int l = 1; l <= 10; l++)
                {
                    Console.Write($"|{i * l}");
                }
                Console.WriteLine();
            }
        }
    }
}
