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
		/// <summary> Parses lines of code and returns the <c>WFGPS</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>WFGPS</c> instance.</returns>
		public static WFGPS ParseWFGPS(string[] code)
		{
			WFGPS obj = new WFGPS();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.SideId = ConvertToInt(value);
					if (name == "GID") obj.Gid = value.Trim('"');
					if (name == "GIZ") obj.Giz = value.Trim('"');
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "VF") obj.Vf= ((value == "1") || (value == "YES"));
					if (name == "PS") obj.Ps= ((value == "1") || (value == "YES"));
					if (name == "LAY") obj.Lay = value.Trim('"');
				}
			}
			return obj;
		}
	}
}
