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
		/// <summary> Parses lines of code and returns the <c>Ellipse</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Ellipse</c> instance.</returns>
		public static Ellipse ParseEllipse(string[] code)
		{
			Ellipse obj = new Ellipse();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "ID") obj.Id = Convert.ToInt32(value);
					if (name == "XC") obj.Xc = ConvertToDouble(value);
					if (name == "YC") obj.Yc = ConvertToDouble(value);
					if (name == "A1") obj.A1 = ConvertToDouble(value);
					if (name == "A2") obj.A2 = ConvertToDouble(value);
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "AS") obj.As = ConvertToDouble(value);
					if (name == "DIR") obj.Dir= (CircleDirection)Enum.Parse(typeof(CircleDirection),value);
					if (name == "UNE") obj.Une= ((value == "1") || (value == "YES"));
					if (name == "ELM") obj.Elm = ConvertToInt(value);
					if (name == "MLE") obj.Mle = ConvertToDouble(value);
					if (name == "UA") obj.Ua= ((value == "1") || (value == "YES"));
					if (name == "ZS") obj.Zs = ConvertToDouble(value);
					if (name == "ZE") obj.Ze = ConvertToDouble(value);
					if (name == "SC") obj.Sc= (SharpCorner)Enum.Parse(typeof(SharpCorner),value);
					if (name == "FD") obj.Fd = ConvertToInt(value);
					if (name == "SP") obj.Sp = ConvertToInt(value);
					if (name == "AE") obj.Ae = ConvertToDouble(value);
				}
			}
			return obj;
		}
	}
}
