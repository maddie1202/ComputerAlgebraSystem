using ComputerAlgrebraSystem.Model;
using ComputerAlgrebraSystem.Model.BinaryTree;
using ComputerAlgrebraSystem.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ComputerAlgebraSystem.Tests
{
    class ExpressionSimplifyTests
    {
        private Expression GetExpression(string exprText)
        {
            var parser = AntlrUtils.GetParser(exprText);
            var cst = parser.compileUnit();
            var ast = new BuildBinaryTreeVisitor().VisitCompileUnit(cst);
            return new BuildExpressionVisitor().Visit((ExpressionNode)ast);
        }

        [Test]
        public void SimplifyAdditionAndMultiplication()
        {
            var expression = GetExpression("(1+1)*2");
            //expression.Simplify();
            Assert.AreEqual("4", expression.ToString());
        }

    }
}
