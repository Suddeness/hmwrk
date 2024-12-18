using System;
using System.Xml.Linq;

namespace Lab7_task2
{
    //парусник
    internal class Sailboats : Ships
    {
        protected int height;
        protected int numOfSails;

        public Sailboats(int _length, int _wight, int _draft, int _loadCapacity, 
            int _height, int _numOfSails, string _type = "Sailboats") :
            base(_length, _wight, _draft, _loadCapacity, _type)
        {
            this.height = _height;
            this.numOfSails = _numOfSails;
        }

        public void SLBdata()
        {
            if (height >= (length / width) * 2) { Console.WriteLine("this sailboat needs to be checked for stability"); }
            Console.WriteLine($"height:{height}\nnumber of sails:{numOfSails}");
            base.ShowData();
        }
    }
}
