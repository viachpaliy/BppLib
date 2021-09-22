using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>PLine</c> represents cutting and milling operations in the CID program.</summary>
    public class PLine : IBlock
    {
        public Tech TechBlock {get; set;} = new Tech();

        /// <value>Property <c>Side</c> represents the piece side.</value>
        public int Side {get; set;} = 0;

        /// <value>Property <c>Geometry</c> represents the geometry of operation.</value>
        public List<Line> Geometry = new List<Line>();

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {StringBuilder sb = new StringBuilder();
            sb.AppendLine("  BEGIN PLINE");
            sb.AppendLine(TechBlock.AsCidCode());
            foreach(var item in Geometry)
            {
                sb.Append("\r\n" + item.AsCidCode());
            }
            sb.Append("\r\n" + "  END PLINE");
            return sb.ToString();
        }

        /// <summary>This method turns the <c>PLine</c> into "BLOCK".</summary>
        public string AsCidBlock()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN BLOCK");
            sb.AppendLine("  NAME=WRK");
            sb.AppendLine("  SIDE=" + Side.ToString());
            sb.AppendLine(this.AsCidCode());
            sb.Append("END BLOCK");
            return sb.ToString();
        }
    }
}