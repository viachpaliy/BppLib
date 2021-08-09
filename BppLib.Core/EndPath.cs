using System;
using System.Text;

namespace BppLib.Core
{
	/// <summary>Class <c>EndPath</c> models  the end of the machining operation.
	/// </summary>
	public class EndPath: IBppCode
	{
		/// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "ENDPATH" ;

		/// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

		/// <summary>This constructor initializes the new EndPath 
   	    ///  with Id which equal hash code of C# object.</summary>
		public EndPath()
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
			sb.Append(Id.ToString().Replace(",","."));
			sb.Append(", \"\", 0 :");
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
			sb.AppendLine("	NAME=ENDPATH");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString().Replace(",","."));
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}