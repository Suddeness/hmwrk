using System;

namespace Lab7_task2
{
    //пароплав
    internal class SteamBoat:Ships
    {
        string engineType;
        int enginePower;

        public SteamBoat(int _length, int _wight, int _draft, int _loadCapacity, 
            string _engineType, int _enginePower, string _type = "SteamBoat"):
            base(_length, _wight, _draft, _loadCapacity, _type)
        { 
            enginePower = _enginePower;
            engineType = _engineType;
        }
        public void SBdata() 
        { 
            if (width > 40)
            {
                Console.WriteLine("width more than 40\nunloading of the boat is impossible");
            }
            Console.WriteLine($"engine type: {engineType}\nengine power: {enginePower}");
            base.ShowData();
        }

    }
}
