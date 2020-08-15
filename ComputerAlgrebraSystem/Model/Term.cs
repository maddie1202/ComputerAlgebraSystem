using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ComputerAlgrebraSystem.Model
{
    public class Term
    {
        private readonly List<IrrationalNumber> IrrationalNumbers = new List<IrrationalNumber>();
        private readonly List<RationalNumber> RationalNumbers = new List<RationalNumber>();
        private readonly List<PowerOperation> PowerOperations = new List<PowerOperation>();
        private readonly List<SymbolicFunction> Functions = new List<SymbolicFunction>();
        private readonly List<Variable> Variables = new List<Variable>();
        private List<Expression> Expressions = new List<Expression>();

        public Term(Term term)
        {
            MulltiplyTerm(term);
        }

        public Term(int value)
        {
            RationalNumbers.Add(value);
        }
        public Term()
        {
        }

        public Term Multiply(Term term)
        {
            var newTerm = new Term(this);
            newTerm.MulltiplyTerm(term);
            return newTerm;
        }

        public Term Multiply(params Expression[] expressions)
        {
            var newTerm = new Term(this);
            newTerm.Expressions.AddRange(expressions);
            return newTerm;
        }

        public Term Multiply(params PowerOperation[] powerOperations)
        {
            var newTerm = new Term(this);
            newTerm.PowerOperations.AddRange(powerOperations);
            return newTerm;
        }

        public Term Multiply(params SymbolicFunction[] functions)
        {
            var newTerm = new Term(this);
            newTerm.Functions.AddRange(functions);
            return newTerm;
        }

        public Term Multiply(params RationalNumber[] rationalNumbers)
        {
            var newTerm = new Term(this);
            newTerm.RationalNumbers.AddRange(rationalNumbers);
            return newTerm;
        }

        public Term Multiply(params Variable[] variables)
        {
            var newTerm = new Term(this);
            newTerm.Variables.AddRange(variables);
            return newTerm;
        }

        public Term Multiply(params IrrationalNumber[] irrationalNumbers)
        {
            var newTerm = new Term(this);
            newTerm.IrrationalNumbers.AddRange(irrationalNumbers);
            return newTerm;
        }

        public Term Divide(Expression expression)
        {
            var term = new Term(this);
            term.DivideExpression(expression);
            return term;
        }

        private void MulltiplyTerm(Term term)
        {
            IrrationalNumbers.AddRange(term.IrrationalNumbers);
            RationalNumbers.AddRange(term.RationalNumbers);
            PowerOperations.AddRange(term.PowerOperations);
            Functions.AddRange(term.Functions);
            Variables.AddRange(term.Variables);
            Expressions.AddRange(term.Expressions);
        }

        private void DivideExpression(Expression expression)
        {
            var term = new Term();

            term.PowerOperations.Add(new PowerOperation
            { Base = expression, Exponent = new Expression(-1)});

            var inversedExpression = new Expression(term);
            MulltiplyTerm(inversedExpression.Terms.Single());
        }

        public void Simplify()
        {
            var newExpressions = new List<Expression>();
            var expressionsCopy = new List<Expression>(Expressions);

            foreach (var expression in expressionsCopy)
            {
                if (expression.Terms.Count() == 1)
                {
                    MulltiplyTerm(expression.Terms.Single());
                }
                else
                {
                    newExpressions.Add(expression);
                }
            }

            Expressions = newExpressions;
        }

        public bool HasNestedExpressions()
        {
            return Expressions.Count != 0;
        }

        public override string ToString()
        {
            Simplify();

            var stringBuilder = new StringBuilder();

            stringBuilder.Append(RationalNumbers.Aggregate("", (acc, x) => acc + x + " * "));
            stringBuilder.Append(IrrationalNumbers.Aggregate("", (acc, x) => acc + x + " * "));
            stringBuilder.Append(PowerOperations.Aggregate("", (acc, x) => acc + x + " * "));
            stringBuilder.Append(Functions.Aggregate("", (acc, x) => acc + x + " * "));
            stringBuilder.Append(Variables.Aggregate("", (acc, x) => acc + x + " * "));
            stringBuilder.Append(Expressions.Aggregate("", (acc, x) => acc + "(" + x + ")" + " * "));

            // remove the extra "*" at the end
            stringBuilder.Remove(stringBuilder.Length - 3, 3);

            return stringBuilder.ToString();
        }
    }
}