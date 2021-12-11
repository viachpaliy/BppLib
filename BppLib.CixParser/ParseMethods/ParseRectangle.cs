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
		/// <summary> Parses lines of code and returns the <c>Rectangle</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>Rectangle</c> instance.</returns>
		public static Rectangle ParseRectangle(string[] code)
		{
			Rectangle obj = new Rectangle();
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
					if (name == "L") obj.L = ConvertToDouble(value);
					if (name == "H") obj.H = ConvertToDouble(value);
					if (name == "DIR") obj.Dir= (CircleDirection)Enum.Parse(typeof(CircleDirection),value);
					if (name == "CT") obj.Ct= (ChamferType)Enum.Parse(typeof(ChamferType),value);
					if (name == "CD") obj.Cd = ConvertToDouble(value);
					if (name == "SS") obj.Ss = ConvertToInt(value);
					if (name == "SD")
					{
						if (value.Trim() == "HALF")
                		{
                    		obj.StartFromHalfSide = true;
                		}
            			else
                		{
                    		obj.StartFromHalfSide = false; 
                    		obj.Sd = ConvertToDouble(value);
                		}
					}
					if (name == "A") obj.A = ConvertToDouble(value);
					if (name == "ZS") obj.Zs = ConvertToDouble(value);
					if (name == "ZE") obj.Ze = ConvertToDouble(value);
					if (name == "SC") obj.Sc= (SharpCorner)Enum.Parse(typeof(SharpCorner),value);
					if (name == "FD") obj.Fd = ConvertToInt(value);
					if (name == "SP") obj.Sp = ConvertToInt(value);
					if (name == "USC") obj.Usc= ((value == "1") || (value == "YES"));
					if (name == "CRN") obj.Crn = ConvertToInt(value);
				}
			}
			return obj;
		}
	}
}
