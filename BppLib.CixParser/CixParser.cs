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
		/// <summary> JavaScript engine. </summary>
        public static Jurassic.ScriptEngine engine = new Jurassic.ScriptEngine();

        /// <summary> Parses the array of strings and returns the instance of the <c>HeaderSection</c> class.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The instance of the <c>HeaderSection</c> class.</returns>
		public static HeaderSection ParseHeaderSection(string[] code)
		{
            string patternStart = @"^\s*BEGIN\s+ID\s+CID3\s*$";
			bool startSection = false;
			bool endSection = false;
			Regex rStart = new Regex(patternStart);
			string patternEnd = @"^\s*END\s+ID\s*$";
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
            HeaderSection h = new HeaderSection();
            Regex relRegex = new Regex(@"\s*REL\s*=\s*(\d\.\d+)\s*$");
            foreach(var s in SectionCode)
            {
                Match mRel = relRegex.Match(s);
				if (mRel.Success) h.Release = mRel.Groups[1].Value;
            }
            return h;
        }

        /// <summary> Parses the array of strings and returns the instance of the <c>MainDataSection</c> class.</summary>
		/// <param name="code"> The array of strings.</param>
		/// <returns> The instance of the <c>MainDataSection</c> class.</returns>
		public static MainDataSection ParseMainDataSection(string[] code)
		{
            string patternStart = @"^\s*BEGIN\s+MAINDATA\s*$";
			bool startSection = false;
			bool endSection = false;
			Regex rStart = new Regex(patternStart);
			string patternEnd = @"^\s*END\s+MAINDATA\s*$";
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
            MainDataSection mds = new MainDataSection();
            foreach(var s in SectionCode)
			{
                string[] parts = s.Split("=");
                string name = parts[0].Trim();
                string value = parts[1].Trim();
                if (name == "LPX") mds.Lpx = ConvertToDouble(value);
                if (name == "LPY") mds.Lpy = ConvertToDouble(value); 
                if (name == "LPZ") mds.Lpz = ConvertToDouble(value); 
                if (name == "ORLST") mds.OrLst = value.Trim(' ','"');
                if (name == "SIMMETRY") mds.Simmetry = (value.Trim(' ','"') == "1");
                if (name == "TLCHK") mds.TlChk = Convert.ToInt32(value);
                if (name == "TOOLING") mds.Tooling = value.Trim(' ','"');
                if (name == "CUSTSTR")
                    {
                        Regex rCS = new Regex(@"\w+""(\w+)""");
                        if (rCS.IsMatch(value)) mds.CustStr = rCS.Match(value).Groups[1].Value;
                    }
                if (name == "FCN") mds.Fcn = ConvertToDouble(value);
                if (name == "XCUT") mds.XCut = ConvertToDouble(value);
                if (name == "YCUT") mds.YCut = ConvertToDouble(value);
                if (name == "JIGTH") mds.JigTh = ConvertToDouble(value);
                if (name == "CKOP") mds.Ckop = Convert.ToInt32(value);
                if (name == "UNIQUE") mds.Unique = (value.Trim(' ','"') == "1");
                if (name == "MATERIAL") mds.Material = value.Trim(' ','"');
                if (name == "PUTLST") mds.PutLst = value.Trim(' ','"');
                if (name == "OPPWKRS") mds.Oppwkrs = Convert.ToInt32(value);
                if (name == "UNICLAMP") mds.UniClamp = (value.Trim(' ','"') == "1");
                if (name == "CHKCOLL") mds.ChkColl = (value.Trim(' ','"') == "1");
                if (name == "WTPIANI") mds.WtPiani = Convert.ToInt32(value);
                if (name == "COLLTOOL") mds.CollTool = Convert.ToInt32(value);
                if (name == "CALCEDTH") mds.CalcEdTh = Convert.ToInt32(value);
                if (name == "ENABLELABEL") mds.EnableLabel = (value.Trim(' ','"') == "1");
                if (name == "LOCKWASTE") mds.LockWaste = (value.Trim(' ','"') == "1");
                if (name == "LOADEDGEOPT") mds.LoadEdgeOpt = Convert.ToInt32(value);
                if (name == "ITLTYPE") mds.ItlType = Convert.ToInt32(value);
                if (name == "RUNPAV") mds.RunPav = (value.Trim(' ','"') == "1");
                if (name == "FLIPEND") mds.FlipEnd = Convert.ToInt32(value);
                if (name == "ENABLEMACHLINKS") mds.EnableMachLinks = (value.Trim(' ','"') == "1");
                if (name == "ENABLEPURSUITS") mds.EnablePursuits = (value.Trim(' ','"') == "1");
                if (name == "ENABLEFASTVERTBORINGS") mds.EnableFastVertBorings = (value.Trim(' ','"') == "1");
                if (name == "FASTVERTBORINGSVALUE") mds.FastVertBoringsValue = Convert.ToInt32(value);
            }
            return mds;
        }

         /// <summary> Parses the array of strings and returns the instance of the <c>PublicVarsSection</c> class.</summary>
		/// <param name="code"> The array of strings.</param>
		/// <returns> The instance of the <c>PublicVarsSection</c> class.</returns>
        public static PublicVarsSection ParsePublicVarsSection(string[] code)
        {
            string patternStart = @"^\s*BEGIN\s+PUBLICVARS\s*$";
			bool startSection = false;
			bool endSection = false;
			Regex rStart = new Regex(patternStart);
			string patternEnd = @"^\s*END\s+PUBLICVARS\s*$";
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
            PublicVarsSection pvs = new PublicVarsSection();
            Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*,\s*DESCRIPTION\s*=\s*(.*)\s*,\s*TYPE\s*=\s*(\d)\s*$");
            foreach(var s in SectionCode)
			{
                Match m = r.Match(s);
                if (m.Success)
                {
                    var v = new BiesseVariable();
                    v.Name = r.Match(s).Groups[1].Value.Trim();
                    v.Value = r.Match(s).Groups[2].Value.Trim();
                    v.Description = r.Match(s).Groups[3].Value.Trim();
                    if (v.Value.StartsWith('"') && v.Value.EndsWith('"'))
                    {
                        v.Value = v.Value.Trim('"');
                        v.Typ = BiesseVariablesType.String ;
                    }
                    else
                        {v.Typ = (BiesseVariablesType)Convert.ToInt32(r.Match(s).Groups[4].Value);}
                    pvs.PublicVariables.Add(v);
                }
            }
            return pvs;
        }
    
    	/// <summary> Converts the string to double using engine for evaluation.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The double.</returns>
		public static double ConvertToDouble(string code)
		{
			return engine.Evaluate<double>(code);
		}

		/// <summary> Converts the string to int using engine for evaluation.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The int.</returns>
		public static int ConvertToInt(string code)
		{
			return engine.Evaluate<int>(code);
		}
    
    
    }
}
