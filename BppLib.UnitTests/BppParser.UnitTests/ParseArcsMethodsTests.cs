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
            string code = "  @ AINC_ANCE, \"\", \"\", 159162244, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseAincAnCe(code);
            Assert.AreEqual(159162244, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
        }
    }
}