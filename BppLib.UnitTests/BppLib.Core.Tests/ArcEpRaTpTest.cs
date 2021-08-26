using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ArcEpRaTpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new ArcEpRaTp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xe = 100;
            double ye = 50;
            var obj = new ArcEpRaTp{Ye = ye, Xe = xe};
            Assert.AreEqual(xe, obj.Xe);
            Assert.AreEqual(ye, obj.Ye);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new ArcEpRaTp();
            int i = 159162436 ;
            obj.Id = i ;
            string expected = "@ ARC_EPRATP, \"\", \"\", 159162436, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new ArcEpRaTp();
            int i = 159162436 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ARC_EPRATP
	PARAM,NAME=ID,VALUE=159162436
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=R,VALUE=0
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