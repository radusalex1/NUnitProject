namespace Exercise3
{
    public class Date
    {
        public DateTime CurrentDate;

        public Date(DateTime currentDate)
        {
            this.CurrentDate = currentDate;
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

        public bool IsExpired(int year,int month,int day)
        {
            if(IsValid(year,month,day))
            {
                var date = new DateTime(year,month,day);
                if (date < CurrentDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
    }
}
