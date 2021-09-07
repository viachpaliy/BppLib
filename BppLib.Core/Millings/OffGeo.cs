using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>OffGeo</c> models the geometry offset.</summary>
	public class OffGeo: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "OFFGEO" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Id</c> represents the description of the generated geometry.</value> 
		public string Id { get; set; } = "P1001" ;

        /// <value>Property <c>Gid</c> represents the identification code of the drawing to be called up.</value>
		public string Gid { get; set; } = "" ;

        /// <value>Property <c>Sil</c> allows to define a list of IDs - separated by a comma - in
		/// order to identify the single geometric parts you need to work on(e.g. <code>Sil = "59891, 59802, 59896"</code>)
		public string Sil { get; set; } = "" ;

        /// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "OFFGEO" ;

        /// <value>Property <c>Ofs</c> represents the offset for compensation.</value>
        public double Ofs { get; set; } = 0 ;

        /// <value>Property <c>Shc</c> used to choose if y, the sharp corners are rounded:
        /// <c>Shc = true</c> - the sharp corners are not rounded
        /// <c>Shc = false</c> - the sharp corners are rounded.</value>
        public bool Shc { get; set; } = false ;

        /// <value>Property <c>Osl</c> used to choose which parts of the selected geometry are to be copied.</value>
        public OffsetSelectionType Osl { get; set; } = OffsetSelectionType.oslTan ;

        /// <value>Property <c>Ltp</c> used to join the copy of a geometric unit with the preceding one.
        /// <c>Ltp = true</c> - the copies are joined.
        /// <c>Ltp = false</c> -  the copies are not joined .</value>
        public bool Ltp { get; set; } = false ;

        /// <value>Property <c>Rv</c> reverses the direction of the programmed geometrical profile;
        /// the initial point of the geometry thus becomes the final point.</value>
		public bool Rv { get; set; } = false ;

        /// <value>Property <c>Crt</c> represents the position of the tool with respect to the working trajectory.</value>
        public OffsetCompensationType Crt { get; set; } = OffsetCompensationType.LeftRight;

        /// <summary>This constructor initializes the new OffGeo
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public OffGeo()
		{
			IntId = GetHashCode();
		}

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("@ " + BppName + ", \"\", \"\", ");
			sb.Append(IntId.ToString());
			sb.Append(", \"\", 0 :");
			sb.Append(" \"" + Id + "\"");
			sb.Append(",");
            sb.Append(" \"" + Gid + "\"");
			sb.Append(",");
            sb.Append(" \"" + Sil + "\"");
			sb.Append(",");
            sb.Append(" \"" + Lay + "\"");
			sb.Append(",");
            sb.Append(" " + Ofs.ToString().Replace(',','.'));
			sb.Append(",");
            if (Shc)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
            sb.Append(",");
            sb.Append(" " + ((int)Osl).ToString());
			sb.Append(",");
            if (Ltp)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
            sb.Append(",");
            if (Rv)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
            sb.Append(",");
            sb.Append(" " + ((int)Crt).ToString());
            return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=OFFGEO");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
            sb.AppendLine("	PARAM,NAME=GID,VALUE=\"" + Gid + "\"");
            sb.AppendLine("	PARAM,NAME=SIL,VALUE=\"" + Sil + "\"");
            sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
            sb.AppendLine("	PARAM,NAME=OFS,VALUE=" + Ofs.ToString().Replace(',','.'));
            if (Shc)
                {sb.AppendLine("	PARAM,NAME=SHC,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=SHC,VALUE=NO");}
            sb.AppendLine("	PARAM,NAME=OSL,VALUE=" + Osl.ToString());
            if (Ltp)
                {sb.AppendLine("	PARAM,NAME=LTP,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=LTP,VALUE=NO");}
            if (Rv)
                {sb.AppendLine("	PARAM,NAME=RV,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=RV,VALUE=NO");}
            sb.AppendLine("	PARAM,NAME=CRT,VALUE=" + ((int)Crt).ToString());
            sb.Append("END MACRO");
			return sb.ToString();
		}
    }

}