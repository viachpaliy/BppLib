using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void AincAnCeTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=AINC_ANCE
	PARAM,NAME=ID,VALUE=32854180
	PARAM,NAME=XI,VALUE=0
	PARAM,NAME=YI,VALUE=0
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseAincAnCe(code);
			Assert.AreEqual("AINC_ANCE", obj.BppName);
			Assert.AreEqual(32854180, obj.Id);
			Assert.AreEqual(0, obj.Xi);
			Assert.AreEqual(0, obj.Yi);
			Assert.AreEqual(0, obj.A);
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
