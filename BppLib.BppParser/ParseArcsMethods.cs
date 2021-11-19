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
		public static AincAnCe ParseAincAnCe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			AincAnCe obj = new AincAnCe();
			obj.Id = id;
			obj.Xi = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yi = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.A = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[3]);
			obj.Zs = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[6]);
			obj.Fd = Convert.ToInt32(values[7]);
			obj.Sp = Convert.ToInt32(values[8]);
			obj.Sol = Convert.ToInt32(values[9]);
			return obj;
		}

		public static AincEpRa ParseAincEpRa(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			AincEpRa obj = new AincEpRa();
			obj.Id = id;
			obj.Xi = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yi = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[3]);
			obj.Zs = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[6]);
			obj.Fd = Convert.ToInt32(values[7]);
			obj.Sp = Convert.ToInt32(values[8]);
			obj.Sol = Convert.ToInt32(values[9]);
			return obj;
		}

		public static ArcAnCe ParseArcAnCe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcAnCe obj = new ArcAnCe();
			obj.Id = id;
			obj.A = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Xc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[3]);
			obj.Zs = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[6]);
			obj.Fd = Convert.ToInt32(values[7]);
			obj.Sp = Convert.ToInt32(values[8]);
			obj.Sol = Convert.ToInt32(values[9]);
			return obj;
		}

		public static ArcAnCeRaTp ParseArcAnCeRaTp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcAnCeRaTp obj = new ArcAnCeRaTp();
			obj.Id = id;
			obj.A = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Xc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[4]);
			obj.Zs = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[7]);
			obj.Fd = Convert.ToInt32(values[8]);
			obj.Sp = Convert.ToInt32(values[9]);
			obj.Sol = Convert.ToInt32(values[10]);
			return obj;
		}

		public static ArcCeTs ParseArcCeTs(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcCeTs obj = new ArcCeTs();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[2]);
			obj.Zs = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[5]);
			obj.Fd = Convert.ToInt32(values[6]);
			obj.Sp = Convert.ToInt32(values[7]);
			obj.Sol = Convert.ToInt32(values[8]);
			return obj;
		}

		public static ArcCeTsPk ParseArcCeTsPk(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcCeTsPk obj = new ArcCeTsPk();
			obj.Id = id;
			obj.Xc = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[2]);
			obj.Zs = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[5]);
			obj.Fd = Convert.ToInt32(values[6]);
			obj.Sp = Convert.ToInt32(values[7]);
			obj.Sol = Convert.ToInt32(values[8]);
			return obj;
		}

		public static ArcEpCe ParseArcEpCe(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcEpCe obj = new ArcEpCe();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Xc = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Yc = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[4]);
			obj.Zs = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[6], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[7]);
			obj.Fd = Convert.ToInt32(values[8]);
			obj.Sp = Convert.ToInt32(values[9]);
			obj.Sol = Convert.ToInt32(values[10]);
			return obj;
		}

		public static ArcEpRa ParseArcEpRa(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcEpRa obj = new ArcEpRa();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[3]);
			obj.Zs = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[6]);
			obj.Fd = Convert.ToInt32(values[7]);
			obj.Sp = Convert.ToInt32(values[8]);
			obj.Sol = Convert.ToInt32(values[9]);
			return obj;
		}

		public static ArcEpRaTp ParseArcEpRaTp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcEpRaTp obj = new ArcEpRaTp();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.R = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[3]);
			obj.Zs = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[6]);
			obj.Fd = Convert.ToInt32(values[7]);
			obj.Sp = Convert.ToInt32(values[8]);
			obj.Sol = Convert.ToInt32(values[9]);
			return obj;
		}

		public static ArcEpTp ParseArcEpTp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcEpTp obj = new ArcEpTp();
			obj.Id = id;
			obj.Xe = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[2]);
			obj.Zs = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[5]);
			obj.Fd = Convert.ToInt32(values[6]);
			obj.Sp = Convert.ToInt32(values[7]);
			obj.Sol = Convert.ToInt32(values[8]);
			return obj;
		}

		public static ArcIpEp ParseArcIpEp(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcIpEp obj = new ArcIpEp();
			obj.Id = id;
			obj.X2 = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Y2 = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Xe = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ye = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[4], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[5], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[6]);
			obj.Fd = Convert.ToInt32(values[7]);
			obj.Sp = Convert.ToInt32(values[8]);
			obj.Sol = Convert.ToInt32(values[9]);
			return obj;
		}

		public static ArcRaTs ParseArcRaTs(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcRaTs obj = new ArcRaTs();
			obj.Id = id;
			obj.R = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[1]);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static ArcRaTsPk ParseArcRaTsPk(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ArcRaTsPk obj = new ArcRaTsPk();
			obj.Id = id;
			obj.R = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Dir =(CircleDirection)Convert.ToInt32(values[1]);
			obj.Zs = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[3], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[4]);
			obj.Fd = Convert.ToInt32(values[5]);
			obj.Sp = Convert.ToInt32(values[6]);
			obj.Sol = Convert.ToInt32(values[7]);
			return obj;
		}

		public static ConnectorA ParseConnectorA(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ConnectorA obj = new ConnectorA();
			obj.Id = id;
			obj.R = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[3]);
			obj.Fd = Convert.ToInt32(values[4]);
			obj.Sp = Convert.ToInt32(values[5]);
			obj.Sol = Convert.ToInt32(values[6]);
			return obj;
		}

		public static ConnectorB ParseConnectorB(string code)
		{
			string[] subs = code.Split(':');
			string[] p1 = subs[0].Split(',');
			int id = Convert.ToInt32(p1[3]);
			string[] values = subs[1].Split(',');
			ConnectorB obj = new ConnectorB();
			obj.Id = id;
			obj.R = Convert.ToDouble(values[0], CultureInfo.InvariantCulture);
			obj.Zs = Convert.ToDouble(values[1], CultureInfo.InvariantCulture);
			obj.Ze = Convert.ToDouble(values[2], CultureInfo.InvariantCulture);
			obj.Sc =(SharpCorner)Convert.ToInt32(values[3]);
			obj.Fd = Convert.ToInt32(values[4]);
			obj.Sp = Convert.ToInt32(values[5]);
			obj.Sol = Convert.ToInt32(values[6]);
			return obj;
		}


    }
}
