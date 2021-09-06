using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class PutProgTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new PutProg();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new PutProg{Y = yi, X = xi};
            Assert.AreEqual(xi, obj.X);
            Assert.AreEqual(yi, obj.Y);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new PutProg();
            int i = 155209268 ;
            obj.IntId = i ;
            obj.Id = "P1007";
            string expected = "@ PUTPROG, \"\", \"\", 155209268, \"\", 0 : \"P1007\", \"\", -1, -1, -1, 0, 0, 1, 1, 1, 0, 0, 0, 0, \"\"" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new PutProg();
            obj.Id = "P1007";
            string expected =@"BEGIN MACRO
	NAME=PUTPROG
	PARAM,NAME=ID,VALUE=""P1007""
	PARAM,NAME=SPNAME,VALUE=""""
	PARAM,NAME=SPLPX,VALUE=-1
	PARAM,NAME=SPLPY,VALUE=-1
	PARAM,NAME=SPLPZ,VALUE=-1
	PARAM,NAME=SYMY,VALUE=NO
	PARAM,NAME=ROT,VALUE=0
	PARAM,NAME=SPCRN,VALUE=1
	PARAM,NAME=RFT,VALUE=1
	PARAM,NAME=REF,VALUE=1
	PARAM,NAME=BCK,VALUE=0
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=PAV,VALUE=NO
	PARAM,NAME=VARS,VALUE=""""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}