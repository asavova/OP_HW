using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void ReadInput(uint[] arr,uint length)
        {
           
            for (uint i = 0; i < length; i++)
            {
                arr[i] = uint.Parse(Console.ReadLine());
            }
        }
        
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint[] customers = new uint[n];

            ReadInput(customers, n);

            uint workers = 7;
            uint AllReturned = 0;
            uint Returned=0;
            uint Serviced = 0;
            uint day = 1;
            while (n != 0)
            {
               
                if (day % 3 == 0 && Serviced < AllReturned)
                {
                    workers++;
                }
                Returned = customers[day - 1] - workers; //assuming the value of customers is greater than or equal to workers               
                Serviced += workers;
                AllReturned += Returned;

                day++;
                n--;
            }

            Console.WriteLine($"Serviced Customers: {Serviced}");
            Console.WriteLine($"Returned Customers: {AllReturned}");

        }
    }
}
