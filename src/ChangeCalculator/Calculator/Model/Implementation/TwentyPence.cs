using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class TwentyPence : BaseDenomination
    {
        public TwentyPence(int quantity) : base(IMoney.eDenomination.TwentyPence, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"20p";
        }
    }
}