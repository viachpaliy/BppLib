using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class S32Tests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new S32();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new S32{Stp = r};
            Assert.AreEqual(r, obj.Stp);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new S32();
            int i = 158594788 ;
            obj.IntId = i ;
            string expected = "@ S32, \"\", \"\", 158594788, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, 0, 32, 0, 0, \"\", 1, 0, 0, 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"S32\", 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new S32();
            int i = 158594788 ;
            obj.IntId = i ;
            string expected =@"BEGIN MACRO
	NAME=S32
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=DIA,VALUE=5
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=DIR,VALUE=drX
	PARAM,NAME=STP,VALUE=32
	PARAM,NAME=DST,VALUE=0
	PARAM,NAME=TYP,VALUE=sysCorr
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=XMI,VALUE=0
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
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
	PARAM,NAME=LAY,VALUE=""S32""
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=DTAS,VALUE=NO
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}