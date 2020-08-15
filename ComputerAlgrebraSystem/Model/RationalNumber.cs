using Fractions;

namespace ComputerAlgrebraSystem.Model
{
    public  class RationalNumber : Constant
    {
        public Fraction Number { get; set; }

        public RationalNumber()
        {
        }

        public RationalNumber(int value)
        {
            Number = value;
        }

        public static implicit operator RationalNumber(Fraction fraction)
        {
            return new RationalNumber { Number = fraction };
        }

        public static implicit operator RationalNumber(int value)
        {
            return new RationalNumber { Number = value };
        }


        public RationalNumber(int numerator, int denominator)
        {
            Number = new Fraction(numerator, denominator);
        }

        public override double ToDouble()
        {
            return Number.ToDouble();
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}