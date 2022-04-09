using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_9_Delegate_Event
{
    internal class Lambda_Expressions
    {
        delegate void MyDelegate();
        delegate int Operation(int x, int y);
        delegate void Print();

        public static void Message1()
        {
            Console.WriteLine("Hello world");
        }
        public static void Message2()
        {
            Console.WriteLine("Barlus hayer");
        }

        static void Main()
        {
            MyDelegate myDelegate = () => Console.WriteLine("Barlus Hayer");  // Creates lambda expression, that doesn't take parameters
            myDelegate();                                                     // Barlus Hayer

            MyDelegate myDelegate1 = () =>           // If there are many operations for lambda must write in scopes
            {
                Console.Write("Hello ");
                Console.WriteLine("world!");
            };
            myDelegate1();                           // Hello world!

            var myDelegate2 = () => Console.WriteLine("I am Arthur");   // We can write with var, here var means MyDelegate
            myDelegate2();                                              // I am Arthur

            Operation sum = (x, y) => x + y;         //  Takes parameters, because in delegate Operation parameters are int
            Console.WriteLine(sum(6, 7));   // 13    // we can miss here parameters types

            //var multiply = (x, y) => x * y;           // Error, for parameters must be given types
            var multiply = (int x, int y) => x * y;     // Here all is ok, var means Operation
            Console.WriteLine(multiply(6, 7));          // 42

            var subtract = (int x, int y) =>
            {
                if (x >= y)
                    return x - y;                      // Return can be used return for expressions
                else
                    return y - x;
            };
            Console.WriteLine(subtract(6, 7));
            Console.WriteLine(subtract(9, 5));

            Print? text = () => Console.Write("Barlus ");    // We can add other lamdas and methods to our lamda expression
            text += () => Console.WriteLine("Hayer");
            text += Message1;
            text += Message2;
            text();
            Console.WriteLine();

            text -= Message2;
            text -= Message1;
            text?.Invoke();

            // We can use lambda-expressions as parameter of methods and result of parameters too
        }
    }
}*/
