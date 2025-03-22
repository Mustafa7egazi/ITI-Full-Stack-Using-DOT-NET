using LabAssignmentDay03;

namespace LabAssignemntDay05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("================== Lab Assignment - Day05 ====================");
            Console.WriteLine("==============================================================");

            #region Task01 - Try Dynamic Integers Stack
            //DynamicIntegersStack MyStack = new DynamicIntegersStack(5);
            //MyStack.Push(1);
            //MyStack.Push(2);
            //MyStack.Push(3);
            //MyStack.Push(4);
            //MyStack.Push(5);
            //MyStack.Push(6);   // full

            //Console.WriteLine(MyStack.Pop());
            //Console.WriteLine(MyStack.Pop());
            //Console.WriteLine(MyStack.Pop());
            //Console.WriteLine(MyStack.Pop());
            //Console.WriteLine(MyStack.Pop());


            //MyStack.Pop();    // Empty

            #endregion

            #region Task02 - Try Dynamic Generic Stack
            //DynamicGenericStack<string> MyGenStack = new DynamicGenericStack<string>(3);
            //MyGenStack.Push("H");
            //MyGenStack.Push("M");
            //MyGenStack.Push("S");

            //MyGenStack.Push("W");   // full

            //Console.WriteLine(MyGenStack.Pop());
            //Console.WriteLine(MyGenStack.Pop());
            //Console.WriteLine(MyGenStack.Pop());


            //MyGenStack.Pop();    // Empty
            #endregion

            #region Task03 - Try Operators On Complex

            //Complex c1 = new Complex(); // real 3 | img 4  default
            //Complex c2 = new Complex (3,4);

            //Complex c3 = c1 + c2;
            //c3++;

            //Console.WriteLine(c3.Print());

            //Complex c4 = c3 + 4; // 8+5i

            //c4 = 4 + c4 ;

            //Console.WriteLine(c4.Print());

            //int real = (int)c4;

            //Console.WriteLine($"Real after casting to int: {real}");

            #endregion

            #region Task04 [Bonus] - try Queue after Implementing it 

            //DynamicGenericQueue<int> q = new DynamicGenericQueue<int>(5);
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);
            //q.Enqueue(6);  // full

    
            //Console.WriteLine($"Dequeued element: {q.Dequeue()}"); 
            //Console.WriteLine($"Dequeued element: {q.Dequeue()}"); 
            //Console.WriteLine($"Dequeued element: {q.Dequeue()}"); 
            //Console.WriteLine($"Dequeued element: {q.Dequeue()}"); 
            //Console.WriteLine($"Dequeued element: {q.Dequeue()}"); 
            //Console.WriteLine($"Dequeued element: {q.Dequeue()}");  // empty

            #endregion

        }
    }
}
