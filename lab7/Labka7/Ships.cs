using System;


namespace Labka7
{
    //корабель
    internal class Ships
    {
        protected string name;
        protected string appointment;
        protected int displacement;
        protected int enginePower;
        protected string typeOfFuel;

        public Ships(string _name, string _appointment, int _displacement, int _enginePower, string _typeOfFuel)
        {
            InputData(_name, _appointment, _displacement, _enginePower, _typeOfFuel);
        }
        public Ships() { }
        public void InputData(string _name, string _appointment, int _displacement, int _enginePower, string _typeOfFuel)
        {
            this.name = _name;
            this.appointment = _appointment;
            this.displacement = _displacement;
            this.enginePower = _enginePower;
            this.typeOfFuel = _typeOfFuel;
        }

        public void ShowData()
        {
            Console.WriteLine($"name: {name}\nappointment: {appointment}\ndisplacement: {displacement}\nengine power: " +
                $"{enginePower}\ntype of fuel: {typeOfFuel}\n");
        }
    }
}