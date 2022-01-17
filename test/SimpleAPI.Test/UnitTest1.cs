using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetRreturnsMyName()
        {
            var returnValue = controller.Get();
            //Assert.Equal("tst", returnValue);
        }
    }
}
