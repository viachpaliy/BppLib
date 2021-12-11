using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void WFGPSTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=WFGPS
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=GIZ,VALUE=""""
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=PS,VALUE=NO
	PARAM,NAME=LAY,VALUE=""WFGPS""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseWFGPS(code);
			Assert.AreEqual("WFGPS", obj.BppName);
			Assert.AreEqual(6, obj.SideId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual("", obj.Giz);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual(false, obj.Ps);
			Assert.AreEqual("WFGPS", obj.Lay);
		}
	}
}
