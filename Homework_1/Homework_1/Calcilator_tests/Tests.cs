using System;
using Homework_1;
using NUnit.Framework;

namespace Calcilator_tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Plus()
        {
            //Arrange
            var var1 = 1;
            var var2 = 2;
            var operation = Calculator.operations.Plus;
            
            //Act
            var result = Calculator.Calculate(var1, var2, operation);
            
            //Assert
            Assert.AreEqual(3,result);
        }

        [Test]
        public void Minus()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = Calculator.operations.Minus;

            var result = Calculator.Calculate(var1, var2, operation);
            
            Assert.AreEqual(1,result);
        }
        
        [Test]
        public void Mult()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = Calculator.operations.Mult;

            var result = Calculator.Calculate(var1, var2, operation);
            
            Assert.AreEqual(2,result);
        }
        
        [Test]
        public void Divade()
        {
            var var1 = 2;
            var var2 = 1;
            var operation = Calculator.operations.Divide;

            var result = Calculator.Calculate(var1, var2, operation);
            
            Assert.AreEqual(2,result);
        }

        [Test]
        public void OperationIsRigth()
        {
            var var1 = 4000;
            var var2 = 4000;
            Calculator.operations operations = default;

            try
            {
                Calculator.Calculate(var1, var2, operations);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.WrongOperator,e);
            }
        }
        [Test]
        public void DivedNotZero()
        {
            var var1 = 1;
            var var2 = 0;
            var operation = Calculator.operations.Divide;
            try
            {
                Calculator.Calculate(var1, var2, operation);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.DivideByZero,e);
            }
        }
        [Test]
        public void OperationIsUnknown()
        {
            var var1 = 1;
            var var2 = 2;
            var operation = Calculator.operations.UnknownOperation;
            try
            {
                Calculator.Calculate(var1, var2, operation);
            }
            catch (Exception e)
            {
                Assert.AreEqual(Calculator.WrongOperator, e);
            }
        }

        [Test]
        public void Arguments()
        {
            var var1 = 1;
            var var2 = 2;
            Calculator.operations operations = default;
            try
            {
                Calculator.Calculate(var1, var2, operations);
            }
            catch (Exception e)
            {
                Assert.AreEqual("NotInteger",e);
            }
        }
    }
}