using NUnit.Framework;
using ComputerAlgrebraSystem.Utils;
using Fractions;
using ComputerAlgrebraSystem.Model.BinaryTree;

namespace ComputerAlgebraSystem.Tests
{
    public class BuildBinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BuildNumberNode()
        {
            var parser = AntlrUtils.GetParser("3");
            var cst = parser.compileUnit();
            var binaryTree = new BuildBinaryTreeVisitor().VisitCompileUnit(cst);

            var numberNode = binaryTree as NumberNode;

            Assert.NotNull(numberNode);
            Assert.AreEqual(numberNode.Value, (Fraction)3);
        }
    }
}