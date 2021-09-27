﻿using System;

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
            NotEnoughArguments = 0,
            SomeOrAllArgsNotInteger = 1,
            OperatorDoseNotExist = 2,
            AllDone = 3,
        }

        public static int Main(string[] args)
        {
            if (IsArgumentsEnough(args) == 2)
            {
                return 0;
            }

            if (!IL_Library_1.Parser.IsInt(args[2], out var num2) || !IL_Library_1.Parser.IsInt(args[0], out var num1))
            {
                return 1;
            }

            var operation = IL_Library_1.Parser.OperationDetector(args[1]);

            if ( operation == IL_Library_1.Calculator.operations.UnknownOperation)
            {
                return 2;
            }

            var result = IL_Library_1.Calculator.Calculate(num1, num2,  operation);

            Console.WriteLine($"{num1}{args[1]}{num2}={result}");

            return 3;
        }
    }
}