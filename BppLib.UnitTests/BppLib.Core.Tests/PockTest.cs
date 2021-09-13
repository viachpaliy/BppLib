using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class PockTests
    {
       

        [Test]
        public void ChangeIdTest()
        {
            var obj = new Pock();
            int i = 123456789 ;
            obj.IntId = i ; 
            Assert.AreEqual(i, obj.IntId);
        }

        [Test]
        public void CreateInstanceTest()
        {
            double r = 100;
            var obj = new Pock{Z = r};
            Assert.AreEqual(r, obj.Z);
        }

        [Test]
        public void AsBppCodeMethodTest()
        {
           var obj = new Pock();
            int i = 158594916 ;
            obj.IntId = i ;
            obj.Id = "P1017";
            string expected = "@ POCK, \"\", \"\", 158594916, \"\", 0 : \"\", \"\", 18, 10, \"\", 1, 0, 0, -1, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, -1, \"P1017\", 0, 0, 0, 0, \"\", 103, 1, 1, 45, 0, 1, 45, 0, 0, 0, 0, 0, \"\", 0, 0, \"\", \"\", \"POCK\", 0, 0, 0, 0, 0, 0" ;
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
           var obj = new Pock();
            int i = 158594916 ;
            obj.IntId = i ;
            obj.Id = "P1017";
            string expected =@"BEGIN MACRO
	NAME=POCK
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=ISL,VALUE=""""
	PARAM,NAME=DIA,VALUE=18
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=TYP,VALUE=ptZIG
	PARAM,NAME=DLT,VALUE=0
	PARAM,NAME=N,VALUE=-1
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=TC,VALUE=NO
	PARAM,NAME=CKI,VALUE=NO
	PARAM,NAME=ZST,VALUE=10
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=RRV,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=OVM,VALUE=0
	PARAM,NAME=A21,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=S21,VALUE=-1
	PARAM,NAME=ID,VALUE=""P1017""
	PARAM,NAME=DSP,VALUE=0
	PARAM,NAME=RSP,VALUE=0
	PARAM,NAME=IOS,VALUE=0
	PARAM,NAME=WSP,VALUE=0
	PARAM,NAME=TNM,VALUE=""""
	PARAM,NAME=TTP,VALUE=103
	PARAM,NAME=TCL,VALUE=1
	PARAM,NAME=TIN,VALUE=1
	PARAM,NAME=AIN,VALUE=45
	PARAM,NAME=CIN,VALUE=NO
	PARAM,NAME=TOU,VALUE=1
	PARAM,NAME=AOU,VALUE=45
	PARAM,NAME=COU,VALUE=NO
	PARAM,NAME=DIN,VALUE=0
	PARAM,NAME=DOU,VALUE=0
	PARAM,NAME=SDS,VALUE=0
	PARAM,NAME=PRP,VALUE=0
	PARAM,NAME=SPI,VALUE=""""
	PARAM,NAME=SHP,VALUE=0
	PARAM,NAME=EA21,VALUE=NO
	PARAM,NAME=CEN,VALUE=""""
	PARAM,NAME=AGG,VALUE=""""
	PARAM,NAME=LAY,VALUE=""POCK""
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=AR,VALUE=0
	PARAM,NAME=CKA,VALUE=azrNO
	PARAM,NAME=BFC,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=SDSF,VALUE=0
END MACRO";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
    }
}