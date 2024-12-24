namespace CSharpBasics02A
{
    internal class Program
    {
        static void Main()
        {
            #region Check if Number divisible by 3 and 4
            Console.Write("Enter a number: ");
            int Number01 = int.Parse(Console.ReadLine());

            if (Number01 % 3 == 0 && Number01 % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion


            #region Check if Integer is Positive or Negative 
            Console.Write("Enter an integer: ");
            int Number02 = int.Parse(Console.ReadLine());

            if (Number02 < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
            #endregion


            #region Check Max and Min from 3 Integers
            Console.Write("Enter three numbers: ");
            int Number03 = int.Parse(Console.ReadLine());
            int Number04 = int.Parse(Console.ReadLine());
            int Number05 = int.Parse(Console.ReadLine());

            int Max = Math.Max(Math.Max(Number03, Number04), Number05);
            int Min = Math.Min(Math.Min(Number03, Number04), Number05);

            Console.WriteLine("Max element = " + Max);
            Console.WriteLine("Min element = " + Min);
            #endregion


            #region Check if Number is Even or Odd
            Console.Write("Enter an integer: ");
            int Number06 = int.Parse(Console.ReadLine());

            if (Number06 % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            #endregion


            #region Check if Character is Vowel or Consonant 
            Console.Write("Enter a character: ");
            char Character = char.Parse(Console.ReadLine());

            if (Character == 'a' || Character == 'e' || Character == 'i' || Character == 'o' || Character == 'u' ||
                Character == 'A' || Character == 'E' || Character == 'I' || Character == 'O' || Character == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion


            #region Print Numbers from 1 to Input
            Console.Write("Enter a number: ");
            int Number07 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Number07; i++)
            {
                Console.Write(i + " ");
            }
            #endregion


            #region Print Multiplication Table up to 12
            Console.Write("Enter a number: ");
            int Number08 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(Number08 * i + " ");
            }
            #endregion


            #region Print Even Numbers from 1 to Input
            Console.Write("Enter a number: ");
            int Number09 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= Number09; i += 2)
            {
                Console.Write(i + " ");
            }
            #endregion


            #region Power Calculation based on 2 Integers
            //b^x: b (Base of logarithm), x (Exponent)
            Console.Write("Enter base and exponent: ");
            int Base = int.Parse(Console.ReadLine());
            int Exponent = int.Parse(Console.ReadLine());

            int Result01 = 1;
            for (int i = 0; i < Exponent; i++)
            {
                Result01 *= Base;
            }

            Console.WriteLine("Result: " + Result01);
            #endregion


            #region Calculate Total, Average, and Percentage of Marks of 5 Subjects
            Console.Write("Enter marks of five subjects: ");
            int Subject01 = int.Parse(Console.ReadLine());
            int Subject02 = int.Parse(Console.ReadLine());
            int Subject03 = int.Parse(Console.ReadLine());
            int Subject04 = int.Parse(Console.ReadLine());
            int Subject05 = int.Parse(Console.ReadLine());

            int total = Subject01 + Subject02 + Subject03 + Subject04 + Subject05;
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average marks = " + average);
            Console.WriteLine("Percentage = " + percentage);
            #endregion


            #region Print Days in a Month
            //Jan, Mar, May, July, Aug, Oct, Dec: 31 days
            //Apr, Jun, Sep, Nov: 30 days
            //Feb: 28-29 days
            Console.Write("Enter month number: ");
            int Month = int.Parse(Console.ReadLine());

            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in month: 31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in month: 30");
                    break;
                case 2:
                    Console.WriteLine("Days in month: 28-29");
                    break;
                default:
                    Console.WriteLine("Invalid month number");
                    break;
            }
            #endregion


            #region Simple Calculator
            Console.Write("Enter first number: ");
            double Number10 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double Number11 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /): ");
            char Operator = char.Parse(Console.ReadLine());

            double Result02;

            switch (Operator)
            {
                case '+':
                    Result02 = Number10 + Number11;
                    break;
                case '-':
                    Result02 = Number10 - Number11;
                    break;
                case '*':
                    Result02 = Number10 * Number11;
                    break;
                case '/':
                    Result02 = Number10 / Number11;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine("Result: " + Result02);
            #endregion


            #region Reverse a String
            Console.Write("Enter a string: ");
            string Input = Console.ReadLine();

            char[] Characters = Input.ToCharArray();
            Array.Reverse(Characters);
            Console.WriteLine(new string(Characters));
            #endregion


            #region Reverse an Integer
            Console.Write("Enter an integer: ");
            int Number12 = int.Parse(Console.ReadLine());

            int ReversedNumber = 0;
            while (Number12 > 0)
            {
                int Digit = Number12 % 10;
                ReversedNumber = ReversedNumber * 10 + Digit;
                Number12 /= 10;
            }

            Console.WriteLine("Reversed number: " + ReversedNumber);
            #endregion


            #region Print Prime Number within a Range
            //Prime number is a positive integer greater than 1 that has no positive integer divisors other than 1 and itself.
            //If a number N is not prime, it must have at least one divisor less than or equal to its square root.
            Console.Write("Enter starting number of range: ");
            int Start = int.Parse(Console.ReadLine());

            Console.Write("Enter ending number of range: ");
            int End = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between " + Start + " and " + End + " are:");

            for (int Number13 = Start; Number13 <= End; Number13++)
            {
                bool PrimeNumber = true;
                for (int i = 2; i <= Math.Sqrt(Number13); i++)
                {
                    if (Number13 % i == 0)
                    {
                        PrimeNumber = false;
                        break;
                    }
                }

                if (PrimeNumber && Number13 > 1)
                {
                    Console.Write(Number13 + " ");
                }
            }
            #endregion


            #region Convert Decimal to Binary
            //Converting a decimal number to a binary number is by dividing the given number repeatedly by 2 until we get 0 as the quotient.
            Console.Write("Enter a number to convert: ");
            int Number14 = int.Parse(Console.ReadLine());

            string Binary = "";
            while (Number14 > 0)
            {
                int Remainder = Number14 % 2;
                Binary = Remainder + Binary;
                Number14 /= 2;
            }

            Console.WriteLine("The Binary of " + Number14 + " is " + Binary);
            #endregion


            #region Check If 3 Points Lies on the Same Straight Line
            //For three points to be collinear, the slopes between any two pairs of points must be equal: (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1)
            Console.Write("Enter x1, y1: ");
            int X1 = int.Parse(Console.ReadLine());
            int Y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter x2, y2: ");
            int X2 = int.Parse(Console.ReadLine());
            int Y2 = int.Parse(Console.ReadLine());

            Console.Write("Enter x3, y3: ");
            int X3 = int.Parse(Console.ReadLine());
            int Y3 = int.Parse(Console.ReadLine());

            Console.WriteLine((Y2 - Y1) * (X3 - X2) == (Y3 - Y2) * (X2 - X1) ? "On a line" : "Not on a line");
            #endregion


            #region calculate the Efficiency of a Worker
            Console.Write("Enter the time taken to complete the task (in hours): ");
            double TimeTaken = double.Parse(Console.ReadLine());

            if (TimeTaken >= 2 && TimeTaken <= 3)
            {
                Console.WriteLine("Highly Efficient");
            }
            else if (TimeTaken > 3 && TimeTaken <= 4)
            {
                Console.WriteLine("Increase your speed");
            }
            else if (TimeTaken > 4 && TimeTaken <= 5)
            {
                Console.WriteLine("Training required to enhance speed");
            }
            else if (TimeTaken > 5)
            {
                Console.WriteLine("Leave the company");
            }
            else
            {
                Console.WriteLine("Invalid input. Time taken cannot be negative or zero.");
            }
            #endregion
        }
    }
}