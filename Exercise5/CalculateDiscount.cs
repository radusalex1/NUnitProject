using Exercise5.Servicies;

namespace Exercise5
{
    public class CalculateDiscount:IDayOfWeek
    {
        public double price;
        public DateTime dateTime;

        public CalculateDiscount(double price, DateTime dateTime)
        {
            this.price = price;
            this.dateTime = dateTime;
        }

        public int GetDayOfWeekBasedOnDate(DateTime date)
        {
            return (int)date.DayOfWeek;
        }

        //TODO: switch case by dayOfWeek; + de facut calculele;
        public double NewPrice(double price,DateTime date)
        {
            //TODO: daca data nu este valida throw exception; invalidsystemRange cv de genu;
            int dayOfWeek = GetDayOfWeekBasedOnDate(date);
            throw new NotImplementedException();
        }
    }
}
