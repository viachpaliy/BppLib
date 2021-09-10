using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class GeoTextTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new GeoText();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new GeoText{R = r};
            Assert.AreEqual(r, obj.R);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new GeoText();
            int i = 158591652 ;
            obj.IntId = i ;
            obj.Id = "P1018";
            string expected = "@ GEOTEXT, \"\", \"\", 158591652, \"\", 0 : \"P1018\", 0, \"2\", \"Hello World\", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, \"Arial\", 20, 0, 0, 0, 0, 1, 0, -1, 32, 32, 50, 0, 45, 0, 0, 0, 0, 0, 1, 1, \"GEOTEXT\"" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new GeoText();
            int i = 158591652 ;
            obj.IntId = i ;
            obj.Id = "P1018";
            string expected =@"BEGIN MACRO
	NAME=GEOTEXT
	PARAM,NAME=ID,VALUE=""P1018""
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""2""
	PARAM,NAME=TXT,VALUE=""Hello World""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=ANG,VALUE=0
	PARAM,NAME=VRS,VALUE=0
	PARAM,NAME=ALN,VALUE=0
	PARAM,NAME=ACC,VALUE=0
	PARAM,NAME=CIR,VALUE=0
	PARAM,NAME=RDS,VALUE=0
	PARAM,NAME=PST,VALUE=txtExt
	PARAM,NAME=FNT,VALUE=""Arial""
	PARAM,NAME=SZE,VALUE=20
	PARAM,NAME=BOL,VALUE=0
	PARAM,NAME=ITL,VALUE=0
	PARAM,NAME=UDL,VALUE=0
	PARAM,NAME=STR,VALUE=0
	PARAM,NAME=WGH,VALUE=1
	PARAM,NAME=CHS,VALUE=0
	PARAM,NAME=RTY,VALUE=rpNO
	PARAM,NAME=DX,VALUE=32
	PARAM,NAME=DY,VALUE=32
	PARAM,NAME=R,VALUE=50
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=45
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=XRC,VALUE=0
	PARAM,NAME=YRC,VALUE=0
	PARAM,NAME=ARP,VALUE=0
	PARAM,NAME=LRP,VALUE=0
	PARAM,NAME=ER,VALUE=YES
	PARAM,NAME=RDL,VALUE=YES
	PARAM,NAME=LAY,VALUE=""GEOTEXT""
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}