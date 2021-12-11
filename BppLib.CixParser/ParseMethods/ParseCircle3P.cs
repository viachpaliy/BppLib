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
		/// <summary> Parses lines of code and returns the <c>Circle3P</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Circle3P</c> instance.</returns>
		public static Circle3P ParseCircle3P(string[] code)
		{
			Circle3P obj = new Circle3P();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.Id = Convert.ToInt32(value);
					if (name == "X1") obj.X1 = ConvertToDouble(value);
					if (name == "Y1") obj.Y1 = ConvertToDouble(value);
					if (name == "X2") obj.X2 = ConvertToDouble(value);
					if (name == "Y2") obj.Y2 = ConvertToDouble(value);
					if (name == "X3") obj.X3 = ConvertToDouble(value);
					if (name == "Y3") obj.Y3 = ConvertToDouble(value);
					if (name == "AS") obj.As = ConvertToDouble(value);
					if (name == "DIR") obj.Dir= (CircleDirection)Enum.Parse(typeof(CircleDirection),value);
					if (name == "ZS") obj.Zs = ConvertToDouble(value);
					if (name == "ZE") obj.Ze = ConvertToDouble(value);
					if (name == "SC") obj.Sc= (SharpCorner)Enum.Parse(typeof(SharpCorner),value);
					if (name == "FD") obj.Fd = ConvertToInt(value);
					if (name == "SP") obj.Sp = ConvertToInt(value);
				}
			}
			return obj;
		}
	}
}
