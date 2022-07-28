namespace Execise1and2.Servicies
{
    public class Sum : ISum
    {
        public int GetSumAllInts(int[] listOfNumbers)
        {
            return listOfNumbers.Sum();
        }

        public int GetSumAllPositives(int[] listOfNumbers)
        {
            return listOfNumbers.Where(num => num >= 0).Sum();
        }
    }
}
