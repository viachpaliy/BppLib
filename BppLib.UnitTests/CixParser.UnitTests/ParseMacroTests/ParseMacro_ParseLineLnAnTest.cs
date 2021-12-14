using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void LineLnAnTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=LINE_LNAN
	PARAM,NAME=ID,VALUE=426867
	PARAM,NAME=L,VALUE=0
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<LineLnAn>(bj);
			LineLnAn obj = (LineLnAn)bj;
			Assert.AreEqual("LINE_LNAN", obj.BppName);
			Assert.AreEqual(426867, obj.Id);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}
