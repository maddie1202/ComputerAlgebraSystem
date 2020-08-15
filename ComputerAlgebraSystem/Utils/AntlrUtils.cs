using Antlr4.Runtime;
using ComputerAlgebraSystem.Grammar;
using System.IO;

namespace ComputerAlgrebraSystem.Utils
{
    public static class AntlrUtils
    {
        public static MathParser GetParser(string s)
        {
            var inputStream = new AntlrInputStream(new StringReader(s));
            var lexer = new MathLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            return new MathParser(tokenStream);
        }
    }
}
