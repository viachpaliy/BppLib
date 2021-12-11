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
		/// <summary> Parses lines of code and returns the <c>Offset</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Offset</c> instance.</returns>
		public static Offset ParseOffset(string[] code)
		{
			Offset obj = new Offset();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "X") obj.X = ConvertToDouble(value);
					if (name == "Y") obj.Y = ConvertToDouble(value);
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "SHW") obj.Shw= ((value == "1") || (value == "YES"));
				}
			}
			return obj;
		}
	}
}
