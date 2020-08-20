using ComputerAlgrebraSystem.Utils;
using ComputerAlgrebraSystem.Model.BinaryTree;
using NUnit.Framework;
using Fractions;
using ComputerAlgrebraSystem.Model;

namespace ComputerAlgebraSystem.Tests
{
    public class BuildBinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private BinaryTreeNode GetBinaryTree(string s)
        {
            var parser = AntlrUtils.GetParser(s);
            var cst = parser.compileUnit();
            return new BuildBinaryTreeVisitor().VisitCompileUnit(cst);
        }

        [Test]
        public void BuildNumberNode()
        {
            var binaryTree = GetBinaryTree("3");

            var numberNode = binaryTree as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)3, numberNode.Value);
        }

        [Test]
        public void BuildVariableNode()
        {
            var binaryTree = GetBinaryTree("x");

            var variableNode = binaryTree as VariableNode;

            Assert.NotNull(variableNode);
            Assert.AreEqual('x', variableNode.Symbol);
        }

        [Test]
        public void BuildAdditionNode()
        {
            var binaryTree = GetBinaryTree("x + 4");

            var additionNode = binaryTree as AdditionNode;

            Assert.NotNull(additionNode);

            var variableNode = additionNode.Left as VariableNode;

            Assert.NotNull(variableNode);
            Assert.AreEqual('x', variableNode.Symbol);

            var numberNode = additionNode.Right as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)4, numberNode.Value);
        }

        [Test]
        public void BuildSubtractionNode()
        {
            var binaryTree = GetBinaryTree("7 - x");

            var subtractionNode = binaryTree as SubtractionNode;

            Assert.NotNull(subtractionNode);

            var numberNode = subtractionNode.Left as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)7, numberNode.Value);

            var variableNode = subtractionNode.Right as VariableNode;

            Assert.NotNull(variableNode);
            Assert.AreEqual('x', variableNode.Symbol);
        }

        [Test]
        public void BuildMultiplicationNodeWithAsterix()
        {
            var binaryTree = GetBinaryTree("15 * 2");

            var multiplicationNode = binaryTree as MultiplicationNode;

            Assert.NotNull(multiplicationNode);

            var fifteenNode = multiplicationNode.Left as NumberNode;

            Assert.NotNull(fifteenNode);
            Assert.AreEqual((Fraction)15, fifteenNode.Value);

            var twoNode = multiplicationNode.Right as NumberNode;

            Assert.NotNull(twoNode);
            Assert.AreEqual((Fraction)2, twoNode.Value);
        }

        [Test]
        public void BuildMultiplicationNodeNoAsterix()
        {
            var binaryTree = GetBinaryTree("9x");

            var multiplicationNode = binaryTree as MultiplicationNode;

            Assert.NotNull(multiplicationNode);

            var numberNode = multiplicationNode.Left as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)9, numberNode.Value);

            var variableNode = multiplicationNode.Right as VariableNode;

            Assert.NotNull(variableNode);
            Assert.AreEqual('x', variableNode.Symbol);
        }

        [Test]
        public void BuildDivisionNode()
        {
            var binaryTree = GetBinaryTree("11 / x");

            var divisionNode = binaryTree as DivisionNode;

            Assert.NotNull(divisionNode);

            var numberNode = divisionNode.Left as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)11, numberNode.Value);

            var variableNode = divisionNode.Right as VariableNode;

            Assert.NotNull(variableNode);
            Assert.AreEqual('x', variableNode.Symbol);
        }

        [Test]
        public void BuildPowernNode()
        {
            var binaryTree = GetBinaryTree("x^2");

            var powerNode = binaryTree as PowerNode;

            Assert.NotNull(powerNode);

            var variableNode = powerNode.Left as VariableNode;

            Assert.NotNull(variableNode);
            Assert.AreEqual('x', variableNode.Symbol);

            var numberNode = powerNode.Right as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)2, numberNode.Value);
        }

        [Test]
        public void BuildFunctionNode()
        {
            var binaryTree = GetBinaryTree("sqrt(4)");

            var functionNode = binaryTree as FunctionNode;

            Assert.NotNull(functionNode);
            Assert.AreEqual("sqrt", functionNode.FunctionText);

            var numberNode = functionNode.Argument as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual((Fraction)4, numberNode.Value);
        }
    }
}