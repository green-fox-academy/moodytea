using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebAppIntTest.TextFixture;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Models;

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
        public async Task DoublingReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/doubling?input=5");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task DoublingReturnErrorMessage()
        {
            var response = await Context.Client.GetAsync("/doubling");
            string response2 = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an input!\"}", response2);
        }

        [Fact]
        public async Task DoublingReturnTheNumber()
        {
            var response = await Context.Client.GetAsync("/doubling?input=5");
            Assert.Equal("{\"received\":5,\"result\":10}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task GreeterReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/greeter");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GreeterNoNameNoTitle()
        {
            var response = await Context.Client.GetAsync("/greeter");
            Assert.Equal("{\"error\":\"Please provide a name!\"}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task GreeterNoTitle()
        {
            var response = await Context.Client.GetAsync("/greeter?name=Dorothy");
            Assert.Equal("{\"error\":\"Please provide a title!\"}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task GreeterWithTitleAndName()
        {
            var response = await Context.Client.GetAsync("/greeter?name=Dorothy&title=student");
            Assert.Equal("{\"welcome_message\":\"Oh, hi there Dorothy, my dear student!\"}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task AppendAReturnOkStatus()
        {
            var response = await Context.Client.GetAsync("/appenda/kuty");
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task AppendAReturnNotOkStatus()
        {
            var response = await Context.Client.GetAsync("/appenda");
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task AppendAText()
        {
            var response = await Context.Client.GetAsync("/appenda/cic");
            Assert.Equal("{\"appended\":\"cica\"}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task DoUntilWithFactorAndNumber()
        {
            var jsonObject = new UntilClass
            {
               Until = 5,
            };

           var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);
           var content = new StringContent(convertedjsonObject.ToString(),
                        encoding: Encoding.UTF8,
                        mediaType: "application/json");
           var response = await Context.Client.PostAsync("/dountil/factor", content);

            Assert.Equal("{\"result\":120}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task DoUntilWithSumAndNumber()
        {
            var jsonObject = new UntilClass
            {
                Until = 5,
            };

            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);
            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");
            var response = await Context.Client.PostAsync("/dountil/sum", content);

            Assert.Equal("{\"result\":15}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task DoUntilStatusWithoutNumber()
        {
            var jsonObject = new UntilClass { };
            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);
            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");
            var response = await Context.Client.PostAsync("/dountil/sum", content);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task DoUntilWithoutNumber()
        {
            var jsonObject = new UntilClass
            {
                Until = 
            };
            var convertedjsonObject = JsonConvert.SerializeObject(jsonObject);
            var content = new StringContent(convertedjsonObject.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");
            var response = await Context.Client.PostAsync("/dountil/sum", content);

            Assert.Equal("{\"error\":\"Please provide a number!\"}", await response.Content.ReadAsStringAsync());
        }
    }

    
}

