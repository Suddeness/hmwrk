/* Дано три одновимірні масиви, кожний із яких має довільну кількість елементів. 
 * Для кожного із них знайти суму і середнє арифметичне для елементів, значення яких 
 * знаходяться в заданому інтервалі. . Окрім функції main() застосувати дві функції. 
 * Одна – для введення елементів окремого масиву із клавіатури, а інша – для його аналізу 
 * з метою отримати потрібні результати.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace lb3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] result1 = Masiv();
            Analyz(result1);
        }
        static int[][] Masiv()
        {
            int[][] array = new int[3][];
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the size for array" + (i + 1));
                int size;
                while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                {     
                    Console.WriteLine("Invalid size, please enter a positive integer:");
                }
                array[i] = new int[size];

                Console.WriteLine("give values for array" + (i + 1) + ": ");
                string input = Console.ReadLine();
                array[i] = input.Split(' ').Select(int.Parse).ToArray();
            }
            return array;
        }
        static void Analyz(int[][] array)
        {
            Dictionary<int, int> newdict = new Dictionary<int, int>();
            int[] keys = new int[array.Length];
            int integra = 1;
         
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i].Sum();
                int value = key / array[i].Length;
                newdict[key] = value;
                keys[i] = key;
            }
            foreach (int key in keys) 
            {   
                
                int value = newdict[key];
                System.Console.WriteLine("masiv num " + integra + " sum: " + key + " arithmetic mean: " + value);
                integra ++;
            }
        }
        
    }
}

