using System;
using Xunit;

namespace Calculator.Tests
{
    public class SimpleCalculatorTests
    {
        private readonly SimpleCalculator calculator;
        public SimpleCalculatorTests() => calculator = new SimpleCalculator();

        [Fact]
        public void Adding_positive_number_increases_value()
        {
            var anyPositiveNumber = 13.2;

            calculator.Add(anyPositiveNumber);

            Assert.Equal(anyPositiveNumber, calculator.Value);
        }

        [Fact]
        public void Subtracting_negative_number_increases_value()
        {
            var anyNegativeNumber = -2;

            calculator.Subtract(anyNegativeNumber);

            Assert.Equal(-anyNegativeNumber, calculator.Value);
        }

        [Fact]
        public void Division_by_zero_throws()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(1));
        }

        [Fact]
        public void Division_by_notZero_does_not_throw()
        {
            var anyNonZeroNumber = 3.17;

            var exception = Record.Exception(() => calculator.Divide(anyNonZeroNumber));
            Assert.Null(exception);
        }
    }
}
