using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_10
{
    class Program
    {
        static void ReadArr(int[,] Arr)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine($"A[{row + 1},{col + 1}] = ", row, col);
                    Arr[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void SortArr(int[,] Arr)
        {
            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 5; row++)
                {
                    int min = row;
                    for (int i = row + 1; i < 5; i++)
                    {
                        if (Arr[i, col] < Arr[min, col])
                        {
                            min = i;
                        }
                    }
                    int temp = Arr[min, col];
                    Arr[min, col] = Arr[row, col];
                    Arr[row, col] = temp;

                }
            }
        }
        static void PrintArr(int[,] Arr)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 4; col++)

                {
                    Console.Write(" " + Arr[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] Arr = new int[5, 4];
            
            Console.WriteLine($"A[5,4]");
            ReadArr(Arr);
            SortArr(Arr);
            PrintArr(Arr);

            for (int row = 0; row < 5; row++)
            {
                int sum = 0;
                for (int col = 0; col < 4; col++)
                {
                    sum += Arr[row, col];

                }
                Console.WriteLine($"Sum_sort_row_{row+1}={sum}");               
            }
        }
    }
}
