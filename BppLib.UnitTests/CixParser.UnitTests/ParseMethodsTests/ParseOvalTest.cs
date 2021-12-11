using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void OvalTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=OVAL
	PARAM,NAME=ID,VALUE=49972132
	PARAM,NAME=X1,VALUE=0
	PARAM,NAME=Y1,VALUE=0
	PARAM,NAME=R1,VALUE=0
	PARAM,NAME=X2,VALUE=0
	PARAM,NAME=Y2,VALUE=0
	PARAM,NAME=R2,VALUE=0
	PARAM,NAME=LKR,VALUE=0
	PARAM,NAME=AS,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseOval(code);
			Assert.AreEqual("OVAL", obj.BppName);
			Assert.AreEqual(49972132, obj.Id);
			Assert.AreEqual(0, obj.X1);
			Assert.AreEqual(0, obj.Y1);
			Assert.AreEqual(0, obj.R1);
			Assert.AreEqual(0, obj.X2);
			Assert.AreEqual(0, obj.Y2);
			Assert.AreEqual(0, obj.R2);
			Assert.AreEqual(0, obj.Lkr);
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
