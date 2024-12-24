namespace CSharpBasics02
{
    internal class Program
    {
        static void Main()
        {
            #region String Formatting
            //// String Formatting
            Console.WriteLine("Equation: 4 + 3 = 7"); //Output: Equation: 4 + 3 = 7

            string Message = "Equation: 4 + 3 = 7";
            Console.WriteLine(Message); //Output: Equation: 4 + 3 = 7


            // (1) String Concatenation
            int X = 4, Y = 3;
            string Message01 = "Equation: " + X + " + " + Y + " = " + (X + Y);
            Console.WriteLine(Message01); //Output: Equation: 4 + 3 = 7
            //String is an immutable data type, so its value can't be changed after creation.


            // (2) String Format
            //string Message02 = string.Format("Equation: 4 + 3 = 7", X, Y, X + Y);
            string Message02 = string.Format("Equation: {0} + {1} = {2}", X, Y, X + Y);
            Console.WriteLine(Message02); //Output: Equation: 4 + 3 = 7


            // (3) String Interpolation using Manipulation Operator ($)
            string Message03 = $"Equation: {X} + {Y} = {X + Y}";
            #endregion


            #region Conditional Statements using Numeric Data Types
            //// Control Statements (Conditional / Loop)
            // (1) Control Statement: Conditional Statement (If Satement / Swith Statement)

            // ==> Given a month number, print the corresponding month name  using conditional statements
            Console.Write("Enter month number in the 1st quarter: ");
            int MonthNumber = int.Parse(Console.ReadLine());


            //Using If Statement
            if (MonthNumber == 1)
            {
                Console.WriteLine("Jan");
            }
            else if (MonthNumber == 2)
            {
                Console.WriteLine("Feb");
            }
            else if (MonthNumber == 3)
            {
                Console.WriteLine("Mar");
            }
            else
            {
                Console.WriteLine("Month number is not valid!");
            }


            //Using Switch Statement
            switch (MonthNumber)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break;

                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Mar");
                    break;
                default:
                    Console.WriteLine("Month number is not valid!");
                    break;
            }
            //NOTE: Switch statement creates 'Jump Table' in the runtime which includes all cases and the values corresponding to it.
            //NOTE: Jump table is created upon hash table theory which increases the performance of the switch statement.
            #endregion


            #region Conditional Statements using String Data Types
            // ==> Given a user-entered name, print a personalized greeting based on the name, handling both case-sensitive and case-insensitive comparisons using conditional statements
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();


            //Using If Statement
            if (Name == "Ahmed" || Name == "ahmed")
            {
                Console.WriteLine("Hi Ahmed!");
            }
            else if (Name == "Mohamed" || Name == "mohamed")
            {
                Console.WriteLine("Hi Mohamed");
            }
            else if (Name == "Mahmoud" || Name == "mahmoud")
            {
                Console.WriteLine("Hi Mohamed");
            }
            else if (Name == "Moustafa" || Name == "moustafa")
            {
                Console.WriteLine("Hi Mohamed");
            }
            else
            {
                Console.WriteLine("Inavlid input!");
            }


            //Using Switch Statement
            switch (Name)
            {
                case "Ahmed":
                case "ahmed":
                    Console.WriteLine("Hi Ahmed!");
                    break;

                case "Mohamed":
                case "mohamed":
                    Console.WriteLine("Hi Mohamed!");
                    break;

                case "Mahmoud":
                case "mahmoud":
                    Console.WriteLine("Hi Ahmed!");
                    break;

                case "Moustafa":
                case "moustafa":
                    Console.WriteLine("Hi Ahmed!");
                    break;

                default:
                    Console.WriteLine("Inavlid input!");
                    break;
            }
            //NOTE: Switch statements don't support logical operators.
            #endregion


            #region Conditional Statements using Numeric Data Types and Comparison Operators
            // ==> Given a user's age, determine whether they are an adult or a minor using conditional statements
            Console.Write("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());


            //Using If Statement
            if (Age > 18)
            {
                Console.WriteLine("You are older than 18, Welcome!");
            }
            else if (Age < 18)
            {
                Console.WriteLine("You are under than 18, Exit!");
            }
            else
            {
                Console.WriteLine("Meh!");
            }


            //Using Switch Statement #1
            switch (Age > 18)
            {
                case true:
                    Console.WriteLine("You are older than 18, Welcome!");
                    break;
                case false:
                    if (Age < 18)
                    {
                        Console.WriteLine("You are under than 18, Exit!");
                    }
                    else
                    {
                        Console.WriteLine("Meh!");
                    }
                    break;
            }


            //Using Switch Statement #2
            switch (Age)
            {
                case > 18:
                    Console.WriteLine("You are under than 18, Exit!");
                    break;
                case < 18:
                    Console.WriteLine("You are under than 18, Exit!");
                    break;
                default:
                    Console.WriteLine("Meh!");
                    break;
            }
            #endregion


            #region For and Foreach Loop
            //// Control Statements (Conditional / Loop)
            // (2) Loop Statement: Conditional Statement (For, Foreach, While, Do...While)

            // (2.1) For Loop:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World!");
            }


            int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }


            // (2.2) Foreach Loop:
            foreach (int N in Numbers)
            {
                Console.WriteLine(N);
            }
            #endregion


            #region While and Do...While Loop
            // (2.3) While Loop:
            while (true)
            {
                Console.WriteLine("Hello World!");
            }
            //NOTE: The code will be repeated whenever the expression is true.


            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Hello World!");
                i++;
            }


            // (2.4) Do...While Loop:
            do
            {
                Console.WriteLine("Hello World!");
                i++;
            } while (i <= 10);
            //NOTE: The code within the block is executed, then the condition is evaluated.


            int Number;
            bool Flag;
            do
            {
                Console.Write("Enter an even number: ");
                Flag = int.TryParse(Console.ReadLine(), out Number);
            } while (Number % 2 != 0);
            Console.WriteLine(Number);
            #endregion


            #region String
            //String: Built-in class of reference Data Type (Stored in heap)
            //Value of string can't be changed after creation, as it is of immutable type.

            string S01;
            //Declared a reference data (pointer) of type 'String'.
            //S01: Can refer to an object of type 'String', and it currently refers to NULL.
            //8 bytes will be allocated at stack for each reference 'S01', while 0 bytes will be aloocated at heap.

            S01 = new string("Mohamed");
            //Creating new object:
            //STEP 01: Allocates the number of required bytes for the object at heap.
            //STEP 02: Initializes the allocated bytes with the default value.
            //STEP 03: Calls the user-defined constructor if exists.
            //STEP 04: Assigns the object to the reference.
            Console.WriteLine("S01: " + S01);
            Console.WriteLine("S01HashCode: " + S01.GetHashCode());
            Console.WriteLine();

            //S01 = "Mohamed"; //Syntax Sugar

            S01 = "Mahmoud"; //New object is created, and the "Mohamed" object will be not reachable
            Console.WriteLine("S01: " + S01);
            Console.WriteLine("S01HashCode: " + S01.GetHashCode()); //Different HashCode
            Console.WriteLine();
            #endregion


            #region StringBuilder
            //StringBuilder: Built-in class of reference Data Type (Stored in heap)
            //Value of StringBuilder can be changed after creation, as it is of mutable type.

            StringBuilder S02;
            //Declared a reference data (pointer) of type 'String'.
            //S02: Can refer to an object of type 'String', and it currently refers to NULL.

            S02 = new StringBuilder("Ahmed");
            //Creating new object:
            //STEP 01: Allocates the number of required bytes for the object at heap.
            //STEP 02: Initializes the allocated bytes with the default value.
            //STEP 03: Calls the user-defined constructor if exists.
            //STEP 04: Assigns the object to the reference.
            Console.WriteLine("S02: " + S02);
            Console.WriteLine("S02HashCode: " + S02.GetHashCode());
            Console.WriteLine();

            S02.Append(S02);

            Console.WriteLine("S01: " + S02);
            Console.WriteLine("S01HashCode: " + S02.GetHashCode()); //Same HashCode
            Console.WriteLine();
            #endregion


            #region String Methods
            //String Methods: Substring, Replace, StartsWith, ToCharArray, IndexOf, ... etc.
            string S03 = "Hello World!";

            string Result01 = S03.Substring(S03.Length);
            Console.WriteLine(Result01);

            var Result02 = S03.Replace("Hello", "Welcome");
            Console.WriteLine(Result02);
            #endregion
        }
    }
}
