using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void GeoTextTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=GEOTEXT
	PARAM,NAME=ID,VALUE=""P1001""
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""2""
	PARAM,NAME=TXT,VALUE=""Hello World""
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=ANG,VALUE=0
	PARAM,NAME=VRS,VALUE=0
	PARAM,NAME=ALN,VALUE=0
	PARAM,NAME=ACC,VALUE=0
	PARAM,NAME=CIR,VALUE=0
	PARAM,NAME=RDS,VALUE=0
	PARAM,NAME=PST,VALUE=txtExt
	PARAM,NAME=FNT,VALUE=""Arial""
	PARAM,NAME=SZE,VALUE=20
	PARAM,NAME=BOL,VALUE=0
	PARAM,NAME=ITL,VALUE=0
	PARAM,NAME=UDL,VALUE=0
	PARAM,NAME=STR,VALUE=0
	PARAM,NAME=WGH,VALUE=1
	PARAM,NAME=CHS,VALUE=0
	PARAM,NAME=RTY,VALUE=rpNO
	PARAM,NAME=DX,VALUE=32
	PARAM,NAME=DY,VALUE=32
	PARAM,NAME=R,VALUE=50
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=45
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=XRC,VALUE=0
	PARAM,NAME=YRC,VALUE=0
	PARAM,NAME=ARP,VALUE=0
	PARAM,NAME=LRP,VALUE=0
	PARAM,NAME=ER,VALUE=YES
	PARAM,NAME=RDL,VALUE=YES
	PARAM,NAME=LAY,VALUE=""GEOTEXT""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<GeoText>(bj);
			GeoText obj = (GeoText)bj;
			Assert.AreEqual("GEOTEXT", obj.BppName);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("2", obj.Crn);
			Assert.AreEqual("Hello World", obj.Txt);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(0, obj.Ang);
			Assert.AreEqual(TextDirection.LeftToRight, obj.Vrs);
			Assert.AreEqual(TextAlignment.Central, obj.Aln);
			Assert.AreEqual(0, obj.Acc);
			Assert.AreEqual(false, obj.Cir);
			Assert.AreEqual(0, obj.Rds);
			Assert.AreEqual(TextPosition.txtExt, obj.Pst);
			Assert.AreEqual("Arial", obj.Fnt);
			Assert.AreEqual(20, obj.Sze);
			Assert.AreEqual(false, obj.Bol);
			Assert.AreEqual(false, obj.Itl);
			Assert.AreEqual(false, obj.Udl);
			Assert.AreEqual(false, obj.Str);
			Assert.AreEqual(1, obj.Wgh);
			Assert.AreEqual(0, obj.Chs);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual("GEOTEXT", obj.Lay);
		}
	}
}
