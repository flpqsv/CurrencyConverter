using System;
using NUnit.Framework;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace CurrencyConverter.Tests.xUnit1
{
    public class CurrencyTests
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
        
        [Xunit.Theory]
        [InlineData("usd")]
        [InlineData("uah")]
        [InlineData("rub")]
        [InlineData("eur")]
        [InlineData("gbp")]
        public void TryRealCurrencies(ref string currency)
        {
            var currencyClass = new Currency();
            
            Assert.True(currencyClass.ValidateCurrency(ref currency));
        }

        [Xunit.Theory]
        [InlineData("usd")]
        [InlineData("uah")]
        [InlineData("rub")]
        [InlineData("eur")]
        [InlineData("gbp")]
        public void TryRealCurrency2(string currency)
        {
            var currencyClass = new Currency();
            
            Assert.True(currencyClass.DoesCurrencyExist(currency));
        }

        [Fact]
        public void TryWrongCurrency()
        {
            var currencyClass = new Currency();
            string currency = "random";
            
            Assert.False(currencyClass.DoesCurrencyExist(currency));
        }
    }
}