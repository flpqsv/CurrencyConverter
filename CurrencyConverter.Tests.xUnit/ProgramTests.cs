using System;
using Xunit;

namespace CurrencyConverter.Tests.xUnit
{
    public class ProgramTests
    {
        [Fact]
        public void Test1()
        {
            Assert.IsNotEmpty(MainActions.CurrencyRate);
        }
    }
}