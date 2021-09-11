using System;

namespace Calculator
{
    public class SimpleCalculator
    {
        public double Value { get; private set; }

        public void Add(double number) => this.Value += number;

        public void Subtract(double number) => this.Value -= number;

        public void Multiply(double number) => this.Value *= number;

        public void Divide(double number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }

            this.Value /= number;
        }
    }
}
