//using System;
//using System.Collections.Generic;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.TestHost;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace Groot.IntegrrationTests
//{
//    class GrootShould
//    {
//        private readonly TestServer Server;
//        private readonly HttpClient Client;

//        public GrootShould()
//        {
//            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
//            Client = Server.CreateClient();
//        }

//        [Fact]
//        public async Task ReturnOkStatus()
//        {
//            var response = await Client.GetAsync("/groot");

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }
//    }
//}
