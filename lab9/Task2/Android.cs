using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    internal class Android
    {
        int power; 
        int health;
        int damage;
        bool availability;

        public void Set_data(int power, int health, int damage, bool availability) 
        {
            if (power > 100)
            {
                this.power = 100;
            }
            else { this.power = power; }
            this.health = health;
            this.damage = damage;
            this.availability = availability;
        }
        public virtual void Get_data() 
        { Console.WriteLine($"power: {power}%\ndamage: {damage} on hit\n" +
            $"health: {health}\navailabilyty: {availability}"); 
        }
        public virtual bool Status()
        {
            bool readiness=true;
            if (power < 35)
            {
                if (power < 0) { Console.WriteLine("Discharged"); readiness = false;}
                Console.WriteLine($"low power ({power}%)");
            }
            if (health < 100)
            {
                if (health > 70) { Console.WriteLine("minor damage"); }
                else if (health > 40) { Console.WriteLine("moderate damage"); }
                else if (health > 0) { Console.WriteLine("сritical damage"); }
                else { Console.WriteLine("destroyed"); readiness = false;}
            }
            if (availability) { Console.WriteLine("access is available"); }
            else { Console.WriteLine("access denied"); readiness = false;}
            return readiness;
        }   
    }
}
