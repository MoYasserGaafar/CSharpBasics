using System.Drawing;

namespace CShrapBasics01A
{
    internal class Program
    {
        static void Main()
        {
            #region Printing a Number
            Console.WriteLine("Enter a number:  ");

            int Number01 = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + Number01);
            #endregion


            #region Converting String to Integer
            string InputString = "123abc";
            int ParsedInt;
            bool Flag = int.TryParse(InputString, out ParsedInt);

            Console.WriteLine("ParsedInt:  " + ParsedInt); //Output: 0
            Console.WriteLine("Flag:  " + Flag); //Output: False
            #endregion


            #region Simple Arithmetic Operation with Floating-Point Numbers
            double Number02 = 3.14, Number03 = 2.7;
            double Result01 = Number02 + Number03;

            Console.WriteLine("Result: " + Result01); //Output: Result: 5.84
            #endregion


            #region Extracting a Substring
            string Str = "Mastering C#";
            string SubStr = Str.Substring(0, 6);

            Console.WriteLine(SubStr); //Output: Master
            #endregion


            #region Assigning Value Type
            int Number04 = 10;
            int Number05 = Number04;
            Number05 = 20;

            Console.WriteLine(Number04); // Output: 10
            Console.WriteLine(Number05); // Output: 20
            #endregion


            #region Assigning Reference Type
            Point P01 = new Point();
            Point P02 = new Point();
            P02.X = 22;
            P01 = P02;

            Console.WriteLine(P01.X); //Output: 22
            Console.WriteLine(P02.X); //Output: 22
            #endregion


            #region Concatenating Strings
            string String01 = "Mastering";
            string String02 = "C#";
            string ConcatenatedString = String01 + " " + String02;

            Console.WriteLine(ConcatenatedString); // Output: Mastering C#
            #endregion


            #region Simple Interest
            double Principal = 1000, Rate = 5, Time = 2;
            double Interest = (Principal * Rate * Time) / 100;

            Console.WriteLine("Simple Interest: " + Interest); //Output: Simple Interest: 100
            #endregion


            #region BMI Calculation
            double Weight = 80, Height = 1.82;
            double BMI = Weight / (Height * Height);

            Console.WriteLine("BMI: " + BMI); //Output: BMI: 24.151672
            #endregion


            #region Temperature Check
            int Temperature = 25;
            string Message = Temperature < 10 ? "Just Cold" : Temperature > 30 ? "Just Hot" : "Just Good";

            Console.WriteLine(Message); //Output: Just Good
            #endregion


            #region Date Formatting
            DateTime Today = DateTime.Now;

            Console.WriteLine("Today's date: {0:dd, MM, yyyy}", Today); //Output: Today's date: 13, 12, 2024
            Console.WriteLine("Today's date: {0:dd/MM/yyyy}", Today); //Output: Today's date: 13-12-2024
            Console.WriteLine("Today's date: {0:dd-MM-yyyy}", Today); //Output: Today's date: 13-12-2024
            #endregion


            #region Date Formatting
            DateTime Date = new DateTime(2024, 6, 14);

            Console.WriteLine($"The event is on {Date:MM/dd/yyyy}"); //Output: The event is on 06-14-2024
            #endregion


            #region Boolean Expression and Integer Conversion
            int D;
            D = Convert.ToInt32(!(30 < 20));

            Console.WriteLine(D); //Output: 1
            #endregion


            #region Integer Division and Modulus
            Console.WriteLine(13 / 2 + " " + 13 % 2); //Output: 6  1
            #endregion


            #region Increment and Decrement Operators
            int Num = 1, z = 5;

            if (!(Num <= 0))
                Console.WriteLine(++Num + z++ + " " + ++z);
            else
                Console.WriteLine(--Num + z-- + " " + --z); //Output: 7 7
            #endregion
        }
    }
}