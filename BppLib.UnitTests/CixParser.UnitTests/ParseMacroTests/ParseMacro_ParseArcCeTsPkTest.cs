using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void ArcCeTsPkTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ARC_CETSPK
	PARAM,NAME=ID,VALUE=23458411
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<ArcCeTsPk>(bj);
			ArcCeTsPk obj = (ArcCeTsPk)bj;
			Assert.AreEqual("ARC_CETSPK", obj.BppName);
			Assert.AreEqual(23458411, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}