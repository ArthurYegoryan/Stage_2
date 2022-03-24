using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2
{
    class Person <T>                     // Generic type-ը գրում ենք այս ձևով, չակերտների մեջ կարող ենք գրել ցանկացած այլ բան
    {
        public string Name { get; set; }
        public T ID { get; set; }        // ID-ն Generic type-ի է, որը գրում ենք կախված թե Person-ի կողքը ինչ ենք գրում չակերտների մեջ

        public Person(string name, T id)
        {
            Name = name;
            ID = id;
        }
    }

    class Car <T, K>         // Կարող ենք միանգամից տալ մի քանի generic type-եր
    {
        public string Model { get; set; }
        public T HorsePower { get; set; }
        public K VinCode { get; set; }

        public Car(string model, T hp, K vc)
        {
            Model = model;
            HorsePower = hp;
            VinCode = vc;
        }
    }

    internal class Generic_type
    {
        static void Main()
        {
            Person<int> person1 = new Person<int>("Arthur", 666);     // Instance սարքելուց նշում ենք թե ինչ կընդունի մեր generic type-ը
            Console.WriteLine($"Name: {person1.Name}, ID: {person1.ID}");

            Person<string> person2 = new Person<string>("Karen", "AA000");  // Generic type-ը ըմդունում է string type
            Console.WriteLine($"Name: {person2.Name}, ID: {person2.ID}");

            Car<int, string> car = new Car<int, string>("S600", 360, "ABC123CD456");  // Generic type-երը տալիս ենք հերականությամբ
            Console.WriteLine($"Model: {car.Model}, HorsePower: {car.HorsePower}, VinCode: {car.VinCode}");
        }
    }
}*/
