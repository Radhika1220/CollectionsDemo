using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    /// <summary>
    /// SortedList-{Key,value} Pair
    /// Key does not accept null and duplicate values
    /// </summary>
    public class SortedList
    {
        public static void SortedListDemo()
        {
            string res;
            //SortedList
            SortedList<int, string> names = new SortedList<int, string>();
            //Adding elements to sortedlist
            names.Add(1, "Radhika");
            names.Add(2, "Priya");
            names.Add(3, "Praveena");
            names.Add(4, null);

            foreach (KeyValuePair<int, string> kvp in names)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }

            //ContainsKey-Checks the particular key is present or not.If present,the particular key element gets updated.
            if (names.ContainsKey(4))
            {
                names[4] = "Sumathi";
            }


            //TryGetValue-Gets the value associated with the specified key.

            if (names.TryGetValue(4, out res))
            {

                Console.WriteLine("Key: {0}, value: {1}", 4, res);
            }
        }

    }
} 

