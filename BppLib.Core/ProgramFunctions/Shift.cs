using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>Shift</c> models the “SHIFT” instruction.
    /// The “SHIFT” instruction allows the geometries to be moved.</summary>
	public class Shift: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "SHIFT" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; }

        /// <value>Property <c>X</c> represents the X-axis co-ordinate.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate.</value>
		public double Y { get; set; } = 0 ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Shift()
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
			sb.Append(" " + X.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Y.ToString(CultureInfo.InvariantCulture));
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=SHIFT");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString(CultureInfo.InvariantCulture));
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}