using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_9_Delegate_Event
{
    internal class Delegate_2
    {
        delegate int Operation(int x, int y);            // Creates delegate Operation with type int, that takes 2 parameters

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main()
        {
            Operation? operation = Add;                      // Adds Add method ref to operation delegate
            int resultAdd = operation(6, 7);                 // Takes parameters and does add operation
            Console.WriteLine($"Add result: {resultAdd}");   // Prints add operation result

            operation += Multiply;                                // Adds Multiply method ref to operation delegate
            int resultMult = operation(6, 7);                     // Takes parameters and does multiply operation
            Console.WriteLine($"Multiply result: {resultMult}");  // Prints multiply operation result

            operation += Multiply;                           // Adds Multiply method ref to operation delegate
            int resultMult1 = operation(8, 9);

            operation += Multiply;                           // Adds Multiply method ref to operation delegate
            int resultMult2 = operation(10, 11);

            operation -= Multiply;                           // Removes Multiply method ref from operation delegate from the last

            Operation operation1 = Add;                      // Adds Add method ref to operation delegate
            Operation operation2 = new Operation(Add);       // Creates instance of delegate giving Add method as parameter

            Operation operation3 = Add;
            Operation operation4 = Multiply;
            Operation operation5 = operation3 + operation4;   // Concates operation3 and operation4 delegates
            int result = operation5(6, 8);                   // If there are many methods in delegate, returns last method result
            Console.WriteLine(result);

            Operation? operation6 = Add;
            operation6 -= Add;
            int? n = operation6?.Invoke(4, 5);                // There aren't any error
            //int n = operation6(4, 5);                       // Error, null reference 
        }
    }
}*/
