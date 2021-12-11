using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void StartPointTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=START_POINT
	PARAM,NAME=ID,VALUE=55915408
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseStartPoint(code);
			Assert.AreEqual("START_POINT", obj.BppName);
			Assert.AreEqual(55915408, obj.Id);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
		}
	}
}
