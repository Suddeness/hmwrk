using System;

namespace Lb10
{
    internal class Program
    {
        static public void print (Liner cur, Liner prev, string tool, bool rs)
        {
            Console.WriteLine($"{cur.brand} {tool} {prev.brand} = {rs}");
        }
        static void Main(string[] args)
        {
            Liner[] n_array = new Liner[4];
            Liner l1 = new Liner("Ocean liner", 27, 60, 2000);
            Liner l2 = new Liner("Titanic", 50, 70, 2500);
            Liner l3 = new Liner("Queen Mary", 35, 65, 2200);
            Liner l4 = new Liner("Norwegian Pearl", 40, 80, 2400);
            n_array[0] = l1;
            n_array[1] = l2;
            n_array[2] = l3;
            n_array[3] = l4;

            Liner previous = null;
            foreach (Liner currently in n_array) 
            {

                if (previous is null) { previous = currently; }
                else
                {
                    print(currently, previous, "==", currently == previous);
                    print(currently, previous, "!=", currently != previous);
                    print(currently, previous, "<", currently < previous);
                    print(currently, previous, ">", currently > previous);
                    Console.WriteLine("\n");
                    previous = currently;
                }
            }
            int sum = (l1 + l2) + (l3+l4);
            Console.WriteLine($"price for all liners: {sum}");
        }
    }
}
