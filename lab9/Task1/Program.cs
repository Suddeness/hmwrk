using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Type Passenger");
            Passenger passenger = new Passenger();
            passenger.Set_data(5,20,30,15,10,2);
            passenger.Get_data();
            Console.WriteLine($"Net profit: {passenger.Net_profit()}\n");
            Console.WriteLine("Type Freight");
            Freight freight = new Freight();
            freight.Set_data(5, 120, 1500, 370, 1000, 20);
            freight.Get_data();
            Console.WriteLine($"Net profit: {freight.Net_profit()}");
        }
    }
}
