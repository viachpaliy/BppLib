using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>Oval</c> models the oval.</summary>.
	public class Oval: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "OVAL" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>X1</c> represents the X-axis co-ordinate of the centre of the large circle in the oval.</value>
		public double X1 { get; set; } = 0 ;

        /// <value>Property <c>Y1</c> represents the Y-axis co-ordinate of the centre of the large circle in the oval.</value>
		public double Y1 { get; set; } = 0 ;

        /// <value>Property <c>R1</c> represents the radius of the large circle in the oval.</value>
		public double R1 { get; set; } = 0 ;

        /// <value>Property <c>X2</c> represents the X-axis co-ordinate of the centre of the small circle in the oval.</value>
		public double X2 { get; set; } = 0 ;

        /// <value>Property <c>Y2</c> represents the Y-axis co-ordinate of the centre of the small circle in the oval.</value>
		public double Y2 { get; set; } = 0 ;

        /// <value>Property <c>R2</c> represents the radius of the small circle in the oval.</value>
		public double R2 { get; set; } = 0 ;

        /// <value>Property <c>Lkr</c> represents the radius of the two arcs that unite the two circles in the oval.</value>
		public double Lkr { get; set; } = 0 ;

        /// <value>Property <c>As</c> represents the angle of the oval start point.</value>
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

		
        /// <summary>This constructor initializes the new Oval
   	    ///  with Id which equal a hash code of the C# object.</summary>
        public Oval()
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
			sb.Append(" " + X1.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Y1.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + R1.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + X2.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Y2.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + R2.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Lkr.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + As.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Dir).ToString());
			sb.Append(",");
			sb.Append(" " + Zs.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ze.ToString(CultureInfo.InvariantCulture));
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
			sb.AppendLine("	NAME=OVAL");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=X1,VALUE=" + X1.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y1,VALUE=" + Y1.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=R1,VALUE=" + R1.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=X2,VALUE=" + X2.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y2,VALUE=" + Y2.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=R2,VALUE=" + R2.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=LKR,VALUE=" + Lkr.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AS,VALUE=" + As.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
			sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}