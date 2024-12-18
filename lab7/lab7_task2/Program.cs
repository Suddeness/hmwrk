using Lab7_task2;
using System;

namespace Lab7_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ships nship = new Ships(22, 10, 2, 12);
            nship.ShowData();
            
            SteamBoat newBoat = new SteamBoat(120, 42, 4, 20, "sometype", 500);
            newBoat.SBdata();

            Sailboats newSboat = new Sailboats(44, 13, 5, 11, 32, 2);
            newSboat.SLBdata();

            Сorvette newСorvette = new Сorvette(46, 15, 5, 11, "someWeapon", 4);
            newСorvette.CTdata();
        }
    }
}