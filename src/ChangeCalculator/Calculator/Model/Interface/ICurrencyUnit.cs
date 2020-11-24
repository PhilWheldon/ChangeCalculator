namespace Calculator.Model.Interface
{
    public interface ICurrencyUnit
    {
        /// <summary>
        /// Value of the currency unit, expressed in the base unit (pence for GBP)
        /// </summary>
        int Value { get; }

        int Quantity { get; }
    }
}
