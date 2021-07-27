using System;
using System.Threading.Tasks;
using Dotnet.Api.Features.Weather;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Dotnet.Api.Tests.Features.Weather.WeatherForecastControllerTests
{
    public class ConstructorTests
    {
        [Fact]
        public void Given_Logger_Null_Then_ArgumentNullException_Is_Thrown()
        {
            // Arrange
            ILogger<WeatherForecastController> logger = null;

            // Act
            Action construct = () => new WeatherForecastController(logger);            
        
            // Assert
            using (new AssertionScope())
            {
                construct.Should().Throw<ArgumentNullException>().Which.Message
                         .Should().Contain(nameof(logger));
            }
            
        }
    }
}