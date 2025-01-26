using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb10
{
    internal class Clothes:Products
    {

        private string Collor;
        private string Type;
        private int Quantity;
        
        public Clothes(string Collor, string Type, int Quantity) 
        { 
            this.Collor = Collor;
            this.Type = Type;
            this.Quantity = Quantity;
        }
        public override void Residue()
        {
            while (true)
            {
                Console.Write("how much product was sold: ");
                try
                {
                    int Pr_sold = int.Parse(Console.ReadLine());
                    if (Pr_sold > Quantity)
                    {                       
                        Console.Write("sold more than there are!\nif it a mistake press Y: ");
                        if (Console.ReadLine()?.ToLower() != "y") {Quantity = 0;break;}                                                          
                    }
                    else
                    {                      
                        int Per_cent = (int)Math.Round(Pr_sold / Convert.ToSingle(Quantity) * 100);
                        Quantity = Quantity - Pr_sold;
                        Console.Write($"sold {Per_cent}% ");
                        if (Per_cent < 35) { Console.WriteLine("low popularity"); }
                        else if (Per_cent < 60) { Console.WriteLine("medum popularity"); }
                        else { Console.WriteLine("high popularity"); }                       
                        break;
                    }
                    
                }
                catch (FormatException) { Console.WriteLine("Must be integer, pls try again"); }
            }
            Console.WriteLine($"{Quantity} pieces left");
        }
        public override void Change_Data()
        {
            string[] names = { "Collor", "Type", "Quantity" } ;
            foreach (string name in names)
            {
                while (true)
                {
                    Console.Write($"Enter new data for \"{name}\"\nor leave blank (nothing will change):");
                    string? new_data = Console.ReadLine();
                    if (!string.IsNullOrEmpty(new_data))
                    {
                        if (name == "Quantity")
                        {
                            if (int.TryParse(new_data, out int num))
                            { Quantity = num; break; }
                            else { Console.WriteLine($"{name} must be integer!"); }
                        }
                        else if (name == "Type") { Type = new_data; break; }
                        else { Collor = new_data; break; }
                    }
                    else {break;}
                }
            }
            object[] prmtr = { Collor, Type, Quantity };
            for (int i=0; i <= names.Length-1; i++)
            {
                Console.WriteLine($"{names[i]}: {prmtr[i]}");
            }
        }    
    }
}
