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
		/// <summary> Parses lines of code and returns the <c>Geo</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Geo</c> instance.</returns>
		public static Geo ParseGeo(string[] code)
		{
			Geo obj = new Geo();
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
					if (name == "DP") obj.Dp = ConvertToDouble(value);
					if (name == "RTY") obj.Rty= (Repetition)Enum.Parse(typeof(Repetition),value);
					if (name == "XRC") obj.Xrc = ConvertToDouble(value);
					if (name == "YRC") obj.Yrc = ConvertToDouble(value);
					if (name == "DX") obj.Dx = ConvertToDouble(value);
					if (name == "DY") obj.Dy = ConvertToDouble(value);
					if (name == "R") obj.R = ConvertToDouble(value);
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "DA") obj.Da = ConvertToDouble(value);
					if (name == "RDL") obj.Rdl= ((value == "1") || (value == "YES"));
					if (name == "NRP") obj.Nrp = ConvertToInt(value);
					if (name == "ARP") obj.Arp = ConvertToInt(value);
					if (name == "LRP") obj.Lrp = ConvertToInt(value);
					if (name == "ER") obj.Er= ((value == "1") || (value == "YES"));
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "COW") obj.Cow= ((value == "1") || (value == "YES"));
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "CRC") obj.Crc= (ToolCorrection)Enum.Parse(typeof(ToolCorrection),value);
				}
			}
			return obj;
		}
	}
}
