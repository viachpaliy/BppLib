using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineLnXeTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineLnXe();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            var obj = new LineLnXe{L = xi};
            Assert.AreEqual(xi, obj.L);
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
           var obj = new LineLnXe();
            int i = 158594404 ;
            obj.Id = i ;
            obj.L = 12.345;
            obj.Xe = 23.456;
            obj.Zs = 4.56;
            obj.Ze = 5.68;
            string expected = "@ LINE_LNXE, \"\", \"\", 158594404, \"\", 0 : 12.345, 23.456, 4.56, 5.68, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }
        
        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineLnXe();
            int i = 158594404 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_LNXE
	PARAM,NAME=ID,VALUE=158594404
	PARAM,NAME=L,VALUE=0
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