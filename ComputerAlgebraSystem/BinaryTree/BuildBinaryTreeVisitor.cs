using Antlr4.Runtime.Misc;
using ComputerAlgebraSystem.Grammar;
using Fractions;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace ComputerAlgrebraSystem.Model.BinaryTree
{
    public class BuildBinaryTreeVisitor : MathBaseVisitor<BinaryTreeNode>
    {
        public override BinaryTreeNode VisitCompileUnit([NotNull] MathParser.CompileUnitContext context)
        {
            return base.Visit(context);
        }

        public override BinaryTreeNode VisitExpressionCompileUnit([NotNull] MathParser.ExpressionCompileUnitContext context)
        {
            return Visit(context.expression());
        }

        public override BinaryTreeNode VisitEquationCompileUnit([NotNull] MathParser.EquationCompileUnitContext context)
        {
            return Visit(context.equation());
        }

        public override BinaryTreeNode VisitEquation([NotNull] MathParser.EquationContext context)
        {
            return new EquationNode
            {
                Left = (ExpressionNode)Visit(context.left),
                Right = (ExpressionNode)Visit(context.right)
            };
        }

        public override BinaryTreeNode VisitParentheses([NotNull] MathParser.ParenthesesContext context)
        {
            return Visit(context.parenthesesExpression());
        }

        public override BinaryTreeNode VisitUnary([NotNull] MathParser.UnaryContext context)
        {
            switch (context.op.Type)
            {
                case MathLexer.OP_ADD:
                    return Visit(context.expression());

                case MathLexer.OP_SUB:
                    return new MultiplicationNode
                    {
                        Left = new NumberNode { Value = -1 },
                        Right = (ExpressionNode)Visit(context.expression())
                    };

                default:
                    throw new NotSupportedException();
            }
        }

        public override BinaryTreeNode VisitPower([NotNull] MathParser.PowerContext context)
        {
            return new PowerNode
            {
                Left = (ExpressionNode)Visit(context.left),
                Right = (ExpressionNode)Visit(context.right)
            };
        }

        public override BinaryTreeNode VisitMultiplicationNoAsterisk([NotNull] MathParser.MultiplicationNoAsteriskContext context)
        {
            return Visit(context.multiplicationExpression());
        }

        public override BinaryTreeNode VisitMultiplication([NotNull] MathParser.MultiplicationContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.left),
                Right = (ExpressionNode)Visit(context.right)
            };
        }

        public override BinaryTreeNode VisitDivision([NotNull] MathParser.DivisionContext context)
        {
            return new DivisionNode
            {
                Left = (ExpressionNode)Visit(context.left),
                Right = (ExpressionNode)Visit(context.right)
            };
        }

        public override BinaryTreeNode VisitAddition([NotNull] MathParser.AdditionContext context)
        {
            return new AdditionNode
            {
                Left = (ExpressionNode)Visit(context.left),
                Right = (ExpressionNode)Visit(context.right)
            };
        }

        public override BinaryTreeNode VisitSubtraction([NotNull] MathParser.SubtractionContext context)
        {
            return new SubtractionNode
            {
                Left = (ExpressionNode)Visit(context.left),
                Right = (ExpressionNode)Visit(context.right)
            };
        }

        public override BinaryTreeNode VisitFunction(MathParser.FunctionContext context)
        {
            var functionName = context.func.GetText();

            var func = typeof(Math)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.ReturnType == typeof(double))
                .Where(m => m.GetParameters().Select(p => p.ParameterType).SequenceEqual(new[] { typeof(double) }))
                .FirstOrDefault(m => m.Name.Equals(functionName, StringComparison.OrdinalIgnoreCase));

            if (func == null)
                throw new NotSupportedException(string.Format("Function {0} is not supported", functionName));

            return new FunctionNode
            {
                Function = (Func<double, double>)func.CreateDelegate(typeof(Func<double, double>)),
                FunctionText = functionName,
                Argument = (ExpressionNode)Visit(context.expression())
            };
        }

        public override BinaryTreeNode VisitNumber([NotNull] MathParser.NumberContext context)
        {
            return Visit(context.numberExpression());
        }

        public override BinaryTreeNode VisitVariable([NotNull] MathParser.VariableContext context)
        {
            return Visit(context.variableExpression());
        }

        public override BinaryTreeNode VisitParenthesesExpression([NotNull] MathParser.ParenthesesExpressionContext context)
        {
            return Visit(context.expression());
        }

        public override BinaryTreeNode VisitDoubleParentheses([NotNull] MathParser.DoubleParenthesesContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftParenExpr),
                Right = (ExpressionNode)Visit(context.rightParenExpr)
            };
        }

        public override BinaryTreeNode VisitNumberVariable([NotNull] MathParser.NumberVariableContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftNum),
                Right = (ExpressionNode)Visit(context.rightVar)
            };
        }

        public override BinaryTreeNode VisitVariableVariable([NotNull] MathParser.VariableVariableContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftVar),
                Right = (ExpressionNode)Visit(context.rightVar)
            };
        }

        public override BinaryTreeNode VisitVariableNumber([NotNull] MathParser.VariableNumberContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftVar),
                Right = (ExpressionNode)Visit(context.rightNum)
            };
        }

        public override BinaryTreeNode VisitNumberParentheses([NotNull] MathParser.NumberParenthesesContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftNum),
                Right = (ExpressionNode)Visit(context.rightParenExpr)
            };
        }

        public override BinaryTreeNode VisitVariableParentheses([NotNull] MathParser.VariableParenthesesContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftVar),
                Right = (ExpressionNode)Visit(context.rightParenExpr)
            };
        }

        public override BinaryTreeNode VisitParenthesesNumber([NotNull] MathParser.ParenthesesNumberContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftParenExpr),
                Right = (ExpressionNode)Visit(context.rightNum)
            };
        }

        public override BinaryTreeNode VisitParenthesesVariable([NotNull] MathParser.ParenthesesVariableContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftParenExpr),
                Right = (ExpressionNode)Visit(context.rightVar)
            };
        }

        public override BinaryTreeNode VisitMultiplicationParentheses([NotNull] MathParser.MultiplicationParenthesesContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftMulExpr),
                Right = (ExpressionNode)Visit(context.rightParenExpr)
            };
        }

        public override BinaryTreeNode VisitParenthesesMultiplication([NotNull] MathParser.ParenthesesMultiplicationContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftMulExpr),
                Right = (ExpressionNode)Visit(context.rightParenExpr)
            };
        }

        public override BinaryTreeNode VisitVariableMultiplication([NotNull] MathParser.VariableMultiplicationContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftMulExpr),
                Right = (ExpressionNode)Visit(context.rightVar)
            };
        }

        public override BinaryTreeNode VisitMultiplicationVariable([NotNull] MathParser.MultiplicationVariableContext context)
        {
            return new MultiplicationNode
            {
                Left = (ExpressionNode)Visit(context.leftMulExpr),
                Right = (ExpressionNode)Visit(context.rightVar)
            };
        }

        public override BinaryTreeNode VisitNumberExpression([NotNull] MathParser.NumberExpressionContext context)
        {
            return new NumberNode
            {
                Value = (Fraction)double.Parse(
                    context.value.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent)
            };
        }

        public override BinaryTreeNode VisitVariableExpression([NotNull] MathParser.VariableExpressionContext context)
        {
            return new VariableNode
            {
                Symbol = context.value.Text.Single()
            };
        }

    }
}
