using System;
using Home_work_1;
using NUnit.Framework;
using Program = Microsoft.VisualStudio.TestPlatform.TestHost.Program;

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
            var operation = IL_library_.Calculator.operations.Plus;

            //Act
            var result = IL_library_.Calculator.Calculate(var1, var2, operation);

            //Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Minus()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = IL_library_.Calculator.operations.Minus;

            var result = IL_library_.Calculator.Calculate(var1, var2, operation);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Mult()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = IL_library_.Calculator.operations.Mult;

            var result = IL_library_.Calculator.Calculate(var1, var2, operation);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = IL_library_.Calculator.operations.Divide;

            var result = IL_library_.Calculator.Calculate(var1, var2, operation);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void OperationIsRigth()
        {
            var var1 = 4000;
            var var2 = 4000;
            IL_library_.Calculator.operations operations = default;

            try
            {
                IL_library_.Calculator.Calculate(var1, var2, operations);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.WrongOperator.Message, e);
            }
        }

        [Test]
        public void DivedNotZero()
        {
            var var1 = 1;
            var var2 = 0;
            var operation = IL_library_.Calculator.operations.Divide;
            try
            {
                IL_library_.Calculator.Calculate(var1, var2, operation);
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
            var operation = IL_library_.Calculator.operations.UnknownOperation;
            try
            {
                IL_library_.Calculator.Calculate(var1, var2, operation);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.WrongOperator.Message, e);
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
            IL_library_.Calculator.operations operations = default;
            try
            {
                IL_library_.Calculator.Calculate(var1, var2, operations);
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
            var result = IL_library_.Parser.IsInt(var1, out _);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestIsNotInt()
        {
            var var1 = "hi";
            var result = IL_library_.Parser.IsInt(var1, out _);
            Assert.AreEqual(false,result);
        }
        [Test]
        public void TestOperationDetector_Plus()
        {
            var var1 = 1;
            var var2 = 2;
            var operation = IL_library_.Parser.OperationDetector("+");
            var result = IL_library_.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestOperationDetector_Minus()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = IL_library_.Parser.OperationDetector("-");
            var result = IL_library_.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestOperationDetector_Divide()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = IL_library_.Parser.OperationDetector("/");
            var result = IL_library_.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestOperationDetector_Mult()
        {
            var var1 = 1;
            var var2 = 2;
            var operation = IL_library_.Parser.OperationDetector("*");
            var result = IL_library_.Calculator.Calculate(var1, var2, operation);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestOperationDetector_UnknownOperation()
        {
            var var1 = "^";
            try
            {
                var result = IL_library_.Parser.OperationDetector(var1);
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