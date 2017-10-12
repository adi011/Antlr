using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Antlr;

namespace AntlrTests
{
    [TestClass]
    public class ExprListenerTest
    {
        public static String TEXT = 
@"Dawno dawno temu żyła sobie gramatyka bezkontekstowa. 
Składała się z 120 reguł zapisanych w 300 linijkach. 
Była bardzo formalna i poprawna, ale pozostali mieszkańcy krainy tego nie doceniali. 
Wyrażenia regularne zazdrościły jej możliwości. 
Języki rekurencyjnie przeliczalne z kolei prostoty i elegancji.";
        [TestMethod]
        public void TestWordCount()
        {
           ExprListener listener = TextParser.ParseText(TEXT);
            Assert.AreEqual(41,listener.WordCount);
        }

        [TestMethod]
        public void TestSentenceCount()
        {
            ExprListener listener = TextParser.ParseText(TEXT);
            Assert.AreEqual(5,listener.SentenceCount);
        }

        [TestMethod]
        public void TestNumbersCount()
        {
            ExprListener listener = TextParser.ParseText(TEXT);
            Assert.AreEqual(2, listener.NumbersCount);
        }

        [TestMethod]
        public void TestLongestSentenceWordCount()
        {
            ExprListener listener = TextParser.ParseText(TEXT);
            Assert.AreEqual(12, listener.LongestSentenceWordCount);
        }
        [TestMethod]
        public void TestLongestWordLength()
        {
            ExprListener listener = TextParser.ParseText(TEXT);
            Assert.AreEqual(14, listener.LongestWordLength);
        }
    }
}
