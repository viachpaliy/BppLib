using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class WFCTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new WFC();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new WFC{Y = yi, X = xi};
            Assert.AreEqual(xi, obj.X);
            Assert.AreEqual(yi, obj.Y);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new WFC();
            int i = 158184740 ;
            obj.Id = i ;
            string expected = "@ WFC, \"\", \"\", 158184740, \"\", 0 : 6, 200, 200, 0, 0, 18, 0, 90, 200, 2, 1, 0, 0, 1, 0, \"WFC\"";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
            var obj = new WFC();
            int i = 158184740 ;
            obj.Id = i ;
            obj.X = 100.1 ;
            obj.Y = -200.2 ;
            string expected = "@ WFC, \"\", \"\", 158184740, \"\", 0 : 6, 100.1, -200.2, 0, 0, 18, 0, 90, 200, 2, 1, 0, 0, 1, 0, \"WFC\"";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new WFC();
            string expected =@"BEGIN MACRO
	NAME=WFC
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=X,VALUE=200
	PARAM,NAME=Y,VALUE=200
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=H,VALUE=18
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=90
	PARAM,NAME=R,VALUE=200
	PARAM,NAME=DIR,VALUE=dirCCW
	PARAM,NAME=VRT,VALUE=YES
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=AFH,VALUE=NO
	PARAM,NAME=UCS,VALUE=YES
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=LAY,VALUE=""WFC""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}