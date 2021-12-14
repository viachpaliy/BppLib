using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void LineAnXeTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=LINE_ANXE
	PARAM,NAME=ID,VALUE=48132822
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<LineAnXe>(bj);
			LineAnXe obj = (LineAnXe)bj;
			Assert.AreEqual("LINE_ANXE", obj.BppName);
			Assert.AreEqual(48132822, obj.Id);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}
