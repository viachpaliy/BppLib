using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class CutGTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new CutG();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new CutG{R = r};
            Assert.AreEqual(r, obj.R);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new CutG();
            int i = 158596580 ;
            obj.IntId = i ;
            string expected = "@ CUT_G, \"\", \"\", 158596580, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 2, 0, 0, 400, 400, 0, 0, \"\", 1, 4, -1, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, \"P1001\", \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_G\", 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new CutG();
            int i = 156768084 ;
            obj.IntId = i ;
            string expected =@"BEGIN MACRO
	NAME=CUT_G
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=TYP,VALUE=cutXY
	PARAM,NAME=L,VALUE=0
	PARAM,NAME=ANG,VALUE=0
	PARAM,NAME=XE,VALUE=400
	PARAM,NAME=YE,VALUE=400
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=TH,VALUE=4
	PARAM,NAME=RTY,VALUE=rpNO
	PARAM,NAME=DX,VALUE=32
	PARAM,NAME=DY,VALUE=32
	PARAM,NAME=R,VALUE=50
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=45
	PARAM,NAME=RDL,VALUE=YES
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=CKA,VALUE=azrNO
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=XRC,VALUE=0
	PARAM,NAME=YRC,VALUE=0
	PARAM,NAME=ARP,VALUE=0
	PARAM,NAME=LRP,VALUE=0
	PARAM,NAME=ER,VALUE=YES
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=TTK,VALUE=0
	PARAM,NAME=OVM,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=GIP,VALUE=YES
	PARAM,NAME=ID,VALUE=""P1001""
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
	PARAM,NAME=LAY,VALUE=""CUT_G""
	PARAM,NAME=DVR,VALUE=0
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=IMS,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}