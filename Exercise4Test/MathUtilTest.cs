using Exercise4;
using NUnit.Framework;

namespace Exercise4Test
{
    [TestFixture]
    public class MathUtilTest
    {
        [Test]
        [TestCase(1,2,ExpectedResult =1.5)]
        [TestCase(23,27, ExpectedResult =25)]
        public double Average_ShouldReturnAverage_WhenInputIsValid(int a,int b)
        {
            MathUtil math = new MathUtil(a,b);

            return math.Average();
        }

        [Test]
        [TestCase(1,ExpectedResult =1.0)]
        [TestCase(24, ExpectedResult = 24.0)]
        [TestCase(-34, ExpectedResult = -34.0)]
        public double ConvertToDouble_ShouldRetrunNumberAsDouble_WhenInputIsValid(int a)
        {
            MathUtil math = new MathUtil();

            return math.ConvertToDouble(a);
        }

        [Test]
        [TestCase(1.1,4.5, ExpectedResult =5.6)]
        [TestCase(21, 14, ExpectedResult = 35)]
        [TestCase(-64,-4, ExpectedResult = -68)]
        public double GetSum_ShouldReturnSumOfDoubles_WhenInputIsValid(double x, double y)
        {
            MathUtil math = new MathUtil();

            return math.GetSum(x, y);
        }

    }
}
