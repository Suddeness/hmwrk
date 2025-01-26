using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb10
{
    internal class Passenger : Airplane
    {
        private int Seats;
        private int Power;
        private bool Security_check;

        public Passenger(int Seats, int Power, bool Security_check)
        {
            this.Seats = Seats;
            this.Power = Power;
            this.Security_check = Security_check;
        }
        public override void Fly()
        {
            string space = "";
            if (Security_check)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"{space}_____              \\--------\\       \n" +
                                      $"{space} \\--\\             /-\\--------\\-----\\\n" +
                                      $"{space}  \\  \\-----------/ ()\\() () ()\\() ()\\_\n" +
                                      $"{space}   \\  : : : : : :   () () () () ()     |\n" +
                                      $"{space}    \\__________________________________/");
                    space +="      ";
                    Thread.Sleep(200);
                }
            }
            else { Console.WriteLine("security check failed flight impossible"); }
        }
        public override void Free_seats()
        {
            while (true)
            {
                Console.Write("how many people are already on the plane: ");
                string? alrdS = Console.ReadLine();
                if (alrdS == null) { break; }
                else if (int.TryParse(alrdS, out int num))
                {
                    Seats = Seats - num;
                    if (Seats < 0) { Seats = 0; }
                    break;
                }
                else { Console.WriteLine("must be integer!"); }
            }
            Console.WriteLine($"There are {Seats} seats left on the plane");
        }
    }
}
