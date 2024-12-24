using System;

namespace CSharpBasics03A
{
    internal class Program
    {
        #region Function for Summation and Subtraction
        static (int Sum, int Difference) CalcSumDiff(int X, int Y)
        {
            return (X + Y, X - Y);
        }
        #endregion




        #region Function to Calculate the Sum of Digits
        static int SumOfDigits(int Number03)
        {
            int Sum = 0;
            while (Number03 != 0)
            {
                Sum += Number03 % 10; //Sum = Sum + Number03 % 10 ==> Extracts the last digit of the number
                Number03 /= 10; //Number03 = Number03 / 10 ==> Removes the last digit from the number
            }
            return Sum;
        }
        #endregion




        #region Function to Check if a Number is Prime
        //Prime number is a positive integer greater than 1 that has no positive integer divisors other than 1 and itself.
        //If a number N is not prime, it must have at least one divisor less than or equal to its square root.
        static bool IsPrime(int Number04)
        {
            if (Number04 < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(Number04); i++)
            {
                if (Number04 % i == 0)
                    return false;
            }
            return true;
        }
        #endregion




        #region Function to Find Min and Max in an Array using Reference Parameters
        static void MinMaxArray(int[] Array, out int Min, out int Max)
        {
            Min = int.MaxValue;
            Max = int.MinValue;

            foreach (int Number05 in Array)
            {
                if (Number05 < Min) Min = Number05;
                if (Number05 > Max) Max = Number05;
            }
        }
        #endregion




        #region Iterative Function to Calculate Factorial
        static long Factorial(int Number06)
        //Factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n.
        //For any positive integer n, n! = n* (n-1) * (n-2) * ... * 2 * 1
        {
            long Result = 1;
            for (int i = 2; i <= Number06; i++)
            {
                Result *= i; //Result = Result * i
            }
            return Result;
        }
        #endregion




        #region Function to Modify a Character in a String
        static string ChangeChar(string Str, int Position, char NewChar)
        {
            if (Position < 0 || Position >= Str.Length)
                return "Invalid position!";

            char[] CharArray = Str.ToCharArray();
            CharArray[Position] = NewChar;

            return new string(CharArray);
        }
        #endregion




        static void Main()
        {
            #region Function for Summation and Subtraction
            Console.Write("Enter the first number: ");
            int Number01 = int.Parse(Console.ReadLine()); //Input: 7

            Console.Write("Enter the second number: ");
            int Number02 = int.Parse(Console.ReadLine()); //Input: 4

            (int Sum, int Difference) = CalcSumDiff(Number01, Number02);
            Console.WriteLine($"Summation: {Sum}"); //Output: 7 + 4 = 11
            Console.WriteLine($"Subtraction: {Difference}"); //Output: 7 - 4 = 3
            #endregion




            #region Function to Calculate the Sum of Digits
            Console.Write("Enter a number: ");
            int Number03 = int.Parse(Console.ReadLine());

            int DigitsSum = SumOfDigits(Number03);
            Console.WriteLine($"The sum of the digits of the number {Number03} is: {Sum}");
            //Input: 25 
            //First Iteration: Number % 10 = 25 % 10 = 5 ==> Sum = Sum + 5 = 0 + 5 = 5 ==> Number = Number / 10 = 25 / 10 = 2
            //Second Iteration: Number % 10 = 2 % 10 = 2 ==> Sum = Sum + 2 = 5 + 2 = 7 ==> Number = Number / 10 = 2 / 10 = 0
            //Output: 7
            #endregion




            #region Function to Check if a Number is Prime
            Console.Write("Enter a number: ");
            int Number04 = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(Number04) ? "The number is prime" : "The number is not prime");
            #endregion




            #region Function to Find Min and Max in an Array using Reference Parameters
            int[] Array = { 2, 4, 6, 8, 10 };

            MinMaxArray(Array, out int Min, out int Max);

            Console.WriteLine($"Minimum: {Min}, Maximum: {Max}"); //Output: Minimum: 2, Maximum: 10
            #endregion




            #region Iterative Function to Calculate Factorial
            Console.Write("Enter a number: ");
            int Number06 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Factorial of {Number06} is: {Factorial(Number06)}");
            //Input: 5
            //Result = 1 * 2 = 2 ==> Result = 2 * 3 = 6 ==> Result = 6 * 4 = 24 ==> Result = 24 * 5 = 120
            //Output: 120
            #endregion




            #region Function to Modify a Character in a String
            Console.Write("Enter a string: ");
            string Input = Console.ReadLine();

            Console.Write("Enter the position to change (0-based index): ");
            int Position = int.Parse(Console.ReadLine());

            Console.Write("Enter the new character: ");
            char NewChar = Console.ReadLine()[0];

            string ModifiedString = ChangeChar(Input, Position, NewChar);

            Console.WriteLine($"Modified string: {ModifiedString}");
            #endregion




            #region Print an Identity Matrix using for Loop
            Console.Write("Enter the size of the identity matrix (N): ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
            #endregion




            #region Sum of all Elements in an Array
            int[] Arr = { 1, 2, 3, 4, 5 };
            int ElementsSum = 0;

            foreach (int Number07 in Arr)
            {
                ElementsSum += Number07;
            }

            Console.WriteLine("Sum of array elements: " + ElementsSum); //Output: 1 + 2 + 3 + 4 + 5 = 15
            #endregion




            #region Merge Two Sorted Arrays
            int[] Arr1 = { 1, 2, 3, 4 };
            int[] Arr2 = { 5, 6, 7 };
            int[] MergedArray = new int[Arr1.Length + Arr2.Length];
            int i = 0, j = 0, k = 0;
            
            while (i < Arr1.Length && j < Arr2.Length)
            {
                if (Arr1[i] <= Arr2[j])
                {
                    MergedArray[k++] = Arr1[i++];
                }
                else
                {
                    MergedArray[k++] = Arr2[j++];
                }
            }

            while (i < Arr1.Length)
            {
                MergedArray[k++] = Arr1[i++];
            }

            while (j < Arr2.Length)
            {
                MergedArray[k++] = Arr2[j++];
            }

            Console.WriteLine("Merged Array:");
            
            foreach (int Number08 in MergedArray)
            {
                Console.Write(Number08 + " ");
            }
            #endregion
        }
    }
}
