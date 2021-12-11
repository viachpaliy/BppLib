using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void RotateTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ROTATE
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=AR,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseRotate(code);
			Assert.AreEqual("ROTATE", obj.BppName);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Ar);
		}
	}
}
