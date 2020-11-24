using System;
using Calculator.Model.Implementation;
using Calculator.Model.Interface;

namespace Calculator
{
	public class MoneyFactory
	{
		public static IMoney Create(IMoney.eDenomination denominationDenomination, in int qty)
		{
			switch (denominationDenomination)
			{
				case IMoney.eDenomination.Pence:       return new OnePence(qty);
				case IMoney.eDenomination.TwoPence:    return new TwoPence(qty);
				case IMoney.eDenomination.FivePence:   return new FivePence(qty);
				case IMoney.eDenomination.TenPence:    return new TenPence(qty);
				case IMoney.eDenomination.TwentyPence: return new TwentyPence(qty);
				case IMoney.eDenomination.FiftyPence:  return new FiftyPence(qty);
				case IMoney.eDenomination.Pound:       return new OnePound(qty);
				case IMoney.eDenomination.TwoPound:    return new TwoPound(qty);
				case IMoney.eDenomination.FivePound:   return new FivePound(qty);
				case IMoney.eDenomination.TenPound:    return new TenPound(qty);
				case IMoney.eDenomination.TwentyPound: return new TwentyPound(qty);
				case IMoney.eDenomination.FiftyPound:  return new FiftyPound(qty);

				default:
					throw new Exception(@"Unknown denomination");
			}
		}
	}
}