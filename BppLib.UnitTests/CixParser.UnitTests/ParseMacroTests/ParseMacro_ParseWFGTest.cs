using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMacroTests
	{
		[Test]
		public void WFGTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=WFG
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=PDF,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=VRT,VALUE=YES
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=LAY,VALUE=""WFG""
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=HGT,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var bj = ParserCix.ParseMacro(code);
			Assert.IsInstanceOf<WFG>(bj);
			WFG obj = (WFG)bj;
			Assert.AreEqual("WFG", obj.BppName);
			Assert.AreEqual(6, obj.SideId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual(false, obj.Pdf);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual(true, obj.Vrt);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual("WFG", obj.Lay);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(0, obj.Hgt);
		}
	}
}
