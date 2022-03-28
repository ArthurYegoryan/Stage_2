using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_5
{
    internal class StackClass                                         // Stack is a LIFO (last in first out) data structure
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();                // Creates empty Stack

            string[] items = { "Item1", "Item2", "Item3", "Item4" };
            Stack<string> stack1 = new Stack<string>(items);          // Stack stack1 copies elements from items array

            Stack<string> stack2 = new Stack<string>(5);              // Creates empty Stack that has 5 range capacity


            // Stack Count
            int count = items.Count();
            Console.WriteLine($"Count of stack1 elements: {count}");  // Returns count of stack1 elements
            Console.WriteLine();


            // Stack Add (push)
            stack1.Push("Item5");                                     // Addes a new element at the top (end) of Stack
            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Stack Remove (pop)
            stack1.Pop();                                             // Removes last element of Stack from top (end)
            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Get items
            string itemTop = stack1.Peek();                           // Returns last element of Stack (top) without removing it
            Console.WriteLine(itemTop);
            Console.WriteLine();
            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Stack Contain
            bool isContain = stack1.Contains("item2");                // Returns if items Stack contain element that we give (if yes, returns true)
            Console.WriteLine(isContain);                             // False
            bool isContain1 = stack1.Contains("Item2");
            Console.WriteLine(isContain1);                            // True


            // Stack Clear
            //stack1.Clear();                                         // Removes all elements from stack1 Stack            
        }
    }
}*/
