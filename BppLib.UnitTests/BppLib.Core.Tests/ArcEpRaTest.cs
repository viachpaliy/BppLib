using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ArcEpRaTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new ArcEpRa();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xe = 100;
            double ye = 50;
            var obj = new ArcEpRa{Ye = ye, Xe = xe};
            Assert.AreEqual(xe, obj.Xe);
            Assert.AreEqual(ye, obj.Ye);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new ArcEpRa();
            int i = 158603748 ;
            obj.Id = i ;
            string expected = "@ ARC_EPRA, \"\", \"\", 158603748, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new ArcEpRa();
            int i = 158603748 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ARC_EPRA
	PARAM,NAME=ID,VALUE=158603748
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