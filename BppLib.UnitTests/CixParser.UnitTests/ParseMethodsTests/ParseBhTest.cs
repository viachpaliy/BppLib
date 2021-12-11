using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void BhTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=BH
	PARAM,NAME=SIDE,VALUE=1
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
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
	PARAM,NAME=LAY,VALUE=""BH""
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=DTAS,VALUE=NO
	PARAM,NAME=RMD,VALUE=rmdAuto
	PARAM,NAME=DQT,VALUE=0
	PARAM,NAME=ERDW,VALUE=NO
	PARAM,NAME=DFW,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseBh(code);
			Assert.AreEqual("BH", obj.BppName);
			Assert.AreEqual(1, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(false, obj.Ap);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Md);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.A21);
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
			Assert.AreEqual("BH", obj.Lay);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Dtas);
			Assert.AreEqual(RmdType.rmdAuto, obj.Rmd);
			Assert.AreEqual(0, obj.Dqt);
			Assert.AreEqual(false, obj.Erdw);
			Assert.AreEqual(0, obj.Dfw);
		}
	}
}
