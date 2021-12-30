using System;
using System.Collections.Generic;

namespace ListsExample
{
    class Program
    {
        static void E1()
        {
            Random random = new Random();
            int size = 5;
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 101);
            }

            ++size;
            int[] newArray = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[size - 1] = 100;
            array = newArray;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            IList list = new MyArrayList();
            list.AddBack(10);

            //Assert.AreEqual(10, list[0]);
        }
    }
}
