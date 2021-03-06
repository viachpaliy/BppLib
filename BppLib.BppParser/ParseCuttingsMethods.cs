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
		/// <summary> Parses the line of code and returns the <c>CutF</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CutF</c> instance.</returns>
		public static CutF  ParseCutF(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CutF obj = new CutF();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.X = ConvertToDouble(values[1]);
			obj.Y = ConvertToDouble(values[2]);
			obj.Iso = values[3].Trim().Trim('"');
			obj.Opt =(values[4].Trim() == "1");
			obj.Th = ConvertToDouble(values[5]);
			obj.Dp = ConvertToDouble(values[6]);
			obj.Az = ConvertToDouble(values[7]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[8]);
			obj.Thr =(values[9].Trim() == "1");
			obj.Rv =(values[10].Trim() == "1");
			obj.Ttk = ConvertToDouble(values[11]);
			obj.Ovm = ConvertToDouble(values[12]);
			obj.Vtr = ConvertToInt(values[13]);
			obj.Gip =(values[14].Trim() == "1");
			obj.Tnm = values[15].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[16]);
			obj.Tcl = ConvertToInt(values[17]);
			obj.Rsp = ConvertToInt(values[18]);
			obj.Ios = ConvertToInt(values[19]);
			obj.Wsp = ConvertToInt(values[20]);
			obj.Spi = values[21].Trim().Trim('"');
			obj.Bfc =(values[22].Trim() == "1");
			obj.Shp = ConvertToInt(values[23]);
			obj.Brc = ConvertToInt(values[24]);
			obj.Bdr =(values[25].Trim() == "1");
			obj.Prv =(values[26].Trim() == "1");
			obj.Nrv =(values[27].Trim() == "1");
			obj.Din = ConvertToDouble(values[28]);
			obj.Dou = ConvertToDouble(values[29]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[30]);
			obj.Dsp = ConvertToInt(values[31]);
			obj.Cen = values[32].Trim().Trim('"');
			obj.Agg = values[33].Trim().Trim('"');
			obj.Lay = values[34].Trim().Trim('"');
			obj.Etb =(values[35].Trim() == "1");
			obj.Kdt =(values[36].Trim() == "1");
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>CutFR</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CutFR</c> instance.</returns>
		public static CutFR  ParseCutFR(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CutFR obj = new CutFR();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Lx = ConvertToDouble(values[4]);
			obj.Ly = ConvertToDouble(values[5]);
			obj.Iso = values[6].Trim().Trim('"');
			obj.Opt =(values[7].Trim() == "1");
			obj.Th = ConvertToDouble(values[8]);
			obj.Dp = ConvertToDouble(values[9]);
			obj.Az = ConvertToDouble(values[10]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[11]);
			obj.Thr =(values[12].Trim() == "1");
			obj.Rv =(values[13].Trim() == "1");
			obj.Ttk = ConvertToDouble(values[14]);
			obj.Ovm = ConvertToDouble(values[15]);
			obj.Vtr = ConvertToInt(values[16]);
			obj.Gip =(values[17].Trim() == "1");
			obj.Tnm = values[18].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[19]);
			obj.Tcl = ConvertToInt(values[20]);
			obj.Rsp = ConvertToInt(values[21]);
			obj.Ios = ConvertToInt(values[22]);
			obj.Wsp = ConvertToInt(values[23]);
			obj.Spi = values[24].Trim().Trim('"');
			obj.Bfc =(values[25].Trim() == "1");
			obj.Shp = ConvertToInt(values[26]);
			obj.Brc = ConvertToInt(values[27]);
			obj.Bdr =(values[28].Trim() == "1");
			obj.Prv =(values[29].Trim() == "1");
			obj.Nrv =(values[30].Trim() == "1");
			obj.Din = ConvertToDouble(values[31]);
			obj.Dou = ConvertToDouble(values[32]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[33]);
			obj.Dsp = ConvertToInt(values[34]);
			obj.Cen = values[35].Trim().Trim('"');
			obj.Agg = values[36].Trim().Trim('"');
			obj.Lay = values[37].Trim().Trim('"');
			obj.Etb =(values[38].Trim() == "1");
			obj.Kdt =(values[39].Trim() == "1");
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>CutG</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CutG</c> instance.</returns>
		public static CutG  ParseCutG(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CutG obj = new CutG();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.Typ =(CuttingType)ConvertToInt(values[6]);
			obj.L = ConvertToDouble(values[7]);
			obj.Ang = ConvertToDouble(values[8]);
			obj.Xe = ConvertToDouble(values[9]);
			obj.Ye = ConvertToDouble(values[10]);
			obj.Ze = ConvertToDouble(values[11]);
			obj.Az = ConvertToDouble(values[12]);
			obj.Iso = values[13].Trim().Trim('"');
			obj.Opt =(values[14].Trim() == "1");
			obj.Th = ConvertToDouble(values[15]);
			obj.Rty =(Repetition)ConvertToInt(values[16]);
			obj.Dx = ConvertToDouble(values[17]);
			obj.Dy = ConvertToDouble(values[18]);
			obj.R = ConvertToDouble(values[19]);
			obj.A = ConvertToDouble(values[20]);
			obj.Da = ConvertToDouble(values[21]);
			obj.Rdl =(values[22].Trim() == "1");
			obj.Nrp = ConvertToInt(values[23]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[24]);
			obj.Thr =(values[25].Trim() == "1");
			obj.Rv =(values[26].Trim() == "1");
			obj.Xrc = ConvertToDouble(values[27]);
			obj.Yrc = ConvertToDouble(values[28]);
			obj.Arp = ConvertToDouble(values[29]);
			obj.Lrp = ConvertToDouble(values[30]);
			obj.Er =(values[31].Trim() == "1");
			obj.Cow =(values[32].Trim() == "1");
			obj.Ttk = ConvertToDouble(values[33]);
			obj.Ovm = ConvertToDouble(values[34]);
			obj.Tos =(values[35].Trim() == "1");
			obj.Vtr = ConvertToInt(values[36]);
			obj.Gip =(values[37].Trim() == "1");
			obj.Id = values[38].Trim().Trim('"');
			obj.Tnm = values[39].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[40]);
			obj.Tcl = ConvertToInt(values[41]);
			obj.Rsp = ConvertToInt(values[42]);
			obj.Ios = ConvertToInt(values[43]);
			obj.Wsp = ConvertToInt(values[44]);
			obj.Spi = values[45].Trim().Trim('"');
			obj.Bfc =(values[46].Trim() == "1");
			obj.Shp = ConvertToInt(values[47]);
			obj.Brc = ConvertToInt(values[48]);
			obj.Bdr =(values[49].Trim() == "1");
			obj.Prv =(values[50].Trim() == "1");
			obj.Nrv =(values[51].Trim() == "1");
			obj.Din = ConvertToDouble(values[52]);
			obj.Dou = ConvertToDouble(values[53]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[54]);
			obj.Dsp = ConvertToInt(values[55]);
			obj.Cen = values[56].Trim().Trim('"');
			obj.Agg = values[57].Trim().Trim('"');
			obj.Lay = values[58].Trim().Trim('"');
			obj.Dvr = ConvertToDouble(values[59]);
			obj.Etb =(values[60].Trim() == "1");
			obj.Kdt =(values[61].Trim() == "1");
			obj.Ims = ConvertToInt(values[62]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>CutGeo</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CutGeo</c> instance.</returns>
		public static CutGeo  ParseCutGeo(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CutGeo obj = new CutGeo();
			obj.IntId = id;
			obj.Gid = values[0].Trim().Trim('"');
			obj.Dp = ConvertToDouble(values[1]);
			obj.Az = ConvertToDouble(values[2]);
			obj.Iso = values[3].Trim().Trim('"');
			obj.Opt =(values[4].Trim() == "1");
			obj.Th = ConvertToDouble(values[5]);
			obj.Cka =(InclinationRotationType)ConvertToInt(values[6]);
			obj.Thr =(values[7].Trim() == "1");
			obj.Rv =(values[8].Trim() == "1");
			obj.Cow =(values[9].Trim() == "1");
			obj.Sil = values[10].Trim().Trim('"');
			obj.Ttk = ConvertToDouble(values[11]);
			obj.Ovm = ConvertToDouble(values[12]);
			obj.Z = ConvertToDouble(values[13]);
			obj.Tos =(values[14].Trim() == "1");
			obj.Vtr = ConvertToInt(values[15]);
			obj.Gip =(values[16].Trim() == "1");
			obj.Id = values[17].Trim().Trim('"');
			obj.Tnm = values[18].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[19]);
			obj.Tcl = ConvertToInt(values[20]);
			obj.Rsp = ConvertToInt(values[21]);
			obj.Ios = ConvertToInt(values[22]);
			obj.Wsp = ConvertToInt(values[23]);
			obj.Spi = values[24].Trim().Trim('"');
			obj.Bfc =(values[25].Trim() == "1");
			obj.Shp = ConvertToInt(values[26]);
			obj.Brc = ConvertToInt(values[27]);
			obj.Bdr =(values[28].Trim() == "1");
			obj.Prv =(values[29].Trim() == "1");
			obj.Nrv =(values[30].Trim() == "1");
			obj.Din = ConvertToDouble(values[31]);
			obj.Dou = ConvertToDouble(values[32]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[33]);
			obj.Dsp = ConvertToInt(values[34]);
			obj.Cen = values[35].Trim().Trim('"');
			obj.Agg = values[36].Trim().Trim('"');
			obj.Lay = values[37].Trim().Trim('"');
			obj.Dvr = ConvertToDouble(values[38]);
			obj.Etb =(values[39].Trim() == "1");
			obj.Kdt =(values[40].Trim() == "1");
			obj.Ims = ConvertToInt(values[41]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>CutX</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CutX</c> instance.</returns>
		public static CutX  ParseCutX(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CutX obj = new CutX();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.L = ConvertToDouble(values[6]);
			obj.Nrp = ConvertToInt(values[7]);
			obj.D = ConvertToDouble(values[8]);
			obj.Iso = values[9].Trim().Trim('"');
			obj.Opt =(values[10].Trim() == "1");
			obj.Th = ConvertToDouble(values[11]);
			obj.Thr =(values[12].Trim() == "1");
			obj.Rv =(values[13].Trim() == "1");
			obj.Cow =(values[14].Trim() == "1");
			obj.Ttk = ConvertToDouble(values[15]);
			obj.Ovm = ConvertToDouble(values[16]);
			obj.Tos =(values[17].Trim() == "1");
			obj.Vtr = ConvertToInt(values[18]);
			obj.Gip =(values[19].Trim() == "1");
			obj.Tnm = values[20].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[21]);
			obj.Tcl = ConvertToInt(values[22]);
			obj.Rsp = ConvertToInt(values[23]);
			obj.Ios = ConvertToInt(values[24]);
			obj.Wsp = ConvertToInt(values[25]);
			obj.Spi = values[26].Trim().Trim('"');
			obj.Bfc =(values[27].Trim() == "1");
			obj.Shp = ConvertToInt(values[28]);
			obj.Brc = ConvertToInt(values[29]);
			obj.Bdr =(values[30].Trim() == "1");
			obj.Prv =(values[31].Trim() == "1");
			obj.Nrv =(values[32].Trim() == "1");
			obj.Din = ConvertToDouble(values[33]);
			obj.Dou = ConvertToDouble(values[34]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[35]);
			obj.Dsp = ConvertToInt(values[36]);
			obj.Cen = values[37].Trim().Trim('"');
			obj.Agg = values[38].Trim().Trim('"');
			obj.Lay = values[39].Trim().Trim('"');
			obj.Dvr = ConvertToDouble(values[40]);
			obj.Etb =(values[41].Trim() == "1");
			obj.Kdt =(values[42].Trim() == "1");
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>CutY</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CutY</c> instance.</returns>
		public static CutY  ParseCutY(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CutY obj = new CutY();
			obj.IntId = id;
			obj.Side = ConvertToInt(values[0]);
			obj.Crn = values[1].Trim().Trim('"');
			obj.X = ConvertToDouble(values[2]);
			obj.Y = ConvertToDouble(values[3]);
			obj.Z = ConvertToDouble(values[4]);
			obj.Dp = ConvertToDouble(values[5]);
			obj.L = ConvertToDouble(values[6]);
			obj.Nrp = ConvertToInt(values[7]);
			obj.D = ConvertToDouble(values[8]);
			obj.Iso = values[9].Trim().Trim('"');
			obj.Opt =(values[10].Trim() == "1");
			obj.Th = ConvertToDouble(values[11]);
			obj.Thr =(values[12].Trim() == "1");
			obj.Rv =(values[13].Trim() == "1");
			obj.Cow =(values[14].Trim() == "1");
			obj.Ttk = ConvertToDouble(values[15]);
			obj.Ovm = ConvertToDouble(values[16]);
			obj.Tos =(values[17].Trim() == "1");
			obj.Vtr = ConvertToInt(values[18]);
			obj.Gip =(values[19].Trim() == "1");
			obj.Tnm = values[20].Trim().Trim('"');
			obj.Ttp = ConvertToInt(values[21]);
			obj.Tcl = ConvertToInt(values[22]);
			obj.Rsp = ConvertToInt(values[23]);
			obj.Ios = ConvertToInt(values[24]);
			obj.Wsp = ConvertToInt(values[25]);
			obj.Spi = values[26].Trim().Trim('"');
			obj.Bfc =(values[27].Trim() == "1");
			obj.Shp = ConvertToInt(values[28]);
			obj.Brc = ConvertToInt(values[29]);
			obj.Bdr =(values[30].Trim() == "1");
			obj.Prv =(values[31].Trim() == "1");
			obj.Nrv =(values[32].Trim() == "1");
			obj.Din = ConvertToDouble(values[33]);
			obj.Dou = ConvertToDouble(values[34]);
			obj.Crc =(ToolCorrection)ConvertToInt(values[35]);
			obj.Dsp = ConvertToInt(values[36]);
			obj.Cen = values[37].Trim().Trim('"');
			obj.Agg = values[38].Trim().Trim('"');
			obj.Lay = values[39].Trim().Trim('"');
			obj.Dvr = ConvertToDouble(values[40]);
			obj.Etb =(values[41].Trim() == "1");
			obj.Kdt =(values[42].Trim() == "1");
			return obj;
		}

        
    }
}