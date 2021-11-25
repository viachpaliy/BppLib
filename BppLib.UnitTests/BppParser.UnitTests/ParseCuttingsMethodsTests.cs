using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class CuttingsTests
    {
		[Test]
		public void ParseCutGTest()
		{
			string code = "@ CUT_G, \"\", \"\", 151747780, \"\", 0 : 0, \"1\", 32.5, 17.5, 0, 6.5, 2, 0, 0, 767.5, 17.5, 0, 0, \"\", 1, 4, -1, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 9.5, 0, 0, 0, 1, \"P1001\", \"LAMA120\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, \"\", \"\", \"CUT_G\", 0, 0, 0, 0";
			var obj = ParserBpp.ParseCutG(code);
			Assert.AreEqual( 151747780, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual( "1", obj.Crn);
			Assert.AreEqual(32.5, obj.X);
			Assert.AreEqual(17.5, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(6.5, obj.Dp);
			Assert.AreEqual((CuttingType) 2, obj.Typ);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.Ang);
			Assert.AreEqual(767.5, obj.Xe);
			Assert.AreEqual(17.5, obj.Ye);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual( "", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual((InclinationRotationType) 0, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(9.5, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual( "P1001", obj.Id);
			Assert.AreEqual( "LAMA120", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual( "", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual((ToolCorrection) 1, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual( "", obj.Cen);
			Assert.AreEqual( "", obj.Agg);
			Assert.AreEqual( "CUT_G", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(0, obj.Ims);
		}

		[Test]
		public void ParseCutXTest()
		{
			string code = "@ CUT_X, \"\", \"\", 150785972, \"\", 0 : 0, \"1,2\", 6.5, 13.5, 0, 7.5, 793.5, 0, 100, \"\", 1, 3.5, 0, 0, 0, 16.1, 0, 0, 0, 1, \"FABA35\", 200, 2, 0, 0, 0, \"\", 0, 0, 1, 0, 1, 0, 0, 0, 2, 0, \"\", \"\", \"CUT_X\", 0, 0, 0";
			var obj = ParserBpp.ParseCutX(code);
			Assert.AreEqual( 150785972, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual( "1,2", obj.Crn);
			Assert.AreEqual(6.5, obj.X);
			Assert.AreEqual(13.5, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(7.5, obj.Dp);
			Assert.AreEqual(793.5, obj.L);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(100, obj.D);
			Assert.AreEqual( "", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(3.5, obj.Th);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(16.1, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual( "FABA35", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual( "", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(1, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual((ToolCorrection) 2, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual( "", obj.Cen);
			Assert.AreEqual( "", obj.Agg);
			Assert.AreEqual( "CUT_X", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
		}



    }
}