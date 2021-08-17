using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>Scale</c> models the “SCALE” instruction.
    /// The “SCALE” instruction uses a scaling factor to reduce or increase the size of the geometries.</summary>
	public class Scale: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "SCALE" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; }

        /// <value>Property <c>X</c> represents the X-axis co-ordinate of the centre of scale.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate of the centre of scale.</value>
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the scale factor.</value>
		public double Fct { get; set; } = 0 ;

		public int Nu { get; set; } = 0 ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Scale()
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
			sb.Append(" " + Fct.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=SCALE");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=FCT,VALUE=" + Fct.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}