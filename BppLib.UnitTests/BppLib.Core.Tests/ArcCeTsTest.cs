using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ArcCeTsTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new ArcCeTs();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xc = 100;
            double yc = 50;
            var obj = new ArcCeTs{Yc = yc, Xc = xc};
            Assert.AreEqual(xc, obj.Xc);
            Assert.AreEqual(yc, obj.Yc);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new ArcCeTs();
            int i = 95686284 ;
            obj.Id = i ;
            obj.Xc = 35.678;
            obj.Yc = 24.52;
            string expected = "@ ARC_CETS, \"\", \"\", 95686284, \"\", 0 : 35.678, 24.52, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest2()
        {
           var obj = new ArcCeTs();
            int i = 95686284 ;
            obj.Id = i ;
            string expected = "@ ARC_CETS, \"\", \"\", 95686284, \"\", 0 : 0, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new ArcCeTs();
            int i = 95686284 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ARC_CETS
	PARAM,NAME=ID,VALUE=95686284
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