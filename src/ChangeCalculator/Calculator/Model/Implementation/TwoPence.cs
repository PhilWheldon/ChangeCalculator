using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class TwoPence : BaseDenomination
    {
        public TwoPence(int quantity) : base(IMoney.eDenomination.TwoPence, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"2p";
        }
    }
}