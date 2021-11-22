using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class CircleCRTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new CircleCR();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new CircleCR{Yc = yi, Xc = xi};
            Assert.AreEqual(xi, obj.Xc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new CircleCR();
            int i = 159269568 ;
            obj.Id = i ;
            string expected = "@ CIRCLE_CR, \"\", \"\", 159269568, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

         [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
           var obj = new CircleCR();
            int i = 159269568 ;
            obj.Id = i ;
            obj.Xc = 6.598;
            obj.Yc = -7.985;
            string expected = "@ CIRCLE_CR, \"\", \"\", 159269568, \"\", 0 : 6.598, -7.985, 0, 0, 1, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new CircleCR();
            int i = 159269568 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=CIRCLE_CR
	PARAM,NAME=ID,VALUE=159269568
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=R,VALUE=0
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