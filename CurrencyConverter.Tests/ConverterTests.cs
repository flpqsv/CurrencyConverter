using System;
using NUnit.Framework;

namespace CurrencyConverter.Tests
{
    public class ConverterTests
    {
        [Test]
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