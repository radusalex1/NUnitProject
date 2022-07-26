using NUnitTestProject.Servicies;

namespace NUnitTestProject
{
    public class Numbers
    {
        public Sum sum;
        public int[] numbers;

        public Numbers(int[] numbers)
        {
            sum = new Sum();
            this.numbers = numbers;
        }

        public int ReturnSumOfInts()
        {
            return sum.GetSumAllInts(numbers);
        }

        public int ReturnSumOfPositives()
        {
            return sum.GetSumAllPositives(numbers);
        }
    }
}
