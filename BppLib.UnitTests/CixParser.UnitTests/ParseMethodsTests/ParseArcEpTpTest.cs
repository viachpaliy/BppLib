using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void ArcEpTpTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ARC_EPTP
	PARAM,NAME=ID,VALUE=30015890
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseArcEpTp(code);
			Assert.AreEqual("ARC_EPTP", obj.BppName);
			Assert.AreEqual(30015890, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}
	}
}
