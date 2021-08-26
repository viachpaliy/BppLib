using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class RectangleTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Rectangle();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Rectangle{Yc = yi, Xc = xi};
            Assert.AreEqual(xi, obj.Xc);
            Assert.AreEqual(yi, obj.Yc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Rectangle();
            int i = 159162692 ;
            obj.Id = i ;
            string expected = "@ RECTANGLE, \"\", \"\", 159162692, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0, 1, 1" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Rectangle();
            int i = 159162692 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=RECTANGLE
	PARAM,NAME=ID,VALUE=159162692
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=L,VALUE=0
	PARAM,NAME=H,VALUE=0
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
	PARAM,NAME=USC,VALUE=1
	PARAM,NAME=CRN,VALUE=1
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}