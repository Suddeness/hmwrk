using System;

namespace labka8
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Add_data();
            Show_data();
            Console.ReadKey();
        }

        static List<Outfit> outfits = new List<Outfit>();
        public static void Add_data()
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine($"you have already objects {n}\ncreate a new object or type \"exit\"");
                string[] fields = { "brand", "name", "gender", "material", "color", "price" };
                string[] values = new string[fields.Length];

                for (int i = 0; i < fields.Length; i++)
                {
                    while (true)   
                    {
                        Console.Write($"Enter {fields[i]}: ");
                        string input = Console.ReadLine();
                        if (input.ToLower() == "exit") { return; }
                        else if (fields[i] == "price")
                        {
                            if (int.TryParse(input, out int price))
                            {values[i] = price.ToString(); break; }
                            else
                            { Console.WriteLine("Price must be an integer.");}
                        }
                        else {values[i] = input.ToLower(); break;}

                    }
                }
                Outfit outfit = new Outfit();
                outfit.Set_data(values[0], values[1], values[2], values[3], values[4], int.Parse(values[5]));
                outfits.Add(outfit);
                n++;
            }
        }
        public static void Show_data()
        {
            string[] fields = { "brand", "name", "gender", "material", "color", "price" };
            string[] values = new string[fields.Length];
            Console.WriteLine("enter a parameter or skip");
            for (int i = 0; i < fields.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {fields[i]}: ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "skip") { values[i] = null; break; }
                    else if (fields[i] == "price")
                    {
                        if (int.TryParse(input, out int price))
                        { values[i] = price.ToString(); break; }
                        else
                        { Console.WriteLine("Price must be an integer."); }
                    }
                    else { values[i] = input; break; }
                }
            }
            foreach (var outfit in outfits)
            {
                object[] data = outfit.Get_data();
                bool m = true;
                for (int i = 0; i < data.Length; i++)
                { 
                    if (values[i] != null)
                    {
                        if (i == 5) { if (int.Parse(values[i]) < (int)data[i]) { m = false; break; } }
                        else if (values[i] != null && !data[i].ToString().Contains(values[i])) { m = false; break;}
                    } 
                }
                if (m)
                {
                    Console.WriteLine("this outfit corresponds all parameters");
                    for (int _ = 0; _ < data.Length; _++)
                    {
                        Console.WriteLine($"{fields[_]}: {data[_]}");
                    }
                }
            }
        }
    }
}
    
