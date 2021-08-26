using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ScaleTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Scale();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Scale{Y = yi, X = xi};
            Assert.AreEqual(xi, obj.X);
            Assert.AreEqual(yi, obj.Y);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new Scale();
            int i = 155208180 ;
            obj.Id = i ;
            string expected = "@ SCALE, \"\", \"\", 155208180, \"\", 0 : 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new Scale();
            string expected =@"BEGIN MACRO
	NAME=SCALE
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=FCT,VALUE=0
	PARAM,NAME=NU,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}