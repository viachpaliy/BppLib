using System;
using BppLib.Core;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using Jurassic;

namespace BppLib.CixParser
{
	/// <summary> Class for parsing "bpp" files.</summary>
	public static partial class ParserCix
	{
		/// <summary> Parses lines of code and returns the <c>CutFR</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>CutFR</c> instance.</returns>
		public static CutFR ParseCutFR(string[] code)
		{
			CutFR obj = new CutFR();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "SIDE") obj.Side = ConvertToInt(value);
					if (name == "CRN") obj.Crn = value.Trim('"');
					if (name == "X") obj.X = ConvertToDouble(value);
					if (name == "Y") obj.Y = ConvertToDouble(value);
					if (name == "LX") obj.Lx = ConvertToDouble(value);
					if (name == "LY") obj.Ly = ConvertToDouble(value);
					if (name == "ISO") obj.Iso = value.Trim('"');
					if (name == "OPT") obj.Opt= ((value == "1") || (value == "YES"));
					if (name == "TH") obj.Th = ConvertToDouble(value);
					if (name == "DP") obj.Dp = ConvertToDouble(value);
					if (name == "AZ") obj.Az = ConvertToDouble(value);
					if (name == "CKA") obj.Cka= (InclinationRotationType)Enum.Parse(typeof(InclinationRotationType),value);
					if (name == "THR") obj.Thr= ((value == "1") || (value == "YES"));
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "TTK") obj.Ttk = ConvertToDouble(value);
					if (name == "OVM") obj.Ovm = ConvertToDouble(value);
					if (name == "VTR") obj.Vtr = ConvertToInt(value);
					if (name == "GIP") obj.Gip= ((value == "1") || (value == "YES"));
					if (name == "TNM") obj.Tnm = value.Trim('"');
					if (name == "TTP") obj.Ttp = ConvertToInt(value);
					if (name == "TCL") obj.Tcl = ConvertToInt(value);
					if (name == "RSP") obj.Rsp = ConvertToInt(value);
					if (name == "IOS") obj.Ios = ConvertToInt(value);
					if (name == "WSP") obj.Wsp = ConvertToInt(value);
					if (name == "SPI") obj.Spi = value.Trim('"');
					if (name == "BFC") obj.Bfc= ((value == "1") || (value == "YES"));
					if (name == "SHP") obj.Shp = ConvertToInt(value);
					if (name == "BRC") obj.Brc = ConvertToInt(value);
					if (name == "BDR") obj.Bdr= ((value == "1") || (value == "YES"));
					if (name == "PRV") obj.Prv= ((value == "1") || (value == "YES"));
					if (name == "NRV") obj.Nrv= ((value == "1") || (value == "YES"));
					if (name == "DIN") obj.Din = ConvertToDouble(value);
					if (name == "DOU") obj.Dou = ConvertToDouble(value);
					if (name == "CRC") obj.Crc= (ToolCorrection)Enum.Parse(typeof(ToolCorrection),value);
					if (name == "DSP") obj.Dsp = ConvertToInt(value);
					if (name == "CEN") obj.Cen = value.Trim('"');
					if (name == "AGG") obj.Agg = value.Trim('"');
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "ETB") obj.Etb= ((value == "1") || (value == "YES"));
					if (name == "KDT") obj.Kdt= ((value == "1") || (value == "YES"));
				}
			}
			return obj;
		}
	}
}
