using ComputerAlgebraSystem.Model;
using Fractions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ComputerAlgrebraSystem.Model
{
    public  class RationalNumber : Constant, IMultiplier
    {
        public Fraction Number { get; set; }

        public RationalNumber Degree => 1;

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

        public bool IsInteger()
        {
            return Math.Floor(Number.ToDouble()) == Math.Ceiling(Number.ToDouble());
        }

        public static implicit operator Fraction(RationalNumber rationalNumber)
        {
            return rationalNumber.Number;
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
            if (Number == 0) return "0";

            return Number.ToString();
        }

        public IMultiplier Reciprocal()
        {
            return new RationalNumber { Number = 1 / Number};
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumber rationalNumber)) return false;

            return Number.Equals(rationalNumber.Number);
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}