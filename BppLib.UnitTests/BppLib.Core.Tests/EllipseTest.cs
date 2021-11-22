using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class EllipseTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Ellipse();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Ellipse{Yc = yi, Xc = xi};
            Assert.AreEqual(xi, obj.Xc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Ellipse();
            int i = 159161796 ;
            obj.Id = i ;
            string expected = "@ ELLIPSE, \"\", \"\", 159161796, \"\", 0 : 0, 0, 0, 0, 0, 0, 1, 1, 20, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumber()
        {
           var obj = new Ellipse();
            int i = 159161796 ;
            obj.Id = i ;
            obj.Xc = 56.378;
            obj.Yc = -98.365;
            string expected = "@ ELLIPSE, \"\", \"\", 159161796, \"\", 0 : 56.378, -98.365, 0, 0, 0, 0, 1, 1, 20, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Ellipse();
            int i = 159161796 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ELLIPSE
	PARAM,NAME=ID,VALUE=159161796
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=A1,VALUE=0
	PARAM,NAME=A2,VALUE=0
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=AS,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=UNE,VALUE=YES
	PARAM,NAME=ELM,VALUE=20
	PARAM,NAME=MLE,VALUE=0
	PARAM,NAME=UA,VALUE=YES
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=AE,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}