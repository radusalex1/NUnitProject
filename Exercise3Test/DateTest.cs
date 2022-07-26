
using Exercise3;
using NUnit.Framework;
using System;

namespace Exercise3Test
{
    //TODO: test pentru data valida: pass if is valide
    //TODO: test pentru data invalida: pass if throws corect exception

    //TODO: test pentru data expirata: pass if is expired
    //TODO: test pentru data neexpirata: pass if is not expired
    [TestFixture]
    public class DateTest
    {
        [Test]
        [TestCase(2022,13,12)]
        [TestCase(2022,12,32)]
        [TestCase(2022,02,29)]
        public void DateIsInvalid_ShouldThrowException_WhenInputDataIsInvalid(int year,int month,int day)
        {
            var sut = new Date();
            Assert.That(() => sut.IsValid(year,month,day), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(2020,02,29,ExpectedResult = true)]
        [TestCase(2022,02,28,ExpectedResult = true)]
        [TestCase(3000,02,28,ExpectedResult = true)]
        public bool DateIsValid_ShouldPass_WhenInputDataIsValid(int year,int month,int day)
        {
            var sut = new Date();
            return sut.IsValid(year, month, day);
        }
    }
}
