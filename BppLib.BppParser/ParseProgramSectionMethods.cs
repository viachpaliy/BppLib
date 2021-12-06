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
		/// <summary> Parses the array of strings and returns the instance of the <c>BiesseProgram</c> class.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The instance of the <c>BiesseProgram</c> class.</returns>
        public static BiesseProgram ParseBiesseProgram(string[] code)
        {
            BiesseProgram p = new BiesseProgram();
            p.Header = ParseHeaderSection(code);
            p.Description = ParseDescriptionSection(code);
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
            p.ProgramSec = ParseProgramSection(code);
            return p;
        }

		/// <summary> Parses the array of strings and returns the instance of the <c>ProgramSection</c> class.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The instance of the <c>ProgramSection</c> class.</returns>
        public static ProgramSection ParseProgramSection(string[] code)
        { 
            string[] section = GetSectionByName(code, "PROGRAM");
            ProgramSection ps = new ProgramSection();
            foreach(var s in section)
			{
                if (s != "")
                {
					IBppCode biesseEntity;
					try
					{
						biesseEntity = ParseProgramSectionLine(s);
					}
					catch (Exception ex)
					{
						biesseEntity = new VBLine("'" + ex.Message + "-" + s);
					}
                    ps.BiesseEntities.Add(biesseEntity);
                }
            }
            return ps;
        }

		/// <summary> Parses the line of code and returns the <c>IBppCode</c> instance.</summary>
		/// <param name="code"> the line of code.</param>
		/// <returns> The <c>IBppCode</c> instance.</returns>
        public static IBppCode ParseProgramSectionLine(string code)
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
                        obj =(IBppCode)(new VBLine(code));
                        break;
                }
            

            return (IBppCode)obj;
        }
    }
}