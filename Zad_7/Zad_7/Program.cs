using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i <= n; i += 2)
            {
                result = (int)Math.Pow(2, i);
                Console.Write(result + ", ");
            }
        }
    }
}
