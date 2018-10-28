using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_9
{
    class Program
    {
        static void Sort(int[] Arr)
        {
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[j] > Arr[max])
                    {
                        max = j;
                    }
                }

                int temp = Arr[max];
                Arr[max] = Arr[i];
                Arr[i] = temp;
            }

        }

        static void Main(string[] args)
        {
            var Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Sort(Arr);
            Console.WriteLine($"{String.Join(" ", Arr)}");
            Console.WriteLine($"min: {Arr[Arr.Length - 1]}");
        }
    }
}
