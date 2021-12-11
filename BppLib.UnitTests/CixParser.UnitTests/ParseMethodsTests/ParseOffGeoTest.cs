using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void OffGeoTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=OFFGEO
	PARAM,NAME=ID,VALUE=""P1001""
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=SIL,VALUE=""""
	PARAM,NAME=LAY,VALUE=""OFFGEO""
	PARAM,NAME=OFS,VALUE=0
	PARAM,NAME=SHC,VALUE=NO
	PARAM,NAME=OSL,VALUE=oslTan
	PARAM,NAME=LTP,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=CRT,VALUE=1
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseOffGeo(code);
			Assert.AreEqual("OFFGEO", obj.BppName);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual("", obj.Sil);
			Assert.AreEqual("OFFGEO", obj.Lay);
			Assert.AreEqual(0, obj.Ofs);
			Assert.AreEqual(false, obj.Shc);
			Assert.AreEqual(OffsetSelectionType.oslTan, obj.Osl);
			Assert.AreEqual(false, obj.Ltp);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(OffsetCompensationType.LeftRight, obj.Crt);
		}
	}
}
