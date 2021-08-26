using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class BGeoTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new BGeo();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double z = 11.3;
            var obj = new BGeo{Z = z};
            Assert.AreEqual(z, obj.Z);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new BGeo();
            int i = 158597540 ;
            obj.IntId = i ;
            string expected = "@ B_GEO, \"\", \"\", 158597540, \"\", 0 : \"\", 10, 5, 0, \"\", 1, 0, 0, 0, 0, \"\", 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"B_GEO\", 0, 0, 0, 0, -1, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new BGeo();
            int i = 158597540 ;
            obj.IntId = i ;
            obj.Id = "P1007";
            string expected =@"BEGIN MACRO
	NAME=B_GEO
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=DIA,VALUE=5
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=AR,VALUE=0
	PARAM,NAME=CKA,VALUE=azrNO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=SIL,VALUE=""""
	PARAM,NAME=A21,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=S21,VALUE=-1
	PARAM,NAME=ID,VALUE=""P1007""
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
	PARAM,NAME=LAY,VALUE=""B_GEO""
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=DTAS,VALUE=NO
	PARAM,NAME=RMD,VALUE=rmdAuto
	PARAM,NAME=DQT,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}