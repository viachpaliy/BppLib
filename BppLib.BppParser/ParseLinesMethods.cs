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
        public static Chamfer ParseChamfer(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			Chamfer obj = new Chamfer();
			obj.Id = id;
			obj.D = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[3]);
			obj.Fd = Convert.ToInt32(values[4]);
			obj.Sp = Convert.ToInt32(values[5]);
			obj.Sol = Convert.ToInt32(values[6]);
			return obj;
		}

		public static LincEp ParseLincEp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LincEp obj = new LincEp();
			obj.Id = id;
			obj.Xi = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yi = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static LineAnXe ParseLineAnXe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineAnXe obj = new LineAnXe();
			obj.Id = id;
			obj.A = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Xe = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static LineAnYe ParseLineAnYe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineAnYe obj = new LineAnYe();
			obj.Id = id;
			obj.A = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static LineEp ParseLineEp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineEp obj = new LineEp();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			obj.Mvt = (values[8] == "1");
			return obj;
		}

		public static LineEpAnTp ParseLineEpAnTp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineEpAnTp obj = new LineEpAnTp();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.A = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[5]);
			obj.Fd = Convert.ToInt32(values[6]);
			obj.Sp = Convert.ToInt32(values[7]);
			obj.Sol = Convert.ToInt32(values[8]);
			return obj;
		}

		public static LineEpTp ParseLineEpTp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineEpTp obj = new LineEpTp();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static LineLnAn ParseLineLnAn(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineLnAn obj = new LineLnAn();
			obj.Id = id;
			obj.L = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.A = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static LineLnTp ParseLineLnTp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineLnTp obj = new LineLnTp();
			obj.Id = id;
			obj.L = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[3]);
			obj.Fd = Convert.ToInt32(values[4]);
			obj.Sp = Convert.ToInt32(values[5]);
			obj.Sol = Convert.ToInt32(values[6]);
			return obj;
		}

		public static LineLnXe ParseLineLnXe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineLnXe obj = new LineLnXe();
			obj.Id = id;
			obj.L = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Xe = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static LineLnYe ParseLineLnYe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			LineLnYe obj = new LineLnYe();
			obj.Id = id;
			obj.L = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

    }
}
