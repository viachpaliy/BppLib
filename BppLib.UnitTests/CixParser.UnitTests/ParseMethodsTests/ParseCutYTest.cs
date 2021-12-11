using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void CutYTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=CUT_Y
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=L,VALUE=100
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=D,VALUE=100
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=TH,VALUE=4
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=TTK,VALUE=0
	PARAM,NAME=OVM,VALUE=0
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=GIP,VALUE=YES
	PARAM,NAME=TNM,VALUE=""""
	PARAM,NAME=TTP,VALUE=200
	PARAM,NAME=TCL,VALUE=2
	PARAM,NAME=RSP,VALUE=0
	PARAM,NAME=IOS,VALUE=0
	PARAM,NAME=WSP,VALUE=0
	PARAM,NAME=SPI,VALUE=""""
	PARAM,NAME=BFC,VALUE=NO
	PARAM,NAME=SHP,VALUE=0
	PARAM,NAME=BRC,VALUE=0
	PARAM,NAME=BDR,VALUE=NO
	PARAM,NAME=PRV,VALUE=YES
	PARAM,NAME=NRV,VALUE=NO
	PARAM,NAME=DIN,VALUE=0
	PARAM,NAME=DOU,VALUE=0
	PARAM,NAME=CRC,VALUE=0
	PARAM,NAME=DSP,VALUE=0
	PARAM,NAME=CEN,VALUE=""""
	PARAM,NAME=AGG,VALUE=""""
	PARAM,NAME=LAY,VALUE=""CUT_Y""
	PARAM,NAME=DVR,VALUE=0
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseCutY(code);
			Assert.AreEqual("CUT_Y", obj.BppName);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(100, obj.L);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(100, obj.D);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_Y", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
		}
	}
}
