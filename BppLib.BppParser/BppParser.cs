using System;
using BppLib.Core;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using Jurassic;

namespace BppLib.BppParser
{
    public static partial class ParserBpp
    {
		/// <summary> JavaScript engine. </summary>
        public static Jurassic.ScriptEngine engine = new Jurassic.ScriptEngine();

		public static BiesseProgram ParseBppFile(string filePath)
		{
			FileInfo fileInf = new FileInfo(filePath);
			 if (fileInf.Exists)
                {return ParseBiesseProgram(File.ReadAllLines(filePath));}
			else
				{return new BiesseProgram();}
		}

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
			obj.X = ConvertToDouble(values[0]);
			obj.Y = ConvertToDouble(values[1]);
			obj.Z = ConvertToDouble(values[2]);
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
			obj.Side = ConvertToInt(values[1]);
			obj.Crn = values[2].Trim().Trim('"');
			obj.Dp = ConvertToDouble(values[3]);
			obj.Rty =(Repetition)ConvertToInt(values[4]);
			obj.Xrc = ConvertToDouble(values[5]);
			obj.Yrc = ConvertToDouble(values[6]);
			obj.Dx = ConvertToDouble(values[7]);
			obj.Dy = ConvertToDouble(values[8]);
			obj.R = ConvertToDouble(values[9]);
			obj.A = ConvertToDouble(values[10]);
			obj.Da = ConvertToDouble(values[11]);
			obj.Rdl =(values[12].Trim() == "1");
			obj.Nrp = ConvertToInt(values[13]);
			obj.Arp = ConvertToInt(values[14]);
			obj.Lrp = ConvertToInt(values[15]);
			obj.Er =(values[16].Trim() == "1");
			obj.Rv =(values[17].Trim() == "1");
			obj.Cow =(values[18].Trim() == "1");
			obj.Lay = values[19].Trim().Trim('"');
			obj.Crc =(ToolCorrection)ConvertToInt(values[20]);
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

		public static double ConvertToDouble(string code)
		{
			return engine.Evaluate<double>(code);
		}

		public static int ConvertToInt(string code)
		{
			return engine.Evaluate<int>(code);
		}

    }
    
}
