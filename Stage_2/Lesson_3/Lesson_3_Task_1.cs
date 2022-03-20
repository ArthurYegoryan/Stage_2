using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2
{
    class ArrayProperties
    {
        static int _size;
        public ArrayProperties(int size)
        {
            _size = size;
        }

        public string[] array = new string[_size];

        public void MakingArray()
        {
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < _size; i++)
            {
                array[i] = Console.ReadLine();
            }
        }

        public void AddElement()
        {
            Console.Write("Enter the element that you want to add: ");
            string element = Console.ReadLine();

            Console.Write("Enter a new element position: ");
            int position = Convert.ToInt32(Console.ReadLine());

            string[] addedArray = new string[_size + 1];
            for (int i = 0; i < _size + 1; i++)
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
                Console.Write(item + "");
            }
        }

        public void DeleteElement()
        {
            Console.Write("Enter that element position that you want to delete: ");
            int position = Convert.ToInt32(Console.ReadLine());

            string[] deletedElemArray = new string[_size - 1];
            for (int i = 0; i < _size - 1; i++)
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
                Console.Write(item + "");
            }
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
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayProperties arrayProperties = new ArrayProperties(size);

            arrayProperties.MakingArray();
            arrayProperties.AddElement();
            arrayProperties.DeleteElement();
            arrayProperties.GetElement();
            arrayProperties.GetArrayLength();
        }
    }
}
