using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>WFG</c> models the “WFG” instruction.
    /// The “WFG” instruction might be associated with a geometric profile created on face zero of the
    /// piece, in this case it generates, non-standard sides on the basis of the type of profile, 
    /// or it might be associated with a single geometry for the purpose of generating a single non-standard side.</summary>
	public class WFG: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "WFG" ;

		/// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>SideId</c> represents the numbered code to be attributed to the non-standard side created.</value> 
        public int SideId { get; set; } = 6 ;

        /// <value>Property <c>Gid</c> used to select the identification code of the geometry (drawing ID) made on face "0" of the piece.</value>
		public string Gid { get; set; } = "" ;

        /// <value>Property <c>Pdf</c> used to enable two different types of machined piece visualisation in the simulator.
        /// When it is <c>true</c>, the drawing created is displayed as a profile of the piece.
        /// When it is <c>false</c>, both the drawing created and the piece to be machined are displayed.</value>
		public bool Pdf { get; set; } = false ;

        /// <value>Property <c>Rv</c> used to enable reversing of the sides created. This command is connected to the
        /// direction of the drawing. If the drawing has an anticlockwise direction, set this property "true" indicates
        /// that the elements in the drawing are internal sides of the piece . If the drawing has a clockwise direction,
        /// set this property "true" indicates that the elements in the drawing are sides of the piece, and therefore external.</value>
		public bool Rv { get; set; } = false ;

		///  <value>Property <c>Vf</c> used to indicate that the side generated is virtual, i.e. not displayed in the simulator.</value> 
		public bool Vf { get; set; } = false ;

		///  <value>Property <c>Vrt</c> declares that the side is perpendicular to the X,Y plane. To give an inclination to the side
        /// created, set <c>Vrt = false</c>  and set the property <c>Az</c>.</value> 
		public bool Vrt { get; set; } = true ;

		/// <value>Property <c>Az</c> represents the inclination of the side created.
        /// This is enabled by disabling the property <c>Vrt</c>.</value> 
		public double Az { get; set; } = 0 ;

        /// <value>Property <c>Lay</c> represents the string to identify the layer associated with the side created.</value>
		public string Lay { get; set; } = "WFG" ;

        /// <value>Property <c>Z</c> represents the Z position to establish the position of the upper side of the vertical face
        /// (calculated starting from the zero face of the piece).</value> 
		public double Z { get; set; } = 0 ;

        /// <value>Property <c>H</c> represents the height or thickness of the side.</value>
		public double Hgt { get; set; } = 0 ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public WFG()
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
            if (Pdf)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
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
			if (Vrt)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Az.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" \"" + Lay + "\"");
			sb.Append(",");
			sb.Append(" " + Z.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Hgt.ToString(CultureInfo.InvariantCulture));
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=WFG");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + SideId.ToString());
			sb.AppendLine("	PARAM,NAME=GID,VALUE=\"" + Gid + "\"");
            if (Pdf)
				{sb.AppendLine("	PARAM,NAME=PDF,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=PDF,VALUE=NO");}
			if (Rv)
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=NO");}
			if (Vf)
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=NO");}
			if (Vrt)
			    {sb.AppendLine("	PARAM,NAME=VRT,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=VRT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=HGT,VALUE=" + Hgt.ToString(CultureInfo.InvariantCulture));
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}