using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Line</c> represents the line geometry.</summary>
    public class Line 
    {
        /// <value>Property <c>StartPoint</c> represents the start point of the geometry element.</value>
        public Point StartPoint {get; set;} = new Point();

        /// <value>Property <c>EndPoint</c> represents the end point of the geometry element.</value>
        public Point EndPoint {get; set;} = new Point();

        /// <value>Property <c>Xs</c> represents the X-axis co-ordinate of the start point of the geometry element.</value>
        public double Xs 
        {
            get { return StartPoint.X; }
            set { StartPoint.X = value;}
        }

        /// <value>Property <c>Ys</c> represents the Y-axis co-ordinate of the start point of the geometry element.</value>
        public double Ys 
        {
            get { return StartPoint.Y; }
            set { StartPoint.Y = value;}
        }

        /// <value>Property <c>Zs</c> represents the Z-axis co-ordinate of the start point of the geometry element.</value>
        public double Zs
        {
            get { return StartPoint.Z; }
            set { StartPoint.Z = value;}
        }

        /// <value>Property <c>Xe</c> represents the X-axis co-ordinate of the endpoint of the geometry element.</value>
        public double Xe
        {
            get { return EndPoint.X; }
            set { EndPoint.X = value;}
        }

        /// <value>Property <c>Ye</c> represents the Y-axis co-ordinate of the endpoint of the geometry element.</value>
        public double Ye 
        {
            get { return EndPoint.Y; }
            set { EndPoint.Y = value;}
        }

        /// <value>Property <c>Ze</c> represents the Z-axis co-ordinate of the endpoint of the geometry element.</value>
        public double Ze 
        {
            get { return EndPoint.Z; }
            set { EndPoint.Z = value;}
        }

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public virtual string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tLINE,XS=" + Xs.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",YS=" + Ys.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",ZS=" + Zs.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",XE=" + Xe.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",YE=" + Ye.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",ZE=" + Ze.ToString("F4", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}