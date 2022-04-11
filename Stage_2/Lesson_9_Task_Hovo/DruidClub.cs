using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_9_Task_Hovo
{
    public class DruidClub
    {
        public void Information()
        {
            Console.WriteLine("Company: Druid Club");
            Console.WriteLine("Company branches: Cafe Druid, Rest Druid, Pizza Druid");
            Console.WriteLine("Company owner: Arthur Yegoryan");
            Console.WriteLine("==================================");
            Console.WriteLine("Delivery number: 060-66-66-66");
            Console.WriteLine("Thanks for trusting us");
        }

        public void Menu()
        {
            Console.WriteLine("Cafe Menu:");
            Console.WriteLine("------------");
            Console.WriteLine("Espresso\nAmerikano\nLatte\nGlasse");
            Console.WriteLine();

            Console.WriteLine("Rest Menu:");
            Console.WriteLine("------------");
            Console.WriteLine("Barbecue\nOmelet\nSalad\nFish");
            Console.WriteLine();

            Console.WriteLine("Pizza Menu:");
            Console.WriteLine("------------");
            Console.WriteLine("Neapolitan\nChicago\nGreek\nCalifornia");
            Console.WriteLine();
        }
    }
}
