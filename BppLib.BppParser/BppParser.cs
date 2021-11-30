using System;
using BppLib.Core;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BppLib.BppParser
{
    public static partial class ParserBpp
    {

		public static HeaderSection ParseHeaderSection(string[] code)
		{
			string[] section = GetSectionByName(code, "HEADER");
			HeaderSection h = new HeaderSection();
			Regex typeRegex = new Regex(@"^\s*TYPE\s*=\s*(\w+)\s*$");
			Regex versionRegex = new Regex(@"^\s*VER\s*=\s*(\d+)\s*$");
			foreach(var s in section)
			{
				Match mType = typeRegex.Match(s);
				if (mType.Success) h.Typ = mType.Groups[1].Value;
				Match mVer = versionRegex.Match(s);
				if (mVer.Success) h.Version = mVer.Groups[1].Value;
			}
			return h;
		}

		public static  DescriptionSection ParseDescriptionSection(string[] code)
		{
			string[] section = GetSectionByName(code, "DESCRIPTION");
			DescriptionSection ds = new  DescriptionSection();
			StringBuilder sb = new StringBuilder();
			foreach(var s in section)
			{
				if (!String.IsNullOrEmpty(s))
				{
					if (s.Trim().StartsWith('|'))
					sb.AppendLine(s.Trim().TrimStart('|'));
				}
			}
			ds.DescText = sb.ToString();
			return ds;
		}

		public static StartPoint ParseStartPoint(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			StartPoint obj = new StartPoint();
			obj.Id = id;
			obj.X = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Z = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			return obj;
		}

		public static EndPath ParseEndPath(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			EndPath obj = new EndPath();
			obj.Id = id;
			return obj;
		}

		public static Geo ParseGeo(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Geo obj = new Geo();
			obj.IntId = id;
			obj.Id = values[0].Trim().Trim('"');
			obj.Side = Convert.ToInt32(values[1]);
			obj.Crn = values[2].Trim().Trim('"');
			obj.Dp = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Rty =(Repetition)Convert.ToInt32(values[4]);
			obj.Xrc = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Yrc = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Dx = Convert.ToDouble(values[7], CultureInfo.InvariantCulture);
			obj.Dy = Convert.ToDouble(values[8], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			obj.A = Convert.ToDouble(values[10], CultureInfo.InvariantCulture);
			obj.Da = Convert.ToDouble(values[11], CultureInfo.InvariantCulture);
			obj.Rdl =(values[12].Trim() == "1");
			obj.Nrp = Convert.ToInt32(values[13]);
			obj.Arp = Convert.ToInt32(values[14]);
			obj.Lrp = Convert.ToInt32(values[15]);
			obj.Er =(values[16].Trim() == "1");
			obj.Rv =(values[17].Trim() == "1");
			obj.Cow =(values[18].Trim() == "1");
			obj.Lay = values[19].Trim().Trim('"');
			obj.Crc =(ToolCorrection)Convert.ToInt32(values[20]);
			return obj;
		}

        public static string[] SplitColon(string code)
        {
            string[] arr = new string[2];
            bool isQuoteOpen = false;
            for(int i = 0 ; i < code.Length ; i++)
            {
                if (code[i] == '"') 
                    {isQuoteOpen = !isQuoteOpen ;}
                if ((code[i] == ':') & (!isQuoteOpen))
                {
                    arr[0] = code.Substring(0, i);
                    arr[1] = code.Substring(i + 1);
                    break;
                }
            }
            return arr;
        }

        public static string[] SplitComma(string code)
        {
            List<string> lst = new List<string>();
            int startPos = 0;
            
            bool isQuoteOpen = false;
            for(int i = 0 ; i < code.Length ; i++)
            {
                if (code[i] == '"') 
                    {isQuoteOpen = !isQuoteOpen ;} 
                if ((code[i] == ',') & (!isQuoteOpen))
                {
                    int stringLength = i - startPos ; 
                    lst.Add(code.Substring(startPos, stringLength));
                    startPos = i + 1;
                }
            }

            if (startPos < code.Length)
                    {lst.Add(code.Substring(startPos));}

            return lst.ToArray();
        }

		public static string GetBiesseEntityType(string code)
		{
			string pattern = @"^\s*@\s+(\w+)\s*,.*";
			string biesseType = "";
			Regex r = new Regex(pattern);
			Match m = r.Match(code);
			if (m.Success)
			{
				biesseType = m.Groups[1].Value;
			}
			return biesseType;
		}

		public static string[] GetSectionByName(string[] code, string name)
		{
			string patternStart = @"^\s*\[\s*" + name.ToUpper() + @"\s*\]\s*$";
			bool startSection = false;
			bool endSection = false;
			Regex rStart = new Regex(patternStart);
			string patternEnd = @"^\s*\[\s*(\w+)\s*\]\s*$";
			Regex rEnd = new Regex(patternEnd);
			List<string> SectionCode = new List<string>();
			foreach(var s in code)
				{
					Match mEnd = rEnd.Match(s);
					if ((mEnd.Success) && (startSection))
						{
							endSection = true;
						}
					if (endSection) break;
					if (startSection) SectionCode.Add(s);
					Match mStart = rStart.Match(s);
					if (mStart.Success)
						{
							startSection = true;
						}
				}
			return SectionCode.ToArray();
		}

    }
    
}
