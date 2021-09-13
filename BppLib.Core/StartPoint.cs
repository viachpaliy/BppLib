using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>StartPoint</c> models the starting point.</summary>
	public class StartPoint: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "START_POINT" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; }

        /// <value>Property <c>X</c> represents X-axis co-ordinate of the  starting point.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents Y-axis co-ordinate of the  starting point.</value>
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Z</c> represents the depth reached by the tool at the initial machining operation point.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c>.</value>
		public double Z { get; set; } = 0 ;

        /// <summary>This constructor initializes the new StartPoint
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public StartPoint()
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
			sb.Append(" " + X.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Y.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Z.ToString().Replace(",","."));
			return sb.ToString();
		}

		/// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=START_POINT");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString().Replace(",","."));
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}