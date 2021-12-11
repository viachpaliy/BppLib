using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void PockTest()
		{
			string codeString = @"BEGIN MACRO
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
	PARAM,NAME=ID,VALUE=""P1001""
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
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParsePock(code);
			Assert.AreEqual("POCK", obj.BppName);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual("", obj.Isl);
			Assert.AreEqual(18, obj.Dia);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(PocketType.ptZIG, obj.Typ);
			Assert.AreEqual(0, obj.Dlt);
			Assert.AreEqual(-1, obj.N);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(false, obj.Tc);
			Assert.AreEqual(false, obj.Cki);
			Assert.AreEqual(10, obj.Zst);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Rrv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(103, obj.Ttp);
			Assert.AreEqual(1, obj.Tcl);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tin);
			Assert.AreEqual(45, obj.Ain);
			Assert.AreEqual(false, obj.Cin);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tou);
			Assert.AreEqual(45, obj.Aou);
			Assert.AreEqual(false, obj.Cou);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(0, obj.Sds);
			Assert.AreEqual(0, obj.Prp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("POCK", obj.Lay);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(0, obj.Sdsf);
		}
	}
}
