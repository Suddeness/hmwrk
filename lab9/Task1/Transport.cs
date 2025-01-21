using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    internal class Transport
    {
        int price_perKM;
        int route_length;
        int fuel_price; 
        int service_price;

        public virtual void Set_data(int _price_perKM, int _route_length, int _fuel_price, int _service_price) 
        {
            this.price_perKM = _price_perKM;
            this.route_length = _route_length;
            this.service_price = _service_price;
            this.fuel_price = _fuel_price;
        }
        public virtual void Get_data() 
        {
            Console.WriteLine($"Price per kilometer: {price_perKM}$\nRoute length: {route_length}km\n" +
                $"Fuel price: {fuel_price}$\nService price {service_price}$");
        }
        public virtual int Net_profit() 
        {
            return (price_perKM*route_length)-(fuel_price+service_price);
        }
    }
}
