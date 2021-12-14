using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void LineLnYeTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=LINE_LNYE
	PARAM,NAME=ID,VALUE=42750725
	PARAM,NAME=L,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<LineLnYe>(bj);
			LineLnYe obj = (LineLnYe)bj;
			Assert.AreEqual("LINE_LNYE", obj.BppName);
			Assert.AreEqual(42750725, obj.Id);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}
