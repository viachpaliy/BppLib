using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class GeoTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Geo();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new Geo{R = r};
            Assert.AreEqual(r, obj.R);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Geo();
            int i = 158183076 ;
            obj.IntId = i ;
            obj.Id = "P1016";
            string expected = "@ GEO, \"\", \"\", 158183076, \"\", 0 : \"P1016\", 0, \"1\", 0, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 1, 0, 0, \"GEO\", 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Geo();
            int i = 158183076 ;
            obj.IntId = i ;
            obj.Id = "P1016";
            string expected =@"BEGIN MACRO
	NAME=GEO
	PARAM,NAME=ID,VALUE=""P1016""
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=DP,VALUE=0
	PARAM,NAME=RTY,VALUE=rpNO
	PARAM,NAME=XRC,VALUE=0
	PARAM,NAME=YRC,VALUE=0
	PARAM,NAME=DX,VALUE=32
	PARAM,NAME=DY,VALUE=32
	PARAM,NAME=R,VALUE=50
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=45
	PARAM,NAME=RDL,VALUE=YES
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=ARP,VALUE=0
	PARAM,NAME=LRP,VALUE=0
	PARAM,NAME=ER,VALUE=YES
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=LAY,VALUE=""GEO""
	PARAM,NAME=CRC,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}