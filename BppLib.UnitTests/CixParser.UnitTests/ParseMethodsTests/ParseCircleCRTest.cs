using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void CircleCRTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=CIRCLE_CR
	PARAM,NAME=ID,VALUE=7244975
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=R,VALUE=0
	PARAM,NAME=AS,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseCircleCR(code);
			Assert.AreEqual("CIRCLE_CR", obj.BppName);
			Assert.AreEqual(7244975, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(0, obj.As);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}
	}
}
