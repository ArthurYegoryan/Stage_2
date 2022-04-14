using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Stage_2
{    
    internal class Json_Format
    {
        static void Main()
        {
            MyClass myClass = new MyClass(20, "Arthur");

            string json = JsonSerializer.Serialize(myClass);     // Converts myclass to json format
            Console.WriteLine(json);

            var options = new JsonSerializerOptions        // Gives options to json format
            {
                WriteIndented = true,                      // Gives probels to the end of each line
                AllowTrailingCommas = true                 // Gives comma after the last element of json 
            };
            string json1 = JsonSerializer.Serialize(myClass, options);    // Gives options as parameter
            Console.WriteLine(json1);

            MyClass? antiJson = JsonSerializer.Deserialize<MyClass>(json);  // Converts json format to MyClass
            Console.WriteLine(antiJson?.Name);
            Console.WriteLine(antiJson?.Age);
            Console.WriteLine();

            MyClass1 myClass1 = new MyClass1(20, "Arthur");
            string json2 = JsonSerializer.Serialize(myClass1, options);
            Console.WriteLine(json2);
        }

        class MyClass
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public MyClass(int age, string name)
            {
                Age = age;
                Name = name;
            }
        }

        class MyClass1
        {
            [JsonIgnore]                           // Ignores the property on which we give the attribute
            public int Age { get; set; }
            [JsonPropertyName("FirstName")]        // Changes the property name on which we give the attribute
            public string Name { get; set; }
            public MyClass1(int age, string name)
            {
                Age = age;
                Name = name;
            }
        }
    }
}
