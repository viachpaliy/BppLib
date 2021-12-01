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
		public static MainDataSection ParseMainDataSection(string[] code)
		{
			string[] section = GetSectionByName(code, "VARIABLES");
			MainDataSection mds = new MainDataSection();
			Regex rLPX = new Regex(@"\s*PAN\s*=\s*LPX\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rLPY = new Regex(@"\s*PAN\s*=\s*LPY\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rLPZ = new Regex(@"\s*PAN\s*=\s*LPZ\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rORLST = new Regex(@"\s*PAN\s*=\s*ORLST\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rSIMMETRY = new Regex(@"\s*PAN\s*=\s*SIMMETRY\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rTLCHK = new Regex(@"\s*PAN\s*=\s*TLCHK\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rTOOLING = new Regex(@"\s*PAN\s*=\s*TOOLING\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rCUSTSTR = new Regex(@"\s*PAN\s*=\s*CUSTSTR\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rFCN = new Regex(@"\s*PAN\s*=\s*FCN\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rXCUT = new Regex(@"\s*PAN\s*=\s*XCUT\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rYCUT = new Regex(@"\s*PAN\s*=\s*YCUT\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rJIGTH = new Regex(@"\s*PAN\s*=\s*JIGTH\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rCKOP = new Regex(@"\s*PAN\s*=\s*CKOP\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rUNIQUE = new Regex(@"\s*PAN\s*=\s*UNIQUE\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rMATERIAL = new Regex(@"\s*PAN\s*=\s*MATERIAL\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rPUTLST = new Regex(@"\s*PAN\s*=\s*PUTLST\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rOPPWKRS = new Regex(@"\s*PAN\s*=\s*OPPWKRS\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rUNICLAMP = new Regex(@"\s*PAN\s*=\s*UNICLAMP\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rCHKCOLL = new Regex(@"\s*PAN\s*=\s*CHKCOLL\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rWTPIANI = new Regex(@"\s*PAN\s*=\s*WTPIANI\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rCOLLTOOL = new Regex(@"\s*PAN\s*=\s*COLLTOOL\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rCALCEDTH = new Regex(@"\s*PAN\s*=\s*CALCEDTH\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rENABLELABEL = new Regex(@"\s*PAN\s*=\s*ENABLELABEL\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rLOCKWASTE = new Regex(@"\s*PAN\s*=\s*LOCKWASTE\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rLOADEDGEOPT = new Regex(@"\s*PAN\s*=\s*LOADEDGEOPT\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rITLTYPE = new Regex(@"\s*PAN\s*=\s*ITLTYPE\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rRUNPAV = new Regex(@"\s*PAN\s*=\s*RUNPAV\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rFLIPEND = new Regex(@"\s*PAN\s*=\s*FLIPEND\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rENABLEMACHLINKS = new Regex(@"\s*PAN\s*=\s*ENABLEMACHLINKS\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rENABLEPURSUITS = new Regex(@"\s*PAN\s*=\s*ENABLEPURSUITS\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rENABLEFASTVERTBORINGS = new Regex(@"\s*PAN\s*=\s*ENABLEFASTVERTBORINGS\s*\|(.*)\|\|\s*\d\s*\|\s*$");
			Regex rFASTVERTBORINGSVALUE = new Regex(@"\s*PAN\s*=\s*FASTVERTBORINGSVALUE\s*\|(.*)\|\|\s*\d\s*\|\s*$");
            foreach(var s in section)
			{
                if (rLPX.IsMatch(s)) mds.Lpx = ConvertToDouble(rLPX.Match(s).Groups[1].Value);
                if (rLPY.IsMatch(s)) mds.Lpy = ConvertToDouble(rLPY.Match(s).Groups[1].Value); 
                if (rLPZ.IsMatch(s)) mds.Lpz = ConvertToDouble(rLPZ.Match(s).Groups[1].Value); 
                if (rORLST.IsMatch(s)) mds.OrLst = rORLST.Match(s).Groups[1].Value.Trim(' ','"');
                if (rSIMMETRY.IsMatch(s)) mds.Simmetry = (rSIMMETRY.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rTLCHK.IsMatch(s)) mds.TlChk = Convert.ToInt32(rTLCHK.Match(s).Groups[1].Value);
                if (rTOOLING.IsMatch(s)) mds.Tooling = rTOOLING.Match(s).Groups[1].Value.Trim(' ','"');
                if (rCUSTSTR.IsMatch(s))
                    {
                        string str = rCUSTSTR.Match(s).Groups[1].Value.Trim();
                        Regex rCS = new Regex(@"\w+""(\w+)""");
                        if (rCS.IsMatch(str)) mds.CustStr = rCS.Match(str).Groups[1].Value;
                    }
                if (rFCN.IsMatch(s)) mds.Fcn = ConvertToDouble(rFCN.Match(s).Groups[1].Value);
                if (rXCUT.IsMatch(s)) mds.XCut = ConvertToDouble(rXCUT.Match(s).Groups[1].Value);
                if (rYCUT.IsMatch(s)) mds.YCut = ConvertToDouble(rYCUT.Match(s).Groups[1].Value);
                if (rJIGTH.IsMatch(s)) mds.JigTh = ConvertToDouble(rJIGTH.Match(s).Groups[1].Value);
                if (rCKOP.IsMatch(s)) mds.Ckop = Convert.ToInt32(rCKOP.Match(s).Groups[1].Value);
                if (rUNIQUE.IsMatch(s)) mds.Unique = (rUNIQUE.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rMATERIAL.IsMatch(s)) mds.Material = rMATERIAL.Match(s).Groups[1].Value.Trim(' ','"');
                if (rPUTLST.IsMatch(s)) mds.PutLst = rPUTLST.Match(s).Groups[1].Value.Trim(' ','"');
                if (rOPPWKRS.IsMatch(s)) mds.Oppwkrs = Convert.ToInt32(rOPPWKRS.Match(s).Groups[1].Value);
                if (rUNICLAMP.IsMatch(s)) mds.UniClamp = (rUNICLAMP.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rCHKCOLL.IsMatch(s)) mds.ChkColl = (rCHKCOLL.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rWTPIANI.IsMatch(s)) mds.WtPiani = Convert.ToInt32(rWTPIANI.Match(s).Groups[1].Value);
                if (rCOLLTOOL.IsMatch(s)) mds.CollTool = Convert.ToInt32(rCOLLTOOL.Match(s).Groups[1].Value);
                if (rCALCEDTH.IsMatch(s)) mds.CalcEdTh = Convert.ToInt32(rCALCEDTH.Match(s).Groups[1].Value);
                if (rENABLELABEL.IsMatch(s)) mds.EnableLabel = (rENABLELABEL.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rLOCKWASTE.IsMatch(s)) mds.LockWaste = (rLOCKWASTE.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rLOADEDGEOPT.IsMatch(s)) mds.LoadEdgeOpt = Convert.ToInt32(rLOADEDGEOPT.Match(s).Groups[1].Value);
                if (rITLTYPE.IsMatch(s)) mds.ItlType = Convert.ToInt32(rITLTYPE.Match(s).Groups[1].Value);
                if (rRUNPAV.IsMatch(s)) mds.RunPav = (rRUNPAV.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rFLIPEND.IsMatch(s)) mds.FlipEnd = Convert.ToInt32(rFLIPEND.Match(s).Groups[1].Value);
                if (rENABLEMACHLINKS.IsMatch(s)) mds.EnableMachLinks = (rENABLEMACHLINKS.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rENABLEPURSUITS.IsMatch(s)) mds.EnablePursuits = (rENABLEPURSUITS.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rENABLEFASTVERTBORINGS.IsMatch(s)) mds.EnableFastVertBorings = (rENABLEFASTVERTBORINGS.Match(s).Groups[1].Value.Trim(' ','"') == "1");
                if (rFASTVERTBORINGSVALUE.IsMatch(s)) mds.FastVertBoringsValue = Convert.ToInt32(rFASTVERTBORINGSVALUE.Match(s).Groups[1].Value);
            }
			return mds;
		} 

        public static PrivateVarsSection ParsePrivateVarsSection(string[] code)
        {
            string[] section = GetSectionByName(code, "VARIABLES");
            PrivateVarsSection pvs = new PrivateVarsSection();
            Regex r = new Regex(@"\s*LOC\s*=\s*(\w+)\s*\|\s*""?([\w.+-]+)""?\s*\|\s*(.*)\s*\|\s*(\w+)\s*\|\s*$");
            foreach(var s in section)
			{
                if (r.IsMatch(s))
                {
                    var v = new BiesseVariable();
                    v.Name = r.Match(s).Groups[1].Value.Trim();
                    v.Value = r.Match(s).Groups[2].Value.Trim();
                    v.Description = r.Match(s).Groups[3].Value.Trim();
                    v.Typ = (BiesseVariablesType)Convert.ToInt32(r.Match(s).Groups[4].Value);
                    pvs.PrivateVariables.Add(v);
                }
          
            }
            return pvs;
        }

        public static PublicVarsSection ParsePublicVarsSection(string[] code)
        {
            string[] section = GetSectionByName(code, "VARIABLES");
            PublicVarsSection pvs = new PublicVarsSection();
            Regex r = new Regex(@"\s*GLB\s*=\s*(\w+)\s*\|\s*""?([\w.+-]+)""?\s*\|\s*(.*)\s*\|\s*(\w+)\s*\|\s*$");
            foreach(var s in section)
			{
                if (r.IsMatch(s))
                {
                    var v = new BiesseVariable();
                    v.Name = r.Match(s).Groups[1].Value.Trim();
                    v.Value = r.Match(s).Groups[2].Value.Trim();
                    v.Description = r.Match(s).Groups[3].Value.Trim();
                    v.Typ = (BiesseVariablesType)Convert.ToInt32(r.Match(s).Groups[4].Value);
                    pvs.PublicVariables.Add(v);
                }
          
            }
            return pvs;
        }
       
    }
}