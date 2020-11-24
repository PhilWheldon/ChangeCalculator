using System.Collections;
using System.Collections.Generic;
using Calculator.Model.Implementation;
using Calculator.Model.Interface;
using NUnit.Framework;

namespace CalculatorTests
{
    public class CurrencyUnitTests
    {

        [Test]
        [TestCaseSource(nameof(TestCaseSourceData))]
        public void ToString_ReturnsText(BaseDenomination testCurrencyUnit, string expectedResult)
        {
            //Arrange
            
            //Act
            var actualResult = testCurrencyUnit.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        public static IEnumerable<TestCaseData> TestCaseSourceData()
        {
            yield return new TestCaseData(new OnePence( 1), @"1 x 1p");
            yield return new TestCaseData(new OnePence(99), @"99 x 1p");
            yield return new TestCaseData(new OnePound(1), @"1 x £1");
            yield return new TestCaseData(new TenPound( 10), @"10 x £10");
        }
    }
}
