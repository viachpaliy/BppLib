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
		public static Circle3P ParseCircle3P(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Circle3P obj = new Circle3P();
			obj.Id = id;
			obj.X1 = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y1 = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.X2 = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Y2 = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.X3 = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Y3 = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.As = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[7]);
			obj.Zs = Convert.ToDouble(values[8], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[10]);
			obj.Fd = Convert.ToInt32(values[11]);
			obj.Sp = Convert.ToInt32(values[12]);
			return obj;
		}

		public static CircleCR ParseCircleCR(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			CircleCR obj = new CircleCR();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.As = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[4]);
			obj.Zs = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[7]);
			obj.Fd = Convert.ToInt32(values[8]);
			obj.Sp = Convert.ToInt32(values[9]);
			return obj;
		}

		public static Ellipse ParseEllipse(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Ellipse obj = new Ellipse();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.A1 = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.A2 = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.A = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.As = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[6]);
			obj.Une =(values[7].Trim() == "1");
			obj.Elm = Convert.ToInt32(values[8]);
			obj.Mle = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			obj.Ua =(values[10].Trim() == "1");
			obj.Zs = Convert.ToDouble(values[11], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[12], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[13]);
			obj.Fd = Convert.ToInt32(values[14]);
			obj.Sp = Convert.ToInt32(values[15]);
			obj.Ae = Convert.ToDouble(values[16], CultureInfo.InvariantCulture);
			return obj;
		}

		public static Oval ParseOval(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Oval obj = new Oval();
			obj.Id = id;
			obj.X1 = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y1 = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.R1 = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.X2 = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Y2 = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.R2 = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Lkr = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.As = Convert.ToDouble(values[7], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[8]);
			obj.Zs = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[10], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[11]);
			obj.Fd = Convert.ToInt32(values[12]);
			obj.Sp = Convert.ToInt32(values[13]);
			return obj;
		}

		public static Polygon ParsePolygon(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Polygon obj = new Polygon();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.S = Convert.ToInt32(values[3]);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[4]);
			obj.Ct =(ChamferType)Convert.ToInt32(values[5]);
			obj.Cd = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Ss = Convert.ToInt32(values[7]);
            if (values[8].Trim() == "HALF")
                {
                    obj.StartFromHalfSide = true;
                }
            else
                {
                    obj.StartFromHalfSide = false; 
                    obj.Sd = Convert.ToDouble(values[8], CultureInfo.InvariantCulture);
                }
			obj.A = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[10], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[11], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[12]);
			obj.Fd = Convert.ToInt32(values[13]);
			obj.Sp = Convert.ToInt32(values[14]);
			return obj;
		}

		public static Rectangle ParseRectangle(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Rectangle obj = new Rectangle();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.L = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.H = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[4]);
			obj.Ct =(ChamferType)Convert.ToInt32(values[5]);
			obj.Cd = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Ss = Convert.ToInt32(values[7]);
            if (values[8].Trim() == "HALF")
                {
                    obj.StartFromHalfSide = true;
                }
            else
                {
                    obj.StartFromHalfSide = false; 
                    obj.Sd = Convert.ToDouble(values[8], CultureInfo.InvariantCulture);
                }
			obj.A = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[10], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[11], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[12]);
			obj.Fd = Convert.ToInt32(values[13]);
			obj.Sp = Convert.ToInt32(values[14]);
			obj.Usc =(values[15].Trim() == "1");
			obj.Crn = Convert.ToInt32(values[16]);
			return obj;
		}

		public static Star ParseStar(string code)
		{
			string[] subs = SplitColon(code);
			string[] p1 = SplitComma(subs[0]);
			int id = Convert.ToInt32(p1[3]);
			string[] values  = SplitComma(subs[1]);
			Star obj = new Star();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Er = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ir = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Ps = Convert.ToInt32(values[4]);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[5]);
			obj.Ct =(ChamferType)Convert.ToInt32(values[6]);
			obj.Cd = Convert.ToDouble(values[7], CultureInfo.InvariantCulture);
			obj.Ss = Convert.ToInt32(values[8]);
            if (values[9].Trim() == "HALF")
                {
                    obj.StartFromHalfSide = true;
                }
            else
                {
                    obj.StartFromHalfSide = false; 
                    obj.Sd = Convert.ToDouble(values[9], CultureInfo.InvariantCulture);
                }
			obj.A = Convert.ToDouble(values[10], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[11], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[12], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[13]);
			obj.Fd = Convert.ToInt32(values[14]);
			obj.Sp = Convert.ToInt32(values[15]);
			return obj;
		}


    }
}
