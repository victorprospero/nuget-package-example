using System;
using Xunit;

namespace MoneyExtension.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void ShouldConvertDecimalToInt()
        {
            decimal valor = 279.98M;
            int cents = valor.ToCents();
            Assert.Equal(27998, cents);
        }
    }
}
