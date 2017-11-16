using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Groot.IntegrrationTests.TextFixtures;

namespace Groot.IntegrrationTests.Scenarios.Rest
{
    [Collection("BaseCollection")]
    public class GrootShould
    {
        private TestContext Context;

        public GrootShould(TestContext context)
        {
            Context = context;
        }

        [Fact]
        public async Task ReturnErrorJSon()
        {
            var response = await Context.Client.GetAsync("/groot");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Contains("{\"error\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnSimpleJSon()
        {
            var response = await Context.Client.GetAsync("/groot?input=hi");
            string responseJson = await response.Content.ReadAsStringAsync();

            Assert.Contains("{\"received\":\"hi\",\"translated\":\"I am Groot!\"}", responseJson);
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/groot?input=hi");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task IndexShouldReturnNotOkStatus()
        {
            var response = await Context.Client.GetAsync("/groot");

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}