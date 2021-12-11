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
		/// <summary> Parses lines of code and returns the <c>Pock</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Pock</c> instance.</returns>
		public static Pock ParsePock(string[] code)
		{
			Pock obj = new Pock();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "GID") obj.Gid = value.Trim('"');
					if (name == "ISL") obj.Isl = value.Trim('"');
					if (name == "DIA") obj.Dia = ConvertToDouble(value);
					if (name == "DP") obj.Dp = ConvertToDouble(value);
					if (name == "ISO") obj.Iso = value.Trim('"');
					if (name == "OPT") obj.Opt= ((value == "1") || (value == "YES"));
					if (name == "TYP") obj.Typ= (PocketType)Enum.Parse(typeof(PocketType),value);
					if (name == "DLT") obj.Dlt = ConvertToDouble(value);
					if (name == "N") obj.N = ConvertToInt(value);
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "TC") obj.Tc= ((value == "1") || (value == "YES"));
					if (name == "CKI") obj.Cki= ((value == "1") || (value == "YES"));
					if (name == "ZST") obj.Zst = ConvertToDouble(value);
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "RRV") obj.Rrv= ((value == "1") || (value == "YES"));
					if (name == "COW") obj.Cow= ((value == "1") || (value == "YES"));
					if (name == "OVM") obj.Ovm = ConvertToDouble(value);
					if (name == "A21") obj.A21 = ConvertToInt(value);
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "TOS") obj.Tos= ((value == "1") || (value == "YES"));
					if (name == "S21") obj.S21 = ConvertToInt(value);
					if (name == "ID") obj.Id = value.Trim('"');
					if (name == "DSP") obj.Dsp = ConvertToInt(value);
					if (name == "RSP") obj.Rsp = ConvertToInt(value);
					if (name == "IOS") obj.Ios = ConvertToInt(value);
					if (name == "WSP") obj.Wsp = ConvertToInt(value);
					if (name == "TNM") obj.Tnm = value.Trim('"');
					if (name == "TTP") obj.Ttp = ConvertToInt(value);
					if (name == "TCL") obj.Tcl = ConvertToInt(value);
					if (name == "TIN") obj.Tin= (LeadInOutType)Enum.Parse(typeof(LeadInOutType),value);
					if (name == "AIN") obj.Ain = ConvertToInt(value);
					if (name == "CIN") obj.Cin= ((value == "1") || (value == "YES"));
					if (name == "TOU") obj.Tou= (LeadInOutType)Enum.Parse(typeof(LeadInOutType),value);
					if (name == "AOU") obj.Aou = ConvertToInt(value);
					if (name == "COU") obj.Cou= ((value == "1") || (value == "YES"));
					if (name == "DIN") obj.Din = ConvertToDouble(value);
					if (name == "DOU") obj.Dou = ConvertToDouble(value);
					if (name == "SDS") obj.Sds = ConvertToDouble(value);
					if (name == "PRP") obj.Prp = ConvertToInt(value);
					if (name == "SPI") obj.Spi = value.Trim('"');
					if (name == "SHP") obj.Shp = ConvertToInt(value);
					if (name == "EA21") obj.Ea21= ((value == "1") || (value == "YES"));
					if (name == "CEN") obj.Cen = value.Trim('"');
					if (name == "AGG") obj.Agg = value.Trim('"');
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "AZ") obj.Az = ConvertToDouble(value);
					if (name == "AR") obj.Ar = ConvertToDouble(value);
					if (name == "CKA") obj.Cka= (InclinationRotationType)Enum.Parse(typeof(InclinationRotationType),value);
					if (name == "BFC") obj.Bfc= ((value == "1") || (value == "YES"));
					if (name == "ETB") obj.Etb= ((value == "1") || (value == "YES"));
					if (name == "SDSF") obj.Sdsf = ConvertToInt(value);
				}
			}
			return obj;
		}
	}
}
