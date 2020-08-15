using ComputerAlgrebraSystem.Model.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerAlgrebraSystem.Model
{
    internal enum Precedence
    {
        GreaterThan,
        Same,
        LessThan
    }
    internal static class OperatorPrecedence
    {
        private static readonly List<List<Type>> Precedences = new List<List<Type>>
        {
            new List<Type> { typeof(AdditionNode), typeof(SubtractionNode), typeof(FunctionNode) },
            new List<Type> { typeof(MultiplicationNode), typeof(DivisionNode) },
            new List<Type> { typeof(PowerNode) }
        };

        private static int GetTypePrecedence(Type type)
        {
            for (int i = 0; i < Precedences.Count; i++)
            {
                if (Precedences[i].Contains(type))
                {
                    return i;
                }
            }

            throw new ArgumentException($"{type}'s precedence is not specified.");
        }

        /// <summary>
        ///     Determines node1's precedence with reference to node2
        /// </summary>
        /// <param name="node1">   
        ///     The node whose precedemce is returned
        /// </param>
        /// <param name="node2">
        ///     The reference node to determine node1's precedence
        /// </param>
        /// <returns>
        ///     node1's precedence with reference to node2
        /// </returns>
        /// <example>
        ///     <code>
        ///         Assert.IsTrue(additionNode.GetPrecedence(multiplicationNode) == Precedence.LessThan);
        ///     </code>
        /// </example>
        public static Precedence GetPrecedence(this ExpressionNode node1, ExpressionNode node2)
        {
            if (node2.GetType() == typeof(NumberNode) || node2.GetType() == typeof(VariableNode)
                || node1.GetType() == typeof(NumberNode) || node1.GetType() == typeof(VariableNode))
            {
                return Precedence.Same;
            }

            var node1Precedence = GetTypePrecedence(node1.GetType());
            var node2Precedence = GetTypePrecedence(node2.GetType());

            if (node1Precedence > node2Precedence)
            {
                return Precedence.GreaterThan;
            }
            else if (node1Precedence < node2Precedence)
            {
                return Precedence.LessThan;
            }
            else
            {
                return Precedence.Same;
            }
        }

    }
}
