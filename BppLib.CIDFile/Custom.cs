using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Custom</c> represents boring operation in the Biesse CID program.</summary>
    public class Custom : IBlock
    {
        public Tech TechBlock {get; set;} = new Tech();

        public int RefPoint {get; set;} = 2;

        public double X {get; set;} = 0;

        public double Y {get; set;} = 0;

        public double Z {get; set;} = 0;

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  BEGIN CUSTOM");
            sb.AppendLine(TechBlock.AsCidCode());
            sb.AppendLine("	REFPOINT=" + RefPoint.ToString() +" ");
            sb.Append("\tPOINT,X=" + X.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append(",Y=" + Y.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine(",Z=" + Z.ToString("F4", CultureInfo.InvariantCulture));
            sb.Append("  END CUSTOM");
            return sb.ToString();
        } 

        public string AsCidBlock()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN BLOCK");
            sb.AppendLine("  NAME=WRK");
            sb.AppendLine(this.AsCidCode());
            sb.Append("END BLOCK");
            return sb.ToString();
        }
    }
}