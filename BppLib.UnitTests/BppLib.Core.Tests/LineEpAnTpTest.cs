using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineEpAnTpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineEpAnTp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LineEpAnTp{Ye = yi, Xe = xi};
            Assert.AreEqual(xi, obj.Xe);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineEpAnTp();
            int i = 214957740 ;
            obj.Id = i ;
            string expected = "@ LINE_EPANTP, \"\", \"\", 214957740, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
           var obj = new LineEpAnTp();
            int i = 214957740 ;
            obj.Id = i ;
            obj.Xe = 1.234;
            obj.Ye = 2.345;
            obj.A = 3.456;
            obj.Zs = 4.567;
            obj.Ze = -5.678;
            string expected = "@ LINE_EPANTP, \"\", \"\", 214957740, \"\", 0 : 1.234, 2.345, 3.456, 4.567, -5.678, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineEpAnTp();
            int i = 214957740 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_EPANTP
	PARAM,NAME=ID,VALUE=214957740
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=A,VALUE=0
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