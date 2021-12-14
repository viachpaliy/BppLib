using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void UnknownMacroTest()
		{
			string codeString = @"BEGIN MACRO
		NAME=WTCARRIAGE
		PARAM,NAME=NAME,VALUE=""6,3""
		PARAM,NAME=POS,VALUE=1171.600000
		PARAM,NAME=REF,VALUE=3
	END MACRO";
            string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<VBLine>(bj);
            VBLine obj = (VBLine)bj;
            Assert.AreEqual("'" + codeString.Replace("\r\n","\n"), obj.Code);
        }
    }
}