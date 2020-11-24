using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class OnePound : BaseDenomination
    {
        public OnePound(int quantity) : base(IMoney.eDenomination.Pound, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"£1";
        }
    }
}