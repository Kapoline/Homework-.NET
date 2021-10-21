using System;
using NUnit.Framework;

namespace Calculator_tests
{
    [TestFixture]
    public class Test_RCE
    {
        [Test]
        public void ParserIntTest()
        {
            var var1 = "a";
            try
            {
                var result = F_Calculator_RCE.Parser_RCE.parserInt<int>(var1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Error", e.Message);
            }
        }

        [Test]
        public void ParserFloatTest()
        {
            var var1 = "a";
            try
            {
                var result = F_Calculator_RCE.Parser_RCE.parserDouble<float>(var1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Error", e.Message);
            }
        }

        [Test]
        public void ParserDouble()
        {
            var var1 = "a";
            try
            {
                var result = F_Calculator_RCE.Parser_RCE.parserDouble<double>(var1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Error", e.Message);
            }
        }

        [Test]
        public void ParserDecimal()
        {
            var var1 = "a";
            try
            {
                var result = F_Calculator_RCE.Parser_RCE.parserDecimal<decimal>(var1);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Error", e.Message);
            }
        }
        
    }
}