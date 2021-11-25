using NUnit.Framework;
using BppLib.BppParser;
using BppLib.Core;

namespace BppParser.UnitTests
{
    [TestFixture]
    public class MillingsTests
    {
		[Test]
		public void ParseRoutTest()
		{
			string code = "@ ROUT, \"\", \"\", 515, \"\", 0 : \"P00198\", 0, \"1,3\", 0, 4.2, \"\", 1, 16, -1, 0, 0, 0, 0, 50, 0, 45, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, -1, 0, 0, 0, 0, 0, \"16X27\", 102, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 20, 20, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 5, 0, 20, 80, 60, 0, \"\", \"\", \"ROUT\", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0";
			var obj = ParserBpp.ParseRout(code);
			Assert.AreEqual( 515, obj.IntId);
			Assert.AreEqual( "P00198", obj.Id);
			Assert.AreEqual(0, obj.Side);
			Assert.AreEqual( "1,3", obj.Crn);
			Assert.AreEqual(0, obj.Z);
			Assert.AreEqual(4.2, obj.Dp);
			Assert.AreEqual( "", obj.Iso);
			Assert.AreEqual(true, obj.Opt);
			Assert.AreEqual(16, obj.Dia);
			Assert.AreEqual(Repetition.rpNO, obj.Rty);
			Assert.AreEqual(0, obj.Xrc);
			Assert.AreEqual(0, obj.Yrc);
			Assert.AreEqual(0, obj.Dx);
			Assert.AreEqual(0, obj.Dy);
			Assert.AreEqual(50, obj.R);
			Assert.AreEqual(0, obj.A);
			Assert.AreEqual(45, obj.Da);
			Assert.AreEqual(true, obj.Rdl);
			Assert.AreEqual(0, obj.Nrp);
			Assert.AreEqual(0, obj.Az);
			Assert.AreEqual(0, obj.Ar);
			Assert.AreEqual(0, obj.Zs);
			Assert.AreEqual(0, obj.Ze);
			Assert.AreEqual((InclinationRotationType) 0, obj.Cka);
			Assert.AreEqual(true, obj.Thr);
			Assert.AreEqual(false, obj.Rv);
			Assert.AreEqual(false, obj.Ckt);
			Assert.AreEqual(0, obj.Arp);
			Assert.AreEqual(0, obj.Lrp);
			Assert.AreEqual(false, obj.Er);
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
			Assert.AreEqual(false, obj.Gip);
			Assert.AreEqual(1, obj.Lsv);
			Assert.AreEqual(-1, obj.S21);
			Assert.AreEqual(0, obj.Azs);
			Assert.AreEqual(0, obj.Dsp);
			Assert.AreEqual(0, obj.Rsp);
			Assert.AreEqual(0, obj.Ios);
			Assert.AreEqual(0, obj.Wsp);
			Assert.AreEqual( "16X27", obj.Tnm);
			Assert.AreEqual(102, obj.Ttp);
			Assert.AreEqual(1, obj.Tcl);
			Assert.AreEqual((ToolCorrection) 2, obj.Crc);
			Assert.AreEqual((LeadInOutType) 0, obj.Tin);
			Assert.AreEqual(0, obj.Ain);
			Assert.AreEqual(false, obj.Cin);
			Assert.AreEqual(0, obj.Gin);
			Assert.AreEqual(false, obj.Tbi);
			Assert.AreEqual(0, obj.Tli);
			Assert.AreEqual(0, obj.Tqi);
			Assert.AreEqual((LeadInOutType) 0, obj.Tou);
			Assert.AreEqual(0, obj.Aou);
			Assert.AreEqual(false, obj.Cou);
			Assert.AreEqual(0, obj.Gou);
			Assert.AreEqual(false, obj.Tbo);
			Assert.AreEqual(0, obj.Tlo);
			Assert.AreEqual(0, obj.Tqo);
			Assert.AreEqual(20, obj.Din);
			Assert.AreEqual(20, obj.Dou);
			Assert.AreEqual(0, obj.Sds);
			Assert.AreEqual(0, obj.Prp);
			Assert.AreEqual(false, obj.Bdr);
			Assert.AreEqual( "", obj.Spi);
			Assert.AreEqual(false, obj.Sc);
			Assert.AreEqual(false, obj.Swi);
			Assert.AreEqual(false, obj.Blw);
			Assert.AreEqual(false, obj.Prs);
			Assert.AreEqual(false, obj.Bfc);
			Assert.AreEqual(0, obj.Shp);
			Assert.AreEqual(false, obj.Swp);
			Assert.AreEqual(0, obj.Csp);
			Assert.AreEqual(false, obj.Udt);
			Assert.AreEqual( "", obj.Tdt);
			Assert.AreEqual(5, obj.Ddt);
			Assert.AreEqual(0, obj.Sdt);
			Assert.AreEqual(20, obj.Idt);
			Assert.AreEqual(80, obj.Fdt);
			Assert.AreEqual(60, obj.Rdt);
			Assert.AreEqual(false, obj.Ea21);
			Assert.AreEqual( "", obj.Cen);
			Assert.AreEqual( "", obj.Agg);
			Assert.AreEqual( "ROUT", obj.Lay);
			Assert.AreEqual(0, obj.Eecs);
			Assert.AreEqual(0, obj.Pdin);
			Assert.AreEqual(0, obj.Pdu);
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
			Assert.AreEqual((ShtType) 99, obj.Sht);
			Assert.AreEqual(0, obj.Shd);
		}

        [Test]
		public void ParseRoutGTest()
		{
            string code = "@ ROUTG, \"\", \"\", 150770740, \"\", 0 : \"frez\", \"P1007\", 0, 0, 4.15, \"\", 1, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, -1, 0, 0, 0, 0, 0, \"16X27\", 102, 1, 2, 1, 45, 0, 0, 0, 0, 0, 1, 45, 0, 0, 0, 0, 0, 20, 20, 0, 0, 0, \"\", 0, 0, 0, 0, 0, 0, 0, 0, 0, \"\", 5, 0, 20, 80, 60, 0, \"\", \"\", \"ROUTG\", 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 99, 0";
            var obj = ParserBpp.ParseRoutG(code);
            Assert.AreEqual( "ROUTG", obj.Lay);
            Assert.AreEqual((ShtType) 99, obj.Sht);
            Assert.AreEqual(0.1, obj.Etgt);
            Assert.AreEqual(5, obj.Ddt);
			Assert.AreEqual(0, obj.Sdt);
			Assert.AreEqual(20, obj.Idt);
			Assert.AreEqual(80, obj.Fdt);
			Assert.AreEqual(60, obj.Rdt);
            Assert.AreEqual(20, obj.Din);
			Assert.AreEqual(20, obj.Dou);
            Assert.AreEqual( "16X27", obj.Tnm);
			Assert.AreEqual(102, obj.Ttp);
			Assert.AreEqual(1, obj.Tcl);
			Assert.AreEqual((ToolCorrection) 2, obj.Crc);
            Assert.AreEqual("frez", obj.Gid);
            Assert.AreEqual("P1007", obj.Id);
            Assert.AreEqual(4.15 , obj.Dp);
        }

    }
}