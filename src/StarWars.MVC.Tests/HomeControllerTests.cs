using Microsoft.AspNetCore.Mvc;
using StarWars.MVC.Controllers;
using Xunit;

namespace StarWars.MVC.Tests
{
    public class MoviesControllerTests
    {
        [Fact]
        public async Task Movies_Returns_ViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = await controller.Movies();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Planets_Returns_ViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = await controller.Planets();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
