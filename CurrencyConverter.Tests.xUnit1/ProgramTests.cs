using System;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace CurrencyConverter.Tests.xUnit1
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