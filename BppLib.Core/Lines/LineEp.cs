using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>LineEp</c> models the line given end point.
    /// Creates a line using the co-ordinates of a known endpoint as reference value.</summary>
	public class LineEp: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "LINE_EP" ;
		
        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
        public int Id { get; set; } 

        /// <value>Property <c>Xe</c> represents the X-axis co-ordinate of the endpoint of the element.</value>
		public double Xe { get; set; } = 0 ;

        /// <value>Property <c>Ye</c> represents the Y-axis co-ordinate of the endpoint of the element.</value>
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

        /// <value>Property <c>Sol</c> represents solutions that can be applied to the line,
        /// on the basis of the data set previously.Values allowed: 0,1</value> 
		public int Sol { get; set; } = 0 ;
        
        /// <value>Property <c>Mvt</c> used to indicate whether the segment of the profile generated must be considered
        /// as a tool positioning trajectory. If this is set at false, the segment is considered as being part of the
        /// machining; if it is set at true, the segment is considered as the positioning trajectory.
		public bool Mvt { get; set; } = false ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public LineEp()
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
			sb.Append(" " + Xe.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Ye.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Zs.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Ze.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + ((int)Sc).ToString());
			sb.Append(",");
			sb.Append(" " + Fd.ToString());
			sb.Append(",");
			sb.Append(" " + Sp.ToString());
			sb.Append(",");
			sb.Append(" " + Sol.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Mvt));
			return sb.ToString();
		}

		/// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=LINE_EP");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=XE,VALUE=" + Xe.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=YE,VALUE=" + Ye.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
			sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.AppendLine("	PARAM,NAME=SOL,VALUE=" + Sol.ToString());
			sb.AppendLine("	PARAM,NAME=MVT,VALUE=" + ConvertBoolToYesNo(Mvt));
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