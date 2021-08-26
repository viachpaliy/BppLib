using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class CutGeoTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new CutGeo();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new CutGeo{Z = r};
            Assert.AreEqual(r, obj.Z);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new CutGeo();
            int i = 158592164 ;
            obj.IntId = i ;
            string expected = "@ CUT_GEO, \"\", \"\", 158592164, \"\", 0 : \"\", 10, 0, \"\", 1, 4, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 1, \"P1001\", \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_GEO\", 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new CutGeo();
            int i = 158592164 ;
            obj.IntId = i ;
			obj.Id = "P1013";
            string expected =@"BEGIN MACRO
	NAME=CUT_GEO
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=TH,VALUE=4
	PARAM,NAME=CKA,VALUE=azrNO
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=SIL,VALUE=""""
	PARAM,NAME=TTK,VALUE=0
	PARAM,NAME=OVM,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=GIP,VALUE=YES
	PARAM,NAME=ID,VALUE=""P1013""
	PARAM,NAME=TNM,VALUE=""""
	PARAM,NAME=TTP,VALUE=200
	PARAM,NAME=TCL,VALUE=2
	PARAM,NAME=RSP,VALUE=0
	PARAM,NAME=IOS,VALUE=0
	PARAM,NAME=WSP,VALUE=0
	PARAM,NAME=SPI,VALUE=""""
	PARAM,NAME=BFC,VALUE=NO
	PARAM,NAME=SHP,VALUE=0
	PARAM,NAME=BRC,VALUE=0
	PARAM,NAME=BDR,VALUE=NO
	PARAM,NAME=PRV,VALUE=YES
	PARAM,NAME=NRV,VALUE=NO
	PARAM,NAME=DIN,VALUE=0
	PARAM,NAME=DOU,VALUE=0
	PARAM,NAME=CRC,VALUE=0
	PARAM,NAME=DSP,VALUE=0
	PARAM,NAME=CEN,VALUE=""""
	PARAM,NAME=AGG,VALUE=""""
	PARAM,NAME=LAY,VALUE=""CUT_GEO""
	PARAM,NAME=DVR,VALUE=0
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=IMS,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}