using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class OnePence : BaseDenomination
    {
        public OnePence(int quantity): base(IMoney.eDenomination.Pence, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"1p";
        }
    }
}