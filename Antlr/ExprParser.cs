using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Antlr.ExprParser;

namespace Antlr
{
    public static class TextParser
    {
        public static ExprListener ParseText(String text)
        {
            AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
            ExprLexer lexer = new ExprLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
            ExprParser parser = new ExprParser(commonTokenStream);
            TextContext context = parser.text();
            ExprListener listener = new ExprListener();
            ParseTreeWalker.Default.Walk(listener, context);
            return listener;
        }
    }
}
