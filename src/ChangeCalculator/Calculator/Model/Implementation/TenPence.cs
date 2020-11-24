using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class TenPence : BaseDenomination
    {
        public TenPence(int quantity) : base(IMoney.eDenomination.TenPence, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"10p";
        }
    }
}