using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgrebraSystem.Model
{
    public abstract class Constant
    {
        public static implicit operator Constant(int value)
        {
            return new RationalNumber(value);
        }

        public abstract double ToDouble();
    }
}
