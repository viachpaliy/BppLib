using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void WFCTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=WFC
	PARAM,NAME=ID,VALUE=6
	PARAM,NAME=X,VALUE=200
	PARAM,NAME=Y,VALUE=200
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=H,VALUE=18
	PARAM,NAME=A,VALUE=0
	PARAM,NAME=DA,VALUE=90
	PARAM,NAME=R,VALUE=200
	PARAM,NAME=DIR,VALUE=dirCCW
	PARAM,NAME=VRT,VALUE=YES
	PARAM,NAME=VF,VALUE=NO
	PARAM,NAME=AFH,VALUE=NO
	PARAM,NAME=UCS,VALUE=YES
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=LAY,VALUE=""WFC""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseWFC(code);
			Assert.AreEqual("WFC", obj.BppName);
			Assert.AreEqual(6, obj.SideId);
			Assert.AreEqual(200, obj.X);
			Assert.AreEqual(200, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(18, obj.H);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(90, obj.Da);
			Assert.AreEqual(200, obj.R);
			Assert.AreEqual(CircleDirection.dirCCW, obj.Dir);
			Assert.AreEqual(true, obj.Vrt);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual(false, obj.Afh);
			Assert.AreEqual(true, obj.Ucs);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual("WFC", obj.Lay);
		}
	}
}
