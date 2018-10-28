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
            int Sum = 0;

            if (FirstNum == SecondNum + ThirdNum)
            {
                Sum = FirstNum;
                Console.WriteLine($"{Math.Min(SecondNum, ThirdNum)} + {Math.Max(SecondNum, ThirdNum)} = {Sum}");
            }

            else if (SecondNum == ThirdNum + FirstNum)
            {
                Sum = SecondNum;
                Console.WriteLine($"{Math.Min(FirstNum, ThirdNum)} + {Math.Max(FirstNum, ThirdNum)} = {Sum}");
            }

            else if (ThirdNum == SecondNum + FirstNum)
            {
                Sum = ThirdNum;
                Console.WriteLine($"{Math.Min(FirstNum, SecondNum)} + {Math.Max(FirstNum, SecondNum)} = {Sum}");
            }
            else Console.WriteLine("No");
        }
    }
}
