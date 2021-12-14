using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void ScaleTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=SCALE
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=FCT,VALUE=0
	PARAM,NAME=NU,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<Scale>(bj);
			Scale obj = (Scale)bj;
			Assert.AreEqual("SCALE", obj.BppName);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Fct);
			Assert.AreEqual(0, obj.Nu);
		}
	}
}
