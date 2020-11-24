using System;
using System.Collections;

using Calculator.Model.Interface;

namespace CalculatorTests.Utilities
{
    public class CurrencyUnitComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            var lhs = x as ICurrencyUnit;
            var rhs = y as ICurrencyUnit;
            
            if (lhs == null || rhs == null) throw new InvalidOperationException();
            
            return Compare(lhs, rhs);
        }

        public int Compare(ICurrencyUnit x, ICurrencyUnit y)
        {
            return (x.Value == y.Value && x.Quantity == y.Quantity)
                ? 0
                : -1
                ;
        }
    }
}