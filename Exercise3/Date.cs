namespace Exercise3
{
    public class Date
    {
        public DateTime CalendaristicDate;

        public Date(DateTime calendaristicDate)
        {
            CalendaristicDate = calendaristicDate;
        }

        public string IsValid()
        {
            return string.Empty;
        }

        public bool IsExpired()
        {
            return false;
        }

    }
}
