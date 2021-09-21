using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>MainData</c> models MAINDATA section in CID program.</summary>
    public class MainData
    {
        /// <value>Property <c>Lx</c> represents the piece width (X dimension of the piece).</value>
        public double Lx { get; set; } = 800 ;

        /// <value>Property <c>Ly</c> represents the piece height (Y dimension of the piece).</value>
        public double Ly { get; set; } = 500 ;

        /// <value>Property <c>Lz</c> represents the thickness of the piece.</value>
        public double Lz { get; set; } = 30 ; 

        public double Ox { get; set; } = 0 ;

        public double Oy { get; set; } = 0 ;

        public double Oz { get; set; } = 0 ;

        public Tech TechBlock {get; set;} = new Tech();

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN MAINDATA");
            sb.AppendLine("  LX=" + Lx.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("  LY=" + Ly.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("  LZ=" + Lz.ToString("F4", CultureInfo.InvariantCulture));
            sb.AppendLine("  OX= " + Ox.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("  OY= " + Oy.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("  OZ= " + Oz.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine(TechBlock.AsCidCode()); 
            sb.Append("END MAINDATA");
            return sb.ToString();
        }

    }
}