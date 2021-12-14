using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void ShiftTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=SHIFT
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<Shift>(bj);
			Shift obj = (Shift)bj;
			Assert.AreEqual("SHIFT", obj.BppName);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
		}
	}
}
