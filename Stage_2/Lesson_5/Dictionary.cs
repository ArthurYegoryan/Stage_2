using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2
{
    internal class Dictionary
    {
        static void Main()
        {
            Dictionary<int, string> people = new Dictionary<int, string>();   // Empty dictionary,   key type - int,   value type - string
            
            var people1 = new Dictionary<int, string>()      // Creating dixtionary people1   (key, value)
            {
                { 1, "Arthur" },
                { 2, "Armen" },
                { 3, "Karen" }
            };
            foreach (var person in people1)
            {
                Console.WriteLine($"ID: {person.Key}, Name: {person.Value}");     // Typing key-values of people1
            }

            var people2 = new Dictionary<int, string>()
            {
                [1] = "Vahe",                               // We can create dictionary key-values in this form, it is the same as in people1
                [2] = "Vardan",
                [3] = "Vahan"
            };

            string person1 = people2[1];                    // Getting value of key 1
            Console.WriteLine($"Person1: {person1}");

            people2[1] = "David";                           // Changing value of key 1
            Console.WriteLine($"Person1: {people2[1]}");

            people2[4] = "Arsen";                           // Adding a new element
            Console.WriteLine($"Person4: {people2[4]}");

            var people3 = new KeyValuePair<int, string>(4, "Tigran");   // Creting one Key-Value Pair


            
            var personInfo = new Dictionary<int, string>();

            personInfo.Add(1, "Arthur");                    // Adding element in personInfo Dictionary
            Console.WriteLine(personInfo[1]);

            //personInfo.Clear();                           // Clearing personInfo Dictionary
            //Console.WriteLine(personInfo[1]);  // Error

            bool a = personInfo.ContainsKey(1);             // Checking personInfo Dictionary contains 1 key or not (if yes, we will get true)
            Console.WriteLine(a);                // True
            bool aa = personInfo.ContainsKey(10);
            Console.WriteLine(aa);               // False

            bool b = personInfo.ContainsValue("Arthur");    // Checking personInfo Dictionary contains "Arthur" value or not (if yes, we will get true)
            Console.WriteLine(b);                // True
            bool bb = personInfo.ContainsValue("Arthur1");
            Console.WriteLine(bb);               // False

            personInfo.Add(2, "Vardan");
            bool c = personInfo.Remove(2);                  // Removing personInfo element with 2 key, (if ok, we will get true)
            Console.WriteLine(c);                // True

            personInfo.Add(3, "Vahan");                     // Removing personInfo element with 2 key, (if ok, we will get true)
            string name;
            bool cc = personInfo.Remove(3, out name);
            Console.WriteLine(cc);               // True
            Console.WriteLine(name);             // Vahan

            string name1;
            bool d = personInfo.TryGetValue(1, out name1);  // Returns the value of key 1 (if ok, we will get true)
            Console.WriteLine(d);                // True
            Console.WriteLine(name1);            // Arthur

            bool e = personInfo.TryAdd(4, "David");         // Trying to add new key value (if ok, we will get true)
            Console.WriteLine(e);                // True
            bool ee = personInfo.TryAdd(1, "Armen");        // It will return false, because key 1 already exist
            Console.WriteLine(ee);               // False

            int count = personInfo.Count;                   // Returns personInfo Dictionary elements (key - values) count
            Console.WriteLine(count);            // 2
        }        
    }
}
