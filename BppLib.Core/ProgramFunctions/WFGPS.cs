using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>WFGPS</c> models the “WFGPS” instruction.
    /// The “WFGPS” instruction associated with two geometries designed one on the zero face and the
    /// other on one of the 4 standard side faces (1, 2, 3, 4) can be used to generate - on the basis of the
    /// angle of the segment created on the side face - a non-standard trapezoidal or vertical/inclined side.</summary>
	public class WFGPS: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "WFGPS" ;

		/// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>SideId</c> represents the numbered code to be attributed to the non-standard side created.</value> 
        public int SideId { get; set; } = 6 ;

		/// <value>Property <c>Gid</c> used to select the identification code of the geometry (drawing ID) made on face "0" of the piece.</value>
		public string Gid { get; set; } = "" ;

		/// <value>Property <c>Giz</c> allows the selection of the geometry identification code (drawing ID ) created on one
        /// of the four side faces (1, 2, 3, 4).</value>
		public string Giz { get; set; } = "" ;

		/// <value>Property <c>Rv</c> makes it possible to indicate that the part of the side on which to apply the machining
        /// operation is opposite to the default side.</value>
		public bool Rv { get; set; } = false ;

		///  <value>Property <c>Vf</c> used to indicate that the side generated is virtual, i.e. not displayed in the simulator.</value> 
		public bool Vf { get; set; } = false ;

        ///  <value>Property <c>Ps</c> used to indicate that the generated side is at right angles to plane X/Y. In this case,
        /// you must check that the two segments generated (i.e. the geometries designed on the zero face
        /// and the side face) have at least one extreme (start or end) point in common.</value>
		public bool Ps { get; set; } = false ;

        /// <value>Property <c>Lay</c> represents the string to identify the layer associated with the side created.</value>
		public string Lay { get; set; } = "WFGPS" ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public WFGPS()
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
			sb.Append(" " + SideId.ToString());
			sb.Append(",");
			sb.Append(" \"" + Gid + "\"");
			sb.Append(",");
			sb.Append(" \"" + Giz + "\"");
			sb.Append(",");
			if (Rv)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			if (Vf)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
            if (Ps)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Lay + "\"");
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=WFGPS");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + SideId.ToString());
			sb.AppendLine("	PARAM,NAME=GID,VALUE=\"" + Gid + "\"");
			sb.AppendLine("	PARAM,NAME=GIZ,VALUE=\"" + Giz + "\"");
			if (Rv)
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=NO");}
			if (Vf)
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=NO");}
            if (Ps)
				{sb.AppendLine("	PARAM,NAME=PS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=PS,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}