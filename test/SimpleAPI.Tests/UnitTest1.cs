using Microsoft.Extensions.Logging;
using Moq;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    private readonly Mock<ILogger<WeatherForecastController>> _mockLogger;

    private readonly WeatherForecastController _weatherForecastController;
    public UnitTest1()
    {
        _mockLogger = new Mock<ILogger<WeatherForecastController>>();
        _weatherForecastController = new WeatherForecastController(_mockLogger.Object);
    }

    [Fact]
    public void Test1()
    {

        var returnValue = _weatherForecastController.Get();
        Assert.True(returnValue!=null);

    }    
}

