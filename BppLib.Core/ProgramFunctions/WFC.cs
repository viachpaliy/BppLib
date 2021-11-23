using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>WFC</c> models the “WFC” instruction.
    /// The “WFC” instruction makes it possible to generate a non-standard side with a curved surface by
    /// making an arc on side 0 of the piece.</summary>
	public class WFC: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "WFC" ;

		/// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>SideId</c> represents the numbered code to be attributed to the non-standard side created.</value> 
        public int SideId { get; set; } = 6 ;

        /// <value>Property <c>X</c> represents the co-ordinate in the direction of the X-axis for the centre of the circle arch.</value>
		public double X { get; set; } = 200 ;

        /// <value>Property <c>Y</c> represents the co-ordinate in the direction of the Y-axis for the centre of the circle arch.</value>
		public double Y { get; set; } = 200 ;

        /// <value>Property <c>Z</c> represents the co-ordinate in the direction of the Z-axis for the centre of the circle arch.</value>
		public double Z { get; set; } = 0 ;

		/// <value>Property <c>Az</c> represents the inclination of the side created.
        /// This is enabled by disabling the property <c>Vrt</c>.</value> 
		public double Az { get; set; } = 0 ;

		/// <value>Property <c>H</c> represents the height or thickness of the side.</value>
		public double H { get; set; } = 18 ;

        /// <value>Property <c>A</c> represents the value of angle to get start point of the circle arc.</value>
		public double A { get; set; } = 0 ;

        /// <value>Property <c>Da</c> represents the  angle size of circular side.</value>
		public double Da { get; set; } = 90 ;

        /// <value>Property <c>Da</c> represents the radius of the circle arc.</value>
		public double R { get; set; } = 200 ;

        /// <value>Property <c>Dir</c> represents the rotation direction;
        /// set dirCCW to indicate an anticlockwise direction, or set
        /// dirCW to indicate a clockwise direction.</value>
		public CircleDirection Dir { get; set; } = CircleDirection.dirCCW ;

		///  <value>Property <c>Vrt</c> declares that the side is perpendicular to the X,Y plane. To give an inclination to the side
        /// created, set <c>Vrt = false</c>  and set the property <c>Az</c>.</value> 
		public bool Vrt { get; set; } = true ;

		///  <value>Property <c>Vf</c> used to indicate that the side generated is virtual, i.e. not displayed in the simulator.</value> 
		public bool Vf { get; set; } = false ;

		///  <value>Property <c>Afh</c> used to automatically calculate the height of the side on the basis of the thickness of
        /// the piece.This is enabled by disabling the property <c>H</c>.</value> 
		public bool Afh { get; set; } = false ;

        ///  <value>Property <c>Ucs</c> used to modify the system that calculates the inclination of the circular faces defined in the <c>Az</c> property.</value> 
		public bool Ucs { get; set; } = true ;

        /// <value>Property <c>Rv</c> used to to indicate that the part of the side to apply the machining operation to
        /// is not the default side, i.e. the one linked to the direction of the generated segment but the opposite one.</value>  
		public bool Rv { get; set; } = false ;

        /// <value>Property <c>Lay</c> represents the string to identify the layer associated with the side created.</value>
		public string Lay { get; set; } = "WFC" ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public WFC()
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
			sb.Append(" " + X.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Y.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Z.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Az.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + H.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + A.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Da.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + R.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " +((int)Dir).ToString());
			sb.Append(",");
			if (Vrt)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			if (Vf)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			if (Afh)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			if (Ucs)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			if (Rv)
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
			sb.AppendLine("	NAME=WFC");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + SideId.ToString());
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=H,VALUE=" + H.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DA,VALUE=" + Da.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
			if (Vrt)
			    {sb.AppendLine("	PARAM,NAME=VRT,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=VRT,VALUE=NO");}
			if (Vf)
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=NO");}
			if (Afh)
				{sb.AppendLine("	PARAM,NAME=AFH,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=AFH,VALUE=NO");}
			if (Ucs)
				{sb.AppendLine("	PARAM,NAME=UCS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=UCS,VALUE=NO");}
			if (Rv)
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}