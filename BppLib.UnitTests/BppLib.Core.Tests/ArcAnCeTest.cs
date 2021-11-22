using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ArcAnCeTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new ArcAnCe();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xc = 100;
            double yc = 50;
            var obj = new ArcAnCe{Yc = yc, Xc = xc};
            Assert.AreEqual(xc, obj.Xc);
            Assert.AreEqual(yc, obj.Yc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new ArcAnCe();
            int i = 158605156 ;
            obj.Id = i ;
            string expected = "@ ARC_ANCE, \"\", \"\", 158605156, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest2()
        {
           var obj = new ArcAnCe();
            int i = 158605156 ;
            obj.Id = i ;
            obj.A = 180.123;
            obj.Xc = 35.678;
            obj.Yc = 24.52;
            string expected = "@ ARC_ANCE, \"\", \"\", 158605156, \"\", 0 : 180.123, 35.678, 24.52, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new ArcAnCe();
            int i = 158605156 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ARC_ANCE
	PARAM,NAME=ID,VALUE=158605156
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
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