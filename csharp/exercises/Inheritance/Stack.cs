using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Stack
    {
        public readonly List<object> _list;

        public Stack()
        {
            _list = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("The passed object is cannot be null.");
            }
            _list.Add(obj);
            Console.WriteLine($"The object {obj} has been added to the stack");
        }

        public object Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The list is already empty. No more objects to pop.");
            }
            int lastIndex = _list.Count - 1;
            var objToBeRemoved = _list[lastIndex];
            _list.RemoveAt(lastIndex);
            return objToBeRemoved;
        }

        public void Clear()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The list is already empty and cannot be cleared.");
            }
            _list.Clear();
            Console.WriteLine("The stack has been cleared.");
        }
    }
}
