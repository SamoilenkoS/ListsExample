using System;
using System.Collections.Generic;
using System.Text;

namespace ListsExample
{
    public class MyArrayList : IList
    {
        private int[] _array;

        public MyArrayList()
        {

        }

        public MyArrayList(int capacity)
        {

        }

        public MyArrayList(int[] array)
        {

        }

        public void Sort(bool ascending = true)
        {
            //
        }

        public void Print()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        public void AddFront(int value)
        {
            throw new NotImplementedException();
        }

        public void AddBack(int value)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, int value)
        {
            throw new NotImplementedException();
        }
    }
}
