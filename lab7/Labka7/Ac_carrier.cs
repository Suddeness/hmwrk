using System;

namespace Labka7
{
    //авіаносець
    internal class Ac_carrier:Ships
    {
        protected string aircraft;
        protected int numOfAircraft;

        public Ac_carrier(string _name, string _appointment, int _displacement, int _enginePower, 
            string _typeOfFuel, string _aircraft, int _numOfAircraft):
            base(_name, _appointment, _displacement, _enginePower, _typeOfFuel)
        {        
            this.aircraft = _aircraft;
            this.numOfAircraft = _numOfAircraft;
        }
        public void ShowAC_Data()
        {
            Console.WriteLine($"aircraft: {aircraft}\nnumber of aircraft: {numOfAircraft}");
            base.ShowData();
        }
    }
}
