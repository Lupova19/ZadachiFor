using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Сумата на числата от 1 до 100 е: {sum}");
        }
    }
}
