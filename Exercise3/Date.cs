namespace Exercise3
{
    public class Date
    {
        public DateTime CalendaristicDate;
        public DateTime CurrentDate = DateTime.Today;

        public Date(DateTime calendaristicDate)
        {
            CalendaristicDate = calendaristicDate;
        }
        public Date()
        {

        }

        public bool IsValid(int year,int month,int day)
        {
            try
            {
                var date = new DateTime(year, month, day);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
           
            return true;
        }

        public bool IsExpired()
        {
            return false;
        }

    }
}
