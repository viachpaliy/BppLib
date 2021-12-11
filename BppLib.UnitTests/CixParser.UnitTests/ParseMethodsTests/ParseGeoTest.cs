using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void GeoTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=GEO
	PARAM,NAME=ID,VALUE=""P1001""
	PARAM,NAME=SIDE,VALUE=0
	PARAM,NAME=CRN,VALUE=""1""
	PARAM,NAME=DP,VALUE=0
	PARAM,NAME=RTY,VALUE=rpNO
	PARAM,NAME=XRC,VALUE=0
	PARAM,NAME=YRC,VALUE=0
	PARAM,NAME=DX,VALUE=32
	PARAM,NAME=DY,VALUE=32
	PARAM,NAME=R,VALUE=50
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=45
	PARAM,NAME=RDL,VALUE=YES
	PARAM,NAME=NRP,VALUE=0
	PARAM,NAME=ARP,VALUE=0
	PARAM,NAME=LRP,VALUE=0
	PARAM,NAME=ER,VALUE=YES
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=LAY,VALUE=""GEO""
	PARAM,NAME=CRC,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseGeo(code);
			Assert.AreEqual("GEO", obj.BppName);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.Dp);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual("GEO", obj.Lay);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
		}
	}
}
