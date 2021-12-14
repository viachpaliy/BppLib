using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void IsoTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ISO
	PARAM,NAME=ISO,VALUE=""""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<Iso>(bj);
			Iso obj = (Iso)bj;
			Assert.AreEqual("ISO", obj.BppName);
			Assert.AreEqual("", obj.IsoText);
		}
	}
}
