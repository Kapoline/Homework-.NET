using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Calculator_ASP;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
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
        [InlineData(1,2, "plus")]
        [InlineData(2, 1, "minus")]
        [InlineData(1, 2, "mult")]
        [InlineData(2, 1, "divide")]
        public async Task Test_Calculate(decimal var1, decimal var2, string operation)
        {
            Factory();
            var client = _factory.CreateClient();
            var url = $"/Calculate?var1={var1}&var2={var2}&operation={operation}";
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Theory]
        [InlineData("/Calculate?var1={1}&var2={0}&operation={/}", HttpStatusCode.BadRequest)]
        public async Task ErrorsWithOperation(string url, HttpStatusCode? statusCode)
        {
            Factory();
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);
            Assert.Equal(statusCode,response.StatusCode);
        }
        [Theory]
        [InlineData("/Calculate?var1={1}&var2={0}&operation={/}" ,  HttpStatusCode.BadRequest)]
        public async Task ErrorWithDivide(string url, HttpStatusCode? statusCode)
        {
            Factory();
            var client = _factory.CreateClient();
            var response = await client.GetAsync(url);
            Assert.Equal(statusCode,response.StatusCode);
        }
    }
}  