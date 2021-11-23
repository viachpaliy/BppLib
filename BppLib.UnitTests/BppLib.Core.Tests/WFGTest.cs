using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class WFGTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new WFG();
            int i = 123456789 ;
            obj.Id = i ; 
            Assert.AreEqual(i, obj.Id);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double xi = 100;
            double yi = 50;
            var obj = new WFG{Z = yi, Hgt = xi};
            Assert.AreEqual(yi, obj.Z);
            Assert.AreEqual(xi, obj.Hgt);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new WFG();
            int i = 158184676 ;
            obj.Id = i ;
            string expected = "@ WFG, \"\", \"\", 158184676, \"\", 0 : 6, \"\", 0, 0, 0, 1, 0, \"WFG\", 0, 0";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsBppCodeMethodTest_withDoubleNumbers()
        {
            var obj = new WFG();
            int i = 158184676 ;
            obj.Id = i ;
            obj.Hgt = 10.1 ;
            obj.Z = -2.2 ;
            string expected = "@ WFG, \"\", \"\", 158184676, \"\", 0 : 6, \"\", 0, 0, 0, 1, 0, \"WFG\", -2.2, 10.1";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new WFG();
            string expected =@"BEGIN MACRO
	NAME=WFG
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=PDF,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=VRT,VALUE=YES
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=LAY,VALUE=""WFG""
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=HGT,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}