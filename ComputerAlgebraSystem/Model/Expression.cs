using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerAlgrebraSystem.Model
{
    public class Expression : Multiplier
    {
        private readonly List<Term> terms = new List<Term>();

        public IEnumerable<Term> Terms 
        { 
            get
            {
                foreach (var term in terms)
                {
                    yield return term;
                }
            }
        }
        public RationalNumber Degree { get; private set; } = 1;

        public Expression(Expression expression)
        {
            terms.AddRange(new List<Term>(expression.Terms));
        }
        
        public Expression(Term term)
        {
            terms.Add(term);
        }

        public Expression(int value)
        {
            terms.Add(new Term(value));
        }

        public Expression(params IEnumerable<Term>[] newTermCollection)
        {
            foreach (var newTerms in newTermCollection)
            {
                terms.AddRange(newTerms);
            }
        }

        public Expression()
        {
        }

        public Expression(Multiplier multiplier)
        {
            terms.Add(new Term(multiplier));
        }

        public Expression AddTerm(Term term)
        {
            var expression = new Expression(this);
            expression.terms.Add(term);
            return expression;
        }

        public Expression AddTerms(IEnumerable<Term> terms)
        {
            var expression = new Expression(this);
            expression.terms.AddRange(terms);
            return expression;
        }

        public void Simplify()
        {
            foreach (var term in terms)
            {
                term.Simplify();
            }
        }

        public dynamic Cast()
        {
            if (terms.Count != 1) return this;

            try
            {
                return terms.Single().Cast();
            }
            catch
            {
                return this;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            foreach (var term in Terms)
            {
                stringBuilder.Append(term.ToString());
                stringBuilder.Append(" + ");
            }

            // remove the extra "+" at the end
            stringBuilder.Remove(stringBuilder.Length - 3, 3); 

            return stringBuilder.ToString();
        }

        public Multiplier Reciprocal()
        {
            var newExpression = new Expression(this);
            newExpression.Degree = Degree.Number * -1;
            return newExpression;
        }
    }
}
