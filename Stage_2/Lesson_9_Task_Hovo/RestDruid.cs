using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_9_Task_Hovo
{
    public class RestDruid
    {
        public string? order;
        public int? quantity; 
        public RestDruid(string order, int? quantity)
        {
            this.order = order;
            this.quantity = quantity;
        }

        public void TakeOrder(string? order)
        {
            if (order == "Barbecue")
            {
                RestDruidMenu barbecue = RestDruidMenu.Barbecue;
                Console.WriteLine($"Your order: {barbecue}");
                Console.WriteLine($"Barbecue price: {(int)barbecue}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)barbecue} = {quantity * (int)barbecue}");
                RestDruidMenu barbecueTime = RestDruidMenu.BarbecueTime;
                Console.WriteLine($"Cooking time: {(int)barbecueTime} min");
            }
            else if (order == "Omelet")
            {
                RestDruidMenu omelet = RestDruidMenu.Omelet;
                Console.WriteLine($"Your order: {omelet}");
                Console.WriteLine($"Omelet price: {(int)omelet}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)omelet} = {quantity * (int)omelet}");
                RestDruidMenu omeletTime = RestDruidMenu.OmeletTime;
                Console.WriteLine($"Cooking time: {(int)omeletTime} min");
            }
            else if (order == "Salad")
            {
                RestDruidMenu salad = RestDruidMenu.Salad;
                Console.WriteLine($"Your order: {salad}");
                Console.WriteLine($"Salad price: {(int)salad}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)salad} = {quantity * (int)salad}");
                RestDruidMenu saladTime = RestDruidMenu.SaladTime;
                Console.WriteLine($"Cooking time: {(int)saladTime} min");
            }
            else if (order == "Fish")
            {
                RestDruidMenu fish = RestDruidMenu.Fish;
                Console.WriteLine($"Your order: {fish}");
                Console.WriteLine($"Fish price: {(int)fish}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)fish} = {quantity * (int)fish}");
                RestDruidMenu fishTime = RestDruidMenu.FishTime;
                Console.WriteLine($"Cooking time: {(int)fishTime} min");
            }
        }
    }
}
