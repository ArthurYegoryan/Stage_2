using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_9_Task_Hovo
{
    internal class MainClass
    { 
        static void Main()
        {
            Console.WriteLine("Hi, welcome please, do you need menu?");
            string? answer = Console.ReadLine();
            Console.WriteLine();

            DruidClub druidClub = new DruidClub();

            if (answer == "Yes")
            {
                druidClub.Menu();
            }

            Console.WriteLine("Please say what do you want?");
            string? order = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"How many do you want from {order}?");
            int? quantity = int.Parse(Console.ReadLine());
            Console.WriteLine();

            CafeDruid cafeDruid = new CafeDruid(order, quantity);
            RestDruid restDruid = new RestDruid(order, quantity);
            PizzaDruid pizzaDruid = new PizzaDruid(order, quantity);

            if (order == "Espresso" || order == "AmeriKano" || order == "Latte" || order == "Glasse")
            {
                cafeDruid.TakeOrder(order);
            }
            else if (order == "Barbecue" || order == "Omelet" || order == "Salad" || order == "Fish")
            {
                restDruid.TakeOrder(order);
            }
            else if (order == "Neapolitan" || order == "Chicago" || order == "Greek" || order == "California")
            {
                pizzaDruid.TakeOrder(order);
            }
        }
    }
}*/
