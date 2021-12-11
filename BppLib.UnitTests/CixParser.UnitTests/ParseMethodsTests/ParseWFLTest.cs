using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void WFLTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=WFL
	PARAM,NAME=ID,VALUE=7
	PARAM,NAME=X,VALUE=200
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=AR,VALUE=135
	PARAM,NAME=L,VALUE=282.85
	PARAM,NAME=H,VALUE=18
	PARAM,NAME=VRT,VALUE=YES
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=AFL,VALUE=NO
	PARAM,NAME=AFH,VALUE=NO
	PARAM,NAME=UCS,VALUE=YES
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=FRC,VALUE=1
	PARAM,NAME=LAY,VALUE=""WFL""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseWFL(code);
			Assert.AreEqual("WFL", obj.BppName);
			Assert.AreEqual(7, obj.SideId);
			Assert.AreEqual(200, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(135, obj.Ar);
			Assert.AreEqual(282.85, obj.L);
			Assert.AreEqual(18, obj.H);
			Assert.AreEqual(true, obj.Vrt);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual(false, obj.Afl);
			Assert.AreEqual(false, obj.Afh);
			Assert.AreEqual(true, obj.Ucs);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(1, obj.Frc);
			Assert.AreEqual("WFL", obj.Lay);
		}
	}
}
