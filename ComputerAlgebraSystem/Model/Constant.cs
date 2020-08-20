using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ComputerAlgrebraSystem.Model
{
    public abstract class Constant
    {
        public static implicit operator Constant(int value)
        {
            return new RationalNumber(value);
        }

        public static explicit operator Constant(Expression expression)
        {
            Term term;

            try
            {
                term = expression.Terms.Single();
            }
            catch
            {
                throw new InvalidCastException(
                    expression + " cannot be cast to Constant because it has more than one term.");
            }

            return (Constant)term;
        }

        public static explicit operator Constant(Term term)
        {
            if (term.IsConstant(out var constant))
            {
                return constant;
            }

            throw new InvalidCastException("Cannot cast " + term.ToString() + " to constant");
        }

        public abstract double ToDouble();
    }
}
