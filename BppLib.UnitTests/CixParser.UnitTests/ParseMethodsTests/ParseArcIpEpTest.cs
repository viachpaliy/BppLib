using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void ArcIpEpTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ARC_IPEP
	PARAM,NAME=ID,VALUE=1707556
	PARAM,NAME=X2,VALUE=0
	PARAM,NAME=Y2,VALUE=0
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseArcIpEp(code);
			Assert.AreEqual("ARC_IPEP", obj.BppName);
			Assert.AreEqual(1707556, obj.Id);
			Assert.AreEqual(0, obj.X2);
			Assert.AreEqual(0, obj.Y2);
			Assert.AreEqual(0, obj.Xe);
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
