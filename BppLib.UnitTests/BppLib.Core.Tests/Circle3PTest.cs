using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class Circle3PTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Circle3P();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Circle3P{Y1 = yi, X2 = xi};
            Assert.AreEqual(xi, obj.X2);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Circle3P();
            int i = 159161028 ;
            obj.Id = i ;
            string expected = "@ CIRCLE_3P, \"\", \"\", 159161028, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
           var obj = new Circle3P();
            int i = 159161028 ;
            obj.Id = i ;
            obj.X1 = 1.236;
            obj.Y1 = -3.65;
            string expected = "@ CIRCLE_3P, \"\", \"\", 159161028, \"\", 0 : 1.236, -3.65, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Circle3P();
            int i = 159161028 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=CIRCLE_3P
	PARAM,NAME=ID,VALUE=159161028
	PARAM,NAME=X1,VALUE=0
	PARAM,NAME=Y1,VALUE=0
	PARAM,NAME=X2,VALUE=0
	PARAM,NAME=Y2,VALUE=0
	PARAM,NAME=X3,VALUE=0
	PARAM,NAME=Y3,VALUE=0
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