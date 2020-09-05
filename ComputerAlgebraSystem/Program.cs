using ComputerAlgrebraSystem.Model;
using ComputerAlgrebraSystem.Model.BinaryTree;
using ComputerAlgrebraSystem.Utils;
using System;

namespace ComputerAlgrebraSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("> ");
                var exprText = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(exprText)) break;

                var parser = AntlrUtils.GetParser(exprText);

                //try
                //{
                    var cst = parser.compileUnit();
                    var ast = new BuildBinaryTreeVisitor().VisitCompileUnit(cst);
                    var expr = new BuildExpressionVisitor().Visit((ExpressionNode)ast);
                    expr.Simplify();

                    Console.WriteLine(expr.ToString());
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex);
                //}

                Console.WriteLine();
            }
        }
    }
}
