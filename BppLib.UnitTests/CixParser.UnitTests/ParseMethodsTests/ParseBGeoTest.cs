using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void BGeoTest()
		{
			string codeString = @"BEGIN MACRO
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
	PARAM,NAME=LAY,VALUE=""B_GEO""
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=DTAS,VALUE=NO
	PARAM,NAME=RMD,VALUE=rmdAuto
	PARAM,NAME=DQT,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseBGeo(code);
			Assert.AreEqual("B_GEO", obj.BppName);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual("", obj.Sil);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("B_GEO", obj.Lay);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Dtas);
			Assert.AreEqual(RmdType.rmdAuto, obj.Rmd);
			Assert.AreEqual(0, obj.Dqt);
		}
	}
}
