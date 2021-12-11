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
		/// <summary> Parses lines of code and returns the <c>WFG</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>WFG</c> instance.</returns>
		public static WFG ParseWFG(string[] code)
		{
			WFG obj = new WFG();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.SideId = Convert.ToInt32(value);
					if (name == "GID") obj.Gid = value.Trim('"');
					if (name == "PDF") obj.Pdf= ((value == "1") || (value == "YES"));
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "VF") obj.Vf= ((value == "1") || (value == "YES"));
					if (name == "VRT") obj.Vrt= ((value == "1") || (value == "YES"));
					if (name == "AZ") obj.Az = ConvertToDouble(value);
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "HGT") obj.Hgt = ConvertToDouble(value);
				}
			}
			return obj;
		}
	}
}
