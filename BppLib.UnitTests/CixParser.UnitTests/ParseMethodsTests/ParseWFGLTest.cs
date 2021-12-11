using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void WFGLTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=WFGL
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=GIZ,VALUE=""""
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=LAY,VALUE=""WFGL""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseWFGL(code);
			Assert.AreEqual("WFGL", obj.BppName);
			Assert.AreEqual(6, obj.SideId);
			Assert.AreEqual("", obj.Giz);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual("WFGL", obj.Lay);
		}
	}
}
