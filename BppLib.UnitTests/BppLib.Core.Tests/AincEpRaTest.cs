using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class AinEpRaTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new AincEpRa();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new AincEpRa{Yi = yi, Xi = xi};
            Assert.AreEqual(xi, obj.Xi);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new AincEpRa();
            int i = 159162948 ;
            obj.Id = i ;
            string expected = "@ AINC_EPRA, \"\", \"\", 159162948, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest2()
        {
           var obj = new AincEpRa();
            int i = 159162948 ;
            obj.Id = i ;
            obj.Xi = 37.3;
            obj.Yi = 52.5;
            obj.R = 99.999;
            string expected = "@ AINC_EPRA, \"\", \"\", 159162948, \"\", 0 : 37.3, 52.5, 99.999, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new AincEpRa();
            int i = 159162948 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=AINC_EPRA
	PARAM,NAME=ID,VALUE=159162948
	PARAM,NAME=XI,VALUE=0
	PARAM,NAME=YI,VALUE=0
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