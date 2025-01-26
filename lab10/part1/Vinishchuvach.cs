using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lb10
{
    internal class Vinishchuvach : Airplane
    {
        private int Speed;
        private int Seats;
        private int Power;
        private int Gun_num;
        public Vinishchuvach(int Speed, int Seats, int Power, int Gun_num)
        {
            this.Speed = Speed;
            this.Seats = Seats;
            this.Power = Power;
            this.Gun_num = Gun_num;
        }

        public override void Fly()
        {
            string Space = "                                                                      ";
            for (int i = 0; i < 10; i++)
            {   
                Console.Clear();
                Console.WriteLine($"{Space}                /---|               _____\n" +
                                  $"{Space}           ____/____|______________/- /> \\\n" +
                                  $"{Space}          /   /     |     '          /     \n" +
                                  $"{Space}- - -   <|  ()   ()   ()__|_________/\n" +
                                  $"{Space}         \\_____,_____,/'");
                Space = Space.Substring(0, Space.Length - 7);
                Thread.Sleep(200);
            }
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