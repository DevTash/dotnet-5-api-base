using Dotnet.Api.Features.Weather;
using FluentAssertions;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;

namespace Dotnet.Api.Tests.Features.Weather.WeatherForecastControllerTests
{
    public class MethodTest
    {
        private readonly ILogger<WeatherForecastController> _mockLogger;
        private readonly WeatherForecastController _sut;

        public MethodTest()
        {
            _mockLogger = Substitute.For<ILogger<WeatherForecastController>>();
            _sut = new WeatherForecastController(_mockLogger);
        }

        [Fact]
        public void Given_X_Then_Y_Expected()
        {
            // Arrange
            // Act
            var forecasts = _sut.Get();
            
            // Assert
            forecasts.Should().NotBeNull();   
        }
    }
}
