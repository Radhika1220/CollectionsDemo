using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    /// <summary>
    /// Collection-List Demo
    /// </summary>
    public class List
    {
        public static void ListDemo()

        {
            //Initializing the list
            var cities = new List<string>();

            //Array with 3 string elements
            string[] popularCities = new string[3] { " San fransico", " Germany", "Manchester" };

            //Addding elements to list
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("France");

            //Accessing the list
            Console.WriteLine("\nCities list are :\n");
            foreach(var c in cities)
            {
                Console.WriteLine("The cities are : {0} ", c);
            }

            //AddRange-Adding range of elements(like array)
            cities.AddRange(popularCities);
            Console.WriteLine("\nAfter adding more cities list are :\n ");
            foreach (var c in cities)
            {
                Console.WriteLine("The cities are : {0} ", c);
            }

        }
    }
}