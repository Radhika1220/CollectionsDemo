using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    /// <summary>
    /// Stack Operations
    /// </summary>
    public class Stack
    {
        public static void StackDemo()
        {
            Stack<int> myStack = new Stack<int>();
           // Pushing into stack
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            //Count returns number of elements present in stack
            Console.Write("\nNumber of elements in Stack: {0}\n", myStack.Count);
            //Contains-returns true if element is present
            Console.WriteLine("{0} is ",myStack.Contains(1));
            while (myStack.Count > 0)
            {
                //Pop the element and print it
                Console.Write(myStack.Pop() + " ");
            }

            Console.Write("\nNumber of elements in Stack: {0}\n", myStack.Count);

        }
    }
}
