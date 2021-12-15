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

		/// <summary> Parses the file and returns the <c>BiesseProgram</c> instance.</summary>
		/// <param name="filePath"> Path to the "cix" file.</param>
		/// <returns> The instance of the <c>BiesseProgram</c> class.</returns>
		public static BiesseProgram ParseCixFile(string filePath)
		{
			FileInfo fileInf = new FileInfo(filePath);
			 if (fileInf.Exists)
                {return ParseBiesseProgram(File.ReadAllLines(filePath));}
			else
				{return new BiesseProgram();}
		}

		/// <summary> Parses the array of strings and returns the instance of the <c>BiesseProgram</c> class.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The instance of the <c>BiesseProgram</c> class.</returns>
        public static BiesseProgram ParseBiesseProgram(string[] code)
        {
            BiesseProgram p = new BiesseProgram();
            p.Header = ParseHeaderSection(code);
            p.MainData = ParseMainDataSection(code);
            p.PublicVars = ParsePublicVarsSection(code);
            p.PrivateVars = ParsePrivateVarsSection(code);
            engine.SetGlobalValue("LPX", p.Lpx);
            engine.SetGlobalValue("lpx", p.Lpx);
            engine.SetGlobalValue("LPY", p.Lpy);
            engine.SetGlobalValue("lpy", p.Lpy);
            engine.SetGlobalValue("LPZ", p.Lpz);
            engine.SetGlobalValue("lpz", p.Lpz);
            if (p.PublicVars.PublicVariables.Count > 0)
            {
                foreach(var v in p.PublicVars.PublicVariables)
                {
                    if (v.Typ == BiesseVariablesType.String)
                        {engine.Execute(v.Name + "=\"" + v.Value +"\"");}
                    else 
                        {engine.Execute(v.Name + "=" + v.Value);}
                }
            }
            if (p.PrivateVars.PrivateVariables.Count > 0)
            {
                foreach(var v in p.PrivateVars.PrivateVariables)
                {
                    if (v.Typ == BiesseVariablesType.String)
                        {engine.Execute(v.Name + "=\"" + v.Value +"\"");}
                    else 
                        {engine.Execute(v.Name + "=" + v.Value);}
                }
            }
            
			int i = 0; 
			while(i < code.Length)
			{
				string vbStart = @"^\s*BEGIN\s+VB\s*$";
				Regex rVbStart = new Regex(vbStart);
				string vbEnd = @"^\s*END\s+VB\s*$";
				Regex rVbEnd = new Regex(vbEnd);
				Match mVbStart = rVbStart.Match(code[i]);
				if (mVbStart.Success)
				{
					i++;
					while(i < code.Length)
					{
						Match mVbEnd = rVbEnd.Match(code[i]);
						if (mVbEnd.Success) break;
						Regex rVbLine = new Regex(@"^\s*VBLINE\s*=\s*""(.*)""$");
						Match mVbLine = rVbLine.Match(code[i]);
						if (mVbLine.Success)  p.ProgramSec.BiesseEntities.Add(new VBLine(mVbLine.Groups[1].Value));
						i++;
					}
				}
				Regex rMacroStart = new Regex(@"^\s*BEGIN\s+MACRO\s*$");
				Regex rMacroEnd = new Regex(@"^\s*END\s+MACRO\s*$");
				Match mMacroStart = rMacroStart.Match(code[i]);
				if (mMacroStart.Success)
				{
					i++;
					List<string> MacroCode = new List<string>();
					while(i < code.Length)
					{
						Match mMacroEnd = rMacroEnd.Match(code[i]);
						if (mMacroEnd.Success) break;
						MacroCode.Add(code[i]);
						i++;
					}
					 if (MacroCode.Count > 0)
               		{
						IBppCode biesseEntity;
						try
						{
						biesseEntity = ParseMacro(MacroCode.ToArray());
						}
						catch (Exception ex)
						{
						biesseEntity = new VBLine("'" + ex.Message + "-" +  String.Join("\n'",code));
						}
                    	p.ProgramSec.BiesseEntities.Add(biesseEntity);
                	}
				}
				Regex rWTToolingStart = new Regex(@"^\s*BEGIN\s+WORKTABLETOOLING\s*$");
				Regex rWTToolingEnd = new Regex(@"^\s*END\s+WORKTABLETOOLING\s*$");
				Match mWTToolingStart = rWTToolingStart.Match(code[i]);
				if (mWTToolingStart.Success)
				{
					i++;
					while(i < code.Length)
					{
						Match mWTToolingEnd = rWTToolingEnd.Match(code[i]);
						if (mWTToolingEnd.Success) break;
						i++;
					}
				}
				i++;
			}
            return p;
        }

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

		/// <summary> Parses the array of strings and returns the instance of the <c>PrivateVarsSection</c> class.</summary>
		/// <param name="code"> The array of strings.</param>
		/// <returns> The instance of the <c>PrivateVarsSection</c> class.</returns>
        public static PrivateVarsSection ParsePrivateVarsSection(string[] code)
        {
            string patternStart = @"^\s*BEGIN\s+PRIVATEVARS\s*$";
			bool startSection = false;
			bool endSection = false;
			Regex rStart = new Regex(patternStart);
			string patternEnd = @"^\s*END\s+PRIVATEVARS\s*$";
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
            PrivateVarsSection pvs = new PrivateVarsSection();
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
                    pvs.PrivateVariables.Add(v);
                }
            }
            return pvs;
        }


		/// <summary> Parses the line of code and returns the <c>IBppCode</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>IBppCode</c> instance.</returns>
        public static IBppCode ParseMacro(string[] code)
        {
            IBppCode obj = new VBLine();
            string biesseType = GetBiesseEntityType(code);
            switch(biesseType)
                {
					case "GEO":
						obj =(IBppCode)ParseGeo(code);
						break;
					case "START_POINT":
						obj =(IBppCode)ParseStartPoint(code);
						break;
					case "ENDPATH":
						obj =(IBppCode)ParseEndPath(code);
						break;
					case "AINC_ANCE":
						obj =(IBppCode)ParseAincAnCe(code);
						break;
					case "AINC_EPRA":
						obj =(IBppCode)ParseAincEpRa(code);
						break;
					case "ARC_ANCE":
						obj =(IBppCode)ParseArcAnCe(code);
						break;
					case "ARC_ANCERATP":
						obj =(IBppCode)ParseArcAnCeRaTp(code);
						break;
					case "ARC_CETS":
						obj =(IBppCode)ParseArcCeTs(code);
						break;
					case "ARC_CETSPK":
						obj =(IBppCode)ParseArcCeTsPk(code);
						break;
					case "ARC_EPCE":
						obj =(IBppCode)ParseArcEpCe(code);
						break;
					case "ARC_EPRA":
						obj =(IBppCode)ParseArcEpRa(code);
						break;
					case "ARC_EPRATP":
						obj =(IBppCode)ParseArcEpRaTp(code);
						break;
					case "ARC_EPTP":
						obj =(IBppCode)ParseArcEpTp(code);
						break;
					case "ARC_IPEP":
						obj =(IBppCode)ParseArcIpEp(code);
						break;
					case "ARC_RATS":
						obj =(IBppCode)ParseArcRaTs(code);
						break;
					case "ARC_RATSPK":
						obj =(IBppCode)ParseArcRaTsPk(code);
						break;
					case "CONNECTOR":
						obj =(IBppCode)ParseConnectorA(code);
						break;
					case "CONNECTOR2":
						obj =(IBppCode)ParseConnectorB(code);
						break;
					case "BCA":
						obj =(IBppCode)ParseBca(code);
						break;
					case "BCL":
						obj =(IBppCode)ParseBcl(code);
						break;
					case "BG":
						obj =(IBppCode)ParseBg(code);
						break;
					case "B_GEO":
						obj =(IBppCode)ParseBGeo(code);
						break;
					case "BH":
						obj =(IBppCode)ParseBh(code);
						break;
					case "BV":
						obj =(IBppCode)ParseBv(code);
						break;
					case "S32":
						obj =(IBppCode)ParseS32(code);
						break;
					case "CUT_F":
						obj =(IBppCode)ParseCutF(code);
						break;
					case "CUT_FR":
						obj =(IBppCode)ParseCutFR(code);
						break;
					case "CUT_G":
						obj =(IBppCode)ParseCutG(code);
						break;
					case "CUT_GEO":
						obj =(IBppCode)ParseCutGeo(code);
						break;
					case "CUT_X":
						obj =(IBppCode)ParseCutX(code);
						break;
					case "CUT_Y":
						obj =(IBppCode)ParseCutY(code);
						break;
					case "CIRCLE_3P":
						obj =(IBppCode)ParseCircle3P(code);
						break;
					case "CIRCLE_CR":
						obj =(IBppCode)ParseCircleCR(code);
						break;
					case "ELLIPSE":
						obj =(IBppCode)ParseEllipse(code);
						break;
					case "OVAL":
						obj =(IBppCode)ParseOval(code);
						break;
					case "POLYGON":
						obj =(IBppCode)ParsePolygon(code);
						break;
					case "RECTANGLE":
						obj =(IBppCode)ParseRectangle(code);
						break;
					case "STAR":
						obj =(IBppCode)ParseStar(code);
						break;
					case "CHAMFER":
						obj =(IBppCode)ParseChamfer(code);
						break;
					case "LINC_EP":
						obj =(IBppCode)ParseLincEp(code);
						break;
					case "LINE_ANXE":
						obj =(IBppCode)ParseLineAnXe(code);
						break;
					case "LINE_ANYE":
						obj =(IBppCode)ParseLineAnYe(code);
						break;
					case "LINE_EP":
						obj =(IBppCode)ParseLineEp(code);
						break;
					case "LINE_EPANTP":
						obj =(IBppCode)ParseLineEpAnTp(code);
						break;
					case "LINE_EPTP":
						obj =(IBppCode)ParseLineEpTp(code);
						break;
					case "LINE_LNAN":
						obj =(IBppCode)ParseLineLnAn(code);
						break;
					case "LINE_LNTP":
						obj =(IBppCode)ParseLineLnTp(code);
						break;
					case "LINE_LNXE":
						obj =(IBppCode)ParseLineLnXe(code);
						break;
					case "LINE_LNYE":
						obj =(IBppCode)ParseLineLnYe(code);
						break;
					case "GEOTEXT":
						obj =(IBppCode)ParseGeoText(code);
						break;
					case "OFFGEO":
						obj =(IBppCode)ParseOffGeo(code);
						break;
					case "POCK":
						obj =(IBppCode)ParsePock(code);
						break;
					case "ROUT":
						obj =(IBppCode)ParseRout(code);
						break;
					case "ROUTG":
						obj =(IBppCode)ParseRoutG(code);
						break;
					case "ISO":
						obj =(IBppCode)ParseIso(code);
						break;
					case "OFFSET":
						obj =(IBppCode)ParseOffset(code);
						break;
					case "PUTPROG":
						obj =(IBppCode)ParsePutProg(code);
						break;
					case "ROTATE":
						obj =(IBppCode)ParseRotate(code);
						break;
					case "SCALE":
						obj =(IBppCode)ParseScale(code);
						break;
					case "SHIFT":
						obj =(IBppCode)ParseShift(code);
						break;
					case "WFC":
						obj =(IBppCode)ParseWFC(code);
						break;
					case "WFG":
						obj =(IBppCode)ParseWFG(code);
						break;
					case "WFGL":
						obj =(IBppCode)ParseWFGL(code);
						break;
					case "WFGPS":
						obj =(IBppCode)ParseWFGPS(code);
						break;
					case "WFL":
						obj =(IBppCode)ParseWFL(code);
						break;
                    default :
                        obj =(IBppCode)(new VBLine("'" + String.Join("\n'",code)));
                        break;
                }
            

            return (IBppCode)obj;
        }

		/// <summary> Returns a string representing the type of the BiesseWorks entity.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The string representing the type of the BiesseWorks entity.</returns>
		public static string GetBiesseEntityType(string[] code)
		{
			string pattern = @"^\s*NAME\s*=\s*(\w+)\s*$";
			string biesseType = "";
			Regex r = new Regex(pattern);
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					biesseType = m.Groups[1].Value;
				}
			}
			return biesseType;
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
