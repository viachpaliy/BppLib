using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
    [TestFixture]
    public class ParseSectionsMethodsTests
    {
                [Test]
		public void ParseHeaderSectionTest()
		{
  
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserCix.ParseHeaderSection(code);
            Assert.AreEqual("3.5", obj.Release);
        }

        
        [Test]
		public void ParseMainDataSectionTest()
        {
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserCix.ParseMainDataSection(code);
            Assert.AreEqual(564.5, obj.Lpx);
            Assert.AreEqual(340.6, obj.Lpy);
            Assert.AreEqual(18.2, obj.Lpz);
            Assert.AreEqual("1,4", obj.OrLst);
            Assert.AreEqual(false, obj.Simmetry);
            Assert.AreEqual(1, obj.TlChk);
            Assert.AreEqual("Tooling", obj.Tooling);
            Assert.AreEqual("text", obj.CustStr);
            Assert.AreEqual(25.4, obj.Fcn);
            Assert.AreEqual(10, obj.Ckop);
            Assert.AreEqual(true, obj.Unique);
            Assert.AreEqual("woodd", obj.Material);
            Assert.AreEqual("putLst", obj.PutLst);
            Assert.AreEqual(3, obj.Oppwkrs);
            Assert.AreEqual(true, obj.UniClamp);
            Assert.AreEqual(true, obj.ChkColl);
            Assert.AreEqual(6, obj.WtPiani);
            Assert.AreEqual(7, obj.CollTool);
            Assert.AreEqual(8, obj.CalcEdTh);
            Assert.AreEqual(true, obj.EnableLabel);
            Assert.AreEqual(true, obj.LockWaste);
            Assert.AreEqual(5, obj.LoadEdgeOpt);
            Assert.AreEqual(4, obj.ItlType);
            Assert.AreEqual(true, obj.RunPav);
            Assert.AreEqual(12, obj.FlipEnd);
            Assert.AreEqual(true, obj.EnableMachLinks);
            Assert.AreEqual(true, obj.EnablePursuits);
            Assert.AreEqual(true, obj.EnableFastVertBorings);
            Assert.AreEqual(13, obj.FastVertBoringsValue);
        }

        [Test]
	    public void ParsePublicVarsSectionTest()
        {
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserCix.ParsePublicVarsSection(code);
            Assert.AreEqual(3, obj.PublicVariables.Count);
            Assert.AreEqual("A", obj.PublicVariables[0].Name);
            Assert.AreEqual("11.5", obj.PublicVariables[0].Value);
            Assert.AreEqual("\"DescA\"", obj.PublicVariables[0].Description);
            Assert.AreEqual(BiesseVariablesType.General, obj.PublicVariables[0].Typ);
            Assert.AreEqual("B", obj.PublicVariables[1].Name);
            Assert.AreEqual("2", obj.PublicVariables[1].Value);
            Assert.AreEqual("\"Desc B\"", obj.PublicVariables[1].Description);
            Assert.AreEqual(BiesseVariablesType.Real, obj.PublicVariables[1].Typ);
            Assert.AreEqual("C", obj.PublicVariables[2].Name);
            Assert.AreEqual("3", obj.PublicVariables[2].Value);
            Assert.AreEqual("\"Desc C\"", obj.PublicVariables[2].Description);
            Assert.AreEqual(BiesseVariablesType.String, obj.PublicVariables[2].Typ);
        }

		[Test]
		public void ParsePrivateVarsSectionTest()
        {
			string[] code = stringCode.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParsePrivateVarsSection(code);
            Assert.AreEqual(3, obj.PrivateVariables.Count);
            Assert.AreEqual("D", obj.PrivateVariables[0].Name);
            Assert.AreEqual("1", obj.PrivateVariables[0].Value);
            Assert.AreEqual("\"Desc D\"", obj.PrivateVariables[0].Description);
            Assert.AreEqual(BiesseVariablesType.Distance, obj.PrivateVariables[0].Typ);
            Assert.AreEqual("E", obj.PrivateVariables[1].Name);
            Assert.AreEqual("5", obj.PrivateVariables[1].Value);
            Assert.AreEqual("\"\"", obj.PrivateVariables[1].Description);
            Assert.AreEqual(BiesseVariablesType.String, obj.PrivateVariables[1].Typ);
            Assert.AreEqual("F", obj.PrivateVariables[2].Name);
            Assert.AreEqual("1.253", obj.PrivateVariables[2].Value);
            Assert.AreEqual("\"\"", obj.PrivateVariables[2].Description);
            Assert.AreEqual(BiesseVariablesType.Real, obj.PrivateVariables[2].Typ);
		}


        string stringCode = @"BEGIN ID CID3
	REL= 3.5
END ID

BEGIN MAINDATA
	LPX=564.5
	LPY=340.6
	LPZ=18.2
	ORLST=""1,4""
	SIMMETRY=0
	TLCHK=1
	TOOLING=""Tooling""
	CUSTSTR=$B$KBsExportToNcRvA.XncExtraPanelData$V""text""
	FCN=25.400000
	XCUT=0
	YCUT=0
	JIGTH=0
	CKOP=10
	UNIQUE=1
	MATERIAL=""woodd""
	PUTLST=""putLst""
	OPPWKRS=3
	UNICLAMP=1
	CHKCOLL=1
	WTPIANI=6
	COLLTOOL=7
	CALCEDTH=8
	ENABLELABEL=1
	LOCKWASTE=1
	LOADEDGEOPT=5
	ITLTYPE=4
	RUNPAV=1
	FLIPEND=12
	ENABLEMACHLINKS=1
	ENABLEPURSUITS=1
	ENABLEFASTVERTBORINGS=1
	FASTVERTBORINGSVALUE=13
END MAINDATA

BEGIN PUBLICVARS
	PARAM, NAME=A, VALUE=11.5, DESCRIPTION=""DescA"", TYPE=0
	PARAM, NAME=B, VALUE=2, DESCRIPTION=""Desc B"", TYPE=2
	PARAM, NAME=C, VALUE=""3"", DESCRIPTION=""Desc C"", TYPE=0
END PUBLICVARS

BEGIN PRIVATEVARS
	PARAM, NAME=D, VALUE=1, DESCRIPTION=""Desc D"", TYPE=4
	PARAM, NAME=E, VALUE=""5"", DESCRIPTION="""", TYPE=0
	PARAM, NAME=F, VALUE=1.253, DESCRIPTION="""", TYPE=2
END PRIVATEVARS

BEGIN MACRO
	NAME=BV
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=100
	PARAM,NAME=Y,VALUE=110
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
	PARAM,NAME=ID,VALUE=""P1001""
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

    }
}