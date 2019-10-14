using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS //
            int[] ints = new int[10];
            for(int i = 0; i < 10; i++) 
            {
                ints[i] = i;
            }

            string[] strings = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            bool[] bools = new bool[10];
            for(int j = 0; j < 10; j++)
            {
                if(j % 2 == 0)
                {
                    bools[j] = true;
                }
                else
                {
                    bools[j] = false;
                }
            }

            // LISTS //
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Cookies n' Cream");
            flavors.Add("Pistachio");
            flavors.Add("Rocky Road");
            Console.WriteLine($"Length of flavors is {flavors.Count}");
            Console.WriteLine($"The third flavor is {flavors[3]}");

            // DICTIONARIES //
            
        }
    }
}
