using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Arc</c> represents the arc geometry.</summary>
    public class Arc : Line 
    {
        /// <value>Property <c>Xc</c> represents X-axis co-ordinate of the centre of the arc.</value>
		public double Xc { get; set; } = 0 ;

        /// <value>Property <c>Yc</c> represents Y-axis co-ordinate of the centre of the arc.</value>
		public double Yc { get; set; } = 0 ;

        /// <value>Property <c>Zc</c> represents Z-axis co-ordinate of the centre of the arc.</value>
		public double Zc { get; set; } = 0 ;

        /// <value>Property <c>R</c> represents arc radius value.</value>
		public double R { get; set; } = 0 ;

        /// <value>Property <c>V</c> represents direction of the geometry;
        /// set "false" to indicate an anticlockwise direction, or set
        /// "true" to indicate a clockwise direction.</value>
        public bool V { get; set; } = true ;

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public override string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tARC ,XS=" + Xs.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",YS=" + Ys.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",ZS=" + Zs.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",XE=" + Xe.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",YE=" + Ye.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",ZE=" + Ze.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",XC=" + Xc.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",YC=" + Yc.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",ZC=" + Zc.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",R=" + R.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",V=");
            if (V) {sb.Append("O");}
            else {sb.Append("A");}
            return sb.ToString();
        }
    }
}