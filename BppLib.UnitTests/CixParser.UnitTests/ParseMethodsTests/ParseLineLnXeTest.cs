using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void LineLnXeTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=LINE_LNXE
	PARAM,NAME=ID,VALUE=34576242
	PARAM,NAME=L,VALUE=0
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseLineLnXe(code);
			Assert.AreEqual("LINE_LNXE", obj.BppName);
			Assert.AreEqual(34576242, obj.Id);
			Assert.AreEqual(0, obj.L);
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
