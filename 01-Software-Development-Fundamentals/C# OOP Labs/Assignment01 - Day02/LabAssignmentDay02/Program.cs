namespace LabAssignmentDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("================================= LAB Assignment - DAY02 =============================================");
            Console.WriteLine("======================================================================================================");


            #region Task01 - Get min and max of 1D array
            //int[] nums = new int[10];
            //int max, min;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"Enter number [{i + 1}]: ");
            //    nums[i] = int.Parse(Console.ReadLine());
            //}
            //min = nums[0];
            //max = nums[0];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (min > nums[i])
            //    {
            //        min = nums[i];
            //    }

            //    if (max < nums[i])
            //    {
            //        max = nums[i];
            //    }
            //}

            //Console.WriteLine($"Max number in the array is {max}, while Min number is {min}");

            #endregion

            #region Task02 - Sort array ascending manually
            //int[] nums2 = new int[10];

            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    Console.Write($"Enter number [{i + 1}]: ");
            //    nums2[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < nums2.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums2.Length - 1 - i; j++)
            //    {
            //        if (nums2[j] > nums2[j + 1])
            //        {
            //            int temp = nums2[j];
            //            nums2[j] = nums2[j + 1];
            //            nums2[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Sorted numbers:");
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    Console.WriteLine(nums2[i]);
            //}

            #endregion

            #region Task03 - search number in array and get index
            //int[] nums3 = new int[10];

            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    Console.Write($"Enter number [{i + 1}]: ");
            //    nums3[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("====================== Array Saved ====================\n");
            //Console.WriteLine("Enter number to search");
            //int theWantedNumber = int.Parse(Console.ReadLine());
            //int index = 100;
            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    if (nums3[i] == theWantedNumber)
            //    {
            //        index = i;
            //        break;
            //    }

            //    if (i == nums3.Length - 1 && index == 100)
            //    {
            //        Console.WriteLine("Number not found");
            //    }

            //}

            //if (index != 100)
            //{
            //    Console.WriteLine($"{theWantedNumber} has been found at index {index}");
            //}

            #endregion

            #region (BOUNS) Task04 - matrix multiplication

            //int[,] FirstMatrix = new int[3, 2];
            //int[,] MultiplicationVector = new int[2, 1];
            //int[,] ResultVector = new int[3, 1];
            //Console.WriteLine("Initialization of the Matrix");
            //for (int i = 0; i < FirstMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value of [{i},{j}]: ");
            //        FirstMatrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("============================================");
            //Console.WriteLine("Initialization of Multiplication Vector");
            //for (int i = 0; i < MultiplicationVector.GetLength(0); i++)
            //{
            //    for (int j = 0; j < MultiplicationVector.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value of [{i},{j}]: ");
            //        MultiplicationVector[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("============================================");
            //Console.WriteLine("Result Vector Initialization");

            //for (int i = 0; i < ResultVector.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ResultVector.GetLength(1); j++)
            //    {
            //        ResultVector[i, j] = (FirstMatrix[i, 0] * MultiplicationVector[0, 0]) +
            //                             (FirstMatrix[i, 1] * MultiplicationVector[1, 0]);
            //    }
            //}
            //Console.WriteLine("============================================");
            //Console.WriteLine("Result Vector as follows");

            //for (int i = 0; i < ResultVector.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ResultVector.GetLength(1); j++)
            //    {
            //        Console.WriteLine(ResultVector[i, j]);
            //    }
            //}

            #endregion

            #region Task05 - store sum of rows in isolated array

            //int[,] nums4 = new int[3,4];
            //int[] sumOfrows = new int[nums4.GetLength(0)];

            //for (int i = 0; i < nums4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < nums4.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value at [{i},{j}]: ");
            //        nums4[i,j] = int.Parse(Console.ReadLine());
            //    }

            //}
            //Console.WriteLine("Array has been stored");

            //for (int i = 0; i < nums4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < nums4.GetLength(1); j++)
            //    {
            //        sumOfrows[i] += nums4[i, j];
            //    }
            //}

            //Console.WriteLine("========= Summation of rows ==========");
            //for (int i = 0; i < sumOfrows.Length; i++)
            //{
            //    Console.WriteLine(sumOfrows[i]);
            //}

            #endregion

            #region Task06 - Calculate birth date
            //int MyYearOfBirth;
            //int MyMonthOfBirth;
            //int MyDayOfBirth;
            //bool isLeap = false;
            //bool isInDaysRange = false; // Initialize here

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Plz enter year from 1980 -> 2023");
            //        MyYearOfBirth = int.Parse(Console.ReadLine());

            //        isLeap = DateTime.IsLeapYear(MyYearOfBirth);

            //        Console.WriteLine("Plz enter your month");
            //        MyMonthOfBirth = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Plz enter your day");
            //        MyDayOfBirth = int.Parse(Console.ReadLine());

            //        if (MyMonthOfBirth == 4 || MyMonthOfBirth == 6 || MyMonthOfBirth == 9 || MyMonthOfBirth == 11)
            //        {
            //            isInDaysRange = MyDayOfBirth >= 1 && MyDayOfBirth <= 30;
            //        }
            //        else if (MyMonthOfBirth == 1 || MyMonthOfBirth == 3 || MyMonthOfBirth == 5 || MyMonthOfBirth == 7 ||
            //                 MyMonthOfBirth == 8 || MyMonthOfBirth == 10 || MyMonthOfBirth == 12)
            //        {
            //            isInDaysRange = MyDayOfBirth >= 1 && MyDayOfBirth <= 31;
            //        }
            //        else if (MyMonthOfBirth == 2)
            //        {
            //            if (isLeap)
            //            {
            //                isInDaysRange = MyDayOfBirth >= 1 && MyDayOfBirth <= 29;
            //            }
            //            else
            //            {
            //                isInDaysRange = MyDayOfBirth >= 1 && MyDayOfBirth <= 28;
            //            }
            //        }
            //        else
            //        {
            //            isInDaysRange = false;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Please enter valid numbers");
            //        MyYearOfBirth = 0;  // Force loop to continue
            //        MyMonthOfBirth = 0;
            //        MyDayOfBirth = 0;
            //        continue;
            //    }

            //} while (MyYearOfBirth < 1980 || MyYearOfBirth > 2023 ||
            //         MyMonthOfBirth < 1 || MyMonthOfBirth > 12 ||
            //         !isInDaysRange);

           
            //DateTime birthDate = new DateTime(MyYearOfBirth, MyMonthOfBirth, MyDayOfBirth);
            //DateTime today = DateTime.Now;
            //int years = today.Year - birthDate.Year;
            //if (today < birthDate.AddYears(years)) years--; // Only adjust years here
            //int months = today.Month - birthDate.Month;
            //if (months < 0)
            //{
            //    months += 12; // Just fix months, don't touch years
            //}
            //int days = today.Day - birthDate.Day;
            //if (days < 0)
            //{
            //    days += DateTime.DaysInMonth(today.Year, today.Month);
            //    months--;
            //}

            //Console.WriteLine($"You are {years} years, {months} months, and {days} days old");
            #endregion

            #region Task 07 Simple calc

            //char choice;

            //do
            //{
            //    Console.Write("Enter first number: ");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter operator 4 basic operator only ");
            //    char op = char.Parse(Console.ReadLine());

            //    double result = 0;
            //    bool isSucceeded = true;

            //    switch (op)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            if (num2 != 0)
            //                result = num1 / num2;
            //            else
            //            {
            //                Console.WriteLine("Can't divide by zero");
            //                isSucceeded = false;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator!");
            //            isSucceeded = false;
            //            break;
            //    }

            //    if (isSucceeded)
            //    {
            //        Console.WriteLine($"{num1} {op} {num2} = {result}");
            //    }

            //    Console.Write("Do you want to continue? (y/n): ");
            //    choice = char.ToLower(Console.ReadKey().KeyChar);
            //    Console.WriteLine(); 

            //} while (choice == 'y');

            #endregion

        }
    }
}
