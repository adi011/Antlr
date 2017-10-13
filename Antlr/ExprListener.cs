using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace Antlr
{
    public class ExprListener:ExprBaseListener
    {
        public int WordCount { get; set; } = 0;
        public int NumbersCount { get; set; } = 0;
        public int SentenceCount { get; set; } = 0;

        public int LongestSentenceWordCount { get; set; } = 0;
        public int LongestWordLength { get; set; } = 0;


        public override void EnterSentence([NotNull] ExprParser.SentenceContext context)
        {
            SentenceCount++;
        }
        
    }
}
