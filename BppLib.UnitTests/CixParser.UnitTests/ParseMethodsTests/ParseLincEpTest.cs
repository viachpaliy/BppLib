using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void LincEpTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=LINC_EP
	PARAM,NAME=ID,VALUE=27717712
	PARAM,NAME=XI,VALUE=0
	PARAM,NAME=YI,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseLincEp(code);
			Assert.AreEqual("LINC_EP", obj.BppName);
			Assert.AreEqual(27717712, obj.Id);
			Assert.AreEqual(0, obj.Xi);
			Assert.AreEqual(0, obj.Yi);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}
