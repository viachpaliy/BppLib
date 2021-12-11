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
		/// <summary> Parses lines of code and returns the <c>WFC</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>WFC</c> instance.</returns>
		public static WFC ParseWFC(string[] code)
		{
			WFC obj = new WFC();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.SideId = Convert.ToInt32(value);
					if (name == "X") obj.X = ConvertToDouble(value);
					if (name == "Y") obj.Y = ConvertToDouble(value);
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "AZ") obj.Az = ConvertToDouble(value);
					if (name == "H") obj.H = ConvertToDouble(value);
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "DA") obj.Da = ConvertToDouble(value);
					if (name == "R") obj.R = ConvertToDouble(value);
					if (name == "DIR") obj.Dir= (CircleDirection)Enum.Parse(typeof(CircleDirection),value);
					if (name == "VRT") obj.Vrt= ((value == "1") || (value == "YES"));
					if (name == "VF") obj.Vf= ((value == "1") || (value == "YES"));
					if (name == "AFH") obj.Afh= ((value == "1") || (value == "YES"));
					if (name == "UCS") obj.Ucs= ((value == "1") || (value == "YES"));
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "LAY") obj.Lay = value.Trim('"');
				}
			}
			return obj;
		}
	}
}
