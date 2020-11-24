using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class TwoPound : BaseDenomination
    {
        public TwoPound(int quantity) : base(IMoney.eDenomination.TwoPound, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"£2";
        }
    }
}