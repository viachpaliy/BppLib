using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class RotateTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Rotate();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Rotate{Y = yi, X = xi};
            Assert.AreEqual(xi, obj.X);
            Assert.AreEqual(yi, obj.Y);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new Rotate();
            int i = 155205364 ;
            obj.Id = i ;
            string expected = "@ ROTATE, \"\", \"\", 155205364, \"\", 0 : 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new Rotate();
            string expected =@"BEGIN MACRO
	NAME=ROTATE
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=AR,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}