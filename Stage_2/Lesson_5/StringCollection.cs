using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Stage_2.Lesson_5
{
    internal class StringCollection_class
    {
        static void Main()
        {
            StringCollection names = new StringCollection();    // Creates String Collection using default constructor


            // Adding Strings
            names.Add("Arthur Yegoryan");       // Adds string member to StringCollection at the end
            names.Add("Vardan Aslanyan");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            string[] names1 = { "Artyom Harutyunyan", "Artak Yepremyan", "Robert Zeynalyan" };
            names.AddRange(names1);             // Adds string array to StringCollection at the end
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            names.Insert(3, "Karen Gomkcyan");  // Adds string element to StrinCollection, at the index where we want
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Accessing Strings
            foreach (var item in names)         // Writing in Console StringCollection members
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Removing String
            //names.Clear();                    // Removes all elements from StringCollection

            names.Remove("Artak Yepremyan");    // Removes the first string member, that we give
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            names.RemoveAt(4);                  // Removes string element that is under the index that we give
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Find String
            int index = names.IndexOf("Vardan Aslanyan");       // Returns the string element index, that we give
            Console.WriteLine(index);

            bool isContains = names.Contains("Arthur Yegoryan");   // Returns if StringCollection contains that string member, that we give (if yes, returns true)
            Console.WriteLine(isContains);                         // True
            bool isContains1 = names.Contains("Suren Petrosyan");
            Console.WriteLine(isContains1);                        // False
            Console.WriteLine();


            // Copy Strings
            string[] namesList = new string[names.Count];          // Creates new string array for copiing StringCollection elements
            names.CopyTo(namesList, 0);                            // Copies StringCollection elements from 0 index and filles in namesList array
            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Count Strings
            int count = names.Count;             // Returns StringCollection elements count
            Console.WriteLine(count);


            // Getting Items
            string person = names[0];            // Returns the string element that is under the index, that we give
            Console.WriteLine(person);
        }
    }
}
