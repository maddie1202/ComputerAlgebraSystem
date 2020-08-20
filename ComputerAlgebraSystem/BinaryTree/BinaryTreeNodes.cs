using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgrebraSystem.Model.BinaryTree
{
    public abstract class BinaryTreeNode
    {
    }

    public class EquationNode : BinaryTreeNode
    {
        public ExpressionNode Left { get; set; }
        public ExpressionNode Right { get; set; }
    }

    public abstract class ExpressionNode : BinaryTreeNode
    {

    }

    public abstract class InfixExpressionNode : ExpressionNode
    {
        public ExpressionNode Left { get; set; }
        public ExpressionNode Right { get; set; }
    }

    public class AdditionNode : InfixExpressionNode
    {
    }

    public class SubtractionNode : InfixExpressionNode
    {
    }

    public class MultiplicationNode : InfixExpressionNode
    {
    }

    public class DivisionNode : InfixExpressionNode
    {
    }

    public class PowerNode : InfixExpressionNode
    {

    }

    public class FunctionNode : ExpressionNode
    {
        public Func<double, double> Function { get; set; }
        public string FunctionText { get; set; }
        public ExpressionNode Argument { get; set; }
    }

    public class NumberNode : ExpressionNode
    {
        public Fraction Value { get; set; }
    }

    public class VariableNode : ExpressionNode
    {
        public char Symbol { get; set; }
    }
}
