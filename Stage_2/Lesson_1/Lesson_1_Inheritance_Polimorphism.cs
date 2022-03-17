using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Inheritance_Polimorphism
{    
    sealed class Animal               // Եթե class-ը ունի sealed keyword, ապա այն չի կարող ժառանգվել
    {
        public void Voice()
        {
            Console.WriteLine("Each animal has its own voice!");
        }
    }

    class Dog //: Animal               // Animal-ից ժառանգումը error է տալիս
    {
        public void Voice()
        {
            Console.WriteLine("Haf-haf");
        }
    }

    class Car                                    // Inheritance
    {
        public string brand;
        public string model;
        public int date;

        public virtual void Color()          // Նույն անունով method-ները class-ների մեջ գրելու ժամանակ կարող ենք Base class-ի մեթոդին տալ virtual keyword-ը
        {
            Console.WriteLine("Black");
        }
    }

    class Mercedes : Car
    {
        public override void Color()         // իսկ Base class-ը ժառանգած class-ների նույն անունով method-ներին տալ override keyword-ը
        {
            Console.WriteLine("White");
        }
        public void Method()
        {
            Car car = new Car();             // Կարող ենք ժառանգած class-ում Base class-ի անդամների հետ շփվել method-ի ներսում ստեղծելով instance
            car.Color();
        }
        //Car car = new Car();               // Իսկ հենց ժառանգած class-ում կարող ենք սարքել Base class-ի instance, բայց այն չենք կարող օգտագործել
        //car.
    }

    class BMW : Car
    {
        public override void Color()
        {
            Console.WriteLine("Blue");
        }
    }

    internal class Lesson_1
    {
        static void Main()
        {
            Car car = new Car();
            Mercedes mercedes = new Mercedes();
            mercedes.brand = "Mercedes";
            mercedes.model = "S_600";
            mercedes.date = 2022;

            Console.WriteLine($"Car brend is {mercedes.brand}");
            Console.WriteLine($"Car model is {mercedes.model}");
            Console.WriteLine($"Car date is {mercedes.date}");
            mercedes.Color();

            car.Color();

            BMW bmw = new BMW();
            bmw.Color();

            mercedes.Method();
        }
    }
}*/
