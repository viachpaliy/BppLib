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
		public static Iso ParseIso(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Iso obj = new Iso();
			obj.Id = id;
			obj.IsoText = values[0].Trim().Trim('"');
			return obj;
		}

		public static Offset ParseOffset(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Offset obj = new Offset();
			obj.Id = id;
			obj.X = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Z = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Shw =(values[3].Trim() == "1");
			return obj;
		}

		public static PutProg ParsePutProg(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			PutProg obj = new PutProg();
			obj.IntId = id;
			obj.Id = values[0].Trim().Trim('"');
			obj.SpName = values[1].Trim().Trim('"');
			obj.SpLpx = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.SpLpy = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.SpLpz = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.SymY =(values[5].Trim() == "1");
			obj.Rot = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.SpCrn = Convert.ToInt32(values[7]);
			obj.Rft = Convert.ToInt32(values[8]);
			obj.Ref = Convert.ToInt32(values[9]);
			obj.Bck = Convert.ToInt32(values[10]);
			obj.X = Convert.ToDouble(values[11], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[12], CultureInfo.InvariantCulture);
			obj.Pav =(values[13].Trim() == "1");
			obj.Vars = values[14].Trim().Trim('"');
			return obj;
		}

		public static Rotate ParseRotate(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Rotate obj = new Rotate();
			obj.Id = id;
			obj.X = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Ar = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			return obj;
		}

		public static Scale ParseScale(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Scale obj = new Scale();
			obj.Id = id;
			obj.X = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Fct = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Nu = Convert.ToInt32(values[3]);
			return obj;
		}

		public static Shift ParseShift(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Shift obj = new Shift();
			obj.Id = id;
			obj.X = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			return obj;
		}

		public static WFC ParseWFC(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFC obj = new WFC();
			obj.Id = id;
			obj.SideId = Convert.ToInt32(values[0]);
			obj.X = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Z = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Az = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.H = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.A = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Da = Convert.ToDouble(values[7], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[8], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[9]);
			obj.Vrt =(values[10].Trim() == "1");
			obj.Vf =(values[11].Trim() == "1");
			obj.Afh =(values[12].Trim() == "1");
			obj.Ucs =(values[13].Trim() == "1");
			obj.Rv =(values[14].Trim() == "1");
			obj.Lay = values[15].Trim().Trim('"');
			return obj;
		}

		public static WFG ParseWFG(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFG obj = new WFG();
			obj.Id = id;
			obj.SideId = Convert.ToInt32(values[0]);
			obj.Gid = values[1].Trim().Trim('"');
			obj.Pdf =(values[2].Trim() == "1");
			obj.Rv =(values[3].Trim() == "1");
			obj.Vf =(values[4].Trim() == "1");
			obj.Vrt =(values[5].Trim() == "1");
			obj.Az = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Lay = values[7].Trim().Trim('"');
			obj.Z = Convert.ToDouble(values[8], CultureInfo.InvariantCulture);
			obj.Hgt = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			return obj;
		}

		public static WFGL ParseWFGL(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFGL obj = new WFGL();
			obj.Id = id;
			obj.SideId = Convert.ToInt32(values[0]);
			obj.Giz = values[1].Trim().Trim('"');
			obj.Rv =(values[2].Trim() == "1");
			obj.Vf =(values[3].Trim() == "1");
			obj.Lay = values[4].Trim().Trim('"');
			return obj;
		}

		public static WFGPS ParseWFGPS(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFGPS obj = new WFGPS();
			obj.Id = id;
			obj.SideId = Convert.ToInt32(values[0]);
			obj.Gid = values[1].Trim().Trim('"');
			obj.Giz = values[2].Trim().Trim('"');
			obj.Rv =(values[3].Trim() == "1");
			obj.Vf =(values[4].Trim() == "1");
			obj.Ps =(values[5].Trim() == "1");
			obj.Lay = values[6].Trim().Trim('"');
			return obj;
		}

		public static WFL ParseWFL(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFL obj = new WFL();
			obj.Id = id;
			obj.SideId = Convert.ToInt32(values[0]);
			obj.X = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Y = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Z = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Az = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ar = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.L = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.H = Convert.ToDouble(values[7], CultureInfo.InvariantCulture);
			obj.Vrt =(values[8].Trim() == "1");
			obj.Vf =(values[9].Trim() == "1");
			obj.Afl =(values[10].Trim() == "1");
			obj.Afh =(values[11].Trim() == "1");
			obj.Ucs =(values[12].Trim() == "1");
			obj.Rv =(values[13].Trim() == "1");
			obj.Frc = Convert.ToInt32(values[14]);
			obj.Lay = values[15].Trim().Trim('"');
			return obj;
		}

    
    }
}