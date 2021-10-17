using System;
using Home_work_1;
using NUnit.Framework;


namespace Calculator_tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Plus()
        {
            //Arrange
            var var1 = 1;
            var var2 = 2;
            var operation = F_Calculator.Calculator.Operations.Plus;

            //Act
            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Minus()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = F_Calculator.Calculator.Operations.Minus;

            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Mult()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = F_Calculator.Calculator.Operations.Mult;

            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = F_Calculator.Calculator.Operations.Divide;

            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);

            Assert.AreEqual(2, result);
        }
        
        [Test]
        public void DivedNotZero()
        {
            var var1 = 1;
            var var2 = 0;
            var operation = F_Calculator.Calculator.Operations.Divide;
            try
            {
                F_Calculator.Calculator.Calculate(var1, var2, operation);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.DivideByZero.Message, e.Message);
            }
        }

        [Test]
        public void OperationIsUnknown()
        {
            var var1 = 1;
            var var2 = 2;
            var operation = F_Calculator.Calculator.Operations.UnknownOperation;
            try
            {
                F_Calculator.Calculator.Calculate(var1, var2, operation);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.WrongOperator.Message, e.Message);
            }
        }
    }

    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void Arguments()
        {
            var var1 = '=';
            var var2 = '-';
            Calculator.operations operations = default;
            try
            {
                Calculator.Calculate(var1, var2, operations);
            }
            catch (Exception e)
            {
                Assert.AreEqual("NotInteger", e);
            }
        }

        [Test]
        public void TestIsInt()
        {
            var var1 = "1";
            var result = F_Calculator.Parser.IsInt(var1, out _);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestIsNotInt()
        {
            var var1 = "hi";
            var result = F_Calculator.Parser.IsInt(var1, out _);
            Assert.AreEqual(false,result);
        }
        [Test]
        public void TestOperationDetector_Plus()
        {
            var var1 = 1;
            var var2 = 2;
            var operation = F_Calculator.Parser.OperatorDetector("+");
            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestOperationDetector_Minus()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = F_Calculator.Parser.OperatorDetector("-");
            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestOperationDetector_Divide()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = F_Calculator.Parser.OperatorDetector("/");
            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestOperationDetector_Mult()
        {
            var var1 = 1;
            var var2 = 2;
            var operation = F_Calculator.Parser.OperatorDetector("*");
            var result = F_Calculator.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestOperationDetector_UnknownOperation()
        {
            var var1 = "^";
            try
            {
                var result = Parser.OperationDetector(var1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("UnknownOperation", e);
            }
        }

        [Test]
        public void EnoughArguments()
        {
            var args = new string[]{"1","+"};
            try
            {
                var argsLenth = args.Length;
            }
            catch (Exception e)
            {
                Assert.AreEqual("NotEnoughArguments", e);
            }
        }
    }
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void MainTestTrue()
        {
            var arg = new string[] {"1", "+", "1"};
            Assert.AreEqual(0,Home_work_1.Program.Main(arg));
        }
        [Test]
        public void MainTestFalse_1()
        {
            var arg = new string[] {"1", "+"};
            Assert.AreEqual(1,Home_work_1.Program.Main(arg));
        }
        [Test]
        public void MainTestFalse_2()
        {
            var arg = new string[] {"-", "+", "1"};
            Assert.AreEqual(2,Home_work_1.Program.Main(arg));
        }
        [Test]
        public void MainTestFalse_3()
        {
            var arg = new string[] {"1", ":", "1"};
            Assert.AreEqual(3,Home_work_1.Program.Main(arg));
        }
    }
}