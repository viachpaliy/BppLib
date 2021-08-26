using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class ArcRaTsTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new ArcRaTs();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new ArcRaTs{R = r};
            Assert.AreEqual(r, obj.R);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new ArcRaTs();
            int i = 156768084 ;
            obj.Id = i ;
            string expected = "@ ARC_RATS, \"\", \"\", 156768084, \"\", 0 : 0, 1, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new ArcRaTs();
            int i = 156768084 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=ARC_RATS
	PARAM,NAME=ID,VALUE=156768084
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