using ComputerAlgebraSystem.Model;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace ComputerAlgrebraSystem.Model
{
    public class Variable : IComponent
    {
        public char Symbol { get; set; }
        public RationalNumber Degree { get; set; } = 1;

        public IComponent Reciprocal()
        {
            return new Variable { Symbol = Symbol, Degree = Degree.Number * -1 };
        }

        //public static List<IComponent> SimplifyVariableSums(IEnumerable<Variable> variables)
        //{
        //    var multipliers = new List<IComponent>();
        //    var symbolGroups = variables.GroupBy(x => x);

        //    foreach (var symbolGroup in symbolGroups)
        //    {
        //        multipliers.Add(symbolGroup.Key);

        //        if (symbolGroup.Count() > 1)
        //        {
        //            multipliers.Add((RationalNumber)symbolGroup.Count());
        //        }
        //    }

        //    return multipliers;
        //}

        public override bool Equals(object obj)
        {
            if (!(obj is Variable otherVariable)) return false;

            return Symbol.Equals(otherVariable.Symbol) && Degree.Equals(otherVariable.Degree);
        }

        public override int GetHashCode()
        {
            return Symbol.GetHashCode() + Degree.GetHashCode();
        }

        public override string ToString()
        {
            if (Degree.Number == 1)
            {
                return Symbol.ToString();
            }

            if (Degree.IsInteger())
            {
                return Symbol.ToString() + "^" + Degree.ToString();
            }

            return Symbol.ToString() + "^(" + Degree.ToString() + ")";
        }

        public IComponent Add(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Subtract(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Multiply(IComponent other)
        {
            throw new NotImplementedException();
        }

        public IComponent Divide(IComponent other)
        {
            throw new NotImplementedException();
        }
    }
}