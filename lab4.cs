using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Diagnostics;

namespace lb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine(" ");
            Task2();
            Console.WriteLine(" ");
            Task3();
        }
        /*Визначити  два одновимірних масиви із довільною кількістю елементів,
        значення як их отримувати за допомогою генератора випадкових чисел.
        Перший масив зросту співробітників в сантиметрах,
        а другий – відповідна їхня вага в кілограмах.
        Зріст і вага  повинні знаходитися в заданих межах.
        Відсортувати їх в порядку зростання зросту і результати вивести на екран.
        Кількість елементів ввести із клавіатури. */

        static void Task1()
        {
            Console.WriteLine("Task1, введiть кiлькiсть елементiв у списках");
            short choice = Convert.ToInt16(Console.ReadLine());
            int[] masiv1 = new int[choice];
            int[] masiv2 = new int[choice];
            Random rnd = new Random();
            int rndnum2;
            for (int i = 0; i < choice; i++)
            {
                int rndnum1 = rnd.Next(160, 191);
                masiv1[i] = rndnum1;
                if (rndnum1 > 175)
                {
                    rndnum2 = rnd.Next(50, 77);
                }
                else
                {
                    rndnum2 = rnd.Next(60, 91);
                }
                masiv2[i] = rndnum2;
            }
            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine("person " + (i + 1) + ": " + masiv1[i] + "см " + masiv2[i] + "кг");

            }
            Array.Sort(masiv1); Array.Sort(masiv2);
            Console.WriteLine("sorted array 1: " + string.Join(", ", masiv1));
            Console.WriteLine("sorted array 2: " + string.Join(", ", masiv2));
        }
        /* Придумати власний приклад задачі, для розв’язання якої потрібно застосувати сортування за участю двох  одновимірних масивів.
        У магазині продаються різні товари. Кожен товар має ціну та рейтинг. 
        Потрібно відсортувати товари за рейтингом у порядку спадання, при цьому, 
        щоб ціна відповідного товару залишалася на своєму місці.
            Опис завдання: У нас є два масиви:
            Перший масив – це масив цін товарів.
            Другий масив – це масив рейтингів товарів */
        static void Task2()
        {
            short[] prices = { 100, 50, 200, 150 };
            float[] ratings = { 4.5f, 3.8f, 4.9f, 4.2f };
            var sortirovka = prices.Zip(ratings, (price, rating) => new {Price = price, Rating = rating}).OrderBy(x => x.Rating).ToArray();
            short[] sortprice = sortirovka.Select(x => x.Price).ToArray();
            float[] sortrait = sortirovka.Select(x => x.Rating).ToArray();
            Console.WriteLine("Task 2, Before: ");
            Console.WriteLine("prices: " + string.Join ("| ", prices));
            Console.WriteLine("ratings: " + string.Join("| ", ratings));
            Console.WriteLine("After:");
            for (int i = 0;i < sortprice.Length; i++)
            {
                Console.WriteLine("rating: " + sortrait[i] + ". price:" + sortprice[i]);
            }   
        }
        /* Придумати задачу, для розв’язання якої потрібне сортування в порядку зменшення.
        список студентів з їхніми іменами та підсумковими оцінками. 
        Потрібно відсортувати студентів за підсумковими оцінками в порядку зменшення, 
        щоб на першому місці був студент із найвищою оцінкою.*/
        static void Task3()
        {
            string[] students = { "Артур", "София", "Даниэль", "Ева", "Марк" };
            short[] grades = { 2, 3, 4, 5, 1 };
            var sort = grades.Zip(students, (grade, student) => new { Grade = grade, Student = student }).OrderBy(x => x.Grade).ToArray();
            string[] sortstd = sort.Select(x => x.Student).Reverse().ToArray();
            short[] sortgrad = sort.Select(x => x.Grade).Reverse().ToArray();
            Console.WriteLine("Task 3, Before: ");
            Console.WriteLine("prices: " + string.Join("| ", students));
            Console.WriteLine("ratings: " + string.Join("| ", grades));
            Console.WriteLine("After:");
            for (int i = 0; i < sortstd.Length; i++)
            {
                Console.WriteLine("student: " + sortstd[i] + " --> " + sortgrad[i]);
            }

        }
    }
}

