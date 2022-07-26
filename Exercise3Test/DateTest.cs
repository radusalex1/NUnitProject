using Exercise3;
using NUnit.Framework;
using System;

namespace Exercise3Test
{
    [TestFixture]
    public class DateTest
    {
        [Test]
        [TestCase(2022, 07, 29, ExpectedResult = false)]
        [TestCase(2022, 07, 26, ExpectedResult = false)]
        public bool DateIsExpired_ShouldPass_WhenInputDateTimeIsNotExpired(int year,int month,int day)
        {
            DateTime today = DateTime.Today;
            var sut = new Date(today);
            return sut.IsExpired(year, month, day);
        }

        [Test]
        [TestCase(2022, 07, 25, ExpectedResult = true)]
        [TestCase(2022, 07, 24, ExpectedResult = true)]
        public bool DateIsExpired_ShouldPass_WhenInputDateTimeIsExpired(int year, int month, int day)
        {
            DateTime today = DateTime.Today;
            var sut = new Date(today);
            return sut.IsExpired(year, month, day);
        }

        [Test]
        [TestCase(2022, 13, 12)]
        [TestCase(2022, 12, 32)]
        [TestCase(2022, 02, 29)]
        public void DateIsExpired_ShouldThrowException_WhenInputDateIsNotValid(int year,int month,int day)
        {
            var sut = new Date();
            Assert.That(()=>sut.IsExpired(year, month, day),Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
