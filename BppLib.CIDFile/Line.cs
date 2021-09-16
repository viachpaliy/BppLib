using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Line</c> represents the line geometry.</summary>
    public class Line 
    {
        /// <value>Property <c>Xs</c> represents the X-axis co-ordinate of the start point of the geometry element.</value>
        public double Xs {get; set;} = 0;

        /// <value>Property <c>Ys</c> represents the Y-axis co-ordinate of the start point of the geometry element.</value>
        public double Ys {get; set;} = 0;

        /// <value>Property <c>Zs</c> represents the Z-axis co-ordinate of the start point of the geometry element.</value>
        public double Zs {get; set;} = 0;

        /// <value>Property <c>Xe</c> represents the X-axis co-ordinate of the endpoint of the geometry element.</value>
        public double Xe {get; set;} = 0;

        /// <value>Property <c>Ye</c> represents the Y-axis co-ordinate of the endpoint of the geometry element.</value>
        public double Ye {get; set;} = 0;

        /// <value>Property <c>Ze</c> represents the Z-axis co-ordinate of the endpoint of the geometry element.</value>
        public double Ze {get; set;} = 0;

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