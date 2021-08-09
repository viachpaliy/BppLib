using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>ArcIpEp</c> models the curve using three points.
    /// Creates an arc passing through three points.
    /// </summary>
	public class ArcIpEp: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "ARC_IPEP" ;
		
        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
        public int Id { get; set; } 

        /// <value>Property <c>X2</c> represents X-axis co-ordinate of the second point in the arc.</value>
		public double X2 { get; set; } = 0 ;

        /// <value>Property <c>Y2</c> represents Y-axis co-ordinate of the second point in the arc.</value>
		public double Y2 { get; set; } = 0 ;

		/// <value>Property <c>Xe</c> represents X-axis co-ordinate of the endpoint of the arc.</value>
		public double Xe { get; set; } = 0 ;

        /// <value>Property <c>Ye</c> represents Y-axis co-ordinate of the endpoint of the arc.</value> 
		public double Ye { get; set; } = 0 ;

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

        /// <summary>This constructor initializes the new ArcIpEp
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public ArcIpEp()
		{
			Id = GetHashCode();
		}

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("@ " + BppName + ", \"\", \"\", ");
			sb.Append(Id.ToString().Replace(",","."));
			sb.Append(", \"\", 0 :");
			sb.Append(" " + X2.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Y2.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Xe.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Ye.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Zs.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Ze.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ((int)Sc).ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Fd.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Sp.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Sol.ToString().Replace(",","."));
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=ARC_IPEP");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=X2,VALUE=" + X2.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=Y2,VALUE=" + Y2.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=XE,VALUE=" + Xe.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=YE,VALUE=" + Ye.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SOL,VALUE=" + Sol.ToString().Replace(",","."));
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}