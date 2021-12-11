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
		/// <summary> Parses lines of code and returns the <c>Bcl</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Bcl</c> instance.</returns>
		public static Bcl ParseBcl(string[] code)
		{
			Bcl obj = new Bcl();
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
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "DP") obj.Dp = ConvertToDouble(value);
					if (name == "DIA") obj.Dia = ConvertToDouble(value);
					if (name == "THR") obj.Thr= ((value == "1") || (value == "YES"));
					if (name == "RTY") obj.Rty= (Repetition)Enum.Parse(typeof(Repetition),value);
					if (name == "DX") obj.Dx = ConvertToDouble(value);
					if (name == "DY") obj.Dy = ConvertToDouble(value);
					if (name == "R") obj.R = ConvertToDouble(value);
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "DA") obj.Da = ConvertToDouble(value);
					if (name == "NRP") obj.Nrp = ConvertToInt(value);
					if (name == "ISO") obj.Iso = value.Trim('"');
					if (name == "OPT") obj.Opt= ((value == "1") || (value == "YES"));
					if (name == "AZ") obj.Az = ConvertToDouble(value);
					if (name == "AR") obj.Ar = ConvertToDouble(value);
					if (name == "AP") obj.Ap= ((value == "1") || (value == "YES"));
					if (name == "CKA") obj.Cka= (InclinationRotationType)Enum.Parse(typeof(InclinationRotationType),value);
					if (name == "XRC") obj.Xrc = ConvertToDouble(value);
					if (name == "YRC") obj.Yrc = ConvertToDouble(value);
					if (name == "ARP") obj.Arp = ConvertToDouble(value);
					if (name == "LRP") obj.Lrp = ConvertToDouble(value);
					if (name == "ER") obj.Er= ((value == "1") || (value == "YES"));
					if (name == "MD") obj.Md= ((value == "1") || (value == "YES"));
					if (name == "COW") obj.Cow= ((value == "1") || (value == "YES"));
					if (name == "A21") obj.A21 = ConvertToInt(value);
					if (name == "TOS") obj.Tos= ((value == "1") || (value == "YES"));
					if (name == "VTR") obj.Vtr = ConvertToInt(value);
					if (name == "S21") obj.S21 = ConvertToInt(value);
					if (name == "ID") obj.Id = value.Trim('"');
					if (name == "AZS") obj.Azs = ConvertToDouble(value);
					if (name == "MAC") obj.Mac = value.Trim('"');
					if (name == "TNM") obj.Tnm = value.Trim('"');
					if (name == "TTP") obj.Ttp = ConvertToInt(value);
					if (name == "TCL") obj.Tcl = ConvertToInt(value);
					if (name == "RSP") obj.Rsp = ConvertToInt(value);
					if (name == "IOS") obj.Ios = ConvertToInt(value);
					if (name == "WSP") obj.Wsp = ConvertToInt(value);
					if (name == "SPI") obj.Spi = value.Trim('"');
					if (name == "DDS") obj.Dds = ConvertToDouble(value);
					if (name == "DSP") obj.Dsp = ConvertToInt(value);
					if (name == "BFC") obj.Bfc= ((value == "1") || (value == "YES"));
					if (name == "SHP") obj.Shp = ConvertToInt(value);
					if (name == "EA21") obj.Ea21= ((value == "1") || (value == "YES"));
					if (name == "CEN") obj.Cen = value.Trim('"');
					if (name == "AGG") obj.Agg = value.Trim('"');
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "PRS") obj.Prs= ((value == "1") || (value == "YES"));
					if (name == "ETB") obj.Etb= ((value == "1") || (value == "YES"));
					if (name == "KDT") obj.Kdt= ((value == "1") || (value == "YES"));
					if (name == "DTAS") obj.Dtas= ((value == "1") || (value == "YES"));
					if (name == "RMD") obj.Rmd= (RmdType)Enum.Parse(typeof(RmdType),value);
					if (name == "DQT") obj.Dqt = ConvertToInt(value);
					if (name == "ERDW") obj.Erdw= ((value == "1") || (value == "YES"));
					if (name == "DFW") obj.Dfw = ConvertToInt(value);
				}
			}
			return obj;
		}
	}
}
