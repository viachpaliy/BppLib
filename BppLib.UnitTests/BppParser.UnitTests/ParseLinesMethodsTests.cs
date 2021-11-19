using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class LineTests
    {
 
        [Test]
        public void LineEpTest()
        {
            string code = "  @ LINE_EP, \"\", \"\", 547, \"\", 0 : 70, 575, 0, 0, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseLineEp(code);
            Assert.AreEqual(547, obj.Id);
            Assert.AreEqual(70, obj.Xe);
            Assert.AreEqual(575, obj.Ye);
            Assert.AreEqual(false, obj.Mvt);
        }
    }
}