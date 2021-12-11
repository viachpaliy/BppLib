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
		/// <summary> Parses lines of code and returns the <c>S32</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>S32</c> instance.</returns>
		public static S32 ParseS32(string[] code)
		{
			S32 obj = new S32();
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
					if (name == "DIR") obj.Dir= (Direction)Enum.Parse(typeof(Direction),value);
					if (name == "STP") obj.Stp = ConvertToDouble(value);
					if (name == "DST") obj.Dst = ConvertToDouble(value);
					if (name == "TYP") obj.Typ= (SystemBores)Enum.Parse(typeof(SystemBores),value);
					if (name == "ISO") obj.Iso = value.Trim('"');
					if (name == "OPT") obj.Opt= ((value == "1") || (value == "YES"));
					if (name == "XMI") obj.Xmi = ConvertToDouble(value);
					if (name == "COW") obj.Cow= ((value == "1") || (value == "YES"));
					if (name == "VTR") obj.Vtr = ConvertToInt(value);
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
				}
			}
			return obj;
		}
	}
}
