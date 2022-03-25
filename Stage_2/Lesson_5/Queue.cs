using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_5
{
    internal class QueueClass
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();                               // Creates empty Queue

            string[] names = { "Arthur", "Armen", "Vardan", "Vahan", "David" };      // Creates string array
            Queue<string> queue1 = new Queue<string>(names);                         // Creates Queue that contains names array elements

            Queue<string> queue2 = new Queue<string>(5);                             // Creates empty Queue that has 5 range capacity


            // Queue.Count
            int count = queue.Count;                                                 // Returns Queue elements count
            Console.WriteLine($"Count: {count}");

            int count1 = queue1.Count;
            Console.WriteLine($"Count1: {count1}");

            int count2 = queue2.Count;
            Console.WriteLine($"Count2: {count2}");
            Console.WriteLine();


            // Queue.Enqueue
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            queue1.Enqueue("Karen");                                                 // Addes a string element at the end of Queue, that we give
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Queue.Dequeue
            queue1.Dequeue();                                                        // Removes the first element of the queue
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Queue.Contain
            bool isContains = queue1.Contains("Arthur");                              // Returns Queue contains element, that we give or not (if yes, returns true)
            Console.WriteLine($"Queue contains Arthur: {isContains}");
            Console.WriteLine();

            // Queue.Clear()
            //queue1.Clear();                                                         // Removes all elements from queue1


            // Queu.Peek
            string name = queue1.Peek();                                               // Returns the first element of queue1 without removing it
            Console.WriteLine(name);
            Console.WriteLine();
            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Queue.ToArray()
            Queue<string> queue1Elements = new Queue<string>(queue1.ToArray());         // Copies queue1 elements to a new array
            foreach (var item in queue1Elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
