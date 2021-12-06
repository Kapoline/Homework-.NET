using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using WebAppMVC_8;
using WebAppMVC_8.Calculator;
using Xunit;

namespace WebAppMVC_8_Tests
{
    public class UnitTest1
    {
        private ICalculator _calculator = new Calculator();
        private IParser _parser = new Parser();
        private WebApplicationFactory<Startup> _factory;
        private HttpClient _client;

        private void Factory()
        {
            _factory = new WebApplicationFactory<Startup>();
        }
        [Theory]
        [InlineData("/")]
        public async Task Get_(string url)
        {
            Factory();
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Theory]
        [InlineData(1,2, "+")]
        public async Task CalculatePlus(int var1, int var2, string operation)
        {
            var result = _calculator.Calculate(var1, var2, _parser.ParseOperator(operation));
            Assert.Equal(3,result);
        }
        [Theory]
        [InlineData(2,1, "-")]
        public async Task CalculateMinus(int var1, int var2, string operation)
        {
            var result = _calculator.Calculate(var1, var2, _parser.ParseOperator(operation));
            Assert.Equal(1,result);
        }
        [Theory]
        [InlineData(1,2, "*")]
        public async Task CalculateMult(int var1, int var2, string operation)
        {
            var result = _calculator.Calculate(var1, var2, _parser.ParseOperator(operation));
            Assert.Equal(2,result);
        }
        [Theory]
        [InlineData(2,1, "/")]
        public async Task CalculateDivide(int var1, int var2, string operation)
        {
            var result = _calculator.Calculate(var1, var2, _parser.ParseOperator(operation));
            Assert.Equal(2,result);
        }
        [Theory]
        [InlineData(1,2,"#")]
        public async Task CalculateTest(int var1, int var2, string operation)
        {
            try
            {
                var result = _calculator.Calculate(var1, var2, _parser.ParseOperator(operation));
            }
            catch(Exception e)
            {
                Assert.Equal("Unknownoperation",e.Message);
            }
        }
    }
}