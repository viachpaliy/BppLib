using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class ParseProgramSectionLineMethodsTests
    {
		[Test]
		public void ParseProgramSectionLineTest_Geo_DefaultValues()
		{
			string code = "@ GEO, \"\", \"\", 58225482, \"\", 0 : \"P1001\", 0, \"1\", 0, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 1, 0, 0, \"GEO\", 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Geo>(bj);
			Geo obj = (Geo)bj;
			Assert.AreEqual("GEO", obj.BppName);
			Assert.AreEqual(58225482, obj.IntId);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.Dp);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual("GEO", obj.Lay);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
		}

		[Test]
		public void ParseProgramSectionLineTest_StartPoint_DefaultValues()
		{
			string code = "@ START_POINT, \"\", \"\", 55915408, \"\", 0 : 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<StartPoint>(bj);
			StartPoint obj = (StartPoint)bj;
			Assert.AreEqual("START_POINT", obj.BppName);
			Assert.AreEqual(55915408, obj.Id);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
		}

		[Test]
		public void ParseProgramSectionLineTest_EndPath_DefaultValues()
		{
			string code = "@ ENDPATH, \"\", \"\", 33476626, \"\", 0 :";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<EndPath>(bj);
			EndPath obj = (EndPath)bj;
			Assert.AreEqual("ENDPATH", obj.BppName);
			Assert.AreEqual(33476626, obj.Id);
		}

		[Test]
		public void ParseProgramSectionLineTest_AincAnCe_DefaultValues()
		{
			string code = "@ AINC_ANCE, \"\", \"\", 32854180, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<AincAnCe>(bj);
			AincAnCe obj = (AincAnCe)bj;
			Assert.AreEqual("AINC_ANCE", obj.BppName);
			Assert.AreEqual(32854180, obj.Id);
			Assert.AreEqual(0, obj.Xi);
			Assert.AreEqual(0, obj.Yi);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_AincEpRa_DefaultValues()
		{
			string code = "@ AINC_EPRA, \"\", \"\", 27252167, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<AincEpRa>(bj);
			AincEpRa obj = (AincEpRa)bj;
			Assert.AreEqual("AINC_EPRA", obj.BppName);
			Assert.AreEqual(27252167, obj.Id);
			Assert.AreEqual(0, obj.Xi);
			Assert.AreEqual(0, obj.Yi);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcAnCe_DefaultValues()
		{
			string code = "@ ARC_ANCE, \"\", \"\", 43942917, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcAnCe>(bj);
			ArcAnCe obj = (ArcAnCe)bj;
			Assert.AreEqual("ARC_ANCE", obj.BppName);
			Assert.AreEqual(43942917, obj.Id);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcAnCeRaTp_DefaultValues()
		{
			string code = "@ ARC_ANCERATP, \"\", \"\", 59941933, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcAnCeRaTp>(bj);
			ArcAnCeRaTp obj = (ArcAnCeRaTp)bj;
			Assert.AreEqual("ARC_ANCERATP", obj.BppName);
			Assert.AreEqual(59941933, obj.Id);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcCeTs_DefaultValues()
		{
			string code = "@ ARC_CETS, \"\", \"\", 2606490, \"\", 0 : 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcCeTs>(bj);
			ArcCeTs obj = (ArcCeTs)bj;
			Assert.AreEqual("ARC_CETS", obj.BppName);
			Assert.AreEqual(2606490, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcCeTsPk_DefaultValues()
		{
			string code = "@ ARC_CETSPK, \"\", \"\", 23458411, \"\", 0 : 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcCeTsPk>(bj);
			ArcCeTsPk obj = (ArcCeTsPk)bj;
			Assert.AreEqual("ARC_CETSPK", obj.BppName);
			Assert.AreEqual(23458411, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcEpCe_DefaultValues()
		{
			string code = "@ ARC_EPCE, \"\", \"\", 9799115, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcEpCe>(bj);
			ArcEpCe obj = (ArcEpCe)bj;
			Assert.AreEqual("ARC_EPCE", obj.BppName);
			Assert.AreEqual(9799115, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcEpRa_DefaultValues()
		{
			string code = "@ ARC_EPRA, \"\", \"\", 21083178, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
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

		[Test]
		public void ParseProgramSectionLineTest_ArcEpRaTp_DefaultValues()
		{
			string code = "@ ARC_EPRATP, \"\", \"\", 55530882, \"\", 0 : 0, 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcEpRaTp>(bj);
			ArcEpRaTp obj = (ArcEpRaTp)bj;
			Assert.AreEqual("ARC_EPRATP", obj.BppName);
			Assert.AreEqual(55530882, obj.Id);
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

		[Test]
		public void ParseProgramSectionLineTest_ArcEpTp_DefaultValues()
		{
			string code = "@ ARC_EPTP, \"\", \"\", 30015890, \"\", 0 : 0, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcEpTp>(bj);
			ArcEpTp obj = (ArcEpTp)bj;
			Assert.AreEqual("ARC_EPTP", obj.BppName);
			Assert.AreEqual(30015890, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcIpEp_DefaultValues()
		{
			string code = "@ ARC_IPEP, \"\", \"\", 1707556, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcIpEp>(bj);
			ArcIpEp obj = (ArcIpEp)bj;
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

		[Test]
		public void ParseProgramSectionLineTest_ArcRaTs_DefaultValues()
		{
			string code = "@ ARC_RATS, \"\", \"\", 15368010, \"\", 0 : 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcRaTs>(bj);
			ArcRaTs obj = (ArcRaTs)bj;
			Assert.AreEqual("ARC_RATS", obj.BppName);
			Assert.AreEqual(15368010, obj.Id);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ArcRaTsPk_DefaultValues()
		{
			string code = "@ ARC_RATSPK, \"\", \"\", 4094363, \"\", 0 : 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ArcRaTsPk>(bj);
			ArcRaTsPk obj = (ArcRaTsPk)bj;
			Assert.AreEqual("ARC_RATSPK", obj.BppName);
			Assert.AreEqual(4094363, obj.Id);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ConnectorA_DefaultValues()
		{
			string code = "@ CONNECTOR, \"\", \"\", 36849274, \"\", 0 : 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ConnectorA>(bj);
			ConnectorA obj = (ConnectorA)bj;
			Assert.AreEqual("CONNECTOR", obj.BppName);
			Assert.AreEqual(36849274, obj.Id);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_ConnectorB_DefaultValues()
		{
			string code = "@ CONNECTOR2, \"\", \"\", 63208015, \"\", 0 : 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<ConnectorB>(bj);
			ConnectorB obj = (ConnectorB)bj;
			Assert.AreEqual("CONNECTOR2", obj.BppName);
			Assert.AreEqual(63208015, obj.Id);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_Bca_DefaultValues()
		{
			string code = "@ BCA, \"\", \"\", 32001227, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BCA\", 0, 0, 0, 0, -1, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Bca>(bj);
			Bca obj = (Bca)bj;
			Assert.AreEqual("BCA", obj.BppName);
			Assert.AreEqual(32001227, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual("", obj.Iso);
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
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("BCA", obj.Lay);
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
		public void ParseProgramSectionLineTest_Bcl_DefaultValues()
		{
			string code = "@ BCL, \"\", \"\", 19575591, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BCL\", 0, 0, 0, 0, -1, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Bcl>(bj);
			Bcl obj = (Bcl)bj;
			Assert.AreEqual("BCL", obj.BppName);
			Assert.AreEqual(19575591, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual("", obj.Iso);
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
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("BCL", obj.Lay);
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
		public void ParseProgramSectionLineTest_Bg_DefaultValues()
		{
			string code = "@ BG, \"\", \"\", 41962596, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BG\", 0, 0, 0, 0, -1, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Bg>(bj);
			Bg obj = (Bg)bj;
			Assert.AreEqual("BG", obj.BppName);
			Assert.AreEqual(41962596, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual("", obj.Iso);
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
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("BG", obj.Lay);
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
		public void ParseProgramSectionLineTest_BGeo_DefaultValues()
		{
			string code = "@ B_GEO, \"\", \"\", 42119052, \"\", 0 : \"\", 10, 5, 0, \"\", 1, 0, 0, 0, 0, \"\", 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"B_GEO\", 0, 0, 0, 0, -1, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<BGeo>(bj);
			BGeo obj = (BGeo)bj;
			Assert.AreEqual("B_GEO", obj.BppName);
			Assert.AreEqual(42119052, obj.IntId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual("", obj.Sil);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("B_GEO", obj.Lay);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Dtas);
			Assert.AreEqual(RmdType.rmdAuto, obj.Rmd);
			Assert.AreEqual(0, obj.Dqt);
		}

		[Test]
		public void ParseProgramSectionLineTest_Bh_DefaultValues()
		{
			string code = "@ BH, \"\", \"\", 43527150, \"\", 0 : 1, \"1\", 0, 0, 0, 10, 5, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BH\", 0, 0, 0, 0, -1, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Bh>(bj);
			Bh obj = (Bh)bj;
			Assert.AreEqual("BH", obj.BppName);
			Assert.AreEqual(43527150, obj.IntId);
			Assert.AreEqual(1, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual("", obj.Iso);
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
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("BH", obj.Lay);
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
		public void ParseProgramSectionLineTest_Bv_DefaultValues()
		{
			string code = "@ BV, \"\", \"\", 56200037, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, -1, 32, 32, 50, 0, 45, 0, \"\", 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, -1, \"P1001\", 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"BV\", 0, 0, 0, 0, -1, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Bv>(bj);
			Bv obj = (Bv)bj;
			Assert.AreEqual("BV", obj.BppName);
			Assert.AreEqual(56200037, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual("", obj.Iso);
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
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("BV", obj.Lay);
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
		public void ParseProgramSectionLineTest_S32_DefaultValues()
		{
			string code = "@ S32, \"\", \"\", 36038289, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 5, 0, 0, 32, 0, 0, \"\", 1, 0, 0, 0, \"\", \"\", 0, 0, 0, 0, 0, \"\", 3, 1500, 0, 0, 0, \"\", \"\", \"S32\", 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<S32>(bj);
			S32 obj = (S32)bj;
			Assert.AreEqual("S32", obj.BppName);
			Assert.AreEqual(36038289, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(5, obj.Dia);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(Direction.drX, obj.Dir);
			Assert.AreEqual(32, obj.Stp);
			Assert.AreEqual(0, obj.Dst);
			Assert.AreEqual(SystemBores.sysCorr, obj.Typ);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(0, obj.Xmi);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual("", obj.Mac);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(0, obj.Ttp);
			Assert.AreEqual(0, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(3, obj.Dds);
			Assert.AreEqual(1500, obj.Dsp);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("S32", obj.Lay);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Dtas);
		}

		[Test]
		public void ParseProgramSectionLineTest_CutF_DefaultValues()
		{
			string code = "@ CUT_F, \"\", \"\", 55909147, \"\", 0 : 0, 0, 0, \"\", 1, 4, 10, 0, 0, 0, 0, 0, 0, 0, 1, \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_F\", 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CutF>(bj);
			CutF obj = (CutF)bj;
			Assert.AreEqual("CUT_F", obj.BppName);
			Assert.AreEqual(55909147, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_F", obj.Lay);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
		}

		[Test]
		public void ParseProgramSectionLineTest_CutFR_DefaultValues()
		{
			string code = "@ CUT_FR, \"\", \"\", 33420276, \"\", 0 : 0, \"1\", 0, 0, 500, 300, \"\", 1, 4, 10, 0, 0, 0, 0, 0, 0, 0, 1, \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_FR\", 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CutFR>(bj);
			CutFR obj = (CutFR)bj;
			Assert.AreEqual("CUT_FR", obj.BppName);
			Assert.AreEqual(33420276, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(500, obj.Lx);
			Assert.AreEqual(300, obj.Ly);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_FR", obj.Lay);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
		}

		[Test]
		public void ParseProgramSectionLineTest_CutG_DefaultValues()
		{
			string code = "@ CUT_G, \"\", \"\", 32347029, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 2, 0, 0, 400, 400, 0, 0, \"\", 1, 4, -1, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, \"P1001\", \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_G\", 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CutG>(bj);
			CutG obj = (CutG)bj;
			Assert.AreEqual("CUT_G", obj.BppName);
			Assert.AreEqual(32347029, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(CuttingType.cutXY, obj.Typ);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.Ang);
			Assert.AreEqual(400, obj.Xe);
			Assert.AreEqual(400, obj.Ye);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual("", obj.Iso);
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
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_G", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(0, obj.Ims);
		}

		[Test]
		public void ParseProgramSectionLineTest_CutGeo_DefaultValues()
		{
			string code = "@ CUT_GEO, \"\", \"\", 22687807, \"\", 0 : \"\", 10, 0, \"\", 1, 4, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 1, \"P1001\", \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_GEO\", 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CutGeo>(bj);
			CutGeo obj = (CutGeo)bj;
			Assert.AreEqual("CUT_GEO", obj.BppName);
			Assert.AreEqual(22687807, obj.IntId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual("", obj.Sil);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_GEO", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(0, obj.Ims);
		}

		[Test]
		public void ParseProgramSectionLineTest_CutX_DefaultValues()
		{
			string code = "@ CUT_X, \"\", \"\", 2863675, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 100, 0, 100, \"\", 1, 4, 0, 0, 0, 0, 0, 0, 0, 1, \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_X\", 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CutX>(bj);
			CutX obj = (CutX)bj;
			Assert.AreEqual("CUT_X", obj.BppName);
			Assert.AreEqual(2863675, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(100, obj.L);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(100, obj.D);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_X", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
		}

		[Test]
		public void ParseProgramSectionLineTest_CutY_DefaultValues()
		{
			string code = "@ CUT_Y, \"\", \"\", 25773083, \"\", 0 : 0, \"1\", 0, 0, 0, 10, 100, 0, 100, \"\", 1, 4, 0, 0, 0, 0, 0, 0, 0, 1, \"\", 200, 2, 0, 0, 0, \"\", 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", \"\", \"CUT_Y\", 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CutY>(bj);
			CutY obj = (CutY)bj;
			Assert.AreEqual("CUT_Y", obj.BppName);
			Assert.AreEqual(25773083, obj.IntId);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual(100, obj.L);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(100, obj.D);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(4, obj.Th);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ttk);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(200, obj.Ttp);
			Assert.AreEqual(2, obj.Tcl);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(0, obj.Brc);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual(true, obj.Prv);
			Assert.AreEqual(false, obj.Nrv);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(ToolCorrection.Central, obj.Crc);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("CUT_Y", obj.Lay);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Kdt);
		}

		[Test]
		public void ParseProgramSectionLineTest_Circle3P_DefaultValues()
		{
			string code = "@ CIRCLE_3P, \"\", \"\", 30631159, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Circle3P>(bj);
			Circle3P obj = (Circle3P)bj;
			Assert.AreEqual("CIRCLE_3P", obj.BppName);
			Assert.AreEqual(30631159, obj.Id);
			Assert.AreEqual(0, obj.X1);
			Assert.AreEqual(0, obj.Y1);
			Assert.AreEqual(0, obj.X2);
			Assert.AreEqual(0, obj.Y2);
			Assert.AreEqual(0, obj.X3);
			Assert.AreEqual(0, obj.Y3);
			Assert.AreEqual(0, obj.As);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}

		[Test]
		public void ParseProgramSectionLineTest_CircleCR_DefaultValues()
		{
			string code = "@ CIRCLE_CR, \"\", \"\", 7244975, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<CircleCR>(bj);
			CircleCR obj = (CircleCR)bj;
			Assert.AreEqual("CIRCLE_CR", obj.BppName);
			Assert.AreEqual(7244975, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(0, obj.As);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}

		[Test]
		public void ParseProgramSectionLineTest_Ellipse_DefaultValues()
		{
			string code = "@ ELLIPSE, \"\", \"\", 65204782, \"\", 0 : 0, 0, 0, 0, 0, 0, 1, 1, 20, 0, 1, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Ellipse>(bj);
			Ellipse obj = (Ellipse)bj;
			Assert.AreEqual("ELLIPSE", obj.BppName);
			Assert.AreEqual(65204782, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.A1);
			Assert.AreEqual(0, obj.A2);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.As);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(true, obj.Une);
			Assert.AreEqual(20, obj.Elm);
			Assert.AreEqual(0, obj.Mle);
			Assert.AreEqual(true, obj.Ua);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Ae);
		}

		[Test]
		public void ParseProgramSectionLineTest_Oval_DefaultValues()
		{
			string code = "@ OVAL, \"\", \"\", 49972132, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Oval>(bj);
			Oval obj = (Oval)bj;
			Assert.AreEqual("OVAL", obj.BppName);
			Assert.AreEqual(49972132, obj.Id);
			Assert.AreEqual(0, obj.X1);
			Assert.AreEqual(0, obj.Y1);
			Assert.AreEqual(0, obj.R1);
			Assert.AreEqual(0, obj.X2);
			Assert.AreEqual(0, obj.Y2);
			Assert.AreEqual(0, obj.R2);
			Assert.AreEqual(0, obj.Lkr);
			Assert.AreEqual(0, obj.As);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}

		[Test]
		public void ParseProgramSectionLineTest_Polygon_DefaultValues()
		{
			string code = "@ POLYGON, \"\", \"\", 47096010, \"\", 0 : 0, 0, 0, 3, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Polygon>(bj);
			Polygon obj = (Polygon)bj;
			Assert.AreEqual("POLYGON", obj.BppName);
			Assert.AreEqual(47096010, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.R);
			Assert.AreEqual(3, obj.S);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(ChamferType.cmfNO, obj.Ct);
			Assert.AreEqual(0, obj.Cd);
			Assert.AreEqual(1, obj.Ss);
			Assert.AreEqual(true, obj.StartFromHalfSide);
			Assert.AreEqual(0, obj.Sd);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}

		[Test]
		public void ParseProgramSectionLineTest_Rectangle_DefaultValues()
		{
			string code = "@ RECTANGLE, \"\", \"\", 21210914, \"\", 0 : 0, 0, 0, 0, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0, 1, 1";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Rectangle>(bj);
			Rectangle obj = (Rectangle)bj;
			Assert.AreEqual("RECTANGLE", obj.BppName);
			Assert.AreEqual(21210914, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.H);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(ChamferType.cmfNO, obj.Ct);
			Assert.AreEqual(0, obj.Cd);
			Assert.AreEqual(1, obj.Ss);
			Assert.AreEqual(true, obj.StartFromHalfSide);
			Assert.AreEqual(0, obj.Sd);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(true, obj.Usc);
			Assert.AreEqual(1, obj.Crn);
		}

		[Test]
		public void ParseProgramSectionLineTest_Star_DefaultValues()
		{
			string code = "@ STAR, \"\", \"\", 56680499, \"\", 0 : 0, 0, 100, 25, 5, 1, 0, 0, 1, HALF, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Star>(bj);
			Star obj = (Star)bj;
			Assert.AreEqual("STAR", obj.BppName);
			Assert.AreEqual(56680499, obj.Id);
			Assert.AreEqual(0, obj.Xc);
			Assert.AreEqual(0, obj.Yc);
			Assert.AreEqual(100, obj.Er);
			Assert.AreEqual(25, obj.Ir);
			Assert.AreEqual(5, obj.Ps);
			Assert.AreEqual(CircleDirection.dirCW, obj.Dir);
			Assert.AreEqual(ChamferType.cmfNO, obj.Ct);
			Assert.AreEqual(0, obj.Cd);
			Assert.AreEqual(1, obj.Ss);
			Assert.AreEqual(true, obj.StartFromHalfSide);
			Assert.AreEqual(0, obj.Sd);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
		}

		[Test]
		public void ParseProgramSectionLineTest_Chamfer_DefaultValues()
		{
			string code = "@ CHAMFER, \"\", \"\", 40362448, \"\", 0 : 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Chamfer>(bj);
			Chamfer obj = (Chamfer)bj;
			Assert.AreEqual("CHAMFER", obj.BppName);
			Assert.AreEqual(40362448, obj.Id);
			Assert.AreEqual(0, obj.D);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LincEp_DefaultValues()
		{
			string code = "@ LINC_EP, \"\", \"\", 27717712, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LincEp>(bj);
			LincEp obj = (LincEp)bj;
			Assert.AreEqual("LINC_EP", obj.BppName);
			Assert.AreEqual(27717712, obj.Id);
			Assert.AreEqual(0, obj.Xi);
			Assert.AreEqual(0, obj.Yi);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineAnXe_DefaultValues()
		{
			string code = "@ LINE_ANXE, \"\", \"\", 48132822, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineAnXe>(bj);
			LineAnXe obj = (LineAnXe)bj;
			Assert.AreEqual("LINE_ANXE", obj.BppName);
			Assert.AreEqual(48132822, obj.Id);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineAnYe_DefaultValues()
		{
			string code = "@ LINE_ANYE, \"\", \"\", 30542218, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineAnYe>(bj);
			LineAnYe obj = (LineAnYe)bj;
			Assert.AreEqual("LINE_ANYE", obj.BppName);
			Assert.AreEqual(30542218, obj.Id);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineEp_DefaultValues()
		{
			string code = "@ LINE_EP, \"\", \"\", 6444509, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineEp>(bj);
			LineEp obj = (LineEp)bj;
			Assert.AreEqual("LINE_EP", obj.BppName);
			Assert.AreEqual(6444509, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
			Assert.AreEqual(false, obj.Mvt);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineEpAnTp_DefaultValues()
		{
			string code = "@ LINE_EPANTP, \"\", \"\", 58000584, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineEpAnTp>(bj);
			LineEpAnTp obj = (LineEpAnTp)bj;
			Assert.AreEqual("LINE_EPANTP", obj.BppName);
			Assert.AreEqual(58000584, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineEpTp_DefaultValues()
		{
			string code = "@ LINE_EPTP, \"\", \"\", 52243212, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineEpTp>(bj);
			LineEpTp obj = (LineEpTp)bj;
			Assert.AreEqual("LINE_EPTP", obj.BppName);
			Assert.AreEqual(52243212, obj.Id);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineLnAn_DefaultValues()
		{
			string code = "@ LINE_LNAN, \"\", \"\", 426867, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineLnAn>(bj);
			LineLnAn obj = (LineLnAn)bj;
			Assert.AreEqual("LINE_LNAN", obj.BppName);
			Assert.AreEqual(426867, obj.Id);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineLnTp_DefaultValues()
		{
			string code = "@ LINE_LNTP, \"\", \"\", 3841804, \"\", 0 : 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineLnTp>(bj);
			LineLnTp obj = (LineLnTp)bj;
			Assert.AreEqual("LINE_LNTP", obj.BppName);
			Assert.AreEqual(3841804, obj.Id);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineLnXe_DefaultValues()
		{
			string code = "@ LINE_LNXE, \"\", \"\", 34576242, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineLnXe>(bj);
			LineLnXe obj = (LineLnXe)bj;
			Assert.AreEqual("LINE_LNXE", obj.BppName);
			Assert.AreEqual(34576242, obj.Id);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.Xe);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_LineLnYe_DefaultValues()
		{
			string code = "@ LINE_LNYE, \"\", \"\", 42750725, \"\", 0 : 0, 0, 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<LineLnYe>(bj);
			LineLnYe obj = (LineLnYe)bj;
			Assert.AreEqual("LINE_LNYE", obj.BppName);
			Assert.AreEqual(42750725, obj.Id);
			Assert.AreEqual(0, obj.L);
			Assert.AreEqual(0, obj.Ye);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(SharpCorner.scOFF, obj.Sc);
			Assert.AreEqual(0, obj.Fd);
			Assert.AreEqual(0, obj.Sp);
			Assert.AreEqual(0, obj.Sol);
		}

		[Test]
		public void ParseProgramSectionLineTest_GeoText_DefaultValues()
		{
			string code = "@ GEOTEXT, \"\", \"\", 49212206, \"\", 0 : \"P1001\", 0, \"2\", \"Hello World\", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, \"Arial\", 20, 0, 0, 0, 0, 1, 0, -1, 32, 32, 50, 0, 45, 0, 0, 0, 0, 0, 1, 1, \"GEOTEXT\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<GeoText>(bj);
			GeoText obj = (GeoText)bj;
			Assert.AreEqual("GEOTEXT", obj.BppName);
			Assert.AreEqual(49212206, obj.IntId);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("2", obj.Crn);
			Assert.AreEqual("Hello World", obj.Txt);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(0, obj.Ang);
			Assert.AreEqual(TextDirection.LeftToRight, obj.Vrs);
			Assert.AreEqual(TextAlignment.Central, obj.Aln);
			Assert.AreEqual(0, obj.Acc);
			Assert.AreEqual(false, obj.Cir);
			Assert.AreEqual(0, obj.Rds);
			Assert.AreEqual(TextPosition.txtExt, obj.Pst);
			Assert.AreEqual("Arial", obj.Fnt);
			Assert.AreEqual(20, obj.Sze);
			Assert.AreEqual(false, obj.Bol);
			Assert.AreEqual(false, obj.Itl);
			Assert.AreEqual(false, obj.Udl);
			Assert.AreEqual(false, obj.Str);
			Assert.AreEqual(1, obj.Wgh);
			Assert.AreEqual(0, obj.Chs);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual("GEOTEXT", obj.Lay);
		}

		[Test]
		public void ParseProgramSectionLineTest_OffGeo_DefaultValues()
		{
			string code = "@ OFFGEO, \"\", \"\", 40256670, \"\", 0 : \"P1001\", \"\", \"\", \"OFFGEO\", 0, 0, 0, 0, 0, 1";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<OffGeo>(bj);
			OffGeo obj = (OffGeo)bj;
			Assert.AreEqual("OFFGEO", obj.BppName);
			Assert.AreEqual(40256670, obj.IntId);
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

		[Test]
		public void ParseProgramSectionLineTest_Pock_DefaultValues()
		{
			string code = "@ POCK, \"\", \"\", 26765710, \"\", 0 : \"\", \"\", 18, 10, \"\", 1, 0, 0, -1, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, -1, \"P1001\", 0, 0, 0, 0, \"\", 103, 1, 1, 45, 0, 1, 45, 0, 0, 0, 0, 0, \"\", 0, 0, \"\", \"\", \"POCK\", 0, 0, 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Pock>(bj);
			Pock obj = (Pock)bj;
			Assert.AreEqual("POCK", obj.BppName);
			Assert.AreEqual(26765710, obj.IntId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual("", obj.Isl);
			Assert.AreEqual(18, obj.Dia);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(PocketType.ptZIG, obj.Typ);
			Assert.AreEqual(0, obj.Dlt);
			Assert.AreEqual(-1, obj.N);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(false, obj.Tc);
			Assert.AreEqual(false, obj.Cki);
			Assert.AreEqual(10, obj.Zst);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Rrv);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(103, obj.Ttp);
			Assert.AreEqual(1, obj.Tcl);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tin);
			Assert.AreEqual(45, obj.Ain);
			Assert.AreEqual(false, obj.Cin);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tou);
			Assert.AreEqual(45, obj.Aou);
			Assert.AreEqual(false, obj.Cou);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(0, obj.Sds);
			Assert.AreEqual(0, obj.Prp);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("POCK", obj.Lay);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(0, obj.Sdsf);
		}

		[Test]
		public void ParseProgramSectionLineTest_Rout_DefaultValues()
		{
			string code = "@ ROUT, \"\", \"\", 39564799, \"\", 0 : \"P1001\", 0, \"1\", 0, 10, \"\", 1, 18, -1, 0, 0, 32, 32, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, \"\", 103, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 5, 0, 20, 80, 60, 0, \"\", \"\", \"ROUT\", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Rout>(bj);
			Rout obj = (Rout)bj;
			Assert.AreEqual("ROUT", obj.BppName);
			Assert.AreEqual(39564799, obj.IntId);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual("1", obj.Crn);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(18, obj.Dia);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(32, obj.Dx);
			Assert.AreEqual(32, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Ckt);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(true, obj.Er);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(0, obj.Otr);
			Assert.AreEqual(0, obj.Svr);
			Assert.AreEqual(false, obj.Cof);
			Assert.AreEqual(0, obj.Dof);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual(0, obj.Lsv);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(103, obj.Ttp);
			Assert.AreEqual(1, obj.Tcl);
			Assert.AreEqual(ToolCorrection.Left, obj.Crc);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tin);
			Assert.AreEqual(45, obj.Ain);
			Assert.AreEqual(false, obj.Cin);
			Assert.AreEqual(0, obj.Gin);
			Assert.AreEqual(false, obj.Tbi);
			Assert.AreEqual(0, obj.Tli);
			Assert.AreEqual(0, obj.Tqi);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tou);
			Assert.AreEqual(45, obj.Aou);
			Assert.AreEqual(false, obj.Cou);
			Assert.AreEqual(0, obj.Gou);
			Assert.AreEqual(false, obj.Tbo);
			Assert.AreEqual(0, obj.Tlo);
			Assert.AreEqual(0, obj.Tqo);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(0, obj.Sds);
			Assert.AreEqual(0, obj.Prp);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Sc);
			Assert.AreEqual(false, obj.Swi);
			Assert.AreEqual(false, obj.Blw);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Swp);
			Assert.AreEqual(0, obj.Csp);
			Assert.AreEqual(false, obj.Udt);
			Assert.AreEqual("", obj.Tdt);
			Assert.AreEqual(5, obj.Ddt);
			Assert.AreEqual(0, obj.Sdt);
			Assert.AreEqual(20, obj.Idt);
			Assert.AreEqual(80, obj.Fdt);
			Assert.AreEqual(60, obj.Rdt);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("ROUT", obj.Lay);
			Assert.AreEqual(0, obj.Eecs);
			Assert.AreEqual(1, obj.Pdin);
			Assert.AreEqual(1, obj.Pdu);
			Assert.AreEqual(0, obj.Pcin);
			Assert.AreEqual(0, obj.Pcu);
			Assert.AreEqual(0, obj.Pmol);
			Assert.AreEqual(0, obj.Aux);
			Assert.AreEqual(false, obj.Crr);
			Assert.AreEqual(false, obj.Nebs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Fxd);
			Assert.AreEqual(0, obj.Fxda);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Eml);
			Assert.AreEqual(false, obj.Etg);
			Assert.AreEqual(false, obj.Rtas);
			Assert.AreEqual(false, obj.Rdin);
			Assert.AreEqual(0, obj.Sdsf);
			Assert.AreEqual(false, obj.Incstp);
			Assert.AreEqual(0.1, obj.Etgt);
			Assert.AreEqual(false, obj.Ajt);
			Assert.AreEqual(false, obj.Ion);
			Assert.AreEqual(false, obj.Lubmnz);
			Assert.AreEqual(ShtType.spByPost, obj.Sht);
			Assert.AreEqual(0, obj.Shd);
		}

		[Test]
		public void ParseProgramSectionLineTest_RoutG_DefaultValues()
		{
			string code = "@ ROUTG, \"\", \"\", 20538874, \"\", 0 : \"\", \"P1001\", 0, 0, 10, \"\", 1, 18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, \"\", 103, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 5, 0, 20, 80, 60, 0, \"\", \"\", \"ROUTG\", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<RoutG>(bj);
			RoutG obj = (RoutG)bj;
			Assert.AreEqual("ROUTG", obj.BppName);
			Assert.AreEqual(20538874, obj.IntId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual("P1001", obj.Id);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(10, obj.Dp);
			Assert.AreEqual("", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(18, obj.Dia);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual(InclinationRotationType.azrNO, obj.Cka);
			Assert.AreEqual(false, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Ckt);
			Assert.AreEqual(false, obj.Cow);
			Assert.AreEqual("", obj.Sil);
			Assert.AreEqual(0, obj.Ovm);
			Assert.AreEqual(0, obj.A21);
			Assert.AreEqual(0, obj.Lng);
			Assert.AreEqual(false, obj.Lpr);
			Assert.AreEqual(false, obj.Tos);
			Assert.AreEqual(0, obj.Vtr);
			Assert.AreEqual(0, obj.Dvr);
			Assert.AreEqual(0, obj.Otr);
			Assert.AreEqual(0, obj.Svr);
			Assert.AreEqual(false, obj.Cof);
			Assert.AreEqual(0, obj.Dof);
			Assert.AreEqual(true, obj.Gip);
			Assert.AreEqual(0, obj.Lsv);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual("", obj.Tnm);
			Assert.AreEqual(103, obj.Ttp);
			Assert.AreEqual(1, obj.Tcl);
			Assert.AreEqual(ToolCorrection.Left, obj.Crc);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tin);
			Assert.AreEqual(45, obj.Ain);
			Assert.AreEqual(false, obj.Cin);
			Assert.AreEqual(0, obj.Gin);
			Assert.AreEqual(false, obj.Tbi);
			Assert.AreEqual(0, obj.Tli);
			Assert.AreEqual(0, obj.Tqi);
			Assert.AreEqual(LeadInOutType.Curve, obj.Tou);
			Assert.AreEqual(45, obj.Aou);
			Assert.AreEqual(false, obj.Cou);
			Assert.AreEqual(0, obj.Gou);
			Assert.AreEqual(false, obj.Tbo);
			Assert.AreEqual(0, obj.Tlo);
			Assert.AreEqual(0, obj.Tqo);
			Assert.AreEqual(0, obj.Din);
			Assert.AreEqual(0, obj.Dou);
			Assert.AreEqual(0, obj.Sds);
			Assert.AreEqual(0, obj.Prp);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual("", obj.Spi);
			Assert.AreEqual(false, obj.Sc);
			Assert.AreEqual(false, obj.Swi);
			Assert.AreEqual(false, obj.Blw);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Swp);
			Assert.AreEqual(0, obj.Csp);
			Assert.AreEqual(false, obj.Udt);
			Assert.AreEqual("", obj.Tdt);
			Assert.AreEqual(5, obj.Ddt);
			Assert.AreEqual(0, obj.Sdt);
			Assert.AreEqual(20, obj.Idt);
			Assert.AreEqual(80, obj.Fdt);
			Assert.AreEqual(60, obj.Rdt);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual("", obj.Cen);
			Assert.AreEqual("", obj.Agg);
			Assert.AreEqual("ROUTG", obj.Lay);
			Assert.AreEqual(0, obj.Eecs);
			Assert.AreEqual(1, obj.Pdin);
			Assert.AreEqual(1, obj.Pdu);
			Assert.AreEqual(0, obj.Pcin);
			Assert.AreEqual(0, obj.Pcu);
			Assert.AreEqual(0, obj.Pmol);
			Assert.AreEqual(0, obj.Aux);
			Assert.AreEqual(false, obj.Crr);
			Assert.AreEqual(false, obj.Nebs);
			Assert.AreEqual(false, obj.Etb);
			Assert.AreEqual(false, obj.Fxd);
			Assert.AreEqual(0, obj.Fxda);
			Assert.AreEqual(false, obj.Kdt);
			Assert.AreEqual(false, obj.Eml);
			Assert.AreEqual(false, obj.Etg);
			Assert.AreEqual(false, obj.Rtas);
			Assert.AreEqual(false, obj.Rdin);
			Assert.AreEqual(0, obj.Ims);
			Assert.AreEqual(0, obj.Sdsf);
			Assert.AreEqual(false, obj.Incstp);
			Assert.AreEqual(0.1, obj.Etgt);
			Assert.AreEqual(false, obj.Ajt);
			Assert.AreEqual(false, obj.Ion);
			Assert.AreEqual(false, obj.Lubmnz);
			Assert.AreEqual(ShtType.spByPost, obj.Sht);
			Assert.AreEqual(0, obj.Shd);
		}

		[Test]
		public void ParseProgramSectionLineTest_Iso_DefaultValues()
		{
			string code = "@ ISO, \"\", \"\", 50632145, \"\", 0 : \"\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Iso>(bj);
			Iso obj = (Iso)bj;
			Assert.AreEqual("ISO", obj.BppName);
			Assert.AreEqual(50632145, obj.Id);
			Assert.AreEqual("", obj.IsoText);
		}

		[Test]
		public void ParseProgramSectionLineTest_Offset_DefaultValues()
		{
			string code = "@ OFFSET, \"\", \"\", 53036123, \"\", 0 : 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Offset>(bj);
			Offset obj = (Offset)bj;
			Assert.AreEqual("OFFSET", obj.BppName);
			Assert.AreEqual(53036123, obj.Id);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(false, obj.Shw);
		}

		[Test]
		public void ParseProgramSectionLineTest_PutProg_DefaultValues()
		{
			string code = "@ PUTPROG, \"\", \"\", 7563067, \"\", 0 : \"P1001\", \"\", -1, -1, -1, 0, 0, 1, 1, 1, 0, 0, 0, 0, \"\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<PutProg>(bj);
			PutProg obj = (PutProg)bj;
			Assert.AreEqual("PUTPROG", obj.BppName);
			Assert.AreEqual(7563067, obj.IntId);
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

		[Test]
		public void ParseProgramSectionLineTest_Rotate_DefaultValues()
		{
			string code = "@ ROTATE, \"\", \"\", 958745, \"\", 0 : 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Rotate>(bj);
			Rotate obj = (Rotate)bj;
			Assert.AreEqual("ROTATE", obj.BppName);
			Assert.AreEqual(958745, obj.Id);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Ar);
		}

		[Test]
		public void ParseProgramSectionLineTest_Scale_DefaultValues()
		{
			string code = "@ SCALE, \"\", \"\", 8628710, \"\", 0 : 0, 0, 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Scale>(bj);
			Scale obj = (Scale)bj;
			Assert.AreEqual("SCALE", obj.BppName);
			Assert.AreEqual(8628710, obj.Id);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
			Assert.AreEqual(0, obj.Fct);
			Assert.AreEqual(0, obj.Nu);
		}

		[Test]
		public void ParseProgramSectionLineTest_Shift_DefaultValues()
		{
			string code = "@ SHIFT, \"\", \"\", 10549531, \"\", 0 : 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<Shift>(bj);
			Shift obj = (Shift)bj;
			Assert.AreEqual("SHIFT", obj.BppName);
			Assert.AreEqual(10549531, obj.Id);
			Assert.AreEqual(0, obj.X);
			Assert.AreEqual(0, obj.Y);
		}

		[Test]
		public void ParseProgramSectionLineTest_WFC_DefaultValues()
		{
			string code = "@ WFC, \"\", \"\", 27836922, \"\", 0 : 6, 200, 200, 0, 0, 18, 0, 90, 200, 2, 1, 0, 0, 1, 0, \"WFC\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<WFC>(bj);
			WFC obj = (WFC)bj;
			Assert.AreEqual("WFC", obj.BppName);
			Assert.AreEqual(27836922, obj.Id);
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

		[Test]
		public void ParseProgramSectionLineTest_WFG_DefaultValues()
		{
			string code = "@ WFG, \"\", \"\", 49205706, \"\", 0 : 6, \"\", 0, 0, 0, 1, 0, \"WFG\", 0, 0";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<WFG>(bj);
			WFG obj = (WFG)bj;
			Assert.AreEqual("WFG", obj.BppName);
			Assert.AreEqual(49205706, obj.Id);
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

		[Test]
		public void ParseProgramSectionLineTest_WFGL_DefaultValues()
		{
			string code = "@ WFGL, \"\", \"\", 40198173, \"\", 0 : 6, \"\", 0, 0, \"WFGL\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<WFGL>(bj);
			WFGL obj = (WFGL)bj;
			Assert.AreEqual("WFGL", obj.BppName);
			Assert.AreEqual(40198173, obj.Id);
			Assert.AreEqual(6, obj.SideId);
			Assert.AreEqual("", obj.Giz);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual("WFGL", obj.Lay);
		}

		[Test]
		public void ParseProgramSectionLineTest_WFGPS_DefaultValues()
		{
			string code = "@ WFGPS, \"\", \"\", 26239245, \"\", 0 : 6, \"\", \"\", 0, 0, 0, \"WFGPS\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<WFGPS>(bj);
			WFGPS obj = (WFGPS)bj;
			Assert.AreEqual("WFGPS", obj.BppName);
			Assert.AreEqual(26239245, obj.Id);
			Assert.AreEqual(6, obj.SideId);
			Assert.AreEqual("", obj.Gid);
			Assert.AreEqual("", obj.Giz);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Vf);
			Assert.AreEqual(false, obj.Ps);
			Assert.AreEqual("WFGPS", obj.Lay);
		}

		[Test]
		public void ParseProgramSectionLineTest_WFL_DefaultValues()
		{
			string code = "@ WFL, \"\", \"\", 34826618, \"\", 0 : 7, 200, 0, 0, 0, 135, 282.85, 18, 1, 0, 0, 0, 1, 0, 1, \"WFL\"";
			var bj = ParserBpp.ParseProgramSectionLine(code);
			Assert.IsInstanceOf<WFL>(bj);
			WFL obj = (WFL)bj;
			Assert.AreEqual("WFL", obj.BppName);
			Assert.AreEqual(34826618, obj.Id);
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