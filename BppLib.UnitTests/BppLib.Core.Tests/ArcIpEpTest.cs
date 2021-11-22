using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ArcIpEpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new ArcIpEp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xe = 100;
            double ye = 50;
            var obj = new ArcIpEp{Ye = ye, Xe = xe};
            Assert.AreEqual(xe, obj.Xe);
            Assert.AreEqual(ye, obj.Ye);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new ArcIpEp();
            int i = 159162628 ;
            obj.Id = i ;
            string expected = "@ ARC_IPEP, \"\", \"\", 159162628, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest2()
        {
           var obj = new ArcIpEp();
            int i = 159162628 ;
            obj.Id = i ;
            obj.X2 = 1.234;
            obj.Y2 = 2.345;
            obj.Xe = 3.456;
            obj.Ye = 4.567;
            string expected = "@ ARC_IPEP, \"\", \"\", 159162628, \"\", 0 : 1.234, 2.345, 3.456, 4.567, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new ArcIpEp();
            int i = 159162628 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ARC_IPEP
	PARAM,NAME=ID,VALUE=159162628
	PARAM,NAME=X2,VALUE=0
	PARAM,NAME=Y2,VALUE=0
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
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