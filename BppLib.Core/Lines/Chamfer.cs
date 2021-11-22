using System;
using System.Text;
using System.Globalization;


namespace BppLib.Core
{
    /// <summary>Class <c>Chamfer</c> models the chamfer.</summary>
	public class Chamfer: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "CHAMFER" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>D</c> represents the length of the chamfer.</value>
		public double D { get; set; } = 0 ;

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

        /// <value>Property <c>Sol</c> represents solutions that can be applied to the chamfer,
        /// on the basis of the data set previously.Values allowed: 0,1</value> 
		public int Sol { get; set; } = 0 ;

        /// <summary>This constructor initializes the new Chamfer
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Chamfer()
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
			sb.Append(" " + D.ToString(CultureInfo.InvariantCulture));
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
			sb.Append(",");
			sb.Append(" " + Sol.ToString());
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=CHAMFER");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=D,VALUE=" + D.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
            sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.AppendLine("	PARAM,NAME=SOL,VALUE=" + Sol.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}