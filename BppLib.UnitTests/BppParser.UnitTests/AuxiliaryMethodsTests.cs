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

        [Test]
        public void GetBiesseEntityTypeTest()
        {
            string code = "  @ AINC_ANCE, \":\", \":\", 159162244, \":\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
            string expected = "AINC_ANCE";
            Assert.AreEqual(expected, ParserBpp.GetBiesseEntityType(code));
        }

        [Test]
        public void GetBiesseEntityTypeTest_Negative()
        {
            string code = "PAN=FASTVERTBORINGSVALUE|0||4|";
            string expected = "";
            Assert.AreEqual(expected, ParserBpp.GetBiesseEntityType(code));
        }

        [Test]
        public void GetSectionByNameTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|564||4|
PAN=LPY|340||4|";
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            string[] actual = ParserBpp.GetSectionByName(code, "HEADER");
            Assert.AreEqual(3, actual.Length);
            Assert.AreEqual("TYPE=BPP", actual[0]);
            Assert.AreEqual("VER=150", actual[1]);
            Assert.AreEqual("", actual[2]);
 
        }

    }
}