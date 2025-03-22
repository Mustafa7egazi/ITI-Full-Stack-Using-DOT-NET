namespace LabAssignmentDay04
{
    using System;

    class Program
    {
        static void ModifyByValue(int[] numbers)
        {
            numbers[0] = 100;
            numbers = new int[5];
            numbers[0] = 200;
        }

        static void ModifyByReference(ref int[] numbers)
        {
            numbers[0] = 100;
            numbers = new int[5];
            numbers[0] = 200;
        }

        static void Main()
        {
            // Test passing by value 
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            ModifyByValue(array1);
            Console.WriteLine("By Value: " + array1[0]); // Output: 100

            // Test passing by reference
            int[] array2 = new int[5] { 1, 2, 3, 4, 5 };
            ModifyByReference(ref array2);
            Console.WriteLine("By Reference: " + array2[0]); // Output: 200
        }
    }
}
