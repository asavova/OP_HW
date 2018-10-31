using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void ReadInput(int[] arr,int length)
        {
           
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] customers = new int[n];

            ReadInput(customers, n);

            int workers = 7;
            int AllReturned = 0;
            int Returned=0;
            int Serviced = 0;
            int day = 1;
            while (n != 0)
            {
                
                int customersAday = customers[day - 1];
                if (day % 3 == 0 && Serviced < AllReturned)
                {
                    workers++;
                }
                
                if (customersAday-workers>=0)
                {
                    Returned = customersAday - workers;
                    Serviced += workers;
                }
                else if(customersAday - workers < 0)
                {
                    Returned = 0;
                    Serviced += customersAday;
                }
                
                AllReturned += Returned;

                day++;
                n--;
            }

            Console.WriteLine($"Serviced Customers: {Serviced}");
            Console.WriteLine($"Returned Customers: {AllReturned}");

        }
    }
}
