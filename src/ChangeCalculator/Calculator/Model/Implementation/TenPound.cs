using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class TenPound : BaseDenomination
    {
        public TenPound(int quantity) : base(IMoney.eDenomination.TenPound, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"£10";
        }
    }
}