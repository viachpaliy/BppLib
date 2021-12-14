using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void PolygonTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=POLYGON
	PARAM,NAME=ID,VALUE=47096010
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=R,VALUE=0
	PARAM,NAME=S,VALUE=3
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=CT,VALUE=cmfNO
	PARAM,NAME=CD,VALUE=0
	PARAM,NAME=SS,VALUE=1
	PARAM,NAME=SD,VALUE=HALF
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<Polygon>(bj);
			Polygon obj = (Polygon)bj;
			Assert.AreEqual("POLYGON", obj.BppName);
			Assert.AreEqual(47096010, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(3, obj.S);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(ChamferType.cmfNO, obj.Ct);
			Assert.AreEqual(0, obj.Cd);
			Assert.AreEqual(1, obj.Ss);
			Assert.AreEqual(true, obj.StartFromHalfSide);
			Assert.AreEqual(0, obj.Sd);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}
	}
}
