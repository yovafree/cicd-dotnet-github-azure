using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using StarWars.MVC.Controllers;
using Xunit;

namespace StarWars.MVC.Tests
{
    public class MoviesControllerTests
    {
        [Fact]
        public async Task Movies_Returns_ViewResult()
        {
            var mockLogger = new Mock<ILogger<HomeController>>();
            // Arrange
            var controller = new HomeController(mockLogger.Object);

            // Act
            var result = await controller.Movies();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Planets_Returns_ViewResult()
        {
            var mockLogger = new Mock<ILogger<HomeController>>();
            // Arrange
            var controller = new HomeController(mockLogger.Object);

            // Act
            var result = await controller.Planets();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
