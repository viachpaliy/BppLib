using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Block</c> represents the block of the CID program.</summary>
    public class Block : IBlock
    {
        /// <value>Property <c>Name</c> represents the name of the block.</value>
        public string Name {get; set;} = "WRK";

        /// <value>Property <c>Side</c> represents the piece side.</value>
        public int Side {get; set;} = 0;

        public string Color {get; set;} = "LIGHT_GREEN";

        public bool Visibility = true;

        public List<IBlock> Operations = new List<IBlock>();

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in Operations)
            {
                sb.AppendLine(item.AsCidCode());
            }
            return sb.ToString();
        }

        /// <summary>This method serializes an object as Cid block.</summary>
		/// <returns>A string  is coded as Cid block.</returns>
        public string AsCidBlock()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN BLOCK");
            sb.AppendLine("  NAME=" + Name);
            sb.AppendLine("  SIDE=" + Side.ToString());
            sb.AppendLine("  COLOR=" + Color);
            if (Visibility)
                {sb.AppendLine("  VISIBILITY=YES");}
            else
                {sb.AppendLine("  VISIBILITY=NO");}
            foreach(var item in Operations)
            {
                sb.AppendLine(item.AsCidCode());
            }
            sb.Append("END BLOCK");
            return sb.ToString();
        }

    }
}