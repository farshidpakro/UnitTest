using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using MainAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace XUnit
{

    public class TestWithMock
    {
        private readonly Mock<ILogger<WeatherForecastController>> _mockService;
        private readonly WeatherForecastController _controller;

        public TestWithMock()
        {
            _mockService = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_mockService.Object);
        }
        [Fact]
        public async Task Get_ReturnsOkResult()
        {
            

            var result =  _controller.Get();

            //Assert.IsType<OkObjectResult>(result);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}