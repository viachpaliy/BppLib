using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void IsoTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ISO
	PARAM,NAME=ISO,VALUE=""""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseIso(code);
			Assert.AreEqual("ISO", obj.BppName);
			Assert.AreEqual("", obj.IsoText);
		}
	}
}
