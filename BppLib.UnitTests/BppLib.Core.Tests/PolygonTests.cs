using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class PolygonTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Polygon();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Polygon{Yc = yi, Xc = xi};
            Assert.AreEqual(xi, obj.Xc);
            Assert.AreEqual(yi, obj.Yc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Polygon();
            int i = 159160004 ;
            obj.Id = i ;
            string expected = "@ POLYGON, \"\", \"\", 159160004, \"\", 0 : 0, 0, 0, 3, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
           var obj = new Polygon();
            int i = 159160004 ;
            obj.Id = i ;
            obj.Xc = 124.36;
            obj.Yc = 136.98;
            string expected = "@ POLYGON, \"\", \"\", 159160004, \"\", 0 : 124.36, 136.98, 0, 3, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Polygon();
            int i = 159160004 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=POLYGON
	PARAM,NAME=ID,VALUE=159160004
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=R,VALUE=0
	PARAM,NAME=S,VALUE=3
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=CT,VALUE=cmfNO
	PARAM,NAME=CD,VALUE=0
	PARAM,NAME=SS,VALUE=1
	PARAM,NAME=SD,VALUE=HALF
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}