using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>WFL</c> models the “WFL” instruction.
    /// The “WFL” instruction is used to generate a non-standard side with a flat surface by making a
    /// linear segment on side 0 of the piece.</summary>
	public class WFL: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "WFL" ;

        /// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

        /// <value>Property <c>SideId</c> represents the numbered code to be attributed to the non-standard side created.</value> 
        public int SideId { get; set; } = 7 ;

        /// <value>Property <c>X</c> represents the co-ordinate in the direction of the X-axis of the start point of the angled straight line.</value> 
		public double X { get; set; } = 200 ;

        /// <value>Property <c>Y</c> represents the co-ordinate in the direction of the Y-axis of the start point of the angled straight line.</value> 
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Z</c> represents the co-ordinate in the direction of the Z-axis of the start point.</value> 
		public double Z { get; set; } = 0 ;

        /// <value>Property <c>Az</c> represents the inclination of the side created.
        /// This is enabled by disabling the property <c>Vrt</c>.</value> 
		public double Az { get; set; } = 0 ;
        
        ///  <value>Property <c>Ar</c> represents the angle of rotation of the straight line. The angle must be
        /// calculated from zero degrees (0°) that is always found on the right of the initial point p of the
        /// segment. To rotate the segment anticlockwise, use a negative value (from 0 to -360);
        /// to rotate the segment clockwise, use a positive value (from 0 to +360). The part of the face that
        /// can be machined follows the direction of the segment and is always on its right.</value>
		public double Ar { get; set; } = 135 ;

        ///  <value>Property <c>L</c> represents the length of the side.</value>
		public double L { get; set; } = 282.85 ;

        /// <value>Property <c>H</c> represents the height or thickness of the side.</value>
		public double H { get; set; } = 18 ;

        ///  <value>Property <c>Vrt</c> declares that the side is perpendicular to the X,Y plane. To give an inclination to the side
        /// created, set <c>Vrt = false</c>  and set the property <c>Az</c>.</value> 
		public bool Vrt { get; set; } = true ;

        ///  <value>Property <c>Vf</c> used to indicate that the side generated is virtual, i.e. not displayed in the simulator.</value> 
		public bool Vf { get; set; } = false ;

        ///  <value>Property <c>Afl</c> used to automatically calculates the length of the side created on the basis of coordinates <c>X</c>,<c>Y</c> of the initial point
        /// and the <c>Ar</c> angle.This is enabled by disabling the property <c>L</c>.</value> 
		public bool Afl { get; set; } = false ;

        ///  <value>Property <c>Afh</c> used to automatically calculate the height of the side on the basis of the thickness of
        /// the piece.This is enabled by disabling the property <c>H</c>.</value> 
		public bool Afh { get; set; } = false ;

        ///  <value>Property <c>Ucs</c> used to modify the system that calculates the inclination of the linear faces defined in
        /// the <c>Az</c> property. By default, the reference corner from where to start calculating the face
        /// inclination is corner number two (property set <c>false</c>). The enabled box is used to select the reference
        /// corner in the <c>Frc</c> field.</value>  
		public bool Ucs { get; set; } = true ;

        /// <value>Property <c>Rv</c> used to indicate that the part of the side to apply the machining operation to is not the
        /// one linked to the direction of the generated segment, i.e. the one obtained on the basis of the rule
        /// indicated in property <c>Ar</c> but the opposite one.</value> 
		public bool Rv { get; set; } = false ;

        ///  <value>Property <c>Frc</c> represents the reference corner from where to start calculating the face inclination.</value>  
		public int Frc { get; set; } = 1 ;

        /// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "WFL" ;

        /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public WFL()
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
			sb.Append(" " + Ar.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + L.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + H.ToString(CultureInfo.InvariantCulture));
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
			if (Afl)
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
			sb.Append(" " + Frc.ToString());
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
			sb.AppendLine("	NAME=WFL");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + SideId.ToString());
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AR,VALUE=" + Ar.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=L,VALUE=" + L.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=H,VALUE=" + H.ToString(CultureInfo.InvariantCulture));
            if (Vrt)
			    {sb.AppendLine("	PARAM,NAME=VRT,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=VRT,VALUE=NO");}
			if (Vf)
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=VF,VALUE=NO");}
			if (Afl)
				{sb.AppendLine("	PARAM,NAME=AFL,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=AFL,VALUE=NO");}
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
			sb.AppendLine("	PARAM,NAME=FRC,VALUE=" + Frc.ToString());
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}