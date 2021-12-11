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
		/// <summary> Parses lines of code and returns the <c>ArcEpCe</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>ArcEpCe</c> instance.</returns>
		public static ArcEpCe ParseArcEpCe(string[] code)
		{
			ArcEpCe obj = new ArcEpCe();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.Id = Convert.ToInt32(value);
					if (name == "XE") obj.Xe = ConvertToDouble(value);
					if (name == "YE") obj.Ye = ConvertToDouble(value);
					if (name == "XC") obj.Xc = ConvertToDouble(value);
					if (name == "YC") obj.Yc = ConvertToDouble(value);
					if (name == "DIR") obj.Dir= (CircleDirection)Enum.Parse(typeof(CircleDirection),value);
					if (name == "ZS") obj.Zs = ConvertToDouble(value);
					if (name == "ZE") obj.Ze = ConvertToDouble(value);
					if (name == "SC") obj.Sc= (SharpCorner)Enum.Parse(typeof(SharpCorner),value);
					if (name == "FD") obj.Fd = ConvertToInt(value);
					if (name == "SP") obj.Sp = ConvertToInt(value);
					if (name == "SOL") obj.Sol = ConvertToInt(value);
				}
			}
			return obj;
		}
	}
}
