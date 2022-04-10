using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_9_Task_Hovo
{
    internal class MainClass
    { 
        static void Main()
        {
            Console.WriteLine("Hi, please say what do you want?");
            string? order = Console.ReadLine();

            CafeDruid cafeDruid = new CafeDruid(order);

            if (order == "Espresso" || order == "AmeriKano" || order == "Latte" || order == "Glasse")
            {
                cafeDruid.TakeOrder(order);
            }
            
        }
    }
}
