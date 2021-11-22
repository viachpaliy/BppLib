using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ChamferTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Chamfer();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double d = 100;
            var obj = new Chamfer{D = d};
            Assert.AreEqual(d, obj.D);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Chamfer();
            int i = 158591396 ;
            obj.Id = i ;
            string expected = "@ CHAMFER, \"\", \"\", 158591396, \"\", 0 : 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest2()
        {
           var obj = new Chamfer();
            int i = 158591396 ;
            obj.Id = i ;
            obj.D = 5.95;
            obj.Zs = 3.56;
            obj.Ze = -2.72;
            string expected = "@ CHAMFER, \"\", \"\", 158591396, \"\", 0 : 5.95, 3.56, -2.72, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Chamfer();
            int i = 158591396 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=CHAMFER
	PARAM,NAME=ID,VALUE=158591396
	PARAM,NAME=D,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}