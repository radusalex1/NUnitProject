using Exercise4.Servicies;

namespace Exercise4
{
    //TODO: trebuie facut cast la double la cele 2 numere;
    public class MathUtil
    {
        public double a;
        public double b;
        public ParseNumber parseNumber;

        public MathUtil(int a, int b)
        {
            this.parseNumber = new ParseNumber();
            this.a = parseNumber.ConvertToDoubleType(a);
            this.b = parseNumber.ConvertToDoubleType(b);
        }

        public double Average()
        {
            return (a + b) / 2;
        }
    }
}
