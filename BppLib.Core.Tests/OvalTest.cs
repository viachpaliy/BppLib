using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class OvalTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Oval();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Oval{Y1 = yi, X2 = xi};
            Assert.AreEqual(xi, obj.X2);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Oval();
            int i = 159161604 ;
            obj.Id = i ;
            string expected = "@ OVAL, \"\", \"\", 159161604, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Oval();
            int i = 159161604 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=OVAL
	PARAM,NAME=ID,VALUE=159161604
	PARAM,NAME=X1,VALUE=0
	PARAM,NAME=Y1,VALUE=0
	PARAM,NAME=R1,VALUE=0
	PARAM,NAME=X2,VALUE=0
	PARAM,NAME=Y2,VALUE=0
	PARAM,NAME=R2,VALUE=0
	PARAM,NAME=LKR,VALUE=0
	PARAM,NAME=AS,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
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