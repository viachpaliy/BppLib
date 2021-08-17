using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>CircleCR</c> models the circle given centre and radius.</summary>.
	public class CircleCR: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "CIRCLE_CR" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>Xc</c> represents X-axis co-ordinate of the centre of the circle.</value>
		public double Xc { get; set; } = 0 ;

        /// <value>Property <c>Yc</c> represents Y-axis co-ordinate of the centre of the circle.</value>
		public double Yc { get; set; } = 0 ;

        /// <value>Property <c>R</c> represents the circle radius value.</value>
		public double R { get; set; } = 0 ;

        /// <value>Property <c>As</c> represents the angle of the circle start point.</value>
		public double As { get; set; } = 0 ;

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

        /// <summary>This constructor initializes the new CircleCR
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public CircleCR()
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
			sb.Append(" " + Xc.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Yc.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + R.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + As.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ((int)Dir).ToString());
			sb.Append(",");
			sb.Append(" " + Zs.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Ze.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ((int)Sc).ToString());
			sb.Append(",");
			sb.Append(" " + Fd.ToString());
			sb.Append(",");
			sb.Append(" " + Sp.ToString());
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=CIRCLE_CR");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=XC,VALUE=" + Xc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=YC,VALUE=" + Yc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=AS,VALUE=" + As.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
			sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}