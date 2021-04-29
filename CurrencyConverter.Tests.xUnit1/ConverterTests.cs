using System;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace CurrencyConverter.Tests.xUnit1
{
    public class ConverterTests
    {
        [Fact]
        public void TryGetSum()
        {
            var converter = new Converter();
            var userCurrency = "usd";
            var secondCurrency = "uah";
            double firstCurrency = 100;
            
            var result = Converter.Convert(ref userCurrency, ref firstCurrency, ref secondCurrency);
            Assert.AreEqual(result, Converter.Convert(ref userCurrency, ref firstCurrency, ref secondCurrency));
        }
    }
}