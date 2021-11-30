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

    }
}