using System;

namespace Lab7_task2
{
    //корвет
    internal class Сorvette:Ships
    {
        private string weaponsType;
        private int weaponsNumber;

        public Сorvette(int _length, int _wight, int _draft, int _loadCapacity, string _weaponsType, 
            int _weaponsNumber, string _type = "Сorvette") :
            base(_length, _wight, _draft, _loadCapacity, _type)
        { 
            this.weaponsType = _weaponsType;
            this.weaponsNumber = _weaponsNumber;
        }

        public void CTdata()
        {
            Console.Write("this data is secret\nenter a password: ");
            string password = Console.ReadLine();
            if (password == "12345")
            {
                Console.WriteLine($"weapons type: {weaponsType}\nweapons nmber: {weaponsNumber}");
                base.access = true;
                base.ShowData();
            }
            else { Console.WriteLine("password is incorrect"); }
        }
    }
}
