using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int rem;
            while (num != 0)
            {
                rem = num % 10;
                num = num / 10;
                sum += rem;
            }
            Console.WriteLine(sum);
        }
    }
}
