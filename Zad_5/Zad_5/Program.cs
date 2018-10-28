using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint[] customers = new uint[n];
            for (int i = 0; i < n; i++)
            {
                customers[i] = uint.Parse(Console.ReadLine());
            }

            uint workers = 7;
            uint AllReturned = 0;
            uint Returned = 0;
            uint Serviced = 0;
            int br = 1;
            while (n > 0)
            {
                if (br % 3 == 0 && Serviced < Returned) {  workers++; }
                Returned = (uint)Math.Abs(customers[br - 1] - workers);
                AllReturned += Returned;
                Serviced += workers;
                br++;
                n--;
            }

            Console.WriteLine($"Serviced Customers: {Serviced}");
            Console.WriteLine($"Returned Customers: {AllReturned}");

        }
    }
}
