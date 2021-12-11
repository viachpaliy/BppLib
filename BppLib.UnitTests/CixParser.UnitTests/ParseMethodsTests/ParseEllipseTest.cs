using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void EllipseTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ELLIPSE
	PARAM,NAME=ID,VALUE=65204782
	PARAM,NAME=XC,VALUE=0
	PARAM,NAME=YC,VALUE=0
	PARAM,NAME=A1,VALUE=0
	PARAM,NAME=A2,VALUE=0
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=AS,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=UNE,VALUE=YES
	PARAM,NAME=ELM,VALUE=20
	PARAM,NAME=MLE,VALUE=0
	PARAM,NAME=UA,VALUE=YES
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=AE,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseEllipse(code);
			Assert.AreEqual("ELLIPSE", obj.BppName);
			Assert.AreEqual(65204782, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.A1);
			Assert.AreEqual(0, obj.A2);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.As);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(true, obj.Une);
			Assert.AreEqual(20, obj.Elm);
			Assert.AreEqual(0, obj.Mle);
			Assert.AreEqual(true, obj.Ua);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Ae);
		}
	}
}
