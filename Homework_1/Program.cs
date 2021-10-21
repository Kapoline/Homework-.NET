using System;
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
            var operation =  F_Calculator.Parser.OperatorDetector(args[1]);
            if (args.Length == 2)
                return _notEnoughArguments;
            if (!F_Calculator.Parser.IsInt(args[0], out var var1) || !F_Calculator.Parser.IsInt(args[2], out var var2))
                return _someOrAllArgsNotInteger;
            //if (!F_Calculator_RCE.Parser_RCE.parserInt<int>(args[0]) || !F_Calculator_RCE.Parser_RCE.parserInt<int>(args[2]))
                //return _someOrAllArgsNotInteger
            if (operation == F_Calculator.Calculator.Operations.UnknownOperation)
                return _unknownOperation;
            var result = F_Calculator.Calculator.Calculate(var1, var2,  operation);
            Console.WriteLine($"{var1}{args[1]}{var2}={result}");
            
            return 0;
        }
    }
}