using System.Globalization;

namespace Exercise3
{
    public class Date
    {
        private DateTime currentDate;

        public Date(DateTime currentDate)
        {
            this.currentDate = currentDate;
        }

        public Date()
        {

        }

        private bool IsValid(int year, int month, int day)
        {
            return DateTime.TryParse($"{year}-{month}-{day}",
                                   CultureInfo.InvariantCulture,
                                   DateTimeStyles.None,
                                   out _);
        }

        public bool IsExpired(int year, int month, int day)
        {
            if (!IsValid(year, month, day))
            {
                throw new ArgumentOutOfRangeException();
            }

            var date = new DateTime(year, month, day);

            return date < currentDate;
        }
    }
}
