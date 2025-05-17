﻿using Xunit;

namespace Sparky
{
    public class FiboXUnitTests
    {
        private Fibo? _fibo;

        public FiboXUnitTests()
        {
            _fibo = new Fibo();
        }

        [Fact]
        public void FiboChecker_InputRange1_ReturnsFiboSeries()
        {
            List<int> expectedRange = new() { 0 };

            _fibo!.Range = 1;

            List<int> result = _fibo!.GetFiboSeries();

            Assert.NotEmpty(result);
            Assert.Equal(expectedRange.OrderBy(u => u), result);
            Assert.True(result.SequenceEqual(expectedRange));
        }

        [Fact]
        public void FiboChecker_InputRange6_ReturnsFiboSeries()
        {
            List<int> expectedRange = new() { 0, 1, 1, 2, 3, 5 };

            _fibo!.Range = 6;

            List<int> result = _fibo!.GetFiboSeries();

            Assert.Contains(3, result);
            Assert.Equal(6, result.Count);
            Assert.DoesNotContain(4, result);
            Assert.Equal(expectedRange, result);
        }

    }

}
