using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using Unosquare.Course.REST;
using Xunit;
using Xunit.Abstractions;

namespace IntegrationTest
{
    public class WarehouseTest
    {
        private readonly ITestOutputHelper _outputHelper;
        private readonly WebApplicationFactory<Startup> _factory;

        public WarehouseTest(ITestOutputHelper outputHelper)
        {
            _factory = new WebApplicationFactory<Startup>();
            _outputHelper = outputHelper;
        }

        [Fact]
        public async void TestGetWarehouses()
        {
            //Arrange
            var client = _factory.CreateDefaultClient();

            //Act
            var response = await client.GetAsync("/api/warehouse/warehouses");

            //Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseContent = response.Content.ReadAsStringAsync().Result;
            Assert.NotNull(responseContent);
            Assert.Empty(responseContent);

            _outputHelper.WriteLine(JsonConvert.SerializeObject(responseContent));
        }
    }
}
