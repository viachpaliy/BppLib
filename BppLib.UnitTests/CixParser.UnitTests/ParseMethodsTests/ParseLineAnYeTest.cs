using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void LineAnYeTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=LINE_ANYE
	PARAM,NAME=ID,VALUE=30542218
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseLineAnYe(code);
			Assert.AreEqual("LINE_ANYE", obj.BppName);
			Assert.AreEqual(30542218, obj.Id);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}
