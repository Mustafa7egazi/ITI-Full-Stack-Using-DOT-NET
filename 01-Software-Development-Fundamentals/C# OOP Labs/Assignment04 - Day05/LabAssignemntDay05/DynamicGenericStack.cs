using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignemntDay05
{
    internal class DynamicGenericStack<T>
    {
        private int tos;
        private int size;
        private T[] arr;
        public static int Counter = 0;

        public DynamicGenericStack(int _size)
        {
            tos = 0;
            size = _size;
            arr = new T [size];
        }

        public void Push(T num)
        {
            if (!IsFull())
            {
                arr[tos] = num;
                tos++;
            }
            else
            {
                Console.WriteLine("Stack is full!");
            }

        }

        public T Pop()
        {
            T result = default;
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
                return result;
            }
            else
            {
                Console.WriteLine("Stack is Empty!");
            }
            return result;
        }

        public bool IsFull()
        {
            return tos == size;
        }

        public bool IsEmpty()
        {
            return tos == 0;
        }
    }
}
