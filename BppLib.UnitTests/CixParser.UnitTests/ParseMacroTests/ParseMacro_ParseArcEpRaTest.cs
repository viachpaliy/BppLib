using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void ArcEpRaTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ARC_EPRA
	PARAM,NAME=ID,VALUE=21083178
	PARAM,NAME=XE,VALUE=0
	PARAM,NAME=YE,VALUE=0
	PARAM,NAME=R,VALUE=0
	PARAM,NAME=DIR,VALUE=dirCW
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=SC,VALUE=scOFF
	PARAM,NAME=FD,VALUE=0
	PARAM,NAME=SP,VALUE=0
	PARAM,NAME=SOL,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<ArcEpRa>(bj);
			ArcEpRa obj = (ArcEpRa)bj;
			Assert.AreEqual("ARC_EPRA", obj.BppName);
			Assert.AreEqual(21083178, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.R);
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
