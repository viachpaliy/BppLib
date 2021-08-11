using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class CutYTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new CutY();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new CutY{D = r};
            Assert.AreEqual(r, obj.D);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new CutY();
            int i = 158594660 ;
            obj.IntId = i ;
            string expected = "@ CUT_Y, \"\", \"\", 158594660, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 100, 0, 100, \"\", 1, 4, 0, 0, 0, 0, 0, 0, 0, 1, \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_Y\", 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new CutY();
            int i = 158594660 ;
            obj.IntId = i ;
            string expected =@"BEGIN MACRO
	NAME=CUT_Y
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=L,VALUE=100
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=D,VALUE=100
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=TH,VALUE=4
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=TTK,VALUE=0
	PARAM,NAME=OVM,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=GIP,VALUE=YES
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
	PARAM,NAME=LAY,VALUE=""CUT_Y""
	PARAM,NAME=DVR,VALUE=0
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}