using System.Drawing;

namespace CSharpBasics01
{
    internal class Program
    {
        static void Main()
        {
            #region Region
            Console.WriteLine("Hello World");
            #endregion


            #region Variable Declaration
            //Varivale Declaration: DataType VariableName
            int Number; //Declared vairiable
                        //Allocated unintialized 4 bytes at memory

            //Console.WriteLine(Number); //Invalid

            Number = 5;
            Console.WriteLine(Number);

            int Number01 = 2;
            int Number02 = 3;
            int Number03 = 5;
            Console.WriteLine(Number01); //Output: 2

            int Number04 = 4, Number05 = 7, Number06 = 8;
            Console.WriteLine(Number05); //Output: 7
            #endregion


            #region Value Data Type
            //Data Type: Value Type: Stored in stack
            int Number09; //Declared variable of value type
                          //Allocated unintialized 4 bytes at stack
                          //int: C# keyword (int Number; in C# = int32 Number; in BCL)

            Number09 = 12;
            Console.WriteLine(Number09);
            #endregion


            #region Reference Data Type
            //Data Type: Reference Type:
            Point P01; //Declared variable of reference type
                       //8 bytes will be allocated at stack for the 'P01', and 0 bytes will be allocated at heap
                       //P01: Refer to object from type 'Point'

            //Console.WriteLine(P01); 
            //Unassigned varibale since it only carries the address of another variable

            P01 = new Point();
            //STEP 01: Allocates the number of required bytes for the object at heap
            //STEP 02: Initializes the allocated byte with default value of the data type 
            //STEP 03: Calls user-defined constructor if exist
            //STEP 04: Assigns the object address to the reference 'P01'

            Console.WriteLine(P01.X); //Output: 0
            Console.WriteLine(P01.Y); //Output: 0
            Console.WriteLine(P01); //Output: Namespace name

            Point P02 = new Point();
            P02.X = 22;

            Console.WriteLine(P02.X); //Output: 22
            Console.WriteLine(P02.Y); //Output: 0

            P01 = P02;
            Console.WriteLine(P01.X); //Output: 22
            Console.WriteLine(P02.X); //Output: 22
            #endregion


            #region Casting
            //Casting: Converting from data type to anither data type

            //Casting: Implicit Casting: 
            int X = 5;
            double Y = X; //Implicit Casting (Safe Casting: Affects data type)
            Console.WriteLine(Y);

            //Casting: Explicit Casting
            double R = 2.5;
            //int Z = R; //Invalid
            int Z = (int)R; //Explicit Casting (Unsafe Casting: don't affect data type)
            Console.WriteLine(Z);
            #endregion


            #region Convert, Parse, and TryParse
            //Parse: Built-In Function (Unsafe Conversion)
            Console.WriteLine("Enter your age:  ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age: " + Age);


            //Convert: Built-In Class (Unsafe Conversion)
            Console.WriteLine("Enter your salary:  ");
            int Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salary: " + Salary);


            //TryParse: Built-In Function
            Console.WriteLine("Enter your height:   ");
            int Height;
            bool Flag = int.TryParse(Console.ReadLine(), out Height);
            Console.WriteLine("Height:  " + Height);
            Console.WriteLine("Flag:  " + Flag);
            #endregion


            #region Operators
            ////Unary Operator: Works on one operand (variable)
            int L = 10;
            //Prefix: Increment then print
            Console.WriteLine(++L); //Output: 11
                                    //Postfix: Print then increment
            Console.WriteLine(L++); //Output: 10
            Console.WriteLine(L); //Output: 11

            int K = 10;
            //Prefix: Decrement then print
            Console.WriteLine(--K); //Output: 9
                                    //Postfix: Print then decrement
            Console.WriteLine(K--); //Output: 10
            Console.WriteLine(K); //Output: 9



            ////Binary Operator: Works on two operand (variable)
            int Sum, Sub, Mul, Mod;
            int Number10 = 2, Number11 = 6;

            Sum = Number10 + Number11; //Output: 8
            Sub = Number10 - Number11; //Output: -4
            Mul = Number10 * Number11; //Output: 12
            Mod = Number10 % Number11; //Output: 2



            ////Assignment Operators
            int Q;
            Q = 4;

            Q += 2; //Output: Q = Q + 2
            Q -= 2; //Output: Q = Q - 2
            Q *= 2; //Output: Q = Q * 2
            Q /= 2; //Output: Q = Q / 2
            Q %= 2; //Output: Q = Q % 2



            ////Relational Operator
            int V = 6, W = 7;

            Console.WriteLine(V == W); //Output: False
            Console.WriteLine(V != W); //Output: True
            Console.WriteLine(V > W); //Output: False
            Console.WriteLine(V < W); //Output: True
            Console.WriteLine(V >= W); //Output: False 
            Console.WriteLine(V <= W); //Output: True



            ////Logical Operators
            Console.WriteLine(!false); //!: NOT Operator
            Console.WriteLine(false && true); //&&: AND Operator (Short Circuit)
            Console.WriteLine(false || true); //||: OR Operator (Short Circuit)



            ////Bitwise Operators
            Console.WriteLine(!false); //!: NOT Operator
            Console.WriteLine(false & true); //&: AND Operator (Long Circuit)
            Console.WriteLine(false | true); //|: OR Operator (Long Circuit)



            ////Ternary Operator (Conditional Operator)
            bool Flag01 = 4 > 2;
            Console.WriteLine(Flag01); //Output: True

            string Flag02 = 4 > 2 ? "True" : "False";
            Console.WriteLine(Flag02);
            #endregion
        }
    }
}