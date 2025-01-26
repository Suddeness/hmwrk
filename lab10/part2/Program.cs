using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb10
{
    class Program
    {
        static void Main(string[] args) 
        {
            Clothes newCl = new Clothes("red", "T-shirt", 12);
            newCl.Residue(); newCl.Change_Data();
            Console.WriteLine("\n\n");
            Toys newT = new Toys("-", "plush bunny", 7, 7);
            newT.Residue(); newT.Change_Data();
        }
    }
}
