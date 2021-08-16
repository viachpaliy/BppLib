using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineLnTpTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineLnTp();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            var obj = new LineLnTp{L = xi};
            Assert.AreEqual(xi, obj.L);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineLnTp();
            int i = 215896772 ;
            obj.Id = i ;
            string expected = "@ LINE_LNTP, \"\", \"\", 215896772, \"\", 0 : 0, 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineLnTp();
            int i = 215896772 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_LNTP
	PARAM,NAME=ID,VALUE=215896772
	PARAM,NAME=L,VALUE=0
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