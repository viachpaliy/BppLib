using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class StarTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Star();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Star{Yc = yi, Xc = xi};
            Assert.AreEqual(xi, obj.Xc);
            Assert.AreEqual(yi, obj.Yc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Star();
            int i = 159159492 ;
            obj.Id = i ;
            string expected = "@ STAR, \"\", \"\", 159159492, \"\", 0 : 0, 0, 100, 25, 5, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Star();
            int i = 159159492 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=STAR
	PARAM,NAME=ID,VALUE=159159492
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=ER,VALUE=100
	PARAM,NAME=IR,VALUE=25
	PARAM,NAME=PS,VALUE=5
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