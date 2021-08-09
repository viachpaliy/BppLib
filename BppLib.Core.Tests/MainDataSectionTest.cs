using NUnit.Framework;
using BppLib.Core;

namespace BppLib.Core.Tests
{
    [TestFixture]
    public class MainDataSectionTest
    {
         [Test]
        public void AsBppCodeMethodTest()
        {
            var obj = new MainDataSection();
            string expected = @"[VARIABLES]
PAN=LPX|800||4|
PAN=LPY|500||4|
PAN=LPZ|30||4|
PAN=ORLST|""1""||3|
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
PAN=FASTVERTBORINGSVALUE|0||4|";
            Assert.AreEqual(expected, obj.AsBppCode());
        }

        [Test]
        public void AsCixCodeMethodTest()
        {
            var obj = new MainDataSection();
            string expected = @"BEGIN MAINDATA
	LPX=800
	LPY=500
	LPZ=30
	ORLST=""1""
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
END MAINDATA";
            Assert.AreEqual(expected, obj.AsCixCode());
        }
        
    }
}