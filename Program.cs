using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int count = 0;
            bool found = false;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magic)
                    {
                        firstNumber = i;
                        secondNumber = j;
                        found = true;
                    }
                    count++;
                }
            }
            if (found)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magic}");
            } else
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
