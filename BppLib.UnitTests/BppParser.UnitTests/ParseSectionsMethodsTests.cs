using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class ParseSectionsMethodsTests
    {
        [Test]
		public void ParseHeaderSectionTest()
		{
            string stringCode = @"[HEADER]
TYPE=BPC
VER=140

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|564||4|
PAN=LPY|340||4|";
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserBpp.ParseHeaderSection(code);
            Assert.AreEqual("BPC", obj.Typ);
            Assert.AreEqual("140", obj.Version);
        }

        [Test]
		public void ParseDescriptionSectionTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
| first string
| second string

[VARIABLES]
PAN=LPX|564||4|
PAN=LPY|340||4|";
        
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            string expected = " first string\r\n second string\r\n";
            var obj = ParserBpp.ParseDescriptionSection(code);
            Assert.AreEqual(expected, obj.DescText);
        }


    }
}