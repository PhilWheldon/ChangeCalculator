using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class FiftyPence : BaseDenomination
    {
        public FiftyPence(int quantity) : base(IMoney.eDenomination.FiftyPence, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"50p";
        }
    }
}