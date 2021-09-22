using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Point</c> represents the point in 3D space.</summary>
    public class Point
    {
        /// <value>Property <c>X</c> represents the X-axis co-ordinate of the point.</value>
        public double X {get; set;} = 0;

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate of the point.</value>
        public double Y {get; set;} = 0;

        /// <value>Property <c>Z</c> represents the Z-axis co-ordinate of the point.</value>
        public double Z {get; set;} = 0;

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\tPOINT,X=" + X.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",Y=" + Y.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",Z=" + Z.ToString("F4", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}