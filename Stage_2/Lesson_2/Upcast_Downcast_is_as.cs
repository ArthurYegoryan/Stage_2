using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_2
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string company, string name) : base(name)
        {
            Company = company;
        }
    }

    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string bank, string name) : base(name)
        {
            Bank = bank;
        }
    }

    internal class Upcast_Downcast
    {
        static void Main()
        {
            Employee employee = new Employee("FPS", "Arthur");
            Person person = employee;   // Upcast                 // Person տիպի person-ին վերագրեցինք employee instance-ը, այս դեպքում person-ը և employee-ը հղված են հիշովության մեջ Person class-ի վրա
                                                                  // բայց employee-ից տեսանելի է նաև Employee class-ը, իսկ person-ից ոչ                                                                  
            Console.WriteLine(person.Name);                       // Arthur

            Person person1 = new Client("ACBA", "Aram");          // Նույն ձևով միանգամից ենք վերագրում, այսինքն Client տիպից անցնում ենք Person-ի
            Console.WriteLine(person1.Name);  // Upcast           // Aram

            Person person2 = new Employee("BITC", "Levon");       // Employee տիպից անցնում ենք Person տիպի
            Console.WriteLine(person2.Name);  // Upcast           // Levon

            
            Person person3 = new Person("Vardan");
            Employee? employee1 = person3 as Employee;             // Տվյալ դեպքում employee2-ը կլինի null և կտպի "Casting went wrong"      // as-keyword (person3-ը որպես Employee)
            if (employee1 == null)
            {
                Console.WriteLine("Casting went wrong!");
            }
            else
            {
                Console.WriteLine(employee1.Name);
            }

            Employee employee2 = new Employee("FPS", "Armen");
            Person person4 = employee2;      // Upcast
            Employee employee3 = (Employee)person4;  // Downcast   // person4-ին իջացնում ենք Employee lvl
            Console.WriteLine(person4.Name);                       // Armen
            Console.WriteLine(employee3.Name);                     // Armen

            Person person5 = new Person("Arthur");
            if (person5 is Employee)                               // is-keyword (վերադարձնում է true կամ false, տվյալ դեպքում person5-ը Employee է թե ոչ)
            {
                Console.WriteLine("person5's type is Employee");
            }
            else
            {
                Console.WriteLine("person5's type is not Emloyee");
            }
        }
    }
}*/
