using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class FiguresTests
    {
 
        [Test]
        public void ParseCircle3PTest()
        {
            string code = "  @ CIRCLE_3P, \"\", \"\", 159161028, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseCircle3P(code);
            Assert.AreEqual(159161028, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
        }

        [Test]
        public void ParseCircleCRTest()
        {
            string code = "  @ CIRCLE_CR, \"\", \"\", 159269568, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseCircleCR(code);
            Assert.AreEqual(159269568, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
        }

        [Test]
        public void ParseEllipseTest()
        {
            string code = "  @ ELLIPSE, \"\", \"\", 159161796, \"\", 0 : 0, 0, 0, 0, 0, 0, 1, 1, 20, 0, 1, 0, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseEllipse(code);
            Assert.AreEqual(159161796, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
        }

        [Test]
        public void ParseOvalTest()
        {
            string code = "  @ OVAL, \"\", \"\", 159161604, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseOval(code);
            Assert.AreEqual(159161604, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
        }

        [Test]
        public void ParsePolygonTest()
        {
            string code = "  @ POLYGON, \"\", \"\", 159160004, \"\", 0 : 0, 0, 0, 3, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParsePolygon(code);
            Assert.AreEqual(159160004, obj.Id);
            Assert.AreEqual(3, obj.S);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
            Assert.AreEqual(true, obj.StartFromHalfSide);
        }

        [Test]
        public void ParseRectangleTest()
        {
            string code = "  @ RECTANGLE, \"\", \"\", 159162692, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0, 1, 1";
            var obj = ParserBpp.ParseRectangle(code);
            Assert.AreEqual(159162692, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
            Assert.AreEqual(true, obj.StartFromHalfSide);
        }

        [Test]
        public void ParseStarTest()
        {
            string code = "  @ STAR, \"\", \"\", 159159492, \"\", 0 : 0, 0, 100, 25, 5, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0";
            var obj = ParserBpp.ParseStar(code);
            Assert.AreEqual(159159492, obj.Id);
            Assert.AreEqual(100, obj.Er);
            Assert.AreEqual(25, obj.Ir);
            Assert.AreEqual(5, obj.Ps);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
            Assert.AreEqual(true, obj.StartFromHalfSide);
        }

    }
}