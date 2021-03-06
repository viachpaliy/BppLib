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
		/// <summary> Parses the line of code and returns the <c>AincAnCe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>AincAnCe</c> instance.</returns>
		public static AincAnCe  ParseAincAnCe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			AincAnCe obj = new AincAnCe();
			obj.Id = id;
			obj.Xi = ConvertToDouble(values[0]);
			obj.Yi = ConvertToDouble(values[1]);
			obj.A = ConvertToDouble(values[2]);
			obj.Dir =(CircleDirection)ConvertToInt(values[3]);
			obj.Zs = ConvertToDouble(values[4]);
			obj.Ze = ConvertToDouble(values[5]);
			obj.Sc =(SharpCorner)ConvertToInt(values[6]);
			obj.Fd = ConvertToInt(values[7]);
			obj.Sp = ConvertToInt(values[8]);
			obj.Sol = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>AincEpRa</c> instance.</summary>
		/// <param name="code"> he line of code.</param>
		/// <returns> The <c>AincEpRa</c> instance.</returns>
		public static AincEpRa  ParseAincEpRa(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			AincEpRa obj = new AincEpRa();
			obj.Id = id;
			obj.Xi = ConvertToDouble(values[0]);
			obj.Yi = ConvertToDouble(values[1]);
			obj.R = ConvertToDouble(values[2]);
			obj.Dir =(CircleDirection)ConvertToInt(values[3]);
			obj.Zs = ConvertToDouble(values[4]);
			obj.Ze = ConvertToDouble(values[5]);
			obj.Sc =(SharpCorner)ConvertToInt(values[6]);
			obj.Fd = ConvertToInt(values[7]);
			obj.Sp = ConvertToInt(values[8]);
			obj.Sol = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcAnCe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcAnCe</c> instance.</returns>
		public static ArcAnCe  ParseArcAnCe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcAnCe obj = new ArcAnCe();
			obj.Id = id;
			obj.A = ConvertToDouble(values[0]);
			obj.Xc = ConvertToDouble(values[1]);
			obj.Yc = ConvertToDouble(values[2]);
			obj.Dir =(CircleDirection)ConvertToInt(values[3]);
			obj.Zs = ConvertToDouble(values[4]);
			obj.Ze = ConvertToDouble(values[5]);
			obj.Sc =(SharpCorner)ConvertToInt(values[6]);
			obj.Fd = ConvertToInt(values[7]);
			obj.Sp = ConvertToInt(values[8]);
			obj.Sol = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcAnCeRaTp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcAnCeRaTp</c> instance.</returns>
		public static ArcAnCeRaTp  ParseArcAnCeRaTp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcAnCeRaTp obj = new ArcAnCeRaTp();
			obj.Id = id;
			obj.A = ConvertToDouble(values[0]);
			obj.Xc = ConvertToDouble(values[1]);
			obj.Yc = ConvertToDouble(values[2]);
			obj.R = ConvertToDouble(values[3]);
			obj.Dir =(CircleDirection)ConvertToInt(values[4]);
			obj.Zs = ConvertToDouble(values[5]);
			obj.Ze = ConvertToDouble(values[6]);
			obj.Sc =(SharpCorner)ConvertToInt(values[7]);
			obj.Fd = ConvertToInt(values[8]);
			obj.Sp = ConvertToInt(values[9]);
			obj.Sol = ConvertToInt(values[10]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcCeTs</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcCeTs</c> instance.</returns>
		public static ArcCeTs  ParseArcCeTs(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcCeTs obj = new ArcCeTs();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.Dir =(CircleDirection)ConvertToInt(values[2]);
			obj.Zs = ConvertToDouble(values[3]);
			obj.Ze = ConvertToDouble(values[4]);
			obj.Sc =(SharpCorner)ConvertToInt(values[5]);
			obj.Fd = ConvertToInt(values[6]);
			obj.Sp = ConvertToInt(values[7]);
			obj.Sol = ConvertToInt(values[8]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcCeTsPk</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcCeTsPk</c> instance.</returns>
		public static ArcCeTsPk  ParseArcCeTsPk(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcCeTsPk obj = new ArcCeTsPk();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.Dir =(CircleDirection)ConvertToInt(values[2]);
			obj.Zs = ConvertToDouble(values[3]);
			obj.Ze = ConvertToDouble(values[4]);
			obj.Sc =(SharpCorner)ConvertToInt(values[5]);
			obj.Fd = ConvertToInt(values[6]);
			obj.Sp = ConvertToInt(values[7]);
			obj.Sol = ConvertToInt(values[8]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcEpCe</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcEpCe</c> instance.</returns>
		public static ArcEpCe  ParseArcEpCe(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcEpCe obj = new ArcEpCe();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.Xc = ConvertToDouble(values[2]);
			obj.Yc = ConvertToDouble(values[3]);
			obj.Dir =(CircleDirection)ConvertToInt(values[4]);
			obj.Zs = ConvertToDouble(values[5]);
			obj.Ze = ConvertToDouble(values[6]);
			obj.Sc =(SharpCorner)ConvertToInt(values[7]);
			obj.Fd = ConvertToInt(values[8]);
			obj.Sp = ConvertToInt(values[9]);
			obj.Sol = ConvertToInt(values[10]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcEpRa</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcEpRa</c> instance.</returns>
		public static ArcEpRa  ParseArcEpRa(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcEpRa obj = new ArcEpRa();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.R = ConvertToDouble(values[2]);
			obj.Dir =(CircleDirection)ConvertToInt(values[3]);
			obj.Zs = ConvertToDouble(values[4]);
			obj.Ze = ConvertToDouble(values[5]);
			obj.Sc =(SharpCorner)ConvertToInt(values[6]);
			obj.Fd = ConvertToInt(values[7]);
			obj.Sp = ConvertToInt(values[8]);
			obj.Sol = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcEpRaTp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcEpRaTp</c> instance.</returns>
		public static ArcEpRaTp  ParseArcEpRaTp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcEpRaTp obj = new ArcEpRaTp();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.R = ConvertToDouble(values[2]);
			obj.Dir =(CircleDirection)ConvertToInt(values[3]);
			obj.Zs = ConvertToDouble(values[4]);
			obj.Ze = ConvertToDouble(values[5]);
			obj.Sc =(SharpCorner)ConvertToInt(values[6]);
			obj.Fd = ConvertToInt(values[7]);
			obj.Sp = ConvertToInt(values[8]);
			obj.Sol = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcEpTp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcEpTp</c> instance.</returns>
		public static ArcEpTp  ParseArcEpTp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcEpTp obj = new ArcEpTp();
			obj.Id = id;
			obj.Xe = ConvertToDouble(values[0]);
			obj.Ye = ConvertToDouble(values[1]);
			obj.Dir =(CircleDirection)ConvertToInt(values[2]);
			obj.Zs = ConvertToDouble(values[3]);
			obj.Ze = ConvertToDouble(values[4]);
			obj.Sc =(SharpCorner)ConvertToInt(values[5]);
			obj.Fd = ConvertToInt(values[6]);
			obj.Sp = ConvertToInt(values[7]);
			obj.Sol = ConvertToInt(values[8]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcIpEp</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcIpEp</c> instance.</returns>
		public static ArcIpEp  ParseArcIpEp(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcIpEp obj = new ArcIpEp();
			obj.Id = id;
			obj.X2 = ConvertToDouble(values[0]);
			obj.Y2 = ConvertToDouble(values[1]);
			obj.Xe = ConvertToDouble(values[2]);
			obj.Ye = ConvertToDouble(values[3]);
			obj.Zs = ConvertToDouble(values[4]);
			obj.Ze = ConvertToDouble(values[5]);
			obj.Sc =(SharpCorner)ConvertToInt(values[6]);
			obj.Fd = ConvertToInt(values[7]);
			obj.Sp = ConvertToInt(values[8]);
			obj.Sol = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcRaTs</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcRaTs</c> instance.</returns>
		public static ArcRaTs  ParseArcRaTs(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcRaTs obj = new ArcRaTs();
			obj.Id = id;
			obj.R = ConvertToDouble(values[0]);
			obj.Dir =(CircleDirection)ConvertToInt(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ArcRaTsPk</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ArcRaTsPk</c> instance.</returns>
		public static ArcRaTsPk  ParseArcRaTsPk(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ArcRaTsPk obj = new ArcRaTsPk();
			obj.Id = id;
			obj.R = ConvertToDouble(values[0]);
			obj.Dir =(CircleDirection)ConvertToInt(values[1]);
			obj.Zs = ConvertToDouble(values[2]);
			obj.Ze = ConvertToDouble(values[3]);
			obj.Sc =(SharpCorner)ConvertToInt(values[4]);
			obj.Fd = ConvertToInt(values[5]);
			obj.Sp = ConvertToInt(values[6]);
			obj.Sol = ConvertToInt(values[7]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ConnectorA</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ConnectorA</c> instance.</returns>
		public static ConnectorA  ParseConnectorA(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ConnectorA obj = new ConnectorA();
			obj.Id = id;
			obj.R = ConvertToDouble(values[0]);
			obj.Zs = ConvertToDouble(values[1]);
			obj.Ze = ConvertToDouble(values[2]);
			obj.Sc =(SharpCorner)ConvertToInt(values[3]);
			obj.Fd = ConvertToInt(values[4]);
			obj.Sp = ConvertToInt(values[5]);
			obj.Sol = ConvertToInt(values[6]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>ConnectorB</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>ConnectorB</c> instance.</returns>
		public static ConnectorB  ParseConnectorB(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			ConnectorB obj = new ConnectorB();
			obj.Id = id;
			obj.R = ConvertToDouble(values[0]);
			obj.Zs = ConvertToDouble(values[1]);
			obj.Ze = ConvertToDouble(values[2]);
			obj.Sc =(SharpCorner)ConvertToInt(values[3]);
			obj.Fd = ConvertToInt(values[4]);
			obj.Sp = ConvertToInt(values[5]);
			obj.Sol = ConvertToInt(values[6]);
			return obj;
		}


    }
}
