using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class TwentyPound : BaseDenomination
    {
        public TwentyPound(int quantity) : base(IMoney.eDenomination.TwentyPound, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"£20";
        }
    }
}