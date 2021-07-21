using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    public class Queue
    {
        public static void QueueDemo()
        {
            Queue<string> colours = new Queue<string>();

            colours.Enqueue("Red");
            colours.Enqueue("Yellow");
            colours.Enqueue("Black");

           Console.WriteLine("\nQueue elements are :\n");
           foreach(var c in colours)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("\nTotal number of values in queue : " + colours.Count);
  
            string dequeue = colours.Dequeue();

            Console.WriteLine("\nDequeue element are :\n" + dequeue);

            Queue<string>.Enumerator enumerator = colours.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
