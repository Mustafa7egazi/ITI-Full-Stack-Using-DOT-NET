
using System.Diagnostics.Metrics;

namespace LabAssignemntDay05
{
    internal class DynamicIntegersStack
    {
        private int tos;
        private int size;
        private int[] arr;
        public static int Counter = 0;

        public DynamicIntegersStack(int _size)
        {
            tos = 0;
            size = _size;
            arr = new int[size];
        }

        public void Push(int num)
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

        public int Pop()
        {
            int result = -1;
            if (!IsEmpty())
            {
                tos--;
                result =  arr[tos];
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
