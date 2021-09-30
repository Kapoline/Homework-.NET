﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Home_work_1
{
    [ExcludeFromCodeCoverage]
    public static class Program
    {
        private static int _notEnoughArguments = 1;
        private static int _someOrAllArgsNotInteger = 2;
        private static int _unknownOperation = 3;
        

        public static int Main(string[] args)
        {
            var operation = IL_library_.Parser.OperationDetector(args[1]);
            if (args.Length == 2)
                return _notEnoughArguments;
            if (!IL_library_.Parser.IsInt(args[0], out var var1) || !IL_library_.Parser.IsInt(args[2], out var var2))
                return _someOrAllArgsNotInteger;
            if (operation == IL_library_.Calculator.operations.UnknownOperation)
                return _unknownOperation;
            
            var result = IL_library_.Calculator.Calculate(var1, var2,  operation);
            Console.WriteLine($"{var1}{args[1]}{var2}={result}");
            
            return 0;
        }
    }
}