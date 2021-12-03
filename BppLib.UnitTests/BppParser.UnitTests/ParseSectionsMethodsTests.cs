using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class ParseSectionsMethodsTests
    {
        [Test]
		public void ParseHeaderSectionTest()
		{
            string stringCode = @"[HEADER]
TYPE=BPC
VER=140

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|564||4|
PAN=LPY|340||4|";
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserBpp.ParseHeaderSection(code);
            Assert.AreEqual("BPC", obj.Typ);
            Assert.AreEqual("140", obj.Version);
        }

        [Test]
		public void ParseDescriptionSectionTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
| first string
| second string

[VARIABLES]
PAN=LPX|564||4|
PAN=LPY|340||4|";
        
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            string expected = " first string\r\n second string\r\n";
            var obj = ParserBpp.ParseDescriptionSection(code);
            Assert.AreEqual(expected, obj.DescText);
        }

        [Test]
		public void ParseMainDataSectionTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|564.5||4|
PAN=LPY|340.6||4|
PAN=LPZ|18.2||4|
PAN=ORLST|""1,4""||3|
PAN=SIMMETRY|0||1|
PAN=TLCHK|1||1|
PAN=TOOLING|""Tooling""||3|
PAN=CUSTSTR|$B$KBsExportToNcRvA.XncExtraPanelData$V""text""||3|
PAN=FCN|25.400000||2|
PAN=XCUT|0||4|
PAN=YCUT|0||4|
PAN=JIGTH|0||4|
PAN=CKOP|10||1|
PAN=UNIQUE|1||1|
PAN=MATERIAL|""woodd""||3|
PAN=PUTLST|""putLst""||3|
PAN=OPPWKRS|3||1|
PAN=UNICLAMP|1||1|
PAN=CHKCOLL|1||1|
PAN=WTPIANI|6||1|
PAN=COLLTOOL|7||1|
PAN=CALCEDTH|8||1|
PAN=ENABLELABEL|1||1|
PAN=LOCKWASTE|1||1|
PAN=LOADEDGEOPT|5||1|
PAN=ITLTYPE|4||1|
PAN=RUNPAV|1||1|
PAN=FLIPEND|12||1|
PAN=ENABLEMACHLINKS|1||1|
PAN=ENABLEPURSUITS|1||1|
PAN=ENABLEFASTVERTBORINGS|1||1|
PAN=FASTVERTBORINGSVALUE|13||4|

[PROGRAM]


[VBSCRIPT]

[MACRODATA]

[TDCODES]

[PCF]

[TOOLING]

[SUBPROGS]";

            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserBpp.ParseMainDataSection(code);
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
		public void ParsePrivateVarsSectionTest()
        {
                       string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|564.5||4|
PAN=LPY|340.6||4|
PAN=LPZ|18.2||4|
PAN=ORLST|""1,4""||3|
PAN=SIMMETRY|0||1|
PAN=TLCHK|1||1|
PAN=TOOLING|""Tooling""||3|
PAN=CUSTSTR|$B$KBsExportToNcRvA.XncExtraPanelData$V""text""||3|
PAN=FCN|25.400000||2|
PAN=XCUT|0||4|
PAN=YCUT|0||4|
PAN=JIGTH|0||4|
PAN=CKOP|10||1|
PAN=UNIQUE|1||1|
PAN=MATERIAL|""woodd""||3|
PAN=PUTLST|""putLst""||3|
PAN=OPPWKRS|3||1|
PAN=UNICLAMP|1||1|
PAN=CHKCOLL|1||1|
PAN=WTPIANI|6||1|
PAN=COLLTOOL|7||1|
PAN=CALCEDTH|8||1|
PAN=ENABLELABEL|1||1|
PAN=LOCKWASTE|1||1|
PAN=LOADEDGEOPT|5||1|
PAN=ITLTYPE|4||1|
PAN=RUNPAV|1||1|
PAN=FLIPEND|12||1|
PAN=ENABLEMACHLINKS|1||1|
PAN=ENABLEPURSUITS|1||1|
PAN=ENABLEFASTVERTBORINGS|1||1|
PAN=FASTVERTBORINGSVALUE|13||4|
GLB=CY|150|description CY|0|
GLB=D|20.5|description D|0|
GLB=E|""OK""|description E|0|
LOC=A|+10|description A|0|
LOC=B|-20.5||2|
LOC=C|""TEXT""|description C|3|

[PROGRAM]


[VBSCRIPT]

[MACRODATA]

[TDCODES]

[PCF]

[TOOLING]

[SUBPROGS]";

            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserBpp.ParsePrivateVarsSection(code);
            Assert.AreEqual(3, obj.PrivateVariables.Count);
            Assert.AreEqual("A", obj.PrivateVariables[0].Name);
            Assert.AreEqual("+10", obj.PrivateVariables[0].Value);
            Assert.AreEqual("description A", obj.PrivateVariables[0].Description);
            Assert.AreEqual(BiesseVariablesType.General, obj.PrivateVariables[0].Typ);
            Assert.AreEqual("B", obj.PrivateVariables[1].Name);
            Assert.AreEqual("-20.5", obj.PrivateVariables[1].Value);
            Assert.AreEqual("", obj.PrivateVariables[1].Description);
            Assert.AreEqual(BiesseVariablesType.Real, obj.PrivateVariables[1].Typ);
            Assert.AreEqual("C", obj.PrivateVariables[2].Name);
            Assert.AreEqual("TEXT", obj.PrivateVariables[2].Value);
            Assert.AreEqual("description C", obj.PrivateVariables[2].Description);
            Assert.AreEqual(BiesseVariablesType.String, obj.PrivateVariables[2].Typ);
        }

              [Test]
		public void ParsePublicVarsSectionTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|564.5||4|
PAN=LPY|340.6||4|
PAN=LPZ|18.2||4|
PAN=ORLST|""1,4""||3|
PAN=SIMMETRY|0||1|
PAN=TLCHK|1||1|
PAN=TOOLING|""Tooling""||3|
PAN=CUSTSTR|$B$KBsExportToNcRvA.XncExtraPanelData$V""text""||3|
PAN=FCN|25.400000||2|
PAN=XCUT|0||4|
PAN=YCUT|0||4|
PAN=JIGTH|0||4|
PAN=CKOP|10||1|
PAN=UNIQUE|1||1|
PAN=MATERIAL|""woodd""||3|
PAN=PUTLST|""putLst""||3|
PAN=OPPWKRS|3||1|
PAN=UNICLAMP|1||1|
PAN=CHKCOLL|1||1|
PAN=WTPIANI|6||1|
PAN=COLLTOOL|7||1|
PAN=CALCEDTH|8||1|
PAN=ENABLELABEL|1||1|
PAN=LOCKWASTE|1||1|
PAN=LOADEDGEOPT|5||1|
PAN=ITLTYPE|4||1|
PAN=RUNPAV|1||1|
PAN=FLIPEND|12||1|
PAN=ENABLEMACHLINKS|1||1|
PAN=ENABLEPURSUITS|1||1|
PAN=ENABLEFASTVERTBORINGS|1||1|
PAN=FASTVERTBORINGSVALUE|13||4|
GLB=CY|150|description CY|0|
GLB=D|20.5|description D|2|
GLB=E|""OK""|description E|0|
LOC=A|+10|description A|0|
LOC=B|-20.5||2|
LOC=C|""TEXT""|description C|3|

[PROGRAM]


[VBSCRIPT]

[MACRODATA]

[TDCODES]

[PCF]

[TOOLING]

[SUBPROGS]";

            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            var obj = ParserBpp.ParsePublicVarsSection(code);
            Assert.AreEqual(3, obj.PublicVariables.Count);
            Assert.AreEqual("CY", obj.PublicVariables[0].Name);
            Assert.AreEqual("150", obj.PublicVariables[0].Value);
            Assert.AreEqual("description CY", obj.PublicVariables[0].Description);
            Assert.AreEqual(BiesseVariablesType.General, obj.PublicVariables[0].Typ);
            Assert.AreEqual("D", obj.PublicVariables[1].Name);
            Assert.AreEqual("20.5", obj.PublicVariables[1].Value);
            Assert.AreEqual("description D", obj.PublicVariables[1].Description);
            Assert.AreEqual(BiesseVariablesType.Real, obj.PublicVariables[1].Typ);
            Assert.AreEqual("E", obj.PublicVariables[2].Name);
            Assert.AreEqual("OK", obj.PublicVariables[2].Value);
            Assert.AreEqual("description E", obj.PublicVariables[2].Description);
            Assert.AreEqual(BiesseVariablesType.String, obj.PublicVariables[2].Typ);
        }

        [Test]
		public void ParseProgramSectionLineTest_VBLine()
        {
            string code = " Dim Xi,Yi,N ";
            var obj = ParserBpp.ParseProgramSectionLine(code);
            Assert.IsInstanceOf<VBLine>(obj);
            VBLine vb = (VBLine)obj;
            Assert.AreEqual(code, vb.Code);
        }

        
    [Test]
		public void ParseProgramSectionLineTest_AincAnCe()
        {
            string code = "  @ AINC_ANCE, \"\", \"\", 159162244, \"\", 0 : 12.30*2, LPX/2, 0, 1, 0, 0, 0, 0, 0, 0";
            ParserBpp.engine.Execute("LPX = 740");
            var bj = ParserBpp.ParseProgramSectionLine(code);
            Assert.IsInstanceOf<AincAnCe>(bj);
            AincAnCe obj = (AincAnCe)bj;
            Assert.AreEqual(159162244, obj.Id);
            Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
            Assert.AreEqual(24.6, obj.Xi);
            Assert.AreEqual(370, obj.Yi);
        }

    [Test]
		public void ParseProgramSectionTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|2220||4|
PAN=LPY|600||4|
PAN=LPZ|38||4|
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
GLB=CY|150|description CY|0|
GLB=D|20.5|description D|0|
GLB=E|""OK""|description E|0|
LOC=A|10|description A|0|
LOC=B|20.5|description B|0|
LOC=C|""TEXT""|description C|0|

[PROGRAM]
' SHIFT, "", "", 94502572, "", 0 : 0.3, 0
@ BV, """", """", 97718444, """", 0 : 0, ""2"", 30, CY, 0, 20.5, 35, 0, 1, 0, 0, 0, 0, 0, 0, """", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, ""P1008"", 0, """", """", 3, 0, 0, 0, 0, """", 3, 1500, 0, 0, 0, """", """", ""BV"", 0, 0, 0, 0, -1, 0, 0, 0
' ROUT, """", """", 93331460, """", 0 : ""P1001_2"", 0, ""2"", 0, 4, """", 1, 20, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, ""DTN20X45"", 103, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 20, 20, 30, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 93334852, """", 0 : 0, 0, 0
  @ LINC_EP, """", """", 93332548, """", 0 : 0, lpy-20, 0, 0, 0, 0, 0, 0
  @ CONNECTOR, """", """", 93332100, """", 0 : 16, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 207206268, """", 0 : 20, 20, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 207205116, """", 0 :
@ ROUT, """", """", 97719724, """", 0 : ""P1009"", 0, ""2"", 0, 20.5, """", 1, 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 5000, ""16X27"", 102, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 97719596, """", 0 : -15, CY+8.1, 0
  @ LINE_EP, """", """", 97719276, """", 0 : 32, CY+8.1, 0, 0, 0, 0, 0, 0, 0
  @ LINE_EP, """", """", 95337204, """", 0 : 32, CY-8.1, 0, 0, 0, 0, 0, 0, 0
  @ LINE_EP, """", """", 187539052, """", 0 : -15, CY-8.1, 0, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 97719468, """", 0 :
' ROUT, """", """", 150515764, """", 0 : ""P1022"", 0, ""4"", 0, 5, """", 1, 20, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, ""DTN20X45"", 103, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 150515636, """", 0 : 470+560/2, 50, 0
  @ LINC_EP, """", """", 150522164, """", 0 : -560/2, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 96088900, """", 0 : 0, 490, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 151524268, """", 0 : 560, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 152641500, """", 0 : 0, -490, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 152641820, """", 0 : -560/2, 0, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 96086148, """", 0 :
@ ROUT, """", """", 150521012, """", 0 : ""P1029"", 0, ""4"", 0, 20, """", 1, 6, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, ""D6L25"", 102, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 152516828, """", 0 : 490, 50, 0
  @ LINC_EP, """", """", 96087172, """", 0 : -20, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 151918620, """", 0 : 0, 20, 0, 0, 0, 0, 0, 0
  @ START_POINT, """", """", 96086724, """", 0 : 470, 490+30, 0
  @ LINC_EP, """", """", 96090564, """", 0 : 0, 20, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 96090180, """", 0 : 20, 0, 0, 0, 0, 0, 0, 0
  @ START_POINT, """", """", 151919260, """", 0 : 470+540, 50+490, 0
  @ LINC_EP, """", """", 150519924, """", 0 : 20, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 150521588, """", 0 : 0, -20, 0, 0, 0, 0, 0, 0
  @ START_POINT, """", """", 151917596, """", 0 : 470+560, 70, 0
  @ LINC_EP, """", """", 151916124, """", 0 : 0, -20, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 151919388, """", 0 : -20, 0, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 151915740, """", 0 :


[VBSCRIPT]

[MACRODATA]

[TDCODES]

[PCF]

[TOOLING]";
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
            ParserBpp.engine.Execute("lpy = 600");
            ParserBpp.engine.Execute("CY = 150");
            var obj = ParserBpp.ParseProgramSection(code);
            Assert.AreEqual(36, obj.BiesseEntities.Count);
        }    

               [Test]
		public void ParseParseBiesseProgramTest()
        {
            string stringCode = @"[HEADER]
TYPE=BPP
VER=150

[DESCRIPTION]
|

[VARIABLES]
PAN=LPX|2220||4|
PAN=LPY|600||4|
PAN=LPZ|38||4|
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
GLB=CY|150|description CY|0|
GLB=D|20.5|description D|0|
GLB=E|""OK""|description E|0|
LOC=A|10|description A|0|
LOC=B|20.5|description B|0|
LOC=C|""TEXT""|description C|0|

[PROGRAM]
' SHIFT, "", "", 94502572, "", 0 : 0.3, 0
@ BV, """", """", 97718444, """", 0 : 0, ""2"", 30, CY, 0, 20.5, 35, 0, 1, 0, 0, 0, 0, 0, 0, """", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, ""P1008"", 0, """", """", 3, 0, 0, 0, 0, """", 3, 1500, 0, 0, 0, """", """", ""BV"", 0, 0, 0, 0, -1, 0, 0, 0
' ROUT, """", """", 93331460, """", 0 : ""P1001_2"", 0, ""2"", 0, 4, """", 1, 20, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, ""DTN20X45"", 103, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 20, 20, 30, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 93334852, """", 0 : 0, 0, 0
  @ LINC_EP, """", """", 93332548, """", 0 : 0, lpy-20, 0, 0, 0, 0, 0, 0
  @ CONNECTOR, """", """", 93332100, """", 0 : 16, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 207206268, """", 0 : 20, 20, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 207205116, """", 0 :
@ ROUT, """", """", 97719724, """", 0 : ""P1009"", 0, ""2"", 0, 20.5, """", 1, 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 5000, ""16X27"", 102, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 97719596, """", 0 : -15, CY+8.1, 0
  @ LINE_EP, """", """", 97719276, """", 0 : 32, CY+8.1, 0, 0, 0, 0, 0, 0, 0
  @ LINE_EP, """", """", 95337204, """", 0 : 32, CY-8.1, 0, 0, 0, 0, 0, 0, 0
  @ LINE_EP, """", """", 187539052, """", 0 : -15, CY-8.1, 0, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 97719468, """", 0 :
' ROUT, """", """", 150515764, """", 0 : ""P1022"", 0, ""4"", 0, 5, """", 1, 20, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, ""DTN20X45"", 103, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 150515636, """", 0 : 470+560/2, 50, 0
  @ LINC_EP, """", """", 150522164, """", 0 : -560/2, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 96088900, """", 0 : 0, 490, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 151524268, """", 0 : 560, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 152641500, """", 0 : 0, -490, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 152641820, """", 0 : -560/2, 0, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 96086148, """", 0 :
@ ROUT, """", """", 150521012, """", 0 : ""P1029"", 0, ""4"", 0, 20, """", 1, 6, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, ""D6L25"", 102, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 0, 0, 0, 0, 0, 0, 0, 0, 0, """", 5, 0, 20, 80, 60, 0, """", """", ""ROUT"", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0
  @ START_POINT, """", """", 152516828, """", 0 : 490, 50, 0
  @ LINC_EP, """", """", 96087172, """", 0 : -20, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 151918620, """", 0 : 0, 20, 0, 0, 0, 0, 0, 0
  @ START_POINT, """", """", 96086724, """", 0 : 470, 490+30, 0
  @ LINC_EP, """", """", 96090564, """", 0 : 0, 20, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 96090180, """", 0 : 20, 0, 0, 0, 0, 0, 0, 0
  @ START_POINT, """", """", 151919260, """", 0 : 470+540, 50+490, 0
  @ LINC_EP, """", """", 150519924, """", 0 : 20, 0, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 150521588, """", 0 : 0, -20, 0, 0, 0, 0, 0, 0
  @ START_POINT, """", """", 151917596, """", 0 : 470+560, 70, 0
  @ LINC_EP, """", """", 151916124, """", 0 : 0, -20, 0, 0, 0, 0, 0, 0
  @ LINC_EP, """", """", 151919388, """", 0 : -20, 0, 0, 0, 0, 0, 0, 0
  @ ENDPATH, """", """", 151915740, """", 0 :


[VBSCRIPT]

[MACRODATA]

[TDCODES]

[PCF]

[TOOLING]";
            string[] code = stringCode.Replace("\r\n","\n").Split('\n');
              var obj = ParserBpp.ParseBiesseProgram(code);
            Assert.AreEqual(36, obj.ProgramSec.BiesseEntities.Count);
        }    

    }
}