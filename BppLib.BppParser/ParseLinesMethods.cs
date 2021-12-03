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
		/// <summary> Parses the line of code and returns the <c>Chamfer</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Chamfer</c> instance.</returns>
        public static Chamfer ParseChamfer(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Chamfer obj = new Chamfer();
			obj.Id = id;
			obj.D = ConvertToDouble(values[0]);
			obj.Zs = ConvertToDouble(values[1]);
			obj.Ze = ConvertToDouble(values[2]);
			obj.Sc =(SharpCorner)ConvertToInt(values[3]);
			obj.Fd = ConvertToInt(values[4]);
			obj.Sp = ConvertToInt(values[5]);
			obj.Sol = ConvertToInt(values[6]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LincEp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LincEp</c> instance.</returns>
		public static LincEp  ParseLincEp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LincEp obj = new LincEp();
			obj.Id = id;
			obj.Xi = ConvertToDouble(values[0]);
			obj.Yi = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineAnXe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineAnXe</c> instance.</returns>
		public static LineAnXe  ParseLineAnXe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineAnXe obj = new LineAnXe();
			obj.Id = id;
			obj.A = ConvertToDouble(values[0]);
			obj.Xe = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineAnYe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineAnYe</c> instance.</returns>
		public static LineAnYe  ParseLineAnYe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineAnYe obj = new LineAnYe();
			obj.Id = id;
			obj.A = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineEp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineEp</c> instance.</returns>
		public static LineEp  ParseLineEp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineEp obj = new LineEp();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			obj.Mvt = (values[8] == "1");
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineEpAnTp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineEpAnTp</c> instance.</returns>
		public static LineEpAnTp  ParseLineEpAnTp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineEpAnTp obj = new LineEpAnTp();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.A = ConvertToDouble(values[2]);
			obj.Zs = ConvertToDouble(values[3]);
			obj.Ze = ConvertToDouble(values[4]);
			obj.Sc =(SharpCorner)ConvertToInt(values[5]);
			obj.Fd = ConvertToInt(values[6]);
			obj.Sp = ConvertToInt(values[7]);
			obj.Sol = ConvertToInt(values[8]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineEpTp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineEpTp</c> instance.</returns>
		public static LineEpTp  ParseLineEpTp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineEpTp obj = new LineEpTp();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineLnAn</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineLnAn</c> instance.</returns>
		public static LineLnAn  ParseLineLnAn(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineLnAn obj = new LineLnAn();
			obj.Id = id;
			obj.L = ConvertToDouble(values[0]);
			obj.A = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineLnTp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineLnTp</c> instance.</returns>
		public static LineLnTp  ParseLineLnTp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineLnTp obj = new LineLnTp();
			obj.Id = id;
			obj.L = ConvertToDouble(values[0]);
			obj.Zs = ConvertToDouble(values[1]);
			obj.Ze = ConvertToDouble(values[2]);
			obj.Sc =(SharpCorner)ConvertToInt(values[3]);
			obj.Fd = ConvertToInt(values[4]);
			obj.Sp = ConvertToInt(values[5]);
			obj.Sol = ConvertToInt(values[6]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineLnXe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineLnXe</c> instance.</returns>
		public static LineLnXe  ParseLineLnXe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineLnXe obj = new LineLnXe();
			obj.Id = id;
			obj.L = ConvertToDouble(values[0]);
			obj.Xe = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>LineLnYe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>LineLnYe</c> instance.</returns>
		public static LineLnYe  ParseLineLnYe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			LineLnYe obj = new LineLnYe();
			obj.Id = id;
			obj.L = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

    }
}
