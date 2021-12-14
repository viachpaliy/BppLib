using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void StarTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=STAR
	PARAM,NAME=ID,VALUE=56680499
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=ER,VALUE=100
	PARAM,NAME=IR,VALUE=25
	PARAM,NAME=PS,VALUE=5
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
			Assert.IsInstanceOf<Star>(bj);
			Star obj = (Star)bj;
			Assert.AreEqual("STAR", obj.BppName);
			Assert.AreEqual(56680499, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(100, obj.Er);
			Assert.AreEqual(25, obj.Ir);
			Assert.AreEqual(5, obj.Ps);
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
