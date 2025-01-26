using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb10
{
    internal class Toys:Products
    {
        private string Gender;
        private string Type;
        private int Quantity;
        private int Age_limit;

        public Toys(string gender, string type, int quantity, int age_limit)
        {
            Gender = gender;
            Type = type;
            Quantity = quantity;
            Age_limit = age_limit;
        }
        public override void Residue()
        {               
            point1:
                Console.Write("average buyer's age (select number)\n 1-> 1-5; 2-> 5-10; 3-> 10-15; 4-> 15-18: ");
                if (int.TryParse(Console.ReadLine(), out int Pr))
                {
                    if (Pr == 1) { Pr = 5; }
                    else if (Pr == 2) { Pr = 10; }
                    else if (Pr == 3) { Pr = 15; }
                    else if (Pr == 4) { Pr = 18; }
                    else { Console.WriteLine("incorrect number!"); goto point1; }
                    Age_limit = (Pr + Age_limit) / 2;
                }
                else { Console.WriteLine("must be integer"); goto point1; }                              
            point2:
                Console.Write("how much product was sold: ");
                int Pr_sold;
                if (int.TryParse(Console.ReadLine(),out Pr_sold)){Pr = Pr_sold;} else{Console.WriteLine("must be integer");goto point2;}
                if (Pr_sold > Quantity)
                {
                    Console.Write("sold more than there are!\nif it a mistake press Y: ");
                    if (Console.ReadLine()?.ToLower() != "y") { Quantity = 0; goto point2;}
                }
                else
                {
                    int Per_cent = (int)Math.Round(Pr_sold / Convert.ToSingle(Quantity) * 100);
                    Quantity = Quantity - Pr_sold;
                    Console.Write($"sold {Per_cent}% ");
                    if (Per_cent < 35) { Console.WriteLine("low popularity"); }
                    else if (Per_cent < 60) { Console.WriteLine("medum popularity"); }
                    else { Console.WriteLine("high popularity"); }                   
                }           
            Console.WriteLine($"{Quantity} pieces left");
        }
        public override void Change_Data()
        {
            string[] names = { "Gender", "Type", "Quantity", "Age limit" };
            foreach (string name in names)
            {
                while (true)
                {
                    Console.Write($"Enter new data for \"{name}\"\nor leave blank (nothing will change):");
                    string? new_data = Console.ReadLine();
                    if (!string.IsNullOrEmpty(new_data))
                    {
                        if (name == "Quantity" || name == "Age limit")
                        {
                            if (int.TryParse(new_data, out int num))
                            {if (name == "Quantity") { Quantity = num; }
                             if (name == "Age limit") { Age_limit = num; }
                                break;}
                            else { Console.WriteLine($"{name} must be integer!"); }
                        }
                        else if (name == "Type") { Type = new_data; break; }
                        else if (name == "Gender") { Gender = new_data; break; }
                        else { Gender = new_data; break; }
                    }
                    else { break; }
                }
            }
            object[] prmtr = { Gender, Type, Quantity, Age_limit };
            for (int i = 0; i <= names.Length - 1; i++)
            {
                Console.WriteLine($"{names[i]}: {prmtr[i]}");
            }
        }
    }
}
