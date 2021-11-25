using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class AuxiliaryMethodsTests
    {
        
        [Test]
		public void SplitColonTest()
		{
            string code = "  @ AINC_ANCE, \":\", \":\", 159162244, \":\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
            string[] subs = ParserBpp.SplitColon(code);
            Assert.AreEqual("  @ AINC_ANCE, \":\", \":\", 159162244, \":\", 0 ", subs[0]);
            Assert.AreEqual(" 0, 0, 0, 1, 0, 0, 0, 0, 0, 0", subs[1]);
        }

         [Test]
		public void SplitCommaTest()
		{
            string code = "  @ AINC_ANCE, \"1,2\", \"3,4\", 159162244, \"5,6\", 0 ";
            string[] subs = ParserBpp.SplitComma(code);
            Assert.AreEqual("  @ AINC_ANCE", subs[0]);
            Assert.AreEqual(" \"1,2\"", subs[1]);
            Assert.AreEqual(" \"3,4\"", subs[2]);
            Assert.AreEqual(" 159162244", subs[3]);
            Assert.AreEqual(" \"5,6\"", subs[4]);
            Assert.AreEqual(" 0 ", subs[5]);
        }

    }
}