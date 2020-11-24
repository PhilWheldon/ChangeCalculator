using System.Collections;
using System.Collections.Generic;
using Calculator.Model.Implementation;
using NUnit.Framework;


using Calculator.Model.Interface;
using CalculatorTests.Utilities;
using Moq;

namespace CalculatorTests
{
    public class CalculateTests
    {

        [Test]
        public void Calculate_ReturnsCorrectChangeList()
        {
            //Arrange
            var totalAmountDue = 5.50m;
            var amountGiven = 20.00m;
            IList<ICurrencyUnit> expectedResult = new List<ICurrencyUnit>(
                new ICurrencyUnit[]
                {
                    CreateMockCurrencyUnit(1000, 1),
                    CreateMockCurrencyUnit( 200, 2),
                    CreateMockCurrencyUnit(  50, 1)
                });


            //Act
            var actualResult = Calculator.Calculator.Calculate(totalAmountDue, amountGiven);

            //Assert
            IComparer comparer = new CurrencyUnitComparer();
            CollectionAssert.AreEqual(expectedResult, actualResult, comparer);
        }

        /// <summary>
        /// Creates a mock ICurrencyUnit
        /// </summary>
        /// <param name="unitValue">Value of the currency unit, expressed in pence</param>
        /// <param name="quantity">The Quantity</param>
        /// <returns></returns>
        private ICurrencyUnit CreateMockCurrencyUnit(int unitValue, int quantity)
        {
            var mock = new Mock<ICurrencyUnit>();

            mock.Setup((m) => m.Value)
                .Returns(unitValue);

            mock.Setup((m) => m.Quantity)
                .Returns(quantity);

            return mock.Object;

        }


    }
}