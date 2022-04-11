using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_9_Task_Hovo
{
    public class PizzaDruid
    {
        public string? order;
        public int? quantity;
        public PizzaDruid(string order, int? quantity)
        {
            this.order = order;
            this.quantity = quantity;
        }

        public void TakeOrder(string? order)
        {
            if (order == "Neapolitan")
            {
                PizzaDruidMenu neapolitan = PizzaDruidMenu.Neapolitan;
                Console.WriteLine($"Your order: {neapolitan}");
                Console.WriteLine($"Neapolitan price: {(int)neapolitan}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)neapolitan} = {quantity * (int)neapolitan}");
                PizzaDruidMenu neapolitanTime = PizzaDruidMenu.NeapolitanTime;
                Console.WriteLine($"Cooking time: {(int)neapolitanTime} min");
            }
            else if (order == "Chicago")
            {
                PizzaDruidMenu chicago = PizzaDruidMenu.Chicago;
                Console.WriteLine($"Your order: {chicago}");
                Console.WriteLine($"Chicago price: {(int)chicago}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)chicago} = {quantity * (int)chicago}");
                PizzaDruidMenu chicagiTime = PizzaDruidMenu.ChicagoTime;
                Console.WriteLine($"Cooking time: {(int)chicagiTime} min");
            }
            else if (order == "Greek")
            {
                PizzaDruidMenu greek = PizzaDruidMenu.Greek;
                Console.WriteLine($"Your order: {greek}");
                Console.WriteLine($"Greek price: {(int)greek}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)greek} = {quantity * (int)greek}");
                PizzaDruidMenu greekTime = PizzaDruidMenu.GreekTime;
                Console.WriteLine($"Cooking time: {(int)greekTime} min");
            }
            else if (order == "California")
            {
                PizzaDruidMenu california = PizzaDruidMenu.California;
                Console.WriteLine($"Your order: {california}");
                Console.WriteLine($"California price: {(int)california}");
                Console.WriteLine($"Quantity: {quantity}");
                Console.WriteLine($"Total amount: {quantity} x {(int)california} = {quantity * (int)california}");
                PizzaDruidMenu californiaTime = PizzaDruidMenu.CaliforniaTime;
                Console.WriteLine($"Cooking time: {(int)californiaTime} min");
            }
        }
    }
}
