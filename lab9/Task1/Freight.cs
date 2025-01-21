using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    internal class Freight:Transport
    {
        int products_quantityKg;
        int kg_price;

        public new void Set_data(int _price_perKM, int _route_length, int _fuel_price, int _service_price, int _product_quantityKg, int _kg_price)
        {
            base.Set_data(_price_perKM, _route_length, _fuel_price, _service_price);
            this.products_quantityKg = _product_quantityKg;
            this.kg_price = _kg_price;
        }

        public override void Get_data()
        {
            base.Get_data();
            Console.WriteLine($"Product quantity {products_quantityKg}kg\nprice for kg: {kg_price}$");
        }

        public override int Net_profit()
        {
            return base.Net_profit()+(products_quantityKg*kg_price);
        }

    }
    
}
