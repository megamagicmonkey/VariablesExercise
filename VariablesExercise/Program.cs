using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string tString = "Test String";
            int tInt = 10;
            char tChar = 'T';
            bool tBool = true;
            double tDouble = 10.01;
            decimal tDecimal = 10.02m;

            Console.WriteLine("A printing out of test variables as follows:");
            Console.WriteLine($"String:{tString} Integer:{tInt} Character:{tChar} Boolean:{tBool} Double:{tDouble} Decimal:{tDecimal}");
        }
    }
}
