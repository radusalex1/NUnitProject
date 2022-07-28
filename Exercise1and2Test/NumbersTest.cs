using Execise1and2;
using NUnit.Framework;
using System;

namespace Exercise1and2Test
{

    [TestFixture]
    public class NumbersTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, -3, 4, 0 }, ExpectedResult = 4)]
        public int ReturnSumOfInts_ShouldReturnSum_WhenInputIsValid(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            var actualResult = numbers.ReturnSumOfInts();

            return actualResult;
        }

        [Test]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int ReturnSumOfInts_ShouldReturn0_WhenInputIsNull(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            var actualResult = numbers.ReturnSumOfInts();

            return actualResult;
        }

        [Test]
        [TestCase(new int[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, -18, -45, 90 })]
        public void ReturnSumOfInts_ShouldThrowException_WhenSumIsNotInt(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            Assert.That(() => numbers.ReturnSumOfInts(), Throws.TypeOf<OverflowException>());
        }

        [Test]
        [TestCase(new int[] { 1, 2, -3, -4, 7 }, ExpectedResult = 10)]
        public int ReturnSumOfPositives_ShouldReturnSum_WhenInputIsValid(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            var actualResult = numbers.ReturnSumOfPositives();

            return actualResult;
        }

        [Test]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int ReturnSumOfPositives_ShouldReturn0_WhenInputIsNull(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            var actualResult = numbers.ReturnSumOfPositives();

            return actualResult;
        }

        [Test]
        [TestCase(new int[] { -1, -2, -3 }, ExpectedResult = 0)]
        public int ReturnSumOfPositives_ShouldReturn0_WhenInputHasOnlyNegatives(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            var actualResult = numbers.ReturnSumOfPositives();

            return actualResult;
        }

        [Test]
        [TestCase(new int[] { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, -34, -18 })]
        public void ReturnSumOfPositives_ShouldThrowException_WhenSumIsNotInt(int[] ints)
        {
            Numbers numbers = new Numbers(ints);

            Assert.That(() => numbers.ReturnSumOfPositives(), Throws.TypeOf<OverflowException>());
        }

    }
}
