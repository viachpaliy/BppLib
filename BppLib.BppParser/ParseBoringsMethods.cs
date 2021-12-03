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
		/// <summary> Parses the line of code and returns the <c>Bca</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Bca</c> instance.</returns>
		public static Bca  ParseBca(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Bca obj = new Bca();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Dia = ConvertToDouble(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Rty =(Repetition)ConvertToInt(values[8]);
			obj.Dx = ConvertToDouble(values[9]);
			obj.Dy = ConvertToDouble(values[10]);
			obj.R = ConvertToDouble(values[11]);
			obj.A = ConvertToDouble(values[12]);
			obj.Da = ConvertToDouble(values[13]);
			obj.Nrp = ConvertToInt(values[14]);
			obj.Iso = values[15].Trim().Trim('"');
			obj.Opt =(values[16].Trim() == "1");
			obj.Az = ConvertToDouble(values[17]);
			obj.Ar = ConvertToDouble(values[18]);
			obj.Ap =(values[19].Trim() == "1");
			obj.Cka =(InclinationRotationType)ConvertToInt(values[20]);
			obj.Xrc = ConvertToDouble(values[21]);
			obj.Yrc = ConvertToDouble(values[22]);
			obj.Arp = ConvertToDouble(values[23]);
			obj.Lrp = ConvertToDouble(values[24]);
			obj.Er =(values[25].Trim() == "1");
			obj.Md =(values[26].Trim() == "1");
			obj.Cow =(values[27].Trim() == "1");
			obj.A21 = ConvertToInt(values[28]);
			obj.Tos =(values[29].Trim() == "1");
			obj.Vtr = ConvertToInt(values[30]);
			obj.S21 = ConvertToInt(values[31]);
			obj.Id = values[32].Trim().Trim('"');
			obj.Azs = ConvertToDouble(values[33]);
			obj.Mac = values[34].Trim().Trim('"');
			obj.Tnm = values[35].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[36]);
			obj.Tcl = ConvertToInt(values[37]);
			obj.Rsp = ConvertToInt(values[38]);
			obj.Ios = ConvertToInt(values[39]);
			obj.Wsp = ConvertToInt(values[40]);
			obj.Spi = values[41].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[42]);
			obj.Dsp = ConvertToInt(values[43]);
			obj.Bfc =(values[44].Trim() == "1");
			obj.Shp = ConvertToInt(values[45]);
			obj.Ea21 =(values[46].Trim() == "1");
			obj.Cen = values[47].Trim().Trim('"');
			obj.Agg = values[48].Trim().Trim('"');
			obj.Lay = values[49].Trim().Trim('"');
			obj.Prs =(values[50].Trim() == "1");
			obj.Etb =(values[51].Trim() == "1");
			obj.Kdt =(values[52].Trim() == "1");
			obj.Dtas =(values[53].Trim() == "1");
			obj.Rmd =(RmdType)ConvertToInt(values[54]);
			obj.Dqt = ConvertToInt(values[55]);
			obj.Erdw =(values[56].Trim() == "1");
			obj.Dfw = ConvertToInt(values[57]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Bcl</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Bcl</c> instance.</returns>
		public static Bcl  ParseBcl(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Bcl obj = new Bcl();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Dia = ConvertToDouble(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Rty =(Repetition)ConvertToInt(values[8]);
			obj.Dx = ConvertToDouble(values[9]);
			obj.Dy = ConvertToDouble(values[10]);
			obj.R = ConvertToDouble(values[11]);
			obj.A = ConvertToDouble(values[12]);
			obj.Da = ConvertToDouble(values[13]);
			obj.Nrp = ConvertToInt(values[14]);
			obj.Iso = values[15].Trim().Trim('"');
			obj.Opt =(values[16].Trim() == "1");
			obj.Az = ConvertToDouble(values[17]);
			obj.Ar = ConvertToDouble(values[18]);
			obj.Ap =(values[19].Trim() == "1");
			obj.Cka =(InclinationRotationType)ConvertToInt(values[20]);
			obj.Xrc = ConvertToDouble(values[21]);
			obj.Yrc = ConvertToDouble(values[22]);
			obj.Arp = ConvertToDouble(values[23]);
			obj.Lrp = ConvertToDouble(values[24]);
			obj.Er =(values[25].Trim() == "1");
			obj.Md =(values[26].Trim() == "1");
			obj.Cow =(values[27].Trim() == "1");
			obj.A21 = ConvertToInt(values[28]);
			obj.Tos =(values[29].Trim() == "1");
			obj.Vtr = ConvertToInt(values[30]);
			obj.S21 = ConvertToInt(values[31]);
			obj.Id = values[32].Trim().Trim('"');
			obj.Azs = ConvertToDouble(values[33]);
			obj.Mac = values[34].Trim().Trim('"');
			obj.Tnm = values[35].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[36]);
			obj.Tcl = ConvertToInt(values[37]);
			obj.Rsp = ConvertToInt(values[38]);
			obj.Ios = ConvertToInt(values[39]);
			obj.Wsp = ConvertToInt(values[40]);
			obj.Spi = values[41].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[42]);
			obj.Dsp = ConvertToInt(values[43]);
			obj.Bfc =(values[44].Trim() == "1");
			obj.Shp = ConvertToInt(values[45]);
			obj.Ea21 =(values[46].Trim() == "1");
			obj.Cen = values[47].Trim().Trim('"');
			obj.Agg = values[48].Trim().Trim('"');
			obj.Lay = values[49].Trim().Trim('"');
			obj.Prs =(values[50].Trim() == "1");
			obj.Etb =(values[51].Trim() == "1");
			obj.Kdt =(values[52].Trim() == "1");
			obj.Dtas =(values[53].Trim() == "1");
			obj.Rmd =(RmdType)ConvertToInt(values[54]);
			obj.Dqt = ConvertToInt(values[55]);
			obj.Erdw =(values[56].Trim() == "1");
			obj.Dfw = ConvertToInt(values[57]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Bg</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Bg</c> instance.</returns>
		public static Bg  ParseBg(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Bg obj = new Bg();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Dia = ConvertToDouble(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Rty =(Repetition)ConvertToInt(values[8]);
			obj.Dx = ConvertToDouble(values[9]);
			obj.Dy = ConvertToDouble(values[10]);
			obj.R = ConvertToDouble(values[11]);
			obj.A = ConvertToDouble(values[12]);
			obj.Da = ConvertToDouble(values[13]);
			obj.Nrp = ConvertToInt(values[14]);
			obj.Iso = values[15].Trim().Trim('"');
			obj.Opt =(values[16].Trim() == "1");
			obj.Az = ConvertToDouble(values[17]);
			obj.Ar = ConvertToDouble(values[18]);
			obj.Ap =(values[19].Trim() == "1");
			obj.Cka =(InclinationRotationType)ConvertToInt(values[20]);
			obj.Xrc = ConvertToDouble(values[21]);
			obj.Yrc = ConvertToDouble(values[22]);
			obj.Arp = ConvertToDouble(values[23]);
			obj.Lrp = ConvertToDouble(values[24]);
			obj.Er =(values[25].Trim() == "1");
			obj.Md =(values[26].Trim() == "1");
			obj.Cow =(values[27].Trim() == "1");
			obj.A21 = ConvertToInt(values[28]);
			obj.Tos =(values[29].Trim() == "1");
			obj.Vtr = ConvertToInt(values[30]);
			obj.S21 = ConvertToInt(values[31]);
			obj.Id = values[32].Trim().Trim('"');
			obj.Azs = ConvertToDouble(values[33]);
			obj.Mac = values[34].Trim().Trim('"');
			obj.Tnm = values[35].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[36]);
			obj.Tcl = ConvertToInt(values[37]);
			obj.Rsp = ConvertToInt(values[38]);
			obj.Ios = ConvertToInt(values[39]);
			obj.Wsp = ConvertToInt(values[40]);
			obj.Spi = values[41].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[42]);
			obj.Dsp = ConvertToInt(values[43]);
			obj.Bfc =(values[44].Trim() == "1");
			obj.Shp = ConvertToInt(values[45]);
			obj.Ea21 =(values[46].Trim() == "1");
			obj.Cen = values[47].Trim().Trim('"');
			obj.Agg = values[48].Trim().Trim('"');
			obj.Lay = values[49].Trim().Trim('"');
			obj.Prs =(values[50].Trim() == "1");
			obj.Etb =(values[51].Trim() == "1");
			obj.Kdt =(values[52].Trim() == "1");
			obj.Dtas =(values[53].Trim() == "1");
			obj.Rmd =(RmdType)ConvertToInt(values[54]);
			obj.Dqt = ConvertToInt(values[55]);
			obj.Erdw =(values[56].Trim() == "1");
			obj.Dfw = ConvertToInt(values[57]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>BGeo</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>BGeo</c> instance.</returns>
		public static BGeo  ParseBGeo(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			BGeo obj = new BGeo();
			obj.IntId = id;
			obj.Gid = values[0].Trim().Trim('"');
			obj.Dp = ConvertToDouble(values[1]);
			obj.Dia = ConvertToDouble(values[2]);
			obj.Thr =(values[3].Trim() == "1");
			obj.Iso = values[4].Trim().Trim('"');
			obj.Opt =(values[5].Trim() == "1");
			obj.Az = ConvertToDouble(values[6]);
			obj.Ar = ConvertToDouble(values[7]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[8]);
			obj.Cow =(values[9].Trim() == "1");
			obj.Sil = values[10].Trim().Trim('"');
			obj.A21 = ConvertToInt(values[11]);
			obj.Z = ConvertToDouble(values[12]);
			obj.Tos =(values[13].Trim() == "1");
			obj.Vtr = ConvertToInt(values[14]);
			obj.S21 = ConvertToInt(values[15]);
			obj.Id = values[16].Trim().Trim('"');
			obj.Azs = ConvertToDouble(values[17]);
			obj.Mac = values[18].Trim().Trim('"');
			obj.Tnm = values[19].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[20]);
			obj.Tcl = ConvertToInt(values[21]);
			obj.Rsp = ConvertToInt(values[22]);
			obj.Ios = ConvertToInt(values[23]);
			obj.Wsp = ConvertToInt(values[24]);
			obj.Spi = values[25].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[26]);
			obj.Dsp = ConvertToInt(values[27]);
			obj.Bfc =(values[28].Trim() == "1");
			obj.Shp = ConvertToInt(values[29]);
			obj.Ea21 =(values[30].Trim() == "1");
			obj.Cen = values[31].Trim().Trim('"');
			obj.Agg = values[32].Trim().Trim('"');
			obj.Lay = values[33].Trim().Trim('"');
			obj.Prs =(values[34].Trim() == "1");
			obj.Etb =(values[35].Trim() == "1");
			obj.Kdt =(values[36].Trim() == "1");
			obj.Dtas =(values[37].Trim() == "1");
			obj.Rmd =(RmdType)ConvertToInt(values[38]);
			obj.Dqt = ConvertToInt(values[39]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Bh</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Bh</c> instance.</returns>
		public static Bh  ParseBh(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Bh obj = new Bh();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Dia = ConvertToDouble(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Rty =(Repetition)ConvertToInt(values[8]);
			obj.Dx = ConvertToDouble(values[9]);
			obj.Dy = ConvertToDouble(values[10]);
			obj.R = ConvertToDouble(values[11]);
			obj.A = ConvertToDouble(values[12]);
			obj.Da = ConvertToDouble(values[13]);
			obj.Nrp = ConvertToInt(values[14]);
			obj.Iso = values[15].Trim().Trim('"');
			obj.Opt =(values[16].Trim() == "1");
			obj.Az = ConvertToDouble(values[17]);
			obj.Ar = ConvertToDouble(values[18]);
			obj.Ap =(values[19].Trim() == "1");
			obj.Cka =(InclinationRotationType)ConvertToInt(values[20]);
			obj.Xrc = ConvertToDouble(values[21]);
			obj.Yrc = ConvertToDouble(values[22]);
			obj.Arp = ConvertToDouble(values[23]);
			obj.Lrp = ConvertToDouble(values[24]);
			obj.Er =(values[25].Trim() == "1");
			obj.Md =(values[26].Trim() == "1");
			obj.Cow =(values[27].Trim() == "1");
			obj.A21 = ConvertToInt(values[28]);
			obj.Tos =(values[29].Trim() == "1");
			obj.Vtr = ConvertToInt(values[30]);
			obj.S21 = ConvertToInt(values[31]);
			obj.Id = values[32].Trim().Trim('"');
			obj.Azs = ConvertToDouble(values[33]);
			obj.Mac = values[34].Trim().Trim('"');
			obj.Tnm = values[35].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[36]);
			obj.Tcl = ConvertToInt(values[37]);
			obj.Rsp = ConvertToInt(values[38]);
			obj.Ios = ConvertToInt(values[39]);
			obj.Wsp = ConvertToInt(values[40]);
			obj.Spi = values[41].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[42]);
			obj.Dsp = ConvertToInt(values[43]);
			obj.Bfc =(values[44].Trim() == "1");
			obj.Shp = ConvertToInt(values[45]);
			obj.Ea21 =(values[46].Trim() == "1");
			obj.Cen = values[47].Trim().Trim('"');
			obj.Agg = values[48].Trim().Trim('"');
			obj.Lay = values[49].Trim().Trim('"');
			obj.Prs =(values[50].Trim() == "1");
			obj.Etb =(values[51].Trim() == "1");
			obj.Kdt =(values[52].Trim() == "1");
			obj.Dtas =(values[53].Trim() == "1");
			obj.Rmd =(RmdType)ConvertToInt(values[54]);
			obj.Dqt = ConvertToInt(values[55]);
			obj.Erdw =(values[56].Trim() == "1");
			obj.Dfw = ConvertToInt(values[57]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Bv</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Bv</c> instance.</returns>
		public static Bv  ParseBv(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Bv obj = new Bv();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Dia = ConvertToDouble(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Rty =(Repetition)ConvertToInt(values[8]);
			obj.Dx = ConvertToDouble(values[9]);
			obj.Dy = ConvertToDouble(values[10]);
			obj.R = ConvertToDouble(values[11]);
			obj.A = ConvertToDouble(values[12]);
			obj.Da = ConvertToDouble(values[13]);
			obj.Nrp = ConvertToInt(values[14]);
			obj.Iso = values[15].Trim().Trim('"');
			obj.Opt =(values[16].Trim() == "1");
			obj.Az = ConvertToDouble(values[17]);
			obj.Ar = ConvertToDouble(values[18]);
			obj.Ap =(values[19].Trim() == "1");
			obj.Cka =(InclinationRotationType)ConvertToInt(values[20]);
			obj.Xrc = ConvertToDouble(values[21]);
			obj.Yrc = ConvertToDouble(values[22]);
			obj.Arp = ConvertToDouble(values[23]);
			obj.Lrp = ConvertToDouble(values[24]);
			obj.Er =(values[25].Trim() == "1");
			obj.Md =(values[26].Trim() == "1");
			obj.Cow =(values[27].Trim() == "1");
			obj.A21 = ConvertToInt(values[28]);
			obj.Tos =(values[29].Trim() == "1");
			obj.Vtr = ConvertToInt(values[30]);
			obj.S21 = ConvertToInt(values[31]);
			obj.Id = values[32].Trim().Trim('"');
			obj.Azs = ConvertToDouble(values[33]);
			obj.Mac = values[34].Trim().Trim('"');
			obj.Tnm = values[35].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[36]);
			obj.Tcl = ConvertToInt(values[37]);
			obj.Rsp = ConvertToInt(values[38]);
			obj.Ios = ConvertToInt(values[39]);
			obj.Wsp = ConvertToInt(values[40]);
			obj.Spi = values[41].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[42]);
			obj.Dsp = ConvertToInt(values[43]);
			obj.Bfc =(values[44].Trim() == "1");
			obj.Shp = ConvertToInt(values[45]);
			obj.Ea21 =(values[46].Trim() == "1");
			obj.Cen = values[47].Trim().Trim('"');
			obj.Agg = values[48].Trim().Trim('"');
			obj.Lay = values[49].Trim().Trim('"');
			obj.Prs =(values[50].Trim() == "1");
			obj.Etb =(values[51].Trim() == "1");
			obj.Kdt =(values[52].Trim() == "1");
			obj.Dtas =(values[53].Trim() == "1");
			obj.Rmd =(RmdType)ConvertToInt(values[54]);
			obj.Dqt = ConvertToInt(values[55]);
			obj.Erdw =(values[56].Trim() == "1");
			obj.Dfw = ConvertToInt(values[57]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>S32</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>S32</c> instance.</returns>
		public static S32  ParseS32(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			S32 obj = new S32();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Dia = ConvertToDouble(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Dir =(Direction)ConvertToInt(values[8]);
			obj.Stp = ConvertToDouble(values[9]);
			obj.Dst = ConvertToDouble(values[10]);
			obj.Typ =(SystemBores)ConvertToInt(values[11]);
			obj.Iso = values[12].Trim().Trim('"');
			obj.Opt =(values[13].Trim() == "1");
			obj.Xmi = ConvertToDouble(values[14]);
			obj.Cow =(values[15].Trim() == "1");
			obj.Vtr = ConvertToInt(values[16]);
			obj.Mac = values[17].Trim().Trim('"');
			obj.Tnm = values[18].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[19]);
			obj.Tcl = ConvertToInt(values[20]);
			obj.Rsp = ConvertToInt(values[21]);
			obj.Ios = ConvertToInt(values[22]);
			obj.Wsp = ConvertToInt(values[23]);
			obj.Spi = values[24].Trim().Trim('"');
			obj.Dds = ConvertToDouble(values[25]);
			obj.Dsp = ConvertToInt(values[26]);
			obj.Bfc =(values[27].Trim() == "1");
			obj.Shp = ConvertToInt(values[28]);
			obj.Ea21 =(values[29].Trim() == "1");
			obj.Cen = values[30].Trim().Trim('"');
			obj.Agg = values[31].Trim().Trim('"');
			obj.Lay = values[32].Trim().Trim('"');
			obj.Prs =(values[33].Trim() == "1");
			obj.Etb =(values[34].Trim() == "1");
			obj.Kdt =(values[35].Trim() == "1");
			obj.Dtas =(values[36].Trim() == "1");
			return obj;
		}

        
    }
}
