using Calculator.Model.Interface;

namespace Calculator.Model.Implementation
{
    public class FiftyPound : BaseDenomination
    {
        public FiftyPound(int quantity) : base(IMoney.eDenomination.FiftyPound, quantity)
        {
        }

        protected override string DisplayString()
        {
            return @"£50";
        }
    }
}