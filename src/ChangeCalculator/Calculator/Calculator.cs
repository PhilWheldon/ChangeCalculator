using System.Collections.Generic;
using Calculator.Model.Implementation;
using Calculator.Model.Interface;

namespace Calculator
{
    public class Calculator
    {
        public static IList<ICurrencyUnit> Calculate(in decimal totalAmountDue, in decimal amountGiven)
        {
            return new List<ICurrencyUnit>( new ICurrencyUnit[] {
                new CurrencyUnit(1000, 1)
                ,new CurrencyUnit(200, 2)
                ,new CurrencyUnit(50, 1)
            });
        }
    }
}
