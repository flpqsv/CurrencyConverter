using NUnit.Framework;

namespace CurrencyConverter.Tests
{
    public class CurrencyTests
    {
        [TestCase("usd")]
        [TestCase("uah")]
        [TestCase("rub")]
        [TestCase("eur")]
        [TestCase("gbp")]
        public void TryRealCurrencies(ref string currency)
        {
            var currencyClass = new Currency();
            
            Assert.True(currencyClass.ValidateCurrency(ref currency));
        }

        [TestCase("usd")]
        [TestCase("uah")]
        [TestCase("rub")]
        [TestCase("eur")]
        [TestCase("gbp")]
        public void TryRealCurrency2(string currency)
        {
            var currencyClass = new Currency();
            
            Assert.True(currencyClass.DoesCurrencyExist(currency));
        }

        [Test, Combinatorial]
        public void TryWrongCurrency(string currency)
        {
            var currencyClass = new Currency();
            currency = "random";
            
            Assert.False(currencyClass.DoesCurrencyExist(currency));
        }
    }
}