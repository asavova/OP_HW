using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());
            int ThirdNum = int.Parse(Console.ReadLine());
            

            if (FirstNum == SecondNum + ThirdNum)
            {               
                Console.WriteLine($"{Math.Min(SecondNum, ThirdNum)} + {Math.Max(SecondNum, ThirdNum)} = {FirstNum}");
            }

            else if (SecondNum == ThirdNum + FirstNum)
            {               
                Console.WriteLine($"{Math.Min(FirstNum, ThirdNum)} + {Math.Max(FirstNum, ThirdNum)} = {SecondNum}");
            }

            else if (ThirdNum == SecondNum + FirstNum)
            {              
                Console.WriteLine($"{Math.Min(FirstNum, SecondNum)} + {Math.Max(FirstNum, SecondNum)} = {ThirdNum}");
            }
            else Console.WriteLine("No");
        }
    }
}
