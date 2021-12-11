using NUnit.Framework;
using BppLib.CixParser;
using BppLib.Core;

namespace CixParser.UnitTests
{
	[TestFixture]
	public partial class ParseMethodsTests
	{
		[Test]
		public void RoutGTest()
		{
			string codeString = @"BEGIN MACRO
	NAME=ROUTG
	PARAM,NAME=GID,VALUE=""""
	PARAM,NAME=ID,VALUE=""P1001""
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=Z,VALUE=0
	PARAM,NAME=DP,VALUE=10
	PARAM,NAME=ISO,VALUE=""""
	PARAM,NAME=OPT,VALUE=YES
	PARAM,NAME=DIA,VALUE=18
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=AZ,VALUE=0
	PARAM,NAME=AR,VALUE=0
	PARAM,NAME=ZS,VALUE=0
	PARAM,NAME=ZE,VALUE=0
	PARAM,NAME=CKA,VALUE=azrNO
	PARAM,NAME=THR,VALUE=NO
	PARAM,NAME=RV,VALUE=NO
	PARAM,NAME=CKT,VALUE=NO
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=NU,VALUE=0
	PARAM,NAME=COW,VALUE=NO
	PARAM,NAME=SIL,VALUE=""""
	PARAM,NAME=OVM,VALUE=0
	PARAM,NAME=A21,VALUE=0
	PARAM,NAME=LNG,VALUE=0
	PARAM,NAME=LPR,VALUE=NO
	PARAM,NAME=TOS,VALUE=NO
	PARAM,NAME=VTR,VALUE=0
	PARAM,NAME=DVR,VALUE=0
	PARAM,NAME=OTR,VALUE=0
	PARAM,NAME=SVR,VALUE=0
	PARAM,NAME=COF,VALUE=NO
	PARAM,NAME=DOF,VALUE=0
	PARAM,NAME=GIP,VALUE=YES
	PARAM,NAME=LSV,VALUE=0
	PARAM,NAME=S21,VALUE=-1
	PARAM,NAME=AZS,VALUE=0
	PARAM,NAME=DSP,VALUE=0
	PARAM,NAME=RSP,VALUE=0
	PARAM,NAME=IOS,VALUE=0
	PARAM,NAME=WSP,VALUE=0
	PARAM,NAME=TNM,VALUE=""""
	PARAM,NAME=TTP,VALUE=103
	PARAM,NAME=TCL,VALUE=1
	PARAM,NAME=CRC,VALUE=2
	PARAM,NAME=TIN,VALUE=1
	PARAM,NAME=AIN,VALUE=45
	PARAM,NAME=CIN,VALUE=NO
	PARAM,NAME=GIN,VALUE=0
	PARAM,NAME=TBI,VALUE=NO
	PARAM,NAME=TLI,VALUE=0
	PARAM,NAME=TQI,VALUE=0
	PARAM,NAME=TOU,VALUE=1
	PARAM,NAME=AOU,VALUE=45
	PARAM,NAME=COU,VALUE=NO
	PARAM,NAME=GOU,VALUE=0
	PARAM,NAME=TBO,VALUE=NO
	PARAM,NAME=TLO,VALUE=0
	PARAM,NAME=TQO,VALUE=0
	PARAM,NAME=DIN,VALUE=0
	PARAM,NAME=DOU,VALUE=0
	PARAM,NAME=SDS,VALUE=0
	PARAM,NAME=PRP,VALUE=0
	PARAM,NAME=BDR,VALUE=NO
	PARAM,NAME=SPI,VALUE=""""
	PARAM,NAME=SC,VALUE=NO
	PARAM,NAME=SWI,VALUE=NO
	PARAM,NAME=BLW,VALUE=NO
	PARAM,NAME=PRS,VALUE=NO
	PARAM,NAME=BFC,VALUE=NO
	PARAM,NAME=SHP,VALUE=0
	PARAM,NAME=SWP,VALUE=NO
	PARAM,NAME=CSP,VALUE=0
	PARAM,NAME=UDT,VALUE=NO
	PARAM,NAME=TDT,VALUE=""""
	PARAM,NAME=DDT,VALUE=5
	PARAM,NAME=SDT,VALUE=0
	PARAM,NAME=IDT,VALUE=20
	PARAM,NAME=FDT,VALUE=80
	PARAM,NAME=RDT,VALUE=60
	PARAM,NAME=EA21,VALUE=NO
	PARAM,NAME=CEN,VALUE=""""
	PARAM,NAME=AGG,VALUE=""""
	PARAM,NAME=LAY,VALUE=""ROUTG""
	PARAM,NAME=EECS,VALUE=0
	PARAM,NAME=PDIN,VALUE=1
	PARAM,NAME=PDU,VALUE=1
	PARAM,NAME=PCIN,VALUE=0
	PARAM,NAME=PCU,VALUE=0
	PARAM,NAME=PMOL,VALUE=0
	PARAM,NAME=AUX,VALUE=0
	PARAM,NAME=CRR,VALUE=NO
	PARAM,NAME=NEBS,VALUE=NO
	PARAM,NAME=ETB,VALUE=NO
	PARAM,NAME=FXD,VALUE=NO
	PARAM,NAME=FXDA,VALUE=0
	PARAM,NAME=KDT,VALUE=NO
	PARAM,NAME=EML,VALUE=NO
	PARAM,NAME=ETG,VALUE=NO
	PARAM,NAME=RTAS,VALUE=NO
	PARAM,NAME=RDIN,VALUE=NO
	PARAM,NAME=IMS,VALUE=0
	PARAM,NAME=SDSF,VALUE=0
	PARAM,NAME=INCSTP,VALUE=NO
	PARAM,NAME=ETGT,VALUE=0.1
	PARAM,NAME=AJT,VALUE=NO
	PARAM,NAME=ION,VALUE=NO
	PARAM,NAME=LUBMNZ,VALUE=NO
	PARAM,NAME=SHT,VALUE=spByPost
	PARAM,NAME=SHD,VALUE=0
END MACRO";
			string[] code = codeString.Replace("\r\n","\n").Split('\n');
			var obj = ParserCix.ParseRoutG(code);
			Assert.AreEqual("ROUTG", obj.BppName);
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
	}
}
