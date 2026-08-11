using System;
using CSharpMvc.Services;
using Xunit;

namespace CSharpMvc.Tests
{
    public sealed class OrderServiceTests
    {
        private readonly OrderService _sut = new OrderService();

        [Fact]
        public void CalculateTotal_AppliesDiscount()
        {
            Assert.Equal(180m, _sut.CalculateTotal(2, 100m, 10m));
        }

        [Theory]
        [InlineData(49, false)]
        [InlineData(50, true)]
        public void IsEligibleForFreeShipping_UsesThreshold(int total, bool expected)
        {
            Assert.Equal(expected, _sut.IsEligibleForFreeShipping(total));
        }
    }
}
