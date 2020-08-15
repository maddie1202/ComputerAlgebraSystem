using ComputerAlgrebraSystem.Utils;
using ComputerAlgrebraSystem.Model.BinaryTree;
using NUnit.Framework;
using Fractions;

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