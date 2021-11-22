using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineEpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineEp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LineEp{Ye = yi, Xe = xi};
            Assert.AreEqual(xi, obj.Xe);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineEp();
            int i = 158595300 ;
            obj.Id = i ;
            string expected = "@ LINE_EP, \"\", \"\", 158595300, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_with_double_numbers()
        {
           var obj = new LineEp();
            int i = 158595300 ;
            obj.Id = i ;
            obj.Xe = 987.654;
            obj.Ye = 87.543;
            obj.Zs = 5.68;
            obj.Ze = -6.59;
            string expected = "@ LINE_EP, \"\", \"\", 158595300, \"\", 0 : 987.654, 87.543, 5.68, -6.59, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineEp();
            int i = 158595300 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_EP
	PARAM,NAME=ID,VALUE=158595300
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
	PARAM,NAME=MVT,VALUE=NO
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}