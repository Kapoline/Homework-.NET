using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApp_9;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private WebApplicationFactory<Startup> _factory;

        private void Factory()
        {
            _factory = new WebApplicationFactory<Startup>();
        }
        private const string ResponseBody = "https://localhost:5001/Calculate?str=";
        
        [Theory, InlineData("1+2+3+4+5", 2, 15), InlineData("2/2", 2, 1), InlineData("(2+1)/2", 2, 1)]
        [InlineData("(2+3)/12*7+8*9", 2, 72), InlineData("1-2+3", 2, -4)]
        [InlineData("1/(2+3)", 2, 0)]
        public async Task Test(string expression, int timeInSeconds, decimal answer)
        {
            var client = _factory.CreateClient();
            var watch = new Stopwatch();
            watch.Start();
            var responce = await client.GetAsync($"{ResponseBody}{expression}");
            watch.Stop();
            var result = decimal.Parse(await responce.Content.ReadAsStringAsync(), NumberStyles.Any,
                CultureInfo.InvariantCulture);
            try
            {
                Assert.True(Math.Abs(result - answer) < 0.00001m);
            }
            catch
            {
                Assert.Equal(answer,result);
            }
            
            Assert.Equal(timeInSeconds,(double) Math.Round(watch.ElapsedMilliseconds/1000.0));
        }
    }
}