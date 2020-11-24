using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class FivePence : BaseDenomination
    {
        public FivePence(int quantity) : base(IMoney.eDenomination.FivePence, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"5p";
        }
    }
}