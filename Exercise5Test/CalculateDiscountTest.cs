using Exercise5;
using NUnit.Framework;
using System;

namespace Exercise5Test
{
    [TestFixture]
    public class CalculateDiscountTest
    { 
        [Test]
        [TestCase(100,10,ExpectedResult = 90)]
        [TestCase(1321.42,23.45,ExpectedResult = 1011.55)]
        [TestCase(421,90,ExpectedResult = 42.10)]
        [DefaultFloatingPointTolerance(0.05)]
        public double CalculateNewPrice_ShouldReturn_NewPriceAfterAppliedDiscount(double price,double discount)
        {
            var sut = new CalculateDiscount(price);
            return sut.CalculateNewPrice(discount);
        }

        [Test]
        [TestCase("2022-07-25", 123, ExpectedResult = 100.86)]
        [TestCase("2022-07-26", 421, ExpectedResult = 357.85)]
        [TestCase("2022-07-27", 5432,ExpectedResult = 5432)]
        [TestCase("2022-07-28", 5345,ExpectedResult = 4543.25)]
        [TestCase("2022-07-29", 4421,ExpectedResult = 2210.50)]
        [TestCase("2022-07-30", 532, ExpectedResult = 494.76)]
        [TestCase("2022-07-31", 5325,ExpectedResult = 5058.75)]
        [DefaultFloatingPointTolerance(0.05)]
        public double GetNewPrice_ShouldReturn_NewPriceAfterAppliedDiscountOnSpecificDay(DateTime date,double price)
        {
            var sut = new CalculateDiscount(price, date);
            return sut.GetNewPrice();
        }

        [Test]
        [TestCase("2022-07-25", 123, 101.86)]
        [TestCase("2022-07-26", 421, 358.85)]
        [TestCase("2022-07-27", 5432, 5433)]
        [TestCase("2022-07-28", 5345, 4544.25)]
        [TestCase("2022-07-29", 4421, 2211.50)]
        [TestCase("2022-07-30", 532, 495.76)]
        [TestCase("2022-07-31", 5325, 5059.75)]
        [DefaultFloatingPointTolerance(0.05)]
        public void GetNewPrice_ShouldPass_WhenCalculatedPriceIsDifferentFromExpected(DateTime date, double price,double Expected)
        {
            var sut = new CalculateDiscount(price, date);
            var newPrice = sut.GetNewPrice();
            Assert.That(newPrice, Is.Not.EqualTo(Expected));
        }
    }
}
