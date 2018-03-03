using System;

namespace Data_Structures
{
    public class Stack
    {
        private int[] _elements;
        private int topIndex = -1;

        public Stack(int size)
        {
            _elements = new int[size];
        }

        public bool IsEmpty()
        {
            return topIndex == -1;
        }

        public void Push(int element)
        {
            topIndex++;

            _elements[topIndex] = element;
        }

        public int Pop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Stack is empty. underflow");
                
            var el = _elements[topIndex];

            topIndex--;

            return el;
        }
    }
}