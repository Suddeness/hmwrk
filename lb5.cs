using System;
namespace lb5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Moto[] motos = new Moto[3]; 

          
            motos[0] = new Moto();
            motos[0].add_data("Yamaha", "Gasoline", 100, 15000);

            motos[1] = new Moto();
            motos[1].add_data("Honda", "Electric", 120, 18000);

            motos[2] = new Moto();
            motos[2].add_data("Suzuki", "Diesel", 80, 12000);

          
            Moto.analyzer(motos);
        }
    }

    class Moto
    {
        private string mark;
        private string fuel;
        private int power;
        private int price;

        public void add_data(string mark, string fuel, int power, int price)
        {
            this.mark = mark;
            this.fuel = fuel.ToLower(); 
            this.power = power;
            this.price = price;
        }
        public static void analyzer(Moto[] args)
        {
            Console.WriteLine("enter fuel: ");
            string user_fuel = Console.ReadLine().ToLower();
            Console.WriteLine("enter power: ");
            int user_power = int.Parse(Console.ReadLine());
            bool n = true;
            foreach (Moto moto in args)
            {
                if (moto.an(user_fuel, user_power))
                {
                    moto.show();
                    n = false;
                }
            }
            if (n){ Console.WriteLine("no suitable"); }
        }
        private bool an (string us_fl, int us_pw)
        {
            return us_fl == fuel && us_pw <= power;
        }
        private void show() {
            Console.WriteLine($"Mark: {mark}, Fuel: {fuel}, Power: {power}, Price: {price}");
        }
    }
}
