namespace Exercise5
{
    public class CalculateDiscount
    {
        public double price;
        public DateTime dateTime;

        public const double MONDAY_DISCOUNT = 18;
        public const double TUESDAY_DISCOUNT = 15;
        public const double WEDNESDAY_DISCOUNT = 0;
        public const double THURSDAY_DISCOUNT = 15;
        public const double FRIDAY_DISCOUNT = 50;
        public const double SATURDAY_DISCOUNT = 7;
        public const double SUNDAY_DISCOUNT = 5;

        /// <summary>
        /// Constructor for testing.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="dateTime"></param>
        public CalculateDiscount(double price, DateTime dateTime)
        {
            this.price = price;
            this.dateTime = dateTime;
        }

        public CalculateDiscount(double price)
        {
            dateTime = DateTime.Today;
            this.price = price;
        }

        public string GetDayOfWeekBasedOnDate()
        {
            return dateTime.DayOfWeek.ToString();
        }

        public double CalculateNewPrice(double discount)
        {
            return price - (price * discount / 100.00);
        }

        public double GetNewPrice()
        {
            string dayOfWeek = GetDayOfWeekBasedOnDate();
            double discount = 0;

            switch (dayOfWeek) 
            {
                case "Monday":
                    {
                        discount = MONDAY_DISCOUNT;
                        break;
                    }
                case "Tuesday":
                    {
                        discount = TUESDAY_DISCOUNT;
                        break;
                    }
                case "Thursday":
                    {
                        discount = TUESDAY_DISCOUNT;
                        break; 
                    }
                case "Wednesday":
                    {
                        discount = WEDNESDAY_DISCOUNT;
                        break;
                    }
                case "Friday":
                    {
                        discount = FRIDAY_DISCOUNT;
                        break;
                    }
                case "Saturday":
                    {
                        discount = SATURDAY_DISCOUNT;
                        break;
                    }
                default:
                    {
                        discount = SUNDAY_DISCOUNT;
                        break;
                    }
            }

            return CalculateNewPrice(discount);
        }
    }
}
