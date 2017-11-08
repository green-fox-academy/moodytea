using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAppIntTest.TextFixture;
using Xunit;

namespace WebAppIntTest.Scenarios.Rest
{
    [Collection("BaseCollection")]
    public class AppShould
    {
        private TestContext Context;
        
        public AppShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/rest/doubling?input=5");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }

    
}
