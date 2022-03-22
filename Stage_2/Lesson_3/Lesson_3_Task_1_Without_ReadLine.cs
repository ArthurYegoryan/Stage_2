using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2
{
    class ArrayProperties
    {
        public string[] array = { "1", "a", "tt", "27", "8.5", "#"};

        public void PrintArray()
        {
            Console.Write("Array elements are: ");
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void AddElement()
        {
            Console.Write("Enter the element that you want to add: ");
            string element = Console.ReadLine();

            Console.Write("Enter a new element position: ");
            int position = Convert.ToInt32(Console.ReadLine());

            string[] addedArray = new string[7];
            for (int i = 0; i < 7; i++)
            {
                if (i < position - 1)
                {
                    addedArray[i] = array[i];
                }
                else if (i == position - 1)
                {
                    addedArray[i] = element;
                }
                else
                {
                    addedArray[i] = array[i - 1];
                }
            }

            Console.WriteLine("New array with added element is:");
            foreach (string item in addedArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void DeleteElement()
        {
            Console.Write("Enter that element position that you want to delete: ");
            int position = Convert.ToInt32(Console.ReadLine());

            string[] deletedElemArray = new string[5];
            for (int i = 0; i < 5; i++)
            {
                if (i < position - 1)
                {
                    deletedElemArray[i] = array[i];
                }
                else
                {
                    deletedElemArray[i] = array[i + 1];
                }
            }

            Console.WriteLine("New array with deleted element is:");
            foreach (string item in deletedElemArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void GetElement()
        {
            Console.Write("Enter element index that you want to get: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The element that has index {index} is {array[index]}");
        }

        public void GetArrayLength()
        {
            Console.WriteLine($"The length of array is {array.Length}");
        }
    }
    internal class Lesson_3_Task_1
    {
        static void Main()
        {
            ArrayProperties arrayProperties = new ArrayProperties();

            arrayProperties.PrintArray();
            arrayProperties.AddElement();
            arrayProperties.DeleteElement();
            arrayProperties.GetElement();
            arrayProperties.GetArrayLength();
        }
    }
}*/
