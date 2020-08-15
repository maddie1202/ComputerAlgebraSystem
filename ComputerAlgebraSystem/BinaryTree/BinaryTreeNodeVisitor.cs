using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgrebraSystem.Model.BinaryTree
{
    internal abstract class BinaryTreeNodeVisitor<T>
    {
        public abstract T Visit(AdditionNode node);
        public abstract T Visit(SubtractionNode node);
        public abstract T Visit(MultiplicationNode node);
        public abstract T Visit(DivisionNode node);
        public abstract T Visit(PowerNode node);
        public abstract T Visit(FunctionNode node);
        public abstract T Visit(NumberNode node);
        public abstract T Visit(VariableNode node);

        public virtual T Visit(ExpressionNode node)
        {
            return Visit((dynamic)node);
        }
    }
}
