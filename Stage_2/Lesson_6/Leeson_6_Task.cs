using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stage_2.Lesson_6;

namespace Stage_2
{
    internal class Leeson_6_Task
    {
        static void Main()
        {
            Console.Write("Enter the person name: ");
            string? name = Console.ReadLine();

            Task_FindingClass findingClass = new Task_FindingClass(name);
        }
    }
}
