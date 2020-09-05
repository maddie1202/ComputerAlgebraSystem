using Fractions;
using System;
using System.Data;

namespace ComputerAlgrebraSystem.Model
{
    public class PowerOperation : Multiplier
    {
        public Expression Base { get; set; }
        public Expression Exponent { get; set; }

        public RationalNumber Degree
        { 
            get
            {
                Multiplier multiplier = Exponent.Cast();
                return multiplier.Degree;
            } 
        }

        public Multiplier Reciprocal()
        {
            return new PowerOperation { Base = new Expression(Base), Exponent = new Expression(Exponent.Reciprocal()) };
        }

        public RationalNumber CastToRationalNumber()
        {
            if (Base.Cast() is RationalNumber _base && 
                Exponent.Cast() is RationalNumber exponent)
            {
                var exponentDouble = exponent.ToDouble();

                if (Math.Floor(exponentDouble) == Math.Ceiling(exponentDouble))
                {
                    return Fraction.Pow(_base.Number, exponent.Number.ToInt32());
                }
            }

            throw new InvalidCastException("Cannot cast " + ToString() + " to a rational number.");
        }

        public override string ToString()
        {
            var exponent = Exponent.ToString();
            var _base = Base.ToString();

            if (Exponent.Cast() is RationalNumber rationalNumber && rationalNumber.Number == 1)
            {
                return _base;
            }

            if (!double.TryParse(exponent, out _) && exponent.Length > 1)
            {
                exponent = "(" + exponent + ")";
            }

            if (!double.TryParse(_base, out _) && _base.Length > 1)
            {
                _base = "(" + _base + ")";
            }

            return $"{_base}^{exponent}";
        }
    }
}