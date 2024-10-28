using System;
using System.Collections.Generic;
using System.Text;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("вибрати програму 1-4");
            int choice = Convert.ToInt32(Console.ReadLine());
           
            switch (choice)
            {
                case 1:
                    Console.WriteLine("вибрати варіант first, second, third, all"); string variant = Console.ReadLine().ToLower(); 
                    Console.WriteLine("вибрати x "); float x = float.Parse(Console.ReadLine()); switch (variant)
                    {
                        case "first": float z = (float)Math.Pow(Math.Sin(x), 2);
                            Console.WriteLine($"Результат для first: {z}"); break;
                        case "second": float z11 = (float)Math.Pow(Math.Log(x), 2);
                            Console.WriteLine($"Результат для second: {z11}"); break;
                        case "third":; float z22 = (float)(1 / Math.Cos(Math.Pow(x, 3)));
                            Console.WriteLine($"Результат для third: {z22}"); break;
                        case "all":
                            float z1 = (float)Math.Pow(Math.Sin(x), 2);
                            float z2 = (float)Math.Pow(Math.Log(x), 2);
                            float z3 = (float)(1 / Math.Cos(Math.Pow(x, 3)));
                            Console.WriteLine($"Результат для first: {z1}");
                            Console.WriteLine($"Результат для second: {z2}");
                            Console.WriteLine($"Результат для third: {z3}"); ; break;
                    };break;
            }





        }

    }
}
 