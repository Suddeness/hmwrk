using System;
using System.Collections.Generic;

namespace labka8
{
    internal class Outfit
    {
        private string brand;
        private string name;
        private string gender;
        private string material;
        private string color;
        private int price;

        public void Set_data(string brand, string name, string gender, string material, string color, int price)
        {
            this.brand = brand.ToLower();
            this.name = name.ToLower();
            this.gender = gender.ToLower();
            this.material = material.ToLower();
            this.color = color.ToLower();
            this.price = price;
        }

        public object[] Get_data()
        {
            return new object[] { brand,name,gender,material,color,price};
        }
    }

  
}
