using Fractions;
using System;
using System.ComponentModel;

namespace ComputerAlgrebraSystem.Model
{

    public abstract class IrrationalNumber : Constant
    {
        public abstract string Symbol { get; }
        public Constant Degree { get; set; } = 1;

        public override string ToString() => Symbol;
    }

    public class IrrationalNumberE : IrrationalNumber
    {
        public override string Symbol => "e";

        public override double ToDouble()
        {
            return Math.Pow(2.71828182846, Degree.ToDouble());
        }
    }

    public class IrrationalNumberPi : IrrationalNumber
    {
        public override string Symbol => "pi";

        public override double ToDouble()
        {
            return Math.Pow(3.14159265359, Degree.ToDouble());
        }
    }


}