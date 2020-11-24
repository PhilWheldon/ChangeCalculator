using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class FivePound : BaseDenomination
    {
        public FivePound(int quantity) : base(IMoney.eDenomination.FivePound, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"£5";
        }
    }
}