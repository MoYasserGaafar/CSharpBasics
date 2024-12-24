namespace CSharpBasics03
{
    // namespace contains:
    // 1. Class     --> Contains Functions
    // 2. Struct    --> Contains Functions
    // 3. Interface --> Contains Functions
    // 4. Enum     
    internal class Program
    {
        #region Functions Prototype
        //PrintText() Function
        static void PrintText()
        {
            //Body of function
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Printing :)");
            }
        }


        //PrintTextUsingCount() Function
        static void PrintTextUsingCount(int Count)
        {
            //Body of function
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("Printing :)");
            }
        }


        //SumNumbers() Function
        static int SumNumbers(int Number01, int Number02)
        {
            return Number01 + Number02;
        }
        #endregion




        #region Passing Parameters of Value Type
        //ValSWAP() Function
        static void ValSWAP(int X, int Y) 
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }


        //RefSWAP() Function
        static void RefSWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion




        #region Passing Parameters of Reference Type
        //ValSumArray() Function
        static int ValSumArray(int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;

            for(int i = 0;i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }

            return Sum;
        }


        //RefSumArray() Function
        static int RefSumArray(ref int[] Arr)
        {
            int Sum = 0;
            Arr[0] = 100;

            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }

            return Sum;
        }
        #endregion




        #region Returns of Function
        static int[] SumMul(int X, int Y) 
        {
            int[] Result = { X + Y, X * Y };
            return Result;
        }


        class NewData
        {
            public int Sum;
            public int Mul;
        }

        static NewData SumMul(int X, int Y)
        {
            NewData data = new NewData();
            data.Sum = X + Y;
            data.Mul = X * Y;

            return data;
        }
        #endregion




        #region Passing Parameters by Output
        static void MulSum(int X, int Y, out int Sum, out int Mul)
        {
            Sum = X + Y;
            Mul = X * Y;
        }
        #endregion




        #region Params
        static int SumArray(params int[] Arr) 
        { 
            int Sum = 0;

            for (int i = 0; i < Arr.Length; i++) 
            {
                Sum += Arr[i];
            }

            return Sum;
        }
        #endregion




        //Entry Point
        static void Main()
        {
            #region Array: One-D Array
            ////Array
            // (1) One-D Array
            int[] Numbers;
            //Declares a reference variable that can hold the address of an array of integers.
            //This refernce can refer to object of type array of integers.
            //Initially, this reference is null, meaning it doesn't point to any actual array object in memory.
            //8 bytes will be allocated at stack for the refernce.
            //0 butes will be allocated at heap for the refernce.

            Numbers = new int[5];
            //Creating new object:
            //STEP 01: Allocates the number of required bytes for the object at heap.
            //STEP 02: Initializes the allocated bytes with the default value.
            //STEP 03: Calls the user-defined constructor if exists.
            //STEP 04: Assigns the object to the reference.

            Numbers[0] = 12;
            Numbers[1] = 6;
            Numbers[2] = 7;
            Numbers[3] = 11;
            Numbers[4] = 19;
            Numbers[5] = 20; //Out of range: Index was outside the bounds of the array

            Console.WriteLine(Numbers[0]);
            Console.WriteLine(Numbers[1]);
            Console.WriteLine(Numbers[2]);
            Console.WriteLine(Numbers[3]);
            Console.WriteLine(Numbers[4]);


            int[] Numbers01 = { 12, 6, 7, 11, 19, 20 };
            int[] Numbers02 = new int[6];
            

            Console.Write("Enter Numbers[0]: ");
            Numbers[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter Numbers[1]: ");
            Numbers[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter Numbers[2]: ");
            Numbers[2] = int.Parse(Console.ReadLine());
            Console.Write("Enter Numbers[3]: ");
            Numbers[3] = int.Parse(Console.ReadLine());
            Console.Write("Enter Numbers[4]: ");
            Numbers[4] = int.Parse(Console.ReadLine());
            Console.Write("Enter Numbers[5]: ");
            Numbers[5] = int.Parse(Console.ReadLine());


            // One-D Array using for loop:
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Enter Numbers[{i}]: ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"{Numbers[i]} ");
            }


            Console.WriteLine(Numbers.Length); //Returns size
            Console.WriteLine(Numbers.Rank); //Returns dimension
            #endregion




            #region Array: Two-D Array: Rectangle Array
            // (2) Two-D Array
            // (2.1) Rectangle Array
            int[,] Marks = new int[3, 3];

            Marks[0, 0] = 99;
            Marks[0, 1] = 99;
            Marks[0, 2] = 99;

            Marks[1, 0] = 88;
            Marks[1, 1] = 87;
            Marks[1, 2] = 80;

            Marks[2, 0] = 78;
            Marks[2, 1] = 74;
            Marks[2, 2] = 70;

            Console.WriteLine(Marks[0, 0]);
            Console.WriteLine(Marks[0, 1]);
            Console.WriteLine(Marks[0, 2]);

            Console.WriteLine(Marks[1, 0]);
            Console.WriteLine(Marks[1, 1]);
            Console.WriteLine(Marks[1, 2]);

            Console.WriteLine(Marks[2, 0]);
            Console.WriteLine(Marks[2, 1]);
            Console.WriteLine(Marks[2, 2]);


            // Rectangle Array using for loop:
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Marks[{i}, {j}]: ");
                    Marks[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{Marks[i, j]} ");
                }
                //Conaole.WriteLine(); //Print Marks[i, j] as matrix
            }
            #endregion




            #region Array: Two-D Array: Jagged Array
            // (2.2) Jagged Array
            int[][] Grades = new int[3][];

            Grades[0] = new int[] { 1, 2, 3 };
            Grades[1] = new int[] { 1, 2 };
            Grades[2] = new int[] { 1, 2, 3, 4 };


            // Jagged Array using for loop:
            Grades[0] = new int[2];
            Grades[1] = new int[5];
            Grades[2] = new int[1];

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < Grades[i].Length; j++)
                {
                    Console.Write($"Grades[{i}][{j}]: ");
                    Grades[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < Grades[i].Length; j++)
                {
                    Console.WriteLine($"{Grades[i][j]}");
                }
            }
            #endregion



            #region Functions Prototype
            ////Functions
            //Functions are block code which is called by a user-defined name when needed to be executed.
            //Function Prototype: Signature (Name, Return Type and Parameters) / Body (Code)
            //Methods (Functions): Class Member Method (Static Method) / Object Member Method (Non-Static Method)

            //Calling function
            PrintText();

            //Calling function
            PrintTextUsingCount(5);

            //Calling function
            int Sum = SumNumbers(2, 4);
            Console.WriteLine(Sum);
            #endregion




            #region Passing Parameters of Value Type
            ////Passing Parameters of Value Type: (Passing by Value / Passing by Reference)
            // (1) Passing by Value
            int A = 4, B = 5;

            Console.WriteLine($"A : {A}"); //Output: 4
            Console.WriteLine($"B : {B}"); //Output: 5

            Console.WriteLine(" ==> AFTER SWAP <== ");

            ValSWAP(A, B); //Passing by Value

            Console.WriteLine($"A : {A}"); //Output: 4 !!!!
            Console.WriteLine($"B : {B}"); //Output: 5 !!!!
            //NOTE: X and Y variables are affected by SWAP() function not A and B variables.


            // (2) Passing by Reference
            int C = 4, D = 5;

            Console.WriteLine($"C : {C}"); //Output: 4
            Console.WriteLine($"D : {D}"); //Output: 5

            Console.WriteLine(" ==> AFTER SWAP <== ");

            RefSWAP(ref C, ref D); //Passing by Reference

            Console.WriteLine($"C : {C}"); //Output: 5
            Console.WriteLine($"D : {D}"); //Output: 4
            //NOTE: X and Y variables are affected by SWAP() function same as A and B variables.
            #endregion



            #region Passing Parameters of Reference Type
            ////Passing Parameters of Reference Type: (Passing by Value / Passing by Reference)
            // (1) Passing by Value
            int[] RandomNumbers = { 3, 2, 1 };
            int Result = ValSumArray(RandomNumbers); //Passing by Value

            Console.WriteLine(Result); //Output: 3 + 2 + 100 = 105
            Console.WriteLine(RandomNumbers[0]);


            // (2) Passing by Reference
            int[] RandomNumbers = { 3, 2, 1 };
            int Result = RefSumArray(ref RandomNumbers); //Passing by Reference

            Console.WriteLine(Result); //Output: 3 + 2 + 100 = 105
            Console.WriteLine(RandomNumbers[0]);
            #endregion




            #region Returns of Function
            int E = 3, F = 4;
            int[] Result = SumMul(E, F);

            Console.WriteLine(Result[0]); //Output: 3 + 4 = 7
            Console.WriteLine(Result[1]); //Output: 3 * 4 = 12


            int E = 3, F = 4;
            NewData Result = SumMul(E, F);

            Console.WriteLine(Result.Sum); //Output: 3 + 4 = 7
            Console.WriteLine(Result.Mul); //Output: 3 * 4 = 12
            #endregion




            #region Passing Parameters by Output
            ////Passing Parameters by Output
            int G = 4, H = 5, Sum, Mul;
            MulSum(G, H, out Sum, out Mul);

            Console.WriteLine(Sum); //Output: 4 + 5 = 9
            Console.WriteLine(Mul); //Output: 4 * 5 = 20
            #endregion




            #region Params
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(SumArray(Numbers)); //Output: 26
            #endregion
        }
    }
}
