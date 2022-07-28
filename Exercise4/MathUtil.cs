namespace Exercise4
{
    
    public class MathUtil
    {
        int a;
        int b;
        public MathUtil(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public MathUtil()
        {

        }

        public double Average()
        {
            var x=ConvertToDouble(a);
            var y=ConvertToDouble(b);
            return GetSum(x,y) / 2;
        }

        public double ConvertToDouble(int number)
        {
            return Convert.ToDouble(number);
        }

        public double GetSum(double x, double y)
        {
            return x + y;
        }
    }
}
