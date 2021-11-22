using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LincEpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LincEp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LincEp{Yi = yi, Xi = xi};
            Assert.AreEqual(xi, obj.Xi);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LincEp();
            int i = 158600548 ;
            obj.Id = i ;
            string expected = "@ LINC_EP, \"\", \"\", 158600548, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest2()
        {
           var obj = new LincEp();
            int i = 158600548 ;
            obj.Id = i ;
            obj.Xi = 1.234;
            obj.Yi = 2.345;
            obj.Zs = 3.456;
            obj.Ze = -4.567;
            string expected = "@ LINC_EP, \"\", \"\", 158600548, \"\", 0 : 1.234, 2.345, 3.456, -4.567, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LincEp();
            int i = 158600548 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINC_EP
	PARAM,NAME=ID,VALUE=158600548
	PARAM,NAME=XI,VALUE=0
	PARAM,NAME=YI,VALUE=0
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