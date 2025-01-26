using Lb10;
using System;

namespace LB10
{
    class Program
    {
        static void Main()
        {
            Vinishchuvach new_vin = new Vinishchuvach(130, 7, 1000, 4);
            new_vin.Fly(); new_vin.Free_seats();
            Thread.Sleep(1000);
            Passenger new_pas = new Passenger(30, 1000, true);
            new_pas.Fly(); new_pas.Free_seats();

        }
    }
}