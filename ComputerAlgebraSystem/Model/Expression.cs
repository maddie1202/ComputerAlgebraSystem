using System;
using System.Collections.Generic;
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
        public RationalNumber Degree => 1;


        public Expression(Expression expression)
        {
            terms.AddRange(expression.Terms);
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
    }
}
