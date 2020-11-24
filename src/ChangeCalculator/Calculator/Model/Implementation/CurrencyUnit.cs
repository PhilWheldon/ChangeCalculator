using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class CurrencyUnit : ICurrencyUnit
    {
        public CurrencyUnit(int value, int quantity)
        {
            Value = value;
            Quantity = quantity;
        }

        public int Value { get; }
        public int Quantity { get; }
    }
}