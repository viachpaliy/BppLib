using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void PutProgTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=PUTPROG
	PARAM,NAME=ID,VALUE=""P1001""
	PARAM,NAME=SPNAME,VALUE=""""
	PARAM,NAME=SPLPX,VALUE=-1
	PARAM,NAME=SPLPY,VALUE=-1
	PARAM,NAME=SPLPZ,VALUE=-1
	PARAM,NAME=SYMY,VALUE=NO
	PARAM,NAME=ROT,VALUE=0
	PARAM,NAME=SPCRN,VALUE=1
	PARAM,NAME=RFT,VALUE=1
	PARAM,NAME=REF,VALUE=1
	PARAM,NAME=BCK,VALUE=0
	PARAM,NAME=X,VALUE=0
	PARAM,NAME=Y,VALUE=0
	PARAM,NAME=PAV,VALUE=NO
	PARAM,NAME=VARS,VALUE=""""
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParsePutProg(code);
			Assert.AreEqual("PUTPROG", obj.BppName);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual("", obj.SpName);
			Assert.AreEqual(-1, obj.SpLpx);
			Assert.AreEqual(-1, obj.SpLpy);
			Assert.AreEqual(-1, obj.SpLpz);
			Assert.AreEqual(false, obj.SymY);
			Assert.AreEqual(0, obj.Rot);
			Assert.AreEqual(1, obj.SpCrn);
			Assert.AreEqual(1, obj.Rft);
			Assert.AreEqual(1, obj.Ref);
			Assert.AreEqual(0, obj.Bck);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(false, obj.Pav);
			Assert.AreEqual("", obj.Vars);
		}
	}
}
