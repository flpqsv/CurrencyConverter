using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace CurrencyConverter.Tests
{
    public class ProgramTests
    {
        [Test]
        public void CheckIfDictionaryIsEmpty()
        {
            Assert.IsNotEmpty(MainActions.CurrencyRate);
        }
    }
}