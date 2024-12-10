using System;
using System.Linq.Expressions;
namespace lb6
{
    class Lab6
    {
        static void Main(string[] args)
        {
            string line1 = "line1";
            string line2 = "line2";
            //1.	Об’єднання рядків
            Console.WriteLine("1." + line1 + " " + line2);
            //2.	Вставлення рядків;
            string res = line1.Insert(3, line2);
            Console.WriteLine("2."+res);
            //3.	Заміна рядків;
            res = res.Replace("line", "lent");
            Console.WriteLine("3."+res);
            //4.	Вилучення рядків;
            Console.WriteLine("4." + line2.Remove(2,3));
            //5.	Порівняння двох рядків;
            Console.WriteLine("5." + string.Equals(line1, line2)); 
            //6.	Порівняння символів із двох рядків, які знаходяться на певних місцях;
            Console.WriteLine("6." + string.Equals(line1[0], line2[0]));
            //7.	Визначення індексу першого входження  заданого рядка в інший. 
            Console.WriteLine("7." + line1.IndexOf("e"));
            example_prog();
        }
        static void example_prog()
        {
            Console.WriteLine("write your text");
            string usertxt = Console.ReadLine() ?? "example text";
            while (true)
            {
                try
                {
                    Console.WriteLine("write number what you want to do: (1->add txt, 2->replace txt, 3->delete word)");
                    byte userch = Convert.ToByte(Console.ReadLine());
                    string sectxt;
                    if (userch == 1)
                    {
                        Console.WriteLine("write text which you want to add");
                        sectxt = Console.ReadLine() ?? "second txt";
                        usertxt = usertxt + " " + sectxt;
                    }
                    else if (userch == 2)
                    {
                        Console.WriteLine("write text for replace");
                        sectxt = Console.ReadLine() ?? "second txt";
                        usertxt = sectxt + " (replaced)";
                    }
                    else if (userch == 3)
                    {
                        Console.WriteLine("write word when you want delete");
                        sectxt = Console.ReadLine() ?? "txt";
                        short n1 = Convert.ToInt16(usertxt.IndexOf(sectxt));
                        if (n1 == -1) { Console.WriteLine("this word no find"); }
                        else { usertxt = usertxt.Remove(n1, sectxt.Length); }
                    }
                    else { Console.WriteLine("incorrect number"); }

                    Console.WriteLine(usertxt);
                    Console.WriteLine("if you want contining enter Y:");
                    string? ch = Console.ReadLine()?.ToLower();
                    if (ch != "y") { break; }
                   
                }
                catch (FormatException) { Console.WriteLine("incorrect value"); }


            }
        }
    }
}
