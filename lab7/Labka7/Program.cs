using System;

namespace Labka7
{
    class Program
    {
        static void Main(string[] args)
        {
            Ships newShip = new Ships("somename", "someAppointment", 22, 25, "someType");
            newShip.ShowData();

            Ac_carrier newAC = new Ac_carrier("somename", "someAppointment", 22, 24, "someType", "someAC", 30);
            newAC.ShowAC_Data();
            
            Ms_carrier newMS = new Ms_carrier("somename", "someAppointment", 22, 24, "someType", "someRocketType", 53);
            newMS.ShowMS_Data();            
        }
    }
}
