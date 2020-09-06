using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ComputerAlgrebraSystem.Model
{
    public interface Multiplier
    {
        RationalNumber Degree { get; }
        Multiplier Reciprocal();
    }

    public class Term
    {
        private List<IrrationalNumber> IrrationalNumbers = new List<IrrationalNumber>();
        private List<RationalNumber> RationalNumbers = new List<RationalNumber>();
        private List<PowerOperation> PowerOperations = new List<PowerOperation>();
        private List<SymbolicFunction> Functions = new List<SymbolicFunction>();
        private List<Variable> Variables = new List<Variable>();
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

        public Term(Multiplier multiplier)
        {
            Multiply((dynamic)multiplier);
        }

        public bool IsConstant(out Constant constant)
        {
            if (PowerOperations.Count > 0
                || Functions.Count > 0
                || Variables.Count > 0
                || Expressions.Count > 0)
            {
                constant = default;
                return false;
            }

            if (RationalNumbers.Count == 0 && IrrationalNumbers.Count == 0)
            {
                constant = 1;
                return true;
            }

            if (RationalNumbers.Count > 0 && IrrationalNumbers.Count == 0)
            {
                constant = RationalNumbers.Single();
            }

            if (RationalNumbers.Count == 0 && IrrationalNumbers.Count > 0)
            {
                constant = IrrationalNumbers.Single();
            }

            throw new NotImplementedException("Can't handle a constant " +
                "composed of rational and irrational numbers. 5e for example");
        }

        private List<Multiplier> GetAllMultipliers()
        {
            var multipliers = new List<Multiplier>();

            multipliers.AddRange(IrrationalNumbers);
            multipliers.AddRange(RationalNumbers);
            multipliers.AddRange(PowerOperations);
            multipliers.AddRange(Functions);
            multipliers.AddRange(Variables);
            multipliers.AddRange(Expressions);

            return multipliers;
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

            foreach (var expression in expressions)
            {
                newTerm.MultiplyByAny(expression.Cast());
            }

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

        private void MultiplyByAny(dynamic obj)
        {
            if (obj is Term term)
            {
                MulltiplyTerm(term);
            }
            else if (obj is IrrationalNumber irrationalNumber)
            {
                IrrationalNumbers.Add(irrationalNumber);
            }
            else if (obj is RationalNumber rationalNumber)
            {
                RationalNumbers.Add(rationalNumber);
            }
            else if (obj is PowerOperation powerOperation)
            {
                PowerOperations.Add(powerOperation);
            }
            else if (obj is SymbolicFunction function)
            {
                Functions.Add(function);
            }
            else if (obj is Variable variable)
            {
                Variables.Add(variable);
            }
            else if (obj is Expression expression)
            {
                Expressions.Add(expression);
            }
            else
            {
                throw new Exception("Cannot muplity by type " + obj.GetType());
            }
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
            SimplifyExpressions();
            SimplifyPowerOperations();
            SimplifyVariables();
            SimplifyRationalNumbers();
        }

        private void SimplifyRationalNumbers()
        {
            var rationalNumber = RationalNumbers.Aggregate<RationalNumber, Fraction>(1, (acc, x) => acc * x.Number);
            RationalNumbers = new List<RationalNumber>();

            if (rationalNumber != 1) RationalNumbers.Add(rationalNumber);
        }

        private void SimplifyPowerOperations()
        {
            var newPowerOperations = new List<PowerOperation>();

            foreach (var powerOperation in PowerOperations)
            {
                powerOperation.Base.Simplify();
                powerOperation.Exponent.Simplify();

                try
                {
                    RationalNumbers.Add(powerOperation.CastToRationalNumber());
                }
                catch
                {
                    newPowerOperations.Add(powerOperation);
                }
            }

            PowerOperations = newPowerOperations;
        }

        private void SimplifyVariables()
        {
            var variableGroups = Variables.GroupBy(x => x.Symbol);

            var newVariables = new List<Variable>();

            foreach (var variableGroup in variableGroups)
            {
                var degreeSum = variableGroup
                    .Aggregate<Variable, Fraction>(0, (acc, x) => acc + x.Degree.Number);

                newVariables.Add(new Variable { Symbol = variableGroup.Key, Degree = degreeSum });
            }

            Variables = newVariables;
        }

        private void SimplifyExpressions()
        {
            foreach (var expression in Expressions)
            {
                expression.Simplify();
            }
        }

        public bool HasNestedExpressions()
        {
            return Expressions.Count != 0;
        }

        public dynamic Cast()
        {
            var multipliers = GetAllMultipliers();

            if (multipliers.Count != 1) throw new InvalidCastException();

            return multipliers.Single();
        }

        public override string ToString()
        {
            var numeratorMultipliers = GetAllMultipliers().Where(x => x.Degree.Number >= 0);
            var denominatorMultipliers = GetAllMultipliers().Where(x => x.Degree.Number < 0)
                .Select(x => x.Reciprocal());

            var numerator = numeratorMultipliers.Aggregate("", (acc, x) => acc + x + " * ");
            var denominator = denominatorMultipliers.Aggregate("", (acc, x) => acc + x + " * ");

            // remove the extra "*" at the end
            numerator = numerator.Remove(numerator.Length - 3, 3);

            if (denominator.Equals(""))
            {
                return numerator;
            }

            denominator = denominator.Remove(denominator.Length - 3, 3);

            if (denominatorMultipliers.Count() > 1)
            {
                return numerator + " / (" + denominator + ")";
            }

            return numerator + " / " + denominator;
        }

    }
}