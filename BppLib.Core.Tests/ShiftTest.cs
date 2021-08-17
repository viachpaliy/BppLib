using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ShiftTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Shift();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new Shift{Y = yi, X = xi};
            Assert.AreEqual(xi, obj.X);
            Assert.AreEqual(yi, obj.Y);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new Shift();
            int i = 155204468 ;
            obj.Id = i ;
            string expected = "@ SHIFT, \"\", \"\", 155204468, \"\", 0 : 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new Shift();
            string expected =@"BEGIN MACRO
	NAME=SHIFT
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}