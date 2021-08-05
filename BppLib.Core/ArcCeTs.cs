using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>ArcCeTs</c> models the curve given centre and tangency to next element
	/// (with previous point determined).
    /// Creates an arc with a known start point, using the co-ordinates of the centre of the arc and the tangency to
    /// the following element as reference values.
    /// </summary>
	public class ArcCeTs: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "ARC_CETS" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>Xc</c> represents X-axis co-ordinate of the centre of the arc.</value>
		public double Xc { get; set; } = 0 ;

        /// <value>Property <c>Yc</c> represents Y-axis co-ordinate of the centre of the arc.</value>
		public double Yc { get; set; } = 0 ;

		/// <value>Property <c>Dir</c> represents direction of the geometry;
        /// set dirCCW to indicate an anticlockwise direction, or set
        /// dirCW to indicate a clockwise direction.</value>
		public CircleDirection Dir { get; set; } = CircleDirection.dirCW ;

		/// <value>Property <c>Zs</c> represents value of the increase in machining depth in the initial part of the element.</value>
		public double Zs { get; set; } = 0 ;

        /// <value>Property <c>Ze</c> represents value of the increase in machining depth in the final part of the element.</value>
		public double Ze { get; set; } = 0 ;

        /// <value>Property <c>Sc</c> set sharp corner. Select one of the possible options to indicate that the point of
        /// intersection between the arc and the next element must be machined leaving a sharp corner.</value>
		 public SharpCorner Sc { get; set; } = SharpCorner.scOFF ;

        /// <value>Property <c>Fd</c> represents tool speed of advance value.</value>
		public int Fd { get; set; } = 0 ;

        /// <value>Property <c>Sp</c> represents tool rotation speed value.</value>
		public int Sp { get; set; } = 0 ;

        /// <value>Property <c>Sol</c> represents solutions that can be applied to the arc,
        /// on the basis of the data set previously.Values allowed: 0,1</value> 
		public int Sol { get; set; } = 0 ;

        /// <summary>This constructor initializes the new ArcCeTs
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public ArcCeTs()
		{
			Id = GetHashCode();
		}

        /// <summary>This method serializes an object as Bpp code.
		/// </summary>
		/// <returns>A string  is coded as Bpp code.
		/// </returns>
		public string AsBppCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("@ " + BppName + ", \"\", \"\", ");
			sb.Append(Id.ToString());
			sb.Append(", \"\", 0 :");
			sb.Append(" " + Xc.ToString());
			sb.Append(",");
			sb.Append(" " + Yc.ToString());
			sb.Append(",");
			sb.Append(" " + ((int)Dir).ToString());
			sb.Append(",");
			sb.Append(" " + Zs.ToString());
			sb.Append(",");
			sb.Append(" " + Ze.ToString());
			sb.Append(",");
			sb.Append(" " + ((int)Sc).ToString());
			sb.Append(",");
			sb.Append(" " + Fd.ToString());
			sb.Append(",");
			sb.Append(" " + Sp.ToString());
			sb.Append(",");
			sb.Append(" " + Sol.ToString());
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.
		/// </summary>
		/// <returns>A string  is coded as Cix code.
		/// </returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=ARC_CETS");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=XC,VALUE=" + Xc.ToString());
			sb.AppendLine("	PARAM,NAME=YC,VALUE=" + Yc.ToString());
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
            sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString());
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString());
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
           	sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.AppendLine("	PARAM,NAME=SOL,VALUE=" + Sol.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}