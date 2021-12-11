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
		/// <summary> Parses lines of code and returns the <c>GeoText</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>GeoText</c> instance.</returns>
		public static GeoText ParseGeoText(string[] code)
		{
			GeoText obj = new GeoText();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.Id = value.Trim('"');
					if (name == "SIDE") obj.Side = ConvertToInt(value);
					if (name == "CRN") obj.Crn = value.Trim('"');
					if (name == "TXT") obj.Txt = value.Trim('"');
					if (name == "X") obj.X = ConvertToDouble(value);
					if (name == "Y") obj.Y = ConvertToDouble(value);
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "ANG") obj.Ang = ConvertToDouble(value);
					if (name == "VRS") obj.Vrs= (TextDirection)Enum.Parse(typeof(TextDirection),value);
					if (name == "ALN") obj.Aln= (TextAlignment)Enum.Parse(typeof(TextAlignment),value);
					if (name == "ACC") obj.Acc = ConvertToInt(value);
					if (name == "CIR") obj.Cir= ((value == "1") || (value == "YES"));
					if (name == "RDS") obj.Rds = ConvertToDouble(value);
					if (name == "PST") obj.Pst= (TextPosition)Enum.Parse(typeof(TextPosition),value);
					if (name == "FNT") obj.Fnt = value.Trim('"');
					if (name == "SZE") obj.Sze = ConvertToDouble(value);
					if (name == "BOL") obj.Bol= ((value == "1") || (value == "YES"));
					if (name == "ITL") obj.Itl= ((value == "1") || (value == "YES"));
					if (name == "UDL") obj.Udl= ((value == "1") || (value == "YES"));
					if (name == "STR") obj.Str= ((value == "1") || (value == "YES"));
					if (name == "WGH") obj.Wgh = ConvertToDouble(value);
					if (name == "CHS") obj.Chs = ConvertToInt(value);
					if (name == "RTY") obj.Rty= (Repetition)Enum.Parse(typeof(Repetition),value);
					if (name == "DX") obj.Dx = ConvertToDouble(value);
					if (name == "DY") obj.Dy = ConvertToDouble(value);
					if (name == "R") obj.R = ConvertToDouble(value);
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "DA") obj.Da = ConvertToDouble(value);
					if (name == "NRP") obj.Nrp = ConvertToInt(value);
					if (name == "XRC") obj.Xrc = ConvertToInt(value);
					if (name == "YRC") obj.Yrc = ConvertToInt(value);
					if (name == "ARP") obj.Arp = ConvertToInt(value);
					if (name == "LRP") obj.Lrp = ConvertToInt(value);
					if (name == "ER") obj.Er= ((value == "1") || (value == "YES"));
					if (name == "RDL") obj.Rdl= ((value == "1") || (value == "YES"));
					if (name == "LAY") obj.Lay = value.Trim('"');
				}
			}
			return obj;
		}
	}
}
