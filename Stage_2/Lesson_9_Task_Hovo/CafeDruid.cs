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
        public CafeDruid(string order)
        {
            this.order = order;
        }

        public void TakeOrder(string? order)
        {
            if (order == "Espresso")
            {
                CafeDruidMenu espresso = CafeDruidMenu.Espresso;
                Console.WriteLine($"Your order: {espresso}");
                Console.WriteLine($"Espresso price: {(int)espresso}");
                CafeDruidMenu espressoTime = CafeDruidMenu.EspressoTime;
                Console.WriteLine($"Cooking time: {(int)espressoTime} min");
            }
            else if (order == "Amerikano")
            {
                CafeDruidMenu amerikano = CafeDruidMenu.Amerikano;
                Console.WriteLine($"Your order: {amerikano}");
                Console.WriteLine($"Amerikano price: {(int)amerikano}");
                CafeDruidMenu amerikanoTime = CafeDruidMenu.AmerikanoTime;
                Console.WriteLine($"Cooking time: {(int)amerikanoTime} min");
            }
            else if (order == "Latte")
            {
                CafeDruidMenu latte = CafeDruidMenu.Latte;
                Console.WriteLine($"Your order: {latte}");
                Console.WriteLine($"Latte price: {(int)latte}");
                CafeDruidMenu latteTime = CafeDruidMenu.LatteTime;
                Console.WriteLine($"Cooking time: {(int)latteTime} min");
            }
            else if (order == "Glasse")
            {
                CafeDruidMenu glasse = CafeDruidMenu.Glasse;
                Console.WriteLine($"Your order: {glasse}");
                Console.WriteLine($"Glasse price: {(int)glasse}");
                CafeDruidMenu glasseTime = CafeDruidMenu.GlasseTime;
                Console.WriteLine($"Cooking time: {(int)glasseTime} min");
            }
        }
	    
    }
}
