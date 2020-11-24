using System.Collections;
using System.Collections.Generic;
using Calculator.Model.Implementation;

using NUnit.Framework;

using Calculator.Model.Interface;
using CalculatorTests.Utilities;

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
            IList<IMoney> expectedResult = new List<IMoney>(
                new IMoney[]
                {
                    new TenPound(1),
                    new TwoPound(2), 
                    new FiftyPence(1)
                });


            var calculator = Calculator.Calculator.Create();

            //Act
            var actualResult = calculator.Calculate(totalAmountDue, amountGiven);

            //Assert
            IComparer comparer = new CurrencyUnitComparer();
            CollectionAssert.AreEqual(expectedResult, actualResult, comparer);
        }
    }
}