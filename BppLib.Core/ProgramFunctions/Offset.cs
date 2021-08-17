using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>Offset</c> models the “OFFSET” instruction.
    /// The “OFFSET” instruction is used for temporary translation of the program origin,
    /// moving the piece so as to define a new offset.</summary>
	public class Offset: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "OFFSET" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; }

        /// <value>Property <c>X</c> represents the X-axis co-ordinate.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate.</value>
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Z</c> represents the Z-axis co-ordinate.</value>
		public double Z { get; set; } = 0 ;

		public bool Shw { get; set; } = false ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Offset()
		{
			Id = GetHashCode();
		}

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("@ " + BppName + ", \"\", \"\", ");
			sb.Append(Id.ToString());
			sb.Append(", \"\", 0 :");
			sb.Append(" " + X.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Y.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Z.ToString().Replace(',','.'));
			sb.Append(",");
            if (Shw)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=OFFSET");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString().Replace(',','.'));
            if (Shw)
			    {sb.AppendLine("	PARAM,NAME=SHW,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=SHW,VALUE=NO");}
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}