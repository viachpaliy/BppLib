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
	PARAM,NAME=X,VALUE= 12.5
	PARAM,NAME=Y,VALUE= -135.69 + 23
	PARAM,NAME=AR,VALUE= 360/4
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseRotate(code);
			Assert.AreEqual("ROTATE", obj.BppName);
			Assert.AreEqual(12.5, obj.X);
			Assert.AreEqual(-112.69, obj.Y);
			Assert.AreEqual(90, obj.Ar);
		}
	}
}
