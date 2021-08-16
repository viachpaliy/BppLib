using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineAnXeTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineAnXe();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LineAnXe{A = yi, Xe = xi};
            Assert.AreEqual(xi, obj.Xe);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineAnXe();
            int i = 158596004 ;
            obj.Id = i ;
            string expected = "@ LINE_ANXE, \"\", \"\", 158596004, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withRealData()
        {
            var obj = new LineAnXe{Id = 97455092, A = 13.9, Xe = 22.5, Zs = 1.25, Ze = -2.5};
            string expected = "@ LINE_ANXE, \"\", \"\", 97455092, \"\", 0 : 13.9, 22.5, 1.25, -2.5, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineAnXe();
            int i = 158596004 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_ANXE
	PARAM,NAME=ID,VALUE=158596004
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=XE,VALUE=0
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