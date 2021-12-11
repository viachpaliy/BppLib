using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void EndPathTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ENDPATH
	PARAM,NAME=ID,VALUE=33476626
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseEndPath(code);
			Assert.AreEqual("ENDPATH", obj.BppName);
			Assert.AreEqual(33476626, obj.Id);
		}
	}
}
