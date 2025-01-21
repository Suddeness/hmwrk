using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type2B");
            Type2B t2B = new Type2B();
            t2B.Set_data(80, 67, 70, true, false, true);
            t2B.Get_data(); Console.WriteLine("Status:"); t2B.Status();
            Console.WriteLine("\nType9S");
            Type9S t9S = new Type9S();
            t9S.Set_data(28, 80, 20, true, true, true); t9S.Get_data();
            Console.WriteLine("Status:"); t9S.Status();
        }
    }
}