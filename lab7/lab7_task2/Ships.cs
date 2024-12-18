using System;

namespace Lab7_task2
{
    //корабль
    internal class Ships
    {
        protected string type;
        protected int length;
        protected int width;
        protected int draft;
        protected int loadCapacity;
        protected bool access = false;
        public Ships() { }
        public Ships(int _length, int _wight, int _draft,int _loadCapacity,string _type="Boat") 
        {
            InputData(_type, _length, _wight, _draft, _loadCapacity);
        }
        public void InputData(string _type,int _length, int _wight, int _draft, int _loadCapacity)
        {
            this.type = _type;
            this.length = _length;
            this.width = _wight;
            this.draft = _draft;
            this.loadCapacity = _loadCapacity;
        }
        public void ShowData()
        {
            if (type == "Сorvette")
            {
                if (access == false) 
                {
                    Console.WriteLine("access denied");
                    return;
                }
            }
            Console.WriteLine($"name: {type}\nlenght: {length}\nwight: {width}\ndraft: {draft}\nload capacity: {loadCapacity}\n");           
        }
    }
}
