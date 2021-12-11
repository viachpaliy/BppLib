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
		/// <summary> Parses lines of code and returns the <c>RoutG</c> instance.</summary>
		/// <param name="code"> Lines of code.</param>
		/// <returns> The <c>RoutG</c> instance.</returns>
		public static RoutG ParseRoutG(string[] code)
		{
			RoutG obj = new RoutG();
			Regex r = new Regex(@"^\s*PARAM\s*,\s*NAME\s*=\s*(\w+)\s*,\s*VALUE\s*=\s*(.*)\s*$");
			foreach(var s in code)
			{
				Match m = r.Match(s);
				if (m.Success)
				{
					string name = r.Match(s).Groups[1].Value.Trim();
					string value = r.Match(s).Groups[2].Value.Trim();
					if (name == "GID") obj.Gid = value.Trim('"');
					if (name == "ID") obj.Id = value.Trim('"');
					if (name == "Z") obj.Z = ConvertToDouble(value);
					if (name == "DP") obj.Dp = ConvertToDouble(value);
					if (name == "ISO") obj.Iso = value.Trim('"');
					if (name == "OPT") obj.Opt= ((value == "1") || (value == "YES"));
					if (name == "DIA") obj.Dia = ConvertToDouble(value);
					if (name == "AZ") obj.Az = ConvertToDouble(value);
					if (name == "AR") obj.Ar = ConvertToDouble(value);
					if (name == "ZS") obj.Zs = ConvertToDouble(value);
					if (name == "ZE") obj.Ze = ConvertToDouble(value);
					if (name == "CKA") obj.Cka= (InclinationRotationType)Enum.Parse(typeof(InclinationRotationType),value);
					if (name == "THR") obj.Thr= ((value == "1") || (value == "YES"));
					if (name == "RV") obj.Rv= ((value == "1") || (value == "YES"));
					if (name == "CKT") obj.Ckt= ((value == "1") || (value == "YES"));
					if (name == "COW") obj.Cow= ((value == "1") || (value == "YES"));
					if (name == "SIL") obj.Sil = value.Trim('"');
					if (name == "OVM") obj.Ovm = ConvertToDouble(value);
					if (name == "A21") obj.A21 = ConvertToInt(value);
					if (name == "LNG") obj.Lng = ConvertToDouble(value);
					if (name == "LPR") obj.Lpr= ((value == "1") || (value == "YES"));
					if (name == "TOS") obj.Tos= ((value == "1") || (value == "YES"));
					if (name == "VTR") obj.Vtr = ConvertToInt(value);
					if (name == "DVR") obj.Dvr = ConvertToDouble(value);
					if (name == "OTR") obj.Otr = ConvertToInt(value);
					if (name == "SVR") obj.Svr = ConvertToDouble(value);
					if (name == "COF") obj.Cof= ((value == "1") || (value == "YES"));
					if (name == "DOF") obj.Dof = ConvertToDouble(value);
					if (name == "GIP") obj.Gip= ((value == "1") || (value == "YES"));
					if (name == "LSV") obj.Lsv = ConvertToInt(value);
					if (name == "S21") obj.S21 = ConvertToInt(value);
					if (name == "AZS") obj.Azs = ConvertToDouble(value);
					if (name == "DSP") obj.Dsp = ConvertToInt(value);
					if (name == "RSP") obj.Rsp = ConvertToInt(value);
					if (name == "IOS") obj.Ios = ConvertToInt(value);
					if (name == "WSP") obj.Wsp = ConvertToInt(value);
					if (name == "TNM") obj.Tnm = value.Trim('"');
					if (name == "TTP") obj.Ttp = ConvertToInt(value);
					if (name == "TCL") obj.Tcl = ConvertToInt(value);
					if (name == "CRC") obj.Crc= (ToolCorrection)Enum.Parse(typeof(ToolCorrection),value);
					if (name == "TIN") obj.Tin= (LeadInOutType)Enum.Parse(typeof(LeadInOutType),value);
					if (name == "AIN") obj.Ain = ConvertToInt(value);
					if (name == "CIN") obj.Cin= ((value == "1") || (value == "YES"));
					if (name == "GIN") obj.Gin = ConvertToDouble(value);
					if (name == "TBI") obj.Tbi= ((value == "1") || (value == "YES"));
					if (name == "TLI") obj.Tli = ConvertToDouble(value);
					if (name == "TQI") obj.Tqi = ConvertToDouble(value);
					if (name == "TOU") obj.Tou= (LeadInOutType)Enum.Parse(typeof(LeadInOutType),value);
					if (name == "AOU") obj.Aou = ConvertToInt(value);
					if (name == "COU") obj.Cou= ((value == "1") || (value == "YES"));
					if (name == "GOU") obj.Gou = ConvertToInt(value);
					if (name == "TBO") obj.Tbo= ((value == "1") || (value == "YES"));
					if (name == "TLO") obj.Tlo = ConvertToDouble(value);
					if (name == "TQO") obj.Tqo = ConvertToDouble(value);
					if (name == "DIN") obj.Din = ConvertToDouble(value);
					if (name == "DOU") obj.Dou = ConvertToDouble(value);
					if (name == "SDS") obj.Sds = ConvertToDouble(value);
					if (name == "PRP") obj.Prp = ConvertToInt(value);
					if (name == "BDR") obj.Bdr= ((value == "1") || (value == "YES"));
					if (name == "SPI") obj.Spi = value.Trim('"');
					if (name == "SC") obj.Sc= ((value == "1") || (value == "YES"));
					if (name == "SWI") obj.Swi= ((value == "1") || (value == "YES"));
					if (name == "BLW") obj.Blw= ((value == "1") || (value == "YES"));
					if (name == "PRS") obj.Prs= ((value == "1") || (value == "YES"));
					if (name == "BFC") obj.Bfc= ((value == "1") || (value == "YES"));
					if (name == "SHP") obj.Shp = ConvertToInt(value);
					if (name == "SWP") obj.Swp= ((value == "1") || (value == "YES"));
					if (name == "CSP") obj.Csp = ConvertToInt(value);
					if (name == "UDT") obj.Udt= ((value == "1") || (value == "YES"));
					if (name == "TDT") obj.Tdt = value.Trim('"');
					if (name == "DDT") obj.Ddt = ConvertToDouble(value);
					if (name == "SDT") obj.Sdt = ConvertToDouble(value);
					if (name == "IDT") obj.Idt = ConvertToDouble(value);
					if (name == "FDT") obj.Fdt = ConvertToDouble(value);
					if (name == "RDT") obj.Rdt = ConvertToInt(value);
					if (name == "EA21") obj.Ea21= ((value == "1") || (value == "YES"));
					if (name == "CEN") obj.Cen = value.Trim('"');
					if (name == "AGG") obj.Agg = value.Trim('"');
					if (name == "LAY") obj.Lay = value.Trim('"');
					if (name == "EECS") obj.Eecs = ConvertToInt(value);
					if (name == "PDIN") obj.Pdin = ConvertToDouble(value);
					if (name == "PDU") obj.Pdu = ConvertToDouble(value);
					if (name == "PCIN") obj.Pcin = ConvertToDouble(value);
					if (name == "PCU") obj.Pcu = ConvertToDouble(value);
					if (name == "PMOL") obj.Pmol = ConvertToInt(value);
					if (name == "AUX") obj.Aux = ConvertToInt(value);
					if (name == "CRR") obj.Crr= ((value == "1") || (value == "YES"));
					if (name == "NEBS") obj.Nebs= ((value == "1") || (value == "YES"));
					if (name == "ETB") obj.Etb= ((value == "1") || (value == "YES"));
					if (name == "FXD") obj.Fxd= ((value == "1") || (value == "YES"));
					if (name == "FXDA") obj.Fxda = ConvertToInt(value);
					if (name == "KDT") obj.Kdt= ((value == "1") || (value == "YES"));
					if (name == "EML") obj.Eml= ((value == "1") || (value == "YES"));
					if (name == "ETG") obj.Etg= ((value == "1") || (value == "YES"));
					if (name == "RTAS") obj.Rtas= ((value == "1") || (value == "YES"));
					if (name == "RDIN") obj.Rdin= ((value == "1") || (value == "YES"));
					if (name == "IMS") obj.Ims = ConvertToInt(value);
					if (name == "SDSF") obj.Sdsf = ConvertToInt(value);
					if (name == "INCSTP") obj.Incstp= ((value == "1") || (value == "YES"));
					if (name == "ETGT") obj.Etgt = ConvertToDouble(value);
					if (name == "AJT") obj.Ajt= ((value == "1") || (value == "YES"));
					if (name == "ION") obj.Ion= ((value == "1") || (value == "YES"));
					if (name == "LUBMNZ") obj.Lubmnz= ((value == "1") || (value == "YES"));
					if (name == "SHT") obj.Sht= (ShtType)Enum.Parse(typeof(ShtType),value);
					if (name == "SHD") obj.Shd = ConvertToInt(value);
				}
			}
			return obj;
		}
	}
}
