using System;

namespace Labka7
{
    //ракетоносець
    internal class Ms_carrier:Ships
    { 
        protected string typeOfRocket;
        protected int numOfRockets;

        public Ms_carrier(string _name, string _appointment, int _displacement, int _enginePower, 
            string _typeOfFuel, string _typeOfRocket, int _numOfRockets):
            base(_name, _appointment, _displacement, _enginePower, _typeOfFuel)
        {
            this.typeOfRocket = _typeOfRocket;
            this.numOfRockets = _numOfRockets;
        }
        public void ShowMS_Data()
        {
            Console.WriteLine($"type of rocket: {typeOfRocket}\nnumber of rockets: {numOfRockets}");
            base.ShowData();
        }
    }

}
