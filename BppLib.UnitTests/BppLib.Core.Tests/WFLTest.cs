using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class WFLTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new WFL();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new WFL{Y = yi, X = xi};
            Assert.AreEqual(xi, obj.X);
            Assert.AreEqual(yi, obj.Y);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new WFL();
            int i = 158188900 ;
            obj.Id = i ;
            string expected = "@ WFL, \"\", \"\", 158188900, \"\", 0 : 7, 200, 0, 0, 0, 135, 282.85, 18, 1, 0, 0, 0, 1, 0, 1, \"WFL\"" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new WFL();
            string expected =@"BEGIN MACRO
	NAME=WFL
	PARAM,NAME=ID,VALUE=7
	PARAM,NAME=X,VALUE=200
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=AR,VALUE=135
	PARAM,NAME=L,VALUE=282.85
	PARAM,NAME=H,VALUE=18
	PARAM,NAME=VRT,VALUE=YES
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=AFL,VALUE=NO
	PARAM,NAME=AFH,VALUE=NO
	PARAM,NAME=UCS,VALUE=YES
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=FRC,VALUE=1
	PARAM,NAME=LAY,VALUE=""WFL""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}