using System;

namespace Lb10
{
    internal class Liner
    {
        public string brand;
        private int passenger_num;
        private int speed;
        private int price;
     
        public Liner(string brand, int passenger_num, int speed, int price)
        {  
            this.brand = brand;
            this.passenger_num = passenger_num;
            this.speed = speed;
            this.price = price;
        }
        public static bool operator == (Liner a, Liner b)
        {
            if (ReferenceEquals (a, b)) return true;
            if (a is null || b is null) return false;
            return a.brand == b.brand &&
               a.price == b.price &&
               a.speed == b.speed &&
               a.passenger_num == b.passenger_num;
        }
        public static bool operator !=(Liner a, Liner b) => !(a == b);
        public static bool operator < (Liner a, Liner b) 
        {
            return (a.brand).Length < (b.brand).Length &&
                a.price < b.price && a.passenger_num < b.passenger_num &&
                a.speed < b.speed;
        }
        public static bool operator > (Liner a, Liner b) => !(a <  b);

        public static int operator +(Liner a, Liner b)
        {
            return a.price + b.price;    
        }
        public override bool Equals(object? obj)
        {
            if (obj is Liner other) { return this == other; }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(brand, passenger_num, speed, price);
        }
    }
}
