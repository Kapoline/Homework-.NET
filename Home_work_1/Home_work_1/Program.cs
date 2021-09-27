using System;

namespace Home_work_1
{
    internal class Program
    {
        static int IsArgumentsEnough(string[] arg)
        {
            if (arg.Length == 3)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        enum Exception
        {
            NotEnoughArguments = 1,
            SomeOrAllArgsNotInteger = 2,
            OperatorDoseNotExist = 3,
            AllDone = 0,
        }

        public static int Main(string[] args)
        {
            if (IsArgumentsEnough(args) == 2)
            {
                return 0;
            }

            if (!Parser.IsInt(args[2], out var num2) || !Parser.IsInt(args[0], out var num1))
            {
                return 1;
            }

            var operation = Parser.OperationDetector(args[1]);

            if ( operation == Calculator.operations.UnknownOperation)
            {
                return 2;
            }

            var result = Calculator.Calculate(num1, num2,  operation);

            Console.WriteLine($"{num1}{args[1]}{num2}={result}");

            return 3;
        }
    }
}