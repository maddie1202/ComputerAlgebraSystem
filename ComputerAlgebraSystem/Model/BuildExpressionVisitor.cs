using ComputerAlgrebraSystem.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgrebraSystem.Model
{
    public class BuildExpressionVisitor : BinaryTreeNodeVisitor<Expression>
    {
        public override Expression Visit(AdditionNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            return new Expression(left.Terms, right.Terms);
        }

        public override Expression Visit(SubtractionNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            var negatedRightTerms = new List<Term>();

            foreach (var term in right.Terms)
            {
                negatedRightTerms.Add(term.Multiply(-1));
            }

            return new Expression(left.Terms, negatedRightTerms);
        }

        public override Expression Visit(MultiplicationNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            return new Expression(new Term().Multiply(left, right));
        }

        public override Expression Visit(DivisionNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            var term = new Term().Multiply(left);
            return new Expression(term.Divide(right));
        }

        public override Expression Visit(PowerNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            var powerOperation = new PowerOperation
            { Base = left, Exponent = right };

            return new Expression(new Term().Multiply(powerOperation));
        }

        public override Expression Visit(FunctionNode node)
        {
            var argument = Visit(node.Argument);

            if (node.FunctionText == "sqrt")
            {
                return new Expression(new Term().Multiply(
                    new SquareRootFunction { Argument = argument }));
            }
            else if (node.FunctionText == "exp")
            {
                return new Expression(new Term().Multiply(
                    new ExponentialFunction { Argument = argument }));
            }
            else
            {
                throw new ArgumentException(
                    "Function {0} not supported", node.FunctionText);
            }
        }

        public override Expression Visit(NumberNode node)
        {
            return new Expression(new Term().Multiply(node.Value));
        }

        public override Expression Visit(VariableNode node)
        {
            return new Expression(new Term().Multiply(
                new Variable { Symbol = node.Symbol }));
        }
    }
}
