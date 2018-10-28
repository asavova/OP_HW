using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int result = N;
            for (int i = N - 1; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine($"{N}! = {result}");
        }
    }
}
