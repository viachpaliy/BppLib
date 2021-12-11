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
		/// <summary> Parses lines of code and returns the <c>PutProg</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>PutProg</c> instance.</returns>
		public static PutProg ParsePutProg(string[] code)
		{
			PutProg obj = new PutProg();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.Id = value.Trim('"');
					if (name == "SPNAME") obj.SpName = value.Trim('"');
					if (name == "SPLPX") obj.SpLpx = ConvertToDouble(value);
					if (name == "SPLPY") obj.SpLpy = ConvertToDouble(value);
					if (name == "SPLPZ") obj.SpLpz = ConvertToDouble(value);
					if (name == "SYMY") obj.SymY= ((value == "1") || (value == "YES"));
					if (name == "ROT") obj.Rot = ConvertToDouble(value);
					if (name == "SPCRN") obj.SpCrn = ConvertToInt(value);
					if (name == "RFT") obj.Rft = ConvertToInt(value);
					if (name == "REF") obj.Ref = ConvertToInt(value);
					if (name == "BCK") obj.Bck = ConvertToInt(value);
					if (name == "X") obj.X = ConvertToDouble(value);
					if (name == "Y") obj.Y = ConvertToDouble(value);
					if (name == "PAV") obj.Pav= ((value == "1") || (value == "YES"));
					if (name == "VARS") obj.Vars = value.Trim('"');
				}
			}
			return obj;
		}
	}
}
