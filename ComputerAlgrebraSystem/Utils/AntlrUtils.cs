using System;
using System.Collections.Generic;
using System.Text;
using Antlr4.Runtime;
using ComputerAlgrebraSystem.Grammar;
using System.IO;
using ComputerAlgrebraSystem.Model;

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
