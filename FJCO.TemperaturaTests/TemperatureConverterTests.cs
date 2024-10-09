using Microsoft.VisualStudio.TestTools.UnitTesting;
using FJCO.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FJCO.Temperatura.Tests
{
    [TestClass()]
    public class TemperatureConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            double celsius = 0;
            double expected = 32;
            double actual = temperatureConverter.CelsiusToFahrenheit(celsius);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            double fahrenheit = 32;
            double expected = 0;
            double actual = temperatureConverter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(expected, actual);
        }
    }
}