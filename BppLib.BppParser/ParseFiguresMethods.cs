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
		/// <summary> Parses the line of code and returns the <c>Circle3P</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Circle3P</c> instance.</returns>
		public static Circle3P  ParseCircle3P(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Circle3P obj = new Circle3P();
			obj.Id = id;
			obj.X1 = ConvertToDouble(values[0]);
			obj.Y1 = ConvertToDouble(values[1]);
			obj.X2 = ConvertToDouble(values[2]);
			obj.Y2 = ConvertToDouble(values[3]);
			obj.X3 = ConvertToDouble(values[4]);
			obj.Y3 = ConvertToDouble(values[5]);
			obj.As = ConvertToDouble(values[6]);
			obj.Dir =(CircleDirection)ConvertToInt(values[7]);
			obj.Zs = ConvertToDouble(values[8]);
			obj.Ze = ConvertToDouble(values[9]);
			obj.Sc =(SharpCorner)ConvertToInt(values[10]);
			obj.Fd = ConvertToInt(values[11]);
			obj.Sp = ConvertToInt(values[12]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>CircleCR</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>CircleCR</c> instance.</returns>
		public static CircleCR  ParseCircleCR(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CircleCR obj = new CircleCR();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.R = ConvertToDouble(values[2]);
			obj.As = ConvertToDouble(values[3]);
			obj.Dir =(CircleDirection)ConvertToInt(values[4]);
			obj.Zs = ConvertToDouble(values[5]);
			obj.Ze = ConvertToDouble(values[6]);
			obj.Sc =(SharpCorner)ConvertToInt(values[7]);
			obj.Fd = ConvertToInt(values[8]);
			obj.Sp = ConvertToInt(values[9]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Ellipse</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Ellipse</c> instance.</returns>
		public static Ellipse  ParseEllipse(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Ellipse obj = new Ellipse();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.A1 = ConvertToDouble(values[2]);
			obj.A2 = ConvertToDouble(values[3]);
			obj.A = ConvertToDouble(values[4]);
			obj.As = ConvertToDouble(values[5]);
			obj.Dir =(CircleDirection)ConvertToInt(values[6]);
			obj.Une =(values[7].Trim() == "1");
			obj.Elm = ConvertToInt(values[8]);
			obj.Mle = ConvertToDouble(values[9]);
			obj.Ua =(values[10].Trim() == "1");
			obj.Zs = ConvertToDouble(values[11]);
			obj.Ze = ConvertToDouble(values[12]);
			obj.Sc =(SharpCorner)ConvertToInt(values[13]);
			obj.Fd = ConvertToInt(values[14]);
			obj.Sp = ConvertToInt(values[15]);
			obj.Ae = ConvertToDouble(values[16]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Oval</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Oval</c> instance.</returns>
		public static Oval  ParseOval(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Oval obj = new Oval();
			obj.Id = id;
			obj.X1 = ConvertToDouble(values[0]);
			obj.Y1 = ConvertToDouble(values[1]);
			obj.R1 = ConvertToDouble(values[2]);
			obj.X2 = ConvertToDouble(values[3]);
			obj.Y2 = ConvertToDouble(values[4]);
			obj.R2 = ConvertToDouble(values[5]);
			obj.Lkr = ConvertToDouble(values[6]);
			obj.As = ConvertToDouble(values[7]);
			obj.Dir =(CircleDirection)ConvertToInt(values[8]);
			obj.Zs = ConvertToDouble(values[9]);
			obj.Ze = ConvertToDouble(values[10]);
			obj.Sc =(SharpCorner)ConvertToInt(values[11]);
			obj.Fd = ConvertToInt(values[12]);
			obj.Sp = ConvertToInt(values[13]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Polygon</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Polygon</c> instance.</returns>
		public static Polygon  ParsePolygon(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Polygon obj = new Polygon();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.R = ConvertToDouble(values[2]);
			obj.S = ConvertToInt(values[3]);
			obj.Dir =(CircleDirection)ConvertToInt(values[4]);
			obj.Ct =(ChamferType)ConvertToInt(values[5]);
			obj.Cd = ConvertToDouble(values[6]);
			obj.Ss = ConvertToInt(values[7]);
            if (values[8].Trim() == "HALF")
                {
                    obj.StartFromHalfSide = true;
                }
            else
                {
                    obj.StartFromHalfSide = false; 
                    obj.Sd = ConvertToDouble(values[8]);
                }
			obj.A = ConvertToDouble(values[9]);
			obj.Zs = ConvertToDouble(values[10]);
			obj.Ze = ConvertToDouble(values[11]);
			obj.Sc =(SharpCorner)ConvertToInt(values[12]);
			obj.Fd = ConvertToInt(values[13]);
			obj.Sp = ConvertToInt(values[14]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Rectangle</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Rectangle</c> instance.</returns>
		public static Rectangle  ParseRectangle(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Rectangle obj = new Rectangle();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.L = ConvertToDouble(values[2]);
			obj.H = ConvertToDouble(values[3]);
			obj.Dir =(CircleDirection)ConvertToInt(values[4]);
			obj.Ct =(ChamferType)ConvertToInt(values[5]);
			obj.Cd = ConvertToDouble(values[6]);
			obj.Ss = ConvertToInt(values[7]);
            if (values[8].Trim() == "HALF")
                {
                    obj.StartFromHalfSide = true;
                }
            else
                {
                    obj.StartFromHalfSide = false; 
                    obj.Sd = ConvertToDouble(values[8]);
                }
			obj.A = ConvertToDouble(values[9]);
			obj.Zs = ConvertToDouble(values[10]);
			obj.Ze = ConvertToDouble(values[11]);
			obj.Sc =(SharpCorner)ConvertToInt(values[12]);
			obj.Fd = ConvertToInt(values[13]);
			obj.Sp = ConvertToInt(values[14]);
			obj.Usc =(values[15].Trim() == "1");
			obj.Crn = ConvertToInt(values[16]);
			return obj;
		}

		/// <summary> Parses the line of code and returns the <c>Star</c> instance.</summary>
		/// <param name="code"> The line of code.</param>
		/// <returns> The <c>Star</c> instance.</returns>
		public static Star  ParseStar(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Star obj = new Star();
			obj.Id = id;
			obj.Xc = ConvertToDouble(values[0]);
			obj.Yc = ConvertToDouble(values[1]);
			obj.Er = ConvertToDouble(values[2]);
			obj.Ir = ConvertToDouble(values[3]);
			obj.Ps = ConvertToInt(values[4]);
			obj.Dir =(CircleDirection)ConvertToInt(values[5]);
			obj.Ct =(ChamferType)ConvertToInt(values[6]);
			obj.Cd = ConvertToDouble(values[7]);
			obj.Ss = ConvertToInt(values[8]);
            if (values[9].Trim() == "HALF")
                {
                    obj.StartFromHalfSide = true;
                }
            else
                {
                    obj.StartFromHalfSide = false; 
                    obj.Sd = ConvertToDouble(values[9]);
                }
			obj.A = ConvertToDouble(values[10]);
			obj.Zs = ConvertToDouble(values[11]);
			obj.Ze = ConvertToDouble(values[12]);
			obj.Sc =(SharpCorner)ConvertToInt(values[13]);
			obj.Fd = ConvertToInt(values[14]);
			obj.Sp = ConvertToInt(values[15]);
			return obj;
		}


    }
}
