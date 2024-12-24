namespace CSharpBasics04
{
    internal class Program
    {
        static void Main()
        {
            #region Boxing and Unboxing
            ////Boxing and Unboxing
            // (1) Boxing: Casting from value type to reference type.
            // (2) Unboxing: Casting from reference type to value type.

            object Object01;
            //Object01: Refers to an instance of "Object" or any instance of any type.

            Object01 = 22;
            Object01 = 'Mohamed';

            Object01 = 32;     //Cast from value type [int] to reference type [object] ==> Boxing.
            Object01 = 32.5;   //Cast from value type [double] to reference type [object] ==> Boxing.
            Object01 = 'M';    //Cast from value type [char] to reference type [object] ==> Boxing.
            Object01 = true;   //Cast from value type [bool] to reference type [object] ==> Boxing.


            int X = 22;
            Object01 = X; //Implicit Casting (Safe Casting) ==> Boxing.
            //NOTE: [int] is [object]: Points on instance of [int] using reference of [object].


            object Object02;
            Object02 = 22;
            int Y = (int) Object02; //Explicit Casting (Unsafe Casting) ==> Unboxing.
            #endregion




            #region Nullable Value Type
            //Data Types: Value Type / Reference Type

            int Z = 6; //Value type holds integer value
            //Q = null; //Invalid


            //Nullable Value: Value type which allows null as a valid value.
            int? Age = 28; //Nullable Integer: Allows [int] as a value or [null] as a valid value.
            Age = null;

            double? Salary = 19000.5; //Nullable Double: Allows [double] as a value or [null] as a valid value.
            Salary = null;


            int Q = 5;
            int? R = Q; //Output: 5
            //Nullable Integer: Allows [int] as a value or [null] as a valid value.
            //Implicit Casting (Safe Casting).

            int? X = 5;
            int Y = X; //Invalid
            //NOTE: Y is an integer that allows [int] value only, while X may allow a [null] value.
            //int Y = (int) X; //Explicit Casting (Unsafe Casting).


            //Defensive code to deal with null values #1
            if (X != null)
                Y = (int)X;
            else
                Y = 0;

            Console.WriteLine(Y);


            //Defensive code to deal with null values #2
            if (X is not null)
                Y = (int)X;
            else
                Y = 0;

            Console.WriteLine(Y);


            //Defensive code to deal with null values #3
            if (X.HasValue)
                Y = X.Value;
            else
                Y = 0;

            Console.WriteLine(Y);

            //Y = X.HasValue ? X.Value : 0;
            //Y = X is not null ? X.Value : 0;
            //Y = X ?? 0; //Null Coalescing Operator 
            #endregion




            #region Nullable Reference Type
            string Message = "Hello";
            Message = null;
            Console.WriteLine(Message); //Output:


            string Message01 = null; //Required String
            Console.WriteLine(Message01); //Output:
            Console.WriteLine(Message01.Length); //Null Reference Excpetion: Object reference not set to an instance of an object.

            string? Message02 = null; //Nullable Reference Type (Nullable String)
            Console.WriteLine(Message02); //Output:
            #endregion




            #region Null-Propagation Operator (?)
            double D = default;
            Console.WriteLine(D); //Output: 0

            char C = default; 
            Console.WriteLine(C); //Output:

            bool B = default;
            Console.WriteLine(B); //Output: False


            //NOTE: Default value of any reference type is null.
            int[] Arr = default; //Points to null

            for (int i = 0; i < Arr.Length; i++)
                Console.WriteLine(Arr[i]); //Null Reference Excpetion: Object reference not set to an instance of an object.

            for (int i = 0; (Arr is not null) && i < Arr.Length; i++)
                Console.WriteLine(Arr[i]); //Arr is null

            for (int i = 0; i < Arr?.Length; i++)
                Console.WriteLine(Arr[i]); //Arr is null


            //Best Practice to check for null
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                    Console.WriteLine(Arr[i]);
            }


            int? Len = Arr?.Length; //Output:
            //int? Len = Arr?.Length is not null ? Arr.Length : 0; //Arr is null
            int Len = Arr?.Length ?? 0;
            #endregion
        }
    }
}
