using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_2
{
    public interface IDescription      // Կարող ենք փոխել նաև interface-ի modifire-ը
    {
        const int age = 20;
    }
    
    interface IMoveable                // By default internal
    {
        const int distance = 5;        // By default public       // Const field-երը կարող են լինել interface-ում

        private static int maxDistance = 10;                      // static field-երը կարող են լինել interface-ում

        protected string Name { get; set; }                       // property-ները կարող են լինել interface-ում

        void Move();                                              // method-ները կարող են լինել interface-ում

        void MoveDefault()                                        // C# 8.0-ից սկսած կարող ենք նաև ռեալիզացնել interface-ում
        {
            Console.WriteLine("Something is moving");
        }
    }

    class Car : IMoveable                             // Իմպլեմենտացնում ենք IMoveable interface-ը class-ի համար
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }     // By default property-ի իմպլեմենտացում

        public void Move()
        {
            Console.WriteLine("Car is going");       // Ռեալիզացնում ենք IMovable interface-ի Move() method-ը
        }
    }

    struct Person : IMoveable                        // Իմպլեմենտացնում ենք IMoveable interface-ը struct-ի համար
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }      // By default property-ի իմպլեմենտացում

        public void Move()
        {
            Console.WriteLine("Person is walking");   // Ռեալիզացնում ենք IMovable interface-ի Move() method-ը
        }
    }

    class Vehicle : IMoveable, IDescription           // Class-ը կամ struct-ը կարող են իմպլեմենտացնել միանգամից մի քանի interface-ներ՝ հակառակ ժառանգելուն
    {
        string IMoveable.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Move()
        {
            throw new NotImplementedException();
        }
    }

    internal class Interface
    {
        static void Main()
        {
            //IMoveable moveable = new IMoveable();      // Error      // Interface-ի instance չենք կարող ստեղծել

            Car car = new Car();
            car.Move();                         // Car is going

            Person person = new Person();       // Person is walking
            person.Move();

            Console.WriteLine(IMoveable.distance);      // Կարող ենք դրսում օգտվել և փոփոխել interface-ի տվյալները
        }
    }
}*/
