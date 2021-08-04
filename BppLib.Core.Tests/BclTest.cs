using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class BclTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Bcl();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new Bcl{R = r};
            Assert.AreEqual(r, obj.R);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Bcl();
            int i = 158597028 ;
            obj.IntId = i ;
            obj.Id = "P1004";
            string expected = "@ BCL, \"\", \"\", 158597028, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P1004\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BCL\", 0, 0, 0, 0, -1, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Bcl();
            int i = 158597028 ;
            obj.IntId = i ;
            obj.Id = "P1004";
            string expected =@"BEGIN MACRO
	NAME=BCL
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=DIA,VALUE=5
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=RTY,VALUE=rpNO
	PARAM,NAME=DX,VALUE=32
	PARAM,NAME=DY,VALUE=32
	PARAM,NAME=R,VALUE=50
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=45
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=AR,VALUE=0
	PARAM,NAME=AP,VALUE=NO
	PARAM,NAME=CKA,VALUE=azrNO
	PARAM,NAME=XRC,VALUE=0
	PARAM,NAME=YRC,VALUE=0
	PARAM,NAME=ARP,VALUE=0
	PARAM,NAME=LRP,VALUE=0
	PARAM,NAME=ER,VALUE=YES
	PARAM,NAME=MD,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=A21,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=S21,VALUE=-1
	PARAM,NAME=ID,VALUE=""P1004""
	PARAM,NAME=AZS,VALUE=0
	PARAM,NAME=MAC,VALUE=""""
	PARAM,NAME=TNM,VALUE=""""
	PARAM,NAME=TTP,VALUE=0
	PARAM,NAME=TCL,VALUE=0
	PARAM,NAME=RSP,VALUE=0
	PARAM,NAME=IOS,VALUE=0
	PARAM,NAME=WSP,VALUE=0
	PARAM,NAME=SPI,VALUE=""""
	PARAM,NAME=DDS,VALUE=3
	PARAM,NAME=DSP,VALUE=1500
	PARAM,NAME=BFC,VALUE=NO
	PARAM,NAME=SHP,VALUE=0
	PARAM,NAME=EA21,VALUE=NO
	PARAM,NAME=CEN,VALUE=""""
	PARAM,NAME=AGG,VALUE=""""
	PARAM,NAME=LAY,VALUE=""BCL""
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=DTAS,VALUE=NO
	PARAM,NAME=RMD,VALUE=rmdAuto
	PARAM,NAME=DQT,VALUE=0
	PARAM,NAME=ERDW,VALUE=NO
	PARAM,NAME=DFW,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}