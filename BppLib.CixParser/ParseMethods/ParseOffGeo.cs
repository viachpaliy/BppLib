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
		/// <summary> Parses lines of code and returns the <c>OffGeo</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>OffGeo</c> instance.</returns>
		public static OffGeo ParseOffGeo(string[] code)
		{
			OffGeo obj = new OffGeo();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.Id = value.Trim('"');
					if (name == "GID") obj.Gid = value.Trim('"');
					if (name == "SIL") obj.Sil = value.Trim('"');
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "OFS") obj.Ofs = ConvertToDouble(value);
					if (name == "SHC") obj.Shc= ((value == "1") || (value == "YES"));
					if (name == "OSL") obj.Osl= (OffsetSelectionType)Enum.Parse(typeof(OffsetSelectionType),value);
					if (name == "LTP") obj.Ltp= ((value == "1") || (value == "YES"));
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "CRT") obj.Crt= (OffsetCompensationType)Enum.Parse(typeof(OffsetCompensationType),value);
				}
			}
			return obj;
		}
	}
}
