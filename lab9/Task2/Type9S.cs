using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{

    internal class Type9S : Android
    {
        bool scan_ready;
        bool emp_ready;

        public void Set_data(int power, int health, int damage, bool availability, bool scan_ready, bool emp_ready)
        {
            base.Set_data(power, health, damage, availability);
            this.scan_ready = scan_ready;
            this.emp_ready = emp_ready;
        }
        public override void Get_data()
        {
            base.Get_data();
            Console.WriteLine($"scan ready: {scan_ready}\nEMP ready: {emp_ready}");
        }
        public override bool Status()
        {
            Console.WriteLine("Type 9S (Support)");
            if (!base.Status()){Console.WriteLine("unpreparedness for mission");return false;}
            base.Status();
            if (scan_ready && emp_ready) {Console.WriteLine("ready for mission");}
            else
            {
                if (scan_ready) { Console.WriteLine("EMP not ready"); }
                else if (emp_ready) { Console.WriteLine("scan not ready"); }
                else { Console.WriteLine("complete unpreparedness for mission"); }
            }
            return true;
        }
    }

}
