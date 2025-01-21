using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    internal class Type2B:Android
    {
        bool guns_ready;
        bool skills_ready;
        public void Set_data(int power, int health, int damage, bool availability, bool guns_ready, bool skills_ready)
        {
            base.Set_data(power, health, damage, availability);
            this.guns_ready = guns_ready;
            this.skills_ready = skills_ready;
        }
        public override void Get_data()
        {
            base.Get_data();
            Console.WriteLine($"guns ready: {guns_ready}\nskills ready: {skills_ready}");
        }
        public override bool Status()
        {
            Console.WriteLine("Type 9B (Battle)");
            if (!base.Status()) { Console.WriteLine("unpreparedness for mission"); return false; }
            base.Status();
            if (guns_ready && skills_ready)
            {
                Console.WriteLine("ready for mission");
            }
            else 
            {
                if (guns_ready) { Console.WriteLine("skills not ready"); }
                else if (skills_ready) { Console.WriteLine("guns not ready"); }
                else { Console.WriteLine("complete unpreparedness for mission"); }
            }        
            return true;
        }
    }
}
