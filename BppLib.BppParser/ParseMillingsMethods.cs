using System;
using BppLib.Core;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BppLib.BppParser
{
    public static partial class ParserBpp
    {
		/// <summary> Parses the line of code and returns the <c>GeoText</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>GeoText</c> instance.</returns>
		public static GeoText  ParseGeoText(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			GeoText obj = new GeoText();
			obj.IntId = id;
			obj.Id = values[0].Trim().Trim('"');
			obj.Side = ConvertToInt(values[1]);
			obj.Crn = values[2].Trim().Trim('"');
			obj.Txt = values[3].Trim().Trim('"');
			obj.X = ConvertToDouble(values[4]);
			obj.Y = ConvertToDouble(values[5]);
			obj.Z = ConvertToDouble(values[6]);
			obj.Ang = ConvertToDouble(values[7]);
			obj.Vrs =(TextDirection)ConvertToInt(values[8]);
			obj.Aln =(TextAlignment)ConvertToInt(values[9]);
			obj.Acc = ConvertToInt(values[10]);
			obj.Cir =(values[11].Trim() == "1");
			obj.Rds = ConvertToDouble(values[12]);
			obj.Pst =(TextPosition)ConvertToInt(values[13]);
			obj.Fnt = values[14].Trim().Trim('"');
			obj.Sze = ConvertToDouble(values[15]);
			obj.Bol =(values[16].Trim() == "1");
			obj.Itl =(values[17].Trim() == "1");
			obj.Udl =(values[18].Trim() == "1");
			obj.Str =(values[19].Trim() == "1");
			obj.Wgh = ConvertToDouble(values[20]);
			obj.Chs = ConvertToInt(values[21]);
			obj.Rty =(Repetition)ConvertToInt(values[22]);
			obj.Dx = ConvertToDouble(values[23]);
			obj.Dy = ConvertToDouble(values[24]);
			obj.R = ConvertToDouble(values[25]);
			obj.A = ConvertToDouble(values[26]);
			obj.Da = ConvertToDouble(values[27]);
			obj.Nrp = ConvertToInt(values[28]);
			obj.Xrc = ConvertToInt(values[29]);
			obj.Yrc = ConvertToInt(values[30]);
			obj.Arp = ConvertToInt(values[31]);
			obj.Lrp = ConvertToInt(values[32]);
			obj.Er =(values[33].Trim() == "1");
			obj.Rdl =(values[34].Trim() == "1");
			obj.Lay = values[35].Trim().Trim('"');
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>OffGeo</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>OffGeo</c> instance.</returns>
		public static OffGeo  ParseOffGeo(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			OffGeo obj = new OffGeo();
			obj.IntId = id;
			obj.Id = values[0].Trim().Trim('"');
			obj.Gid = values[1].Trim().Trim('"');
			obj.Sil = values[2].Trim().Trim('"');
			obj.Lay = values[3].Trim().Trim('"');
			obj.Ofs = ConvertToDouble(values[4]);
			obj.Shc =(values[5].Trim() == "1");
			obj.Osl =(OffsetSelectionType)ConvertToInt(values[6]);
			obj.Ltp =(values[7].Trim() == "1");
			obj.Rv =(values[8].Trim() == "1");
			obj.Crt =(OffsetCompensationType)ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Pock</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Pock</c> instance.</returns>
		public static Pock  ParsePock(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Pock obj = new Pock();
			obj.IntId = id;
			obj.Gid = values[0].Trim().Trim('"');
			obj.Isl = values[1].Trim().Trim('"');
			obj.Dia = ConvertToDouble(values[2]);
			obj.Dp = ConvertToDouble(values[3]);
			obj.Iso = values[4].Trim().Trim('"');
			obj.Opt =(values[5].Trim() == "1");
			obj.Typ =(PocketType)ConvertToInt(values[6]);
			obj.Dlt = ConvertToDouble(values[7]);
			obj.N = ConvertToInt(values[8]);
			obj.A = ConvertToDouble(values[9]);
			obj.Tc =(values[10].Trim() == "1");
			obj.Cki =(values[11].Trim() == "1");
			obj.Zst = ConvertToDouble(values[12]);
			obj.Rv =(values[13].Trim() == "1");
			obj.Rrv =(values[14].Trim() == "1");
			obj.Cow =(values[15].Trim() == "1");
			obj.Ovm = ConvertToDouble(values[16]);
			obj.A21 = ConvertToInt(values[17]);
			obj.Z = ConvertToDouble(values[18]);
			obj.Tos =(values[19].Trim() == "1");
			obj.S21 = ConvertToInt(values[20]);
			obj.Id = values[21].Trim().Trim('"');
			obj.Dsp = ConvertToInt(values[22]);
			obj.Rsp = ConvertToInt(values[23]);
			obj.Ios = ConvertToInt(values[24]);
			obj.Wsp = ConvertToInt(values[25]);
			obj.Tnm = values[26].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[27]);
			obj.Tcl = ConvertToInt(values[28]);
			obj.Tin =(LeadInOutType)ConvertToInt(values[29]);
			obj.Ain = ConvertToInt(values[30]);
			obj.Cin =(values[31].Trim() == "1");
			obj.Tou =(LeadInOutType)ConvertToInt(values[32]);
			obj.Aou = ConvertToInt(values[33]);
			obj.Cou =(values[34].Trim() == "1");
			obj.Din = ConvertToDouble(values[35]);
			obj.Dou = ConvertToDouble(values[36]);
			obj.Sds = ConvertToDouble(values[37]);
			obj.Prp = ConvertToInt(values[38]);
			obj.Spi = values[39].Trim().Trim('"');
			obj.Shp = ConvertToInt(values[40]);
			obj.Ea21 =(values[41].Trim() == "1");
			obj.Cen = values[42].Trim().Trim('"');
			obj.Agg = values[43].Trim().Trim('"');
			obj.Lay = values[44].Trim().Trim('"');
			obj.Az = ConvertToDouble(values[45]);
			obj.Ar = ConvertToDouble(values[46]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[47]);
			obj.Bfc =(values[48].Trim() == "1");
			obj.Etb =(values[49].Trim() == "1");
			obj.Sdsf = ConvertToInt(values[50]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Rout</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Rout</c> instance.</returns>
		public static Rout  ParseRout(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Rout obj = new Rout();
			obj.IntId = id;
			obj.Id = values[0].Trim().Trim('"');
			obj.Side = ConvertToInt(values[1]);
			obj.Crn = values[2].Trim().Trim('"');
			obj.Z = ConvertToDouble(values[3]);
			obj.Dp = ConvertToDouble(values[4]);
			obj.Iso = values[5].Trim().Trim('"');
			obj.Opt =(values[6].Trim() == "1");
			obj.Dia = ConvertToDouble(values[7]);
			obj.Rty =(Repetition)ConvertToInt(values[8]);
			obj.Xrc = ConvertToDouble(values[9]);
			obj.Yrc = ConvertToDouble(values[10]);
			obj.Dx = ConvertToDouble(values[11]);
			obj.Dy = ConvertToDouble(values[12]);
			obj.R = ConvertToDouble(values[13]);
			obj.A = ConvertToDouble(values[14]);
			obj.Da = ConvertToDouble(values[15]);
			obj.Rdl =(values[16].Trim() == "1");
			obj.Nrp = ConvertToInt(values[17]);
			obj.Az = ConvertToDouble(values[18]);
			obj.Ar = ConvertToDouble(values[19]);
			obj.Zs = ConvertToDouble(values[20]);
			obj.Ze = ConvertToDouble(values[21]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[22]);
			obj.Thr =(values[23].Trim() == "1");
			obj.Rv =(values[24].Trim() == "1");
			obj.Ckt =(values[25].Trim() == "1");
			obj.Arp = ConvertToDouble(values[26]);
			obj.Lrp = ConvertToDouble(values[27]);
			obj.Er =(values[28].Trim() == "1");
			obj.Cow =(values[29].Trim() == "1");
			obj.Ovm = ConvertToDouble(values[30]);
			obj.A21 = ConvertToInt(values[31]);
			obj.Tos =(values[32].Trim() == "1");
			obj.Vtr = ConvertToInt(values[33]);
			obj.Dvr = ConvertToDouble(values[34]);
			obj.Otr = ConvertToInt(values[35]);
			obj.Svr = ConvertToDouble(values[36]);
			obj.Cof =(values[37].Trim() == "1");
			obj.Dof = ConvertToDouble(values[38]);
			obj.Gip =(values[39].Trim() == "1");
			obj.Lsv = ConvertToInt(values[40]);
			obj.S21 = ConvertToInt(values[41]);
			obj.Azs = ConvertToDouble(values[42]);
			obj.Dsp = ConvertToInt(values[43]);
			obj.Rsp = ConvertToInt(values[44]);
			obj.Ios = ConvertToInt(values[45]);
			obj.Wsp = ConvertToInt(values[46]);
			obj.Tnm = values[47].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[48]);
			obj.Tcl = ConvertToInt(values[49]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[50]);
			obj.Tin =(LeadInOutType)ConvertToInt(values[51]);
			obj.Ain = ConvertToInt(values[52]);
			obj.Cin =(values[53].Trim() == "1");
			obj.Gin = ConvertToDouble(values[54]);
			obj.Tbi =(values[55].Trim() == "1");
			obj.Tli = ConvertToDouble(values[56]);
			obj.Tqi = ConvertToDouble(values[57]);
			obj.Tou =(LeadInOutType)ConvertToInt(values[58]);
			obj.Aou = ConvertToInt(values[59]);
			obj.Cou =(values[60].Trim() == "1");
			obj.Gou = ConvertToInt(values[61]);
			obj.Tbo =(values[62].Trim() == "1");
			obj.Tlo = ConvertToDouble(values[63]);
			obj.Tqo = ConvertToDouble(values[64]);
			obj.Din = ConvertToDouble(values[65]);
			obj.Dou = ConvertToDouble(values[66]);
			obj.Sds = ConvertToDouble(values[67]);
			obj.Prp = ConvertToInt(values[68]);
			obj.Bdr =(values[69].Trim() == "1");
			obj.Spi = values[70].Trim().Trim('"');
			obj.Sc =(values[71].Trim() == "1");
			obj.Swi =(values[72].Trim() == "1");
			obj.Blw =(values[73].Trim() == "1");
			obj.Prs =(values[74].Trim() == "1");
			obj.Bfc =(values[75].Trim() == "1");
			obj.Shp = ConvertToInt(values[76]);
			obj.Swp =(values[77].Trim() == "1");
			obj.Csp = ConvertToInt(values[78]);
			obj.Udt =(values[79].Trim() == "1");
			obj.Tdt = values[80].Trim().Trim('"');
			obj.Ddt = ConvertToDouble(values[81]);
			obj.Sdt = ConvertToDouble(values[82]);
			obj.Idt = ConvertToDouble(values[83]);
			obj.Fdt = ConvertToDouble(values[84]);
			obj.Rdt = ConvertToInt(values[85]);
			obj.Ea21 =(values[86].Trim() == "1");
			obj.Cen = values[87].Trim().Trim('"');
			obj.Agg = values[88].Trim().Trim('"');
			obj.Lay = values[89].Trim().Trim('"');
			obj.Eecs = ConvertToInt(values[90]);
			obj.Pdin = ConvertToDouble(values[91]);
			obj.Pdu = ConvertToDouble(values[92]);
			obj.Pcin = ConvertToDouble(values[93]);
			obj.Pcu = ConvertToDouble(values[94]);
			obj.Pmol = ConvertToInt(values[95]);
			obj.Aux = ConvertToInt(values[96]);
			obj.Crr =(values[97].Trim() == "1");
			obj.Nebs =(values[98].Trim() == "1");
			obj.Etb =(values[99].Trim() == "1");
			obj.Fxd =(values[100].Trim() == "1");
			obj.Fxda = ConvertToInt(values[101]);
			obj.Kdt =(values[102].Trim() == "1");
			obj.Eml =(values[103].Trim() == "1");
			obj.Etg =(values[104].Trim() == "1");
			obj.Rtas =(values[105].Trim() == "1");
			obj.Rdin =(values[106].Trim() == "1");
			obj.Sdsf = ConvertToInt(values[107]);
			obj.Incstp =(values[108].Trim() == "1");
			obj.Etgt = ConvertToDouble(values[109]);
			obj.Ajt =(values[110].Trim() == "1");
			obj.Ion =(values[111].Trim() == "1");
			obj.Lubmnz =(values[112].Trim() == "1");
			obj.Sht =(ShtType)ConvertToInt(values[113]);
			obj.Shd = ConvertToInt(values[114]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>RoutG</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>RoutG</c> instance.</returns>
		public static RoutG  ParseRoutG(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			RoutG obj = new RoutG();
			obj.IntId = id;
			obj.Gid = values[0].Trim().Trim('"');
			obj.Id = values[1].Trim().Trim('"');
			obj.Z = ConvertToDouble(values[3]);
			obj.Dp = ConvertToDouble(values[4]);
			obj.Iso = values[5].Trim().Trim('"');
			obj.Opt =(values[6].Trim() == "1");
			obj.Dia = ConvertToDouble(values[7]);
			obj.Az = ConvertToDouble(values[18]);
			obj.Ar = ConvertToDouble(values[19]);
			obj.Zs = ConvertToDouble(values[20]);
			obj.Ze = ConvertToDouble(values[21]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[22]);
			obj.Thr =(values[23].Trim() == "1");
			obj.Rv =(values[24].Trim() == "1");
			obj.Ckt =(values[25].Trim() == "1");
			obj.Cow =(values[28].Trim() == "1");
			obj.Sil = values[29].Trim().Trim('"');
			obj.Ovm = ConvertToDouble(values[30]);
			obj.A21 = ConvertToInt(values[31]);
			obj.Lng = ConvertToDouble(values[32]);
			obj.Lpr =(values[33].Trim() == "1");
			obj.Tos =(values[34].Trim() == "1");
			obj.Vtr = ConvertToInt(values[35]);
			obj.Dvr = ConvertToDouble(values[36]);
			obj.Otr = ConvertToInt(values[37]);
			obj.Svr = ConvertToDouble(values[38]);
			obj.Cof =(values[39].Trim() == "1");
			obj.Dof = ConvertToDouble(values[40]);
			obj.Gip =(values[41].Trim() == "1");
			obj.Lsv = ConvertToInt(values[42]);
			obj.S21 = ConvertToInt(values[43]);
			obj.Azs = ConvertToDouble(values[44]);
			obj.Dsp = ConvertToInt(values[45]);
			obj.Rsp = ConvertToInt(values[46]);
			obj.Ios = ConvertToInt(values[47]);
			obj.Wsp = ConvertToInt(values[48]);
			obj.Tnm = values[49].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[50]);
			obj.Tcl = ConvertToInt(values[51]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[52]);
			obj.Tin =(LeadInOutType)ConvertToInt(values[53]);
			obj.Ain = ConvertToInt(values[54]);
			obj.Cin =(values[55].Trim() == "1");
			obj.Gin = ConvertToDouble(values[56]);
			obj.Tbi =(values[57].Trim() == "1");
			obj.Tli = ConvertToDouble(values[58]);
			obj.Tqi = ConvertToDouble(values[59]);
			obj.Tou =(LeadInOutType)ConvertToInt(values[60]);
			obj.Aou = ConvertToInt(values[61]);
			obj.Cou =(values[62].Trim() == "1");
			obj.Gou = ConvertToInt(values[63]);
			obj.Tbo =(values[64].Trim() == "1");
			obj.Tlo = ConvertToDouble(values[65]);
			obj.Tqo = ConvertToDouble(values[66]);
			obj.Din = ConvertToDouble(values[67]);
			obj.Dou = ConvertToDouble(values[68]);
			obj.Sds = ConvertToDouble(values[69]);
			obj.Prp = ConvertToInt(values[70]);
			obj.Bdr =(values[71].Trim() == "1");
			obj.Spi = values[72].Trim().Trim('"');
			obj.Sc =(values[73].Trim() == "1");
			obj.Swi =(values[74].Trim() == "1");
			obj.Blw =(values[75].Trim() == "1");
			obj.Prs =(values[76].Trim() == "1");
			obj.Bfc =(values[77].Trim() == "1");
			obj.Shp = ConvertToInt(values[78]);
			obj.Swp =(values[79].Trim() == "1");
			obj.Csp = ConvertToInt(values[80]);
			obj.Udt =(values[81].Trim() == "1");
			obj.Tdt = values[82].Trim().Trim('"');
			obj.Ddt = ConvertToDouble(values[83]);
			obj.Sdt = ConvertToDouble(values[84]);
			obj.Idt = ConvertToDouble(values[85]);
			obj.Fdt = ConvertToDouble(values[86]);
			obj.Rdt = ConvertToInt(values[87]);
			obj.Ea21 =(values[88].Trim() == "1");
			obj.Cen = values[89].Trim().Trim('"');
			obj.Agg = values[90].Trim().Trim('"');
			obj.Lay = values[91].Trim().Trim('"');
			obj.Eecs = ConvertToInt(values[92]);
			obj.Pdin = ConvertToDouble(values[93]);
			obj.Pdu = ConvertToDouble(values[94]);
			obj.Pcin = ConvertToDouble(values[95]);
			obj.Pcu = ConvertToDouble(values[96]);
			obj.Pmol = ConvertToInt(values[97]);
			obj.Aux = ConvertToInt(values[98]);
			obj.Crr =(values[99].Trim() == "1");
			obj.Nebs =(values[100].Trim() == "1");
			obj.Etb =(values[101].Trim() == "1");
			obj.Fxd =(values[102].Trim() == "1");
			obj.Fxda = ConvertToInt(values[103]);
			obj.Kdt =(values[104].Trim() == "1");
			obj.Eml =(values[105].Trim() == "1");
			obj.Etg =(values[106].Trim() == "1");
			obj.Rtas =(values[107].Trim() == "1");
			obj.Rdin =(values[108].Trim() == "1");
			obj.Ims = ConvertToInt(values[109]);
			obj.Sdsf = ConvertToInt(values[110]);
			obj.Incstp =(values[111].Trim() == "1");
			obj.Etgt = ConvertToDouble(values[112]);
			obj.Ajt =(values[113].Trim() == "1");
			obj.Ion =(values[114].Trim() == "1");
			obj.Lubmnz =(values[115].Trim() == "1");
			obj.Sht =(ShtType)ConvertToInt(values[116]);
			obj.Shd = ConvertToInt(values[117]);
			return obj;
		}


    }
}