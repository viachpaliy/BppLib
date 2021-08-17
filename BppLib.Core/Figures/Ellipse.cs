using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>Ellipse</c> models the ellipse.</summary>.
	public class Ellipse: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "ELLIPSE" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>Xc</c> represents the X-axis co-ordinate of the centre of the ellipse.</value>
		public double Xc { get; set; } = 0 ;

        /// <value>Property <c>Yc</c> represents the Y-axis co-ordinate of the centre of the ellipse.</value>
		public double Yc { get; set; } = 0 ;

        /// <value>Property <c>A1</c> represents the value for the larger semi-axis of the ellipse.</value>
		public double A1 { get; set; } = 0 ;

        /// <value>Property <c>A2</c> represents the value for the smaller semi-axis of the ellipse.</value>
		public double A2 { get; set; } = 0 ;

        /// <value>Property <c>A</c> represents the value for the angle of rotation of the ellipse
        /// with respect to the centre of the ellipse itself.</value>
		public double A { get; set; } = 0 ;

        /// <value>Property <c>As</c> represents the angle of the ellipse start point.</value>
		public double As { get; set; } = 0 ;
		
		/// <value>Property <c>Dir</c> represents direction of the geometry;
        /// set dirCCW to indicate an anticlockwise direction, or set
        /// dirCW to indicate a clockwise direction.</value>
		public CircleDirection Dir { get; set; } = CircleDirection.dirCW ;

        /// <value>Property <c>Une</c> represents the type of geometry segmentation.
        /// When this is set to true, uses the number of lines or arcs for segmentation of the geometry into the <c>Elm</c> property.
        /// When it is set to false, uses the maximum length of the lines or the arcs into the <c>Mle</c> property.</value>
		public bool Une { get; set; } = true ;

        /// <value>Property <c>Elm</c> represents the number of lines or arcs for segmentation of the geometry.</value>
		public int Elm { get; set; } = 20 ;

        /// <value>Property <c>Mle</c> represents the maximum length of the lines or the arcs for segmentation of the geometry.</value>
		public double Mle { get; set; } = 0 ;

		/// <value>Property <c>Ua</c> definitions of the way in which the geometry is broken up into segments to allow proper machining.
        /// When this is set to true, uses the arcs. When it is set to false, uses the lines.</value>
        public bool Ua { get; set; } = true ;

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

		/// <value>Property <c>As</c> represents the angle of the ellipse end point.</value>
        public double Ae { get; set; } = 0 ;


        /// <summary>This constructor initializes the new Ellipse
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Ellipse()
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
			sb.Append(" " + A1.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + A2.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + A.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + As.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ((int)Dir).ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Une));
			sb.Append(",");
			sb.Append(" " + Elm.ToString());
			sb.Append(",");
			sb.Append(" " + Mle.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Ua));
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
			sb.Append(",");
			sb.Append(" " + Ae.ToString().Replace(",","."));
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=ELLIPSE");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=XC,VALUE=" + Xc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=YC,VALUE=" + Yc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=A1,VALUE=" + A1.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=A2,VALUE=" + A2.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=AS,VALUE=" + As.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
			sb.AppendLine("	PARAM,NAME=UNE,VALUE=" + ConvertBoolToYesNo(Une));
			sb.AppendLine("	PARAM,NAME=ELM,VALUE=" + Elm.ToString());
			sb.AppendLine("	PARAM,NAME=MLE,VALUE=" + Mle.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=UA,VALUE=" + ConvertBoolToYesNo(Ua));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
			sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.AppendLine("	PARAM,NAME=AE,VALUE=" + Ae.ToString().Replace(",","."));
			sb.Append("END MACRO");
			return sb.ToString();
		}

        string ConvertBoolToNum(bool value)
		{
			if (value)
				{return "1";}
			return "0";
		}

		string ConvertBoolToYesNo(bool value)
		{
			if (value)
				{return "YES";}
			return "NO";
		}

	}
}