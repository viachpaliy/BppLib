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
		/// <summary> Parses the line of code and returns the <c>Iso</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Iso</c> instance.</returns>
		public static Iso  ParseIso(string code)
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

		/// <summary> Parses the line of code and returns the <c>Offset</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Offset</c> instance.</returns>
		public static Offset  ParseOffset(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Offset obj = new Offset();
			obj.Id = id;
			obj.X = ConvertToDouble(values[0]);
			obj.Y = ConvertToDouble(values[1]);
			obj.Z = ConvertToDouble(values[2]);
			obj.Shw =(values[3].Trim() == "1");
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>PutProg</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>PutProg</c> instance.</returns>
		public static PutProg  ParsePutProg(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			PutProg obj = new PutProg();
			obj.IntId = id;
			obj.Id = values[0].Trim().Trim('"');
			obj.SpName = values[1].Trim().Trim('"');
			obj.SpLpx = ConvertToDouble(values[2]);
			obj.SpLpy = ConvertToDouble(values[3]);
			obj.SpLpz = ConvertToDouble(values[4]);
			obj.SymY =(values[5].Trim() == "1");
			obj.Rot = ConvertToDouble(values[6]);
			obj.SpCrn = ConvertToInt(values[7]);
			obj.Rft = ConvertToInt(values[8]);
			obj.Ref = ConvertToInt(values[9]);
			obj.Bck = ConvertToInt(values[10]);
			obj.X = ConvertToDouble(values[11]);
			obj.Y = ConvertToDouble(values[12]);
			obj.Pav =(values[13].Trim() == "1");
			obj.Vars = values[14].Trim().Trim('"');
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Rotate</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Rotate</c> instance.</returns>
		public static Rotate  ParseRotate(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Rotate obj = new Rotate();
			obj.Id = id;
			obj.X = ConvertToDouble(values[0]);
			obj.Y = ConvertToDouble(values[1]);
			obj.Ar = ConvertToDouble(values[2]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Scale</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Scale</c> instance.</returns>
		public static Scale  ParseScale(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Scale obj = new Scale();
			obj.Id = id;
			obj.X = ConvertToDouble(values[0]);
			obj.Y = ConvertToDouble(values[1]);
			obj.Fct = ConvertToDouble(values[2]);
			obj.Nu = ConvertToInt(values[3]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Shift</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Shift</c> instance.</returns>
		public static Shift  ParseShift(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Shift obj = new Shift();
			obj.Id = id;
			obj.X = ConvertToDouble(values[0]);
			obj.Y = ConvertToDouble(values[1]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>WFC</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>WFC</c> instance.</returns>
		public static WFC  ParseWFC(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFC obj = new WFC();
			obj.Id = id;
			obj.SideId = ConvertToInt(values[0]);
			obj.X = ConvertToDouble(values[1]);
			obj.Y = ConvertToDouble(values[2]);
			obj.Z = ConvertToDouble(values[3]);
			obj.Az = ConvertToDouble(values[4]);
			obj.H = ConvertToDouble(values[5]);
			obj.A = ConvertToDouble(values[6]);
			obj.Da = ConvertToDouble(values[7]);
			obj.R = ConvertToDouble(values[8]);
			obj.Dir =(CircleDirection)ConvertToInt(values[9]);
			obj.Vrt =(values[10].Trim() == "1");
			obj.Vf =(values[11].Trim() == "1");
			obj.Afh =(values[12].Trim() == "1");
			obj.Ucs =(values[13].Trim() == "1");
			obj.Rv =(values[14].Trim() == "1");
			obj.Lay = values[15].Trim().Trim('"');
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>WFG</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>WFG</c> instance.</returns>
		public static WFG  ParseWFG(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFG obj = new WFG();
			obj.Id = id;
			obj.SideId = ConvertToInt(values[0]);
			obj.Gid = values[1].Trim().Trim('"');
			obj.Pdf =(values[2].Trim() == "1");
			obj.Rv =(values[3].Trim() == "1");
			obj.Vf =(values[4].Trim() == "1");
			obj.Vrt =(values[5].Trim() == "1");
			obj.Az = ConvertToDouble(values[6]);
			obj.Lay = values[7].Trim().Trim('"');
			obj.Z = ConvertToDouble(values[8]);
			obj.Hgt = ConvertToDouble(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>WFGL</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>WFGL</c> instance.</returns>
		public static WFGL  ParseWFGL(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFGL obj = new WFGL();
			obj.Id = id;
			obj.SideId = ConvertToInt(values[0]);
			obj.Giz = values[1].Trim().Trim('"');
			obj.Rv =(values[2].Trim() == "1");
			obj.Vf =(values[3].Trim() == "1");
			obj.Lay = values[4].Trim().Trim('"');
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>WFGPS</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>WFGPS</c> instance.</returns>
		public static WFGPS  ParseWFGPS(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFGPS obj = new WFGPS();
			obj.Id = id;
			obj.SideId = ConvertToInt(values[0]);
			obj.Gid = values[1].Trim().Trim('"');
			obj.Giz = values[2].Trim().Trim('"');
			obj.Rv =(values[3].Trim() == "1");
			obj.Vf =(values[4].Trim() == "1");
			obj.Ps =(values[5].Trim() == "1");
			obj.Lay = values[6].Trim().Trim('"');
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>WFL</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>WFL</c> instance.</returns>
		public static WFL  ParseWFL(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			WFL obj = new WFL();
			obj.Id = id;
			obj.SideId = ConvertToInt(values[0]);
			obj.X = ConvertToDouble(values[1]);
			obj.Y = ConvertToDouble(values[2]);
			obj.Z = ConvertToDouble(values[3]);
			obj.Az = ConvertToDouble(values[4]);
			obj.Ar = ConvertToDouble(values[5]);
			obj.L = ConvertToDouble(values[6]);
			obj.H = ConvertToDouble(values[7]);
			obj.Vrt =(values[8].Trim() == "1");
			obj.Vf =(values[9].Trim() == "1");
			obj.Afl =(values[10].Trim() == "1");
			obj.Afh =(values[11].Trim() == "1");
			obj.Ucs =(values[12].Trim() == "1");
			obj.Rv =(values[13].Trim() == "1");
			obj.Frc = ConvertToInt(values[14]);
			obj.Lay = values[15].Trim().Trim('"');
			return obj;
		}

    
    }
}