using NUnit.Framework;
using BppLib.Core;
using System.Collections.Generic;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class BiesseProgramTest
    {
         [Test]
        public void AsBppCodeMethodTest_withSimpleBoring()
        {
            var obj = new BiesseProgram();
            obj.MainData.Lpx = 500;
            obj.MainData.Lpy = 400;
            obj.MainData.Lpz = 18;
            obj.MainData.OrLst = "5";
            obj.ProgramSec.BiesseEntities.Add(new Bv{IntId=212926524, Id="D7L19", Side=0, Crn="1,2,4,3", X=9, Y=50, Z=0, Dp=19, Dia=7, Ttp=1});
            string expected = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|500||4|
PAN=LPY|400||4|
PAN=LPZ|18||4|
PAN=ORLST|""5""||3|
PAN=SIMMETRY|1||1|
PAN=TLCHK|0||1|
PAN=TOOLING|""""||3|
PAN=CUSTSTR|$B$KBsExportToNcRvA.XncExtraPanelData$V""""||3|
PAN=FCN|1.000000||2|
PAN=XCUT|0||4|
PAN=YCUT|0||4|
PAN=JIGTH|0||4|
PAN=CKOP|0||1|
PAN=UNIQUE|0||1|
PAN=MATERIAL|""wood""||3|
PAN=PUTLST|""""||3|
PAN=OPPWKRS|0||1|
PAN=UNICLAMP|0||1|
PAN=CHKCOLL|0||1|
PAN=WTPIANI|0||1|
PAN=COLLTOOL|0||1|
PAN=CALCEDTH|0||1|
PAN=ENABLELABEL|0||1|
PAN=LOCKWASTE|0||1|
PAN=LOADEDGEOPT|0||1|
PAN=ITLTYPE|0||1|
PAN=RUNPAV|0||1|
PAN=FLIPEND|0||1|
PAN=ENABLEMACHLINKS|0||1|
PAN=ENABLEPURSUITS|0||1|
PAN=ENABLEFASTVERTBORINGS|0||1|
PAN=FASTVERTBORINGSVALUE|0||4|

[PROGRAM]
@ BV, """", """", 212926524, """", 0 : 0, ""1,2,4,3"", 9, 50, 0, 19, 7, 0, -1, 32, 32, 50, 0, 45, 0, """", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, ""D7L19"", 0, """", """", 1, 0, 0, 0, 0, """", 3, 1500, 0, 0, 0, """", """", ""BV"", 0, 0, 0, 0, -1, 0, 0, 0


[VBSCRIPT]

[MACRODATA]

[TDCODES]

[PCF]

[TOOLING]

[SUBPROGS]

";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest_withSimpleBoring()
        {
            var obj = new BiesseProgram();
            obj.MainData.Lpx = 500;
            obj.MainData.Lpy = 400;
            obj.MainData.Lpz = 18;
            obj.MainData.OrLst = "5";
            obj.ProgramSec.BiesseEntities.Add(new Bv{IntId=212926524, Id="D7L19", Side=0, Crn="1,2,4,3", X=9, Y=50, Z=0, Dp=19, Dia=7, Ttp=1});
            string expected = @"BEGIN ID CID3
	REL= 5.0
END ID

BEGIN MAINDATA
	LPX=500
	LPY=400
	LPZ=18
	ORLST=""5""
	SIMMETRY=1
	TLCHK=0
	TOOLING=""""
	CUSTSTR=$B$KBsExportToNcRvA.XncExtraPanelData$V""""
	FCN=1.000000
	XCUT=0
	YCUT=0
	JIGTH=0
	CKOP=0
	UNIQUE=0
	MATERIAL=""wood""
	PUTLST=""""
	OPPWKRS=0
	UNICLAMP=0
	CHKCOLL=0
	WTPIANI=0
	COLLTOOL=0
	CALCEDTH=0
	ENABLELABEL=0
	LOCKWASTE=0
	LOADEDGEOPT=0
	ITLTYPE=0
	RUNPAV=0
	FLIPEND=0
	ENABLEMACHLINKS=0
	ENABLEPURSUITS=0
	ENABLEFASTVERTBORINGS=0
	FASTVERTBORINGSVALUE=0
END MAINDATA

BEGIN MACRO
	NAME=BV
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1,2,4,3""
	PARAM,NAME=X,VALUE=9
	PARAM,NAME=Y,VALUE=50
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=19
	PARAM,NAME=DIA,VALUE=7
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
	PARAM,NAME=ID,VALUE=""D7L19""
	PARAM,NAME=AZS,VALUE=0
	PARAM,NAME=MAC,VALUE=""""
	PARAM,NAME=TNM,VALUE=""""
	PARAM,NAME=TTP,VALUE=1
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
	PARAM,NAME=LAY,VALUE=""BV""
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=DTAS,VALUE=NO
	PARAM,NAME=RMD,VALUE=rmdAuto
	PARAM,NAME=DQT,VALUE=0
	PARAM,NAME=ERDW,VALUE=NO
	PARAM,NAME=DFW,VALUE=0
END MACRO

BEGIN VB
	VBLINE=""""
END VB

";
             Assert.AreEqual(expected, obj.AsCixCode());
        }

    }

}