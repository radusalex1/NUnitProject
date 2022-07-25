using NUnitTestProject.Servicies;

namespace NUnitTestProject
{
    public class Numbers
    {
        public Sum sum;
        public List<int> numbers;

        public Numbers(List<int> numbers)
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
