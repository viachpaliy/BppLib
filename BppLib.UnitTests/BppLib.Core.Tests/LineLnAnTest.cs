using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class LineLnAnTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new LineLnAn();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new LineLnAn{A = yi, L = xi};
            Assert.AreEqual(xi, obj.L);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new LineLnAn();
            int i = 158590500 ;
            obj.Id = i ;
            obj.L = 1.02;
            obj.A = -42.36;
            obj.Zs = 5.68;
            obj.Ze = -8.97;
            string expected = "@ LINE_LNAN, \"\", \"\", 158590500, \"\", 0 : 1.02, -42.36, 5.68, -8.97, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new LineLnAn();
            int i = 158590500 ;
            obj.Id = i ;
            string expected =@"BEGIN MACRO
	NAME=LINE_LNAN
	PARAM,NAME=ID,VALUE=158590500
	PARAM,NAME=L,VALUE=0
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