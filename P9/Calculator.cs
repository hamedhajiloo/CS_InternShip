using System;
using System.Collections.Generic;
using System.Text;

namespace P9
{
    public class Calculator
    {
        private readonly double _num1;
        private readonly double _num2;

        public Calculator(double num1, double num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public double Calculate(Func<double, double, double> calculationOperation) =>
            calculationOperation(_num1, _num2);
    }
}
