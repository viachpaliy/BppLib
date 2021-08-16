using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineEpTpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineEpTp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LineEpTp{Ye = yi, Xe = xi};
            Assert.AreEqual(xi, obj.Xe);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineEpTp();
            int i = 214957868 ;
            obj.Id = i ;
            string expected = "@ LINE_EPTP, \"\", \"\", 214957868, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineEpTp();
            int i = 214957868 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_EPTP
	PARAM,NAME=ID,VALUE=214957868
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