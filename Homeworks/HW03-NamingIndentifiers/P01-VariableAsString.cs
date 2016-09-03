namespace VariableAsString
{
    using System;

    class Startup
    {
        static void PrintBoolAsString(bool InputBool)
        {
            string BoolAsString = InputBool.ToString();
            Console.WriteLine(BoolAsString);
        }

        public static void Main()
        {
            PrintBoolAsString(true);
        }
    }
}