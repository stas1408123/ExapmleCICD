using ExampleAPI.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace ExampleApi.Test
{
    public class NumberControllerTests
    {

        private readonly Mock<ILogger<NumberController>> _logger = new();


        [Fact]
        public async Task GetFive_ShouldReturnValidModel()
        {
            // Arrange
            int data = 5;

            var controller = new NumberController(_logger.Object);

            // Act
            var result = controller.GetFive();

            // Assert
            data.ShouldBeEquivalentTo(result);
        }
    }
}
