using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_9_Task_Hovo
{
    public class CafeDruid : DruidClub
    {
        public string? order;
        public int? quantity;
        public CafeDruid(string? order, int? quantity)
        {
            this.order = order;
            this.quantity = quantity;
        }

        public void TakeOrder(string? order)
        {
            if (order == "Espresso")
            {
                CafeDruidMenu espresso = CafeDruidMenu.Espresso;
                Console.WriteLine($"Your order: {espresso}");
                Console.WriteLine($"Espresso price: {(int)espresso}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)espresso} = {quantity * (int)espresso}");
                CafeDruidMenu espressoTime = CafeDruidMenu.EspressoTime;
                Console.WriteLine($"Cooking time: {(int)espressoTime} min");
                Console.WriteLine($"Please wait while your order will be ready!");
            }
            else if (order == "Amerikano")
            {
                CafeDruidMenu amerikano = CafeDruidMenu.Amerikano;
                Console.WriteLine($"Your order: {amerikano}");
                Console.WriteLine($"Amerikano price: {(int)amerikano}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)amerikano} = {quantity * (int)amerikano}");
                CafeDruidMenu amerikanoTime = CafeDruidMenu.AmerikanoTime;
                Console.WriteLine($"Cooking time: {(int)amerikanoTime} min");
            }
            else if (order == "Latte")
            {
                CafeDruidMenu latte = CafeDruidMenu.Latte;
                Console.WriteLine($"Your order: {latte}");
                Console.WriteLine($"Latte price: {(int)latte}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)latte} = {quantity * (int)latte}");
                CafeDruidMenu latteTime = CafeDruidMenu.LatteTime;
                Console.WriteLine($"Cooking time: {(int)latteTime} min");
            }
            else if (order == "Glasse")
            {
                CafeDruidMenu glasse = CafeDruidMenu.Glasse;
                Console.WriteLine($"Your order: {glasse}");
                Console.WriteLine($"Glasse price: {(int)glasse}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)glasse} = {quantity * (int)glasse}");
                CafeDruidMenu glasseTime = CafeDruidMenu.GlasseTime;
                Console.WriteLine($"Cooking time: {(int)glasseTime} min");
            }
        }
	    
    }
}
