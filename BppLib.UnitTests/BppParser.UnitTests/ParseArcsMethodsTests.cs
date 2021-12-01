using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class ArcsTests
    {
 
        [Test]
        public void AincAnCeTest()
        {
            string code = "  @ AINC_ANCE, \"\", \"\", 159162244, \"\", 0 : 12.30+2, 0, 0, 1, 0, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseAincAnCe(code);
            Assert.AreEqual(159162244, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
            Assert.AreEqual(14.3, obj.Xi);
        }

        [Test]
        public void AincAnCeTest_variables()
        {
            string code = "  @ AINC_ANCE, \"\", \"\", 159162244, \"\", 0 : 12.30*2, LPX/2, 0, 1, 0, 0, 0, 0, 0, 0";
            ParserBpp.engine.Execute("LPX = 740");
            var obj = ParserBpp.ParseAincAnCe(code);
            Assert.AreEqual(159162244, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
            Assert.AreEqual(24.6, obj.Xi);
            Assert.AreEqual(370, obj.Yi);
        }
    }
}