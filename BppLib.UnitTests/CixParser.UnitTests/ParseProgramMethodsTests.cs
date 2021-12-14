using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
    [TestFixture]
    public class ParseProgramMethodsTests
    {
                [Test]
		public void ParseBiesseProgramTest_VBLines()
		{
            string stringCode = @"BEGIN ID CID3
	REL= 5.0
END ID

BEGIN MAINDATA
	LPX=900
	LPY=360
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

BEGIN PUBLICVARS
	PARAM, NAME=D, VALUE=5, DESCRIPTION="""", TYPE=0
END PUBLICVARS

BEGIN VB
	VBLINE=""Dim C,Cr,Ci""
	VBLINE=""""
	VBLINE=""Ci=Array(4,1)""
	VBLINE=""""
	VBLINE=""If D=5 Then""
	VBLINE=""C=Ci(0)""
	VBLINE=""If C=1 Then""
	VBLINE=""Cr=2""
	VBLINE=""Else""
	VBLINE=""Cr=1""
	VBLINE=""End If""
END VB";
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserCix.ParseBiesseProgram(code);
            Assert.AreEqual(11, obj.ProgramSec.BiesseEntities.Count);
			VBLine str1 = (VBLine)obj.ProgramSec.BiesseEntities[0];
			Assert.AreEqual("Dim C,Cr,Ci", str1.Code);
			VBLine str5 = (VBLine)obj.ProgramSec.BiesseEntities[4];
			Assert.AreEqual("If D=5 Then", str5.Code);
			VBLine str11 = (VBLine)obj.ProgramSec.BiesseEntities[10];
			Assert.AreEqual("End If", str11.Code);
        }

        


    }
}