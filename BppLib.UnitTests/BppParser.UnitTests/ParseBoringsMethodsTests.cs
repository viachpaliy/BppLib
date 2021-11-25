using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class BoringsTests
    {
 
        [Test]
		public void ParseBgTest()
		{
			string code = "@ BG, \"\", \"\", 471, \"\", 0 : 0, \"1\", 138, 566, 0, 18.1, 7, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P00194\", 0, \"\", \"7X35X70V\", 1, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, \"\", \"\", \"BG\", 0, 0, 0, 0, -1, 0, 0, 0";
			var obj = ParserBpp.ParseBg(code);
			Assert.AreEqual( 471, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual( "1", obj.Crn);
			Assert.AreEqual(138, obj.X);
			Assert.AreEqual(566, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(18.1, obj.Dp);
			Assert.AreEqual(7, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual( "", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(false, obj.Ap);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Md);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual( "P00194", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual( "", obj.Mac);
			Assert.AreEqual( "7X35X70V", obj.Tnm);
			Assert.AreEqual(1, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual( "", obj.Spi);
			Assert.AreEqual(0, obj.Dds);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual( "", obj.Cen);
			Assert.AreEqual( "", obj.Agg);
			Assert.AreEqual( "BG", obj.Lay);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Dtas);
			Assert.AreEqual(RmdType.rmdAuto, obj.Rmd);
			Assert.AreEqual(0, obj.Dqt);
			Assert.AreEqual(false, obj.Erdw);
			Assert.AreEqual(0, obj.Dfw);
		}
		[Test]
		public void ParseBhTest()
		{
			string code = "@ BH, \"\", \"\", 96975964, \"\", 0 : 1, \"1,4\", 37.5, 0, 0, 29.9, 8, 0, 0, 100.5, 0, 0, 0, 0, 2, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, -1, \"P1004\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BH\", 0, 0, 0, 0, -1, 0, 0, 0";
			var obj = ParserBpp.ParseBh(code);
			Assert.AreEqual( 96975964, obj.IntId);
			Assert.AreEqual(1, obj.Side);
			Assert.AreEqual( "1,4", obj.Crn);
			Assert.AreEqual(37.5, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(29.9, obj.Dp);
			Assert.AreEqual(8, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual((Repetition) 0, obj.Rty);
			Assert.AreEqual(100.5, obj.Dx);
			Assert.AreEqual(0, obj.Dy);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Da);
			Assert.AreEqual(2, obj.Nrp);
			Assert.AreEqual( "", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(false, obj.Ap);
			Assert.AreEqual((InclinationRotationType) 0, obj.Cka);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(true, obj.Md);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual( "P1004", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual( "", obj.Mac);
			Assert.AreEqual( "", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual( "", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual( "", obj.Cen);
			Assert.AreEqual( "", obj.Agg);
			Assert.AreEqual( "BH", obj.Lay);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Dtas);
			Assert.AreEqual(RmdType.rmdAuto, obj.Rmd);
			Assert.AreEqual(0, obj.Dqt);
			Assert.AreEqual(false, obj.Erdw);
			Assert.AreEqual(0, obj.Dfw);
		}
		

    }
}