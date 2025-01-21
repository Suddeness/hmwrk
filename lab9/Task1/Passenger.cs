using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lb9
{
    internal class Passenger:Transport
    {
        int passengers_num;
        int seat_price;

        public override void Get_data()
        {
            base.Get_data();
            Console.WriteLine($"number of passengers: {passengers_num}\n" +
                $"price per seat: {seat_price}");
        }
        public new void Set_data(int _price_perKM, int _route_length, int _fuel_price, int _service_price, int _passengers_num, int _seat_price)
        {
            base.Set_data(_price_perKM, _route_length, _fuel_price, _service_price);
            this.passengers_num = _passengers_num;
            this.seat_price = _seat_price;
        }
        public override int Net_profit()
        {
            return base.Net_profit()+(passengers_num*seat_price);
        }
    }
}
