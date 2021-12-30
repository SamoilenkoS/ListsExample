using System;
using System.Collections.Generic;
using System.Text;

namespace ListsExample
{
    public interface IList
    {
        void AddFront(int value);
        void AddBack(int value);
        void AddByIndex(int index, int value);
    }
}
