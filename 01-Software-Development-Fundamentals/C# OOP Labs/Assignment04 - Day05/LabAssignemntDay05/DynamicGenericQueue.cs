
namespace LabAssignemntDay05
{
    internal class DynamicGenericQueue<T>
    {
        private int front;    
        private int lastIndex;     // Referes to the last element  ===like===> [lastIndex] 1,2,3,4,5 [front]
        private int size;     
        private T[] arr;     
        public static int Counter = 0;

        public DynamicGenericQueue(int _size)
        {
            front = 0;          // the comming elemet will be in front (0: first index: first element) وهكذا
            lastIndex = -1;     // outside the queue means that no entered elements yet
            size = _size;
            arr = new T[size];
        }
      

        public void Enqueue(T item)
        {
            if (!IsFull())
            {
                lastIndex++;  
                arr[lastIndex] = item;
            }
            else
            {
                Console.WriteLine("Queue is full!");
            }
        }

        public T Dequeue()
        {
            T result = default;
            if (!IsEmpty())
            {
                result = arr[front];
                // Shift all elements to left
                for (int i = 0; i < lastIndex; i++)
                {
                    arr[i] = arr[i + 1];
                }
                lastIndex--;
                return result;
            }
            else
            {
                Console.WriteLine("Queue is Empty! - Any next value is default and means nothing");
            }
            return result;
        }

        public bool IsFull()
        {
            return lastIndex == size - 1;   // طبيعي لاني اول ما عرفته كان -1
        }

        public bool IsEmpty()
        {
            return lastIndex < front;      // last returns to -1 and front returns to 0
        }

    }
}