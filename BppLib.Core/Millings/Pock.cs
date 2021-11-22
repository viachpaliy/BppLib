using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>Pock</c> models the geometric profile pocketing.
    /// The term pocketing refers to internal machining of the geometric profile, that is to say the removal
    /// of a certain amount of material inside or outside the profile so as to create a hole or indentation.</summary>
	public class Pock: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "POCK" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Gid</c> represents the identification code of the geometry to be pocketed.</value>
		public string Gid { get; set; } = "" ;

        /// <value>Property <c>Isl</c> represents the islands list.</value>
		public string Isl { get; set; } = "" ;

        /// <value>Property <c>Dia</c> represents the tool diameter.</value>
		public double Dia { get; set; } = 18 ;

        /// <value>Property <c>Dp</c> represents the depth of the machining operation or
        /// of the perforation offset for through machining operations.</value>
		public double Dp { get; set; } = 10 ;

        /// <value>Property <c>Iso</c> represents the entered ISO instruction.</value> 
		public string Iso { get; set; } = "" ;

        /// <value>Property <c>Opt</c> represents the optimisation of the machining operation.</value>
		public bool Opt { get; set; } = true ;

        /// <value>Property <c>Typ</c> represents the type of machining operation.</value>
		public PocketType Typ { get; set; } = PocketType.ptZIG ;

        /// <value>Property <c>Dlt</c> represents the overlap value for repeated milling operations.</value> 
		public double Dlt { get; set; } = 0 ;

		/// <value>Property <c>N</c> models the "N" parameter of the "POCK" macro.
		/// The exact meaning of the parameter is unknown. Default value is -1.</value> 
		public int N { get; set; } = -1 ;

        /// <value>Property <c>A</c> represents the pocketing inclination.
        /// If pocketing is to be carried out with an inclination in the tool path
        /// around the profile, set the value of the angle.</value>
		public double A { get; set; } = 0 ;

        /// <value>Property <c>Tc</c> activates the properties : Rrv, Tin, Ain, Cin, Tou, Aou, Cou, Din, Sds, Sdsf, Dou, Prp.</value>
		public bool Tc { get; set; } = false ;

        /// <value>Property <c>Cki</c> activates the islands list.</value>
		public bool Cki { get; set; } = false ;

        /// <value>Property <c>Zst</c> represents the Z step - depth of each run.</value>
		public double Zst { get; set; } = 10 ;

		/// <value>Property <c>Rv</c> forces the blade to reverse its direction of movement.</value>
		public bool Rv { get; set; } = false ;

        /// <value>Property <c>Rrv</c> forces the tool is made to reverse its infeed direction during the finish operation.</value>
		public bool Rrv { get; set; } = false ;

		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public bool Cow { get; set; } = false ;

        /// <value>Property <c>Ovm</c> represents the value of the excess material that you wish to leave during the operation.</value>
		public double Ovm { get; set; } = 0 ;
		
        /// <value>Property <c>A21</c> represents the Aggr21 angle.
		/// (For programming milling operations using the AGGRE81 aggregate)
		///The angle related to the corner on which the machining operation is programmed.</value>
		public int A21 { get; set; } = 0 ;

		/// <value>Property <c>Z</c> represents the depth reached by the tool at the initial machining operation point.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c>.</value>
		public double Z { get; set; } = 0 ;

		/// <value>Property <c>Tos</c> enables or disables the translation position of the plane to be worked compared with the main plane of the piece.
		/// When the <c>Tos = true</c> , during the calculation to establish the safety position, the
		/// value set in field Z is ignored, i.e., it is created starting from the surface of the piece. When the <c>Tos</c>
		/// is left disabled, the position defined in field Z is considered as a start point to position the tool at the safety position.</value>
		public bool Tos { get; set; } = false ;

		/// <value>Property <c>S21</c> represents the Aggr21 face.
		/// (For programming milling operations using the AGGRE81 aggregate)
		/// The number of the face towards which the aggregate is directed to enter the piece.</value>
		public int S21 { get; set; } = -1 ;

		/// <value>Property <c>Id</c> represents the description of machining operation.</value> 
		public string Id { get; set; } = "P1001" ;

		/// <value>Property <c>Dsp</c> represents the speed of the tool during the phases of the piece collapse,
		/// usable only for through machining operations.</value>
		public int Dsp { get; set; } = 0 ;

		/// <value>Property <c>Dsp</c> represents the speed of the bit during the phases of the piece collapse,
		/// usable only for through machining operations.</value>
		public int Rsp { get; set; } = 0 ;

        /// <value>Property <c>Ios</c> represents the speed at which the tool moves from the safety position to the surface of the piece.</value>
		public int Ios { get; set; } = 0 ;

        /// <value>Property <c>Wsp</c> represents the speed at which the tool makes the operation.</value>
		public int Wsp { get; set; } = 0 ;

		/// <value>Property <c>Tnm</c> represents the tool code from the predefined list of the tools present in the database.</value> 
		public string Tnm { get; set; } = "" ;

        /// <value>Property <c>Ttp</c> represents the tool type from the predefined list of the tool types present in the database.</value>
		public int Ttp { get; set; } = 103 ;

        /// <value>Property <c>Tcl</c> represents the tool class from the predefined list of the tool classes present in the database.</value>
		public int Tcl { get; set; } = 1 ;

		/// <value>Property <c>Tin</c> represents the lead-in type;
        ///  movement carried out by the tool in order to enter the piece to machine.</value>
		public LeadInOutType Tin { get; set; } = LeadInOutType.Curve ;

        /// <value>Property <c>Ain</c> represents the lead-in angle of the tool.
        /// The type of angle to be entered will vary according to the type of lead-in selected.</value>
		public int Ain { get; set; } = 45 ;

        /// <value>Property <c>Cin</c> enables correction in air.
        /// When the correction in air is enabled, the tool corrects its position before descending,
        /// thereby generating a short linear course parallel to the face.</value>
		public bool Cin { get; set; } = false ;

		/// <value>Property <c>Tou</c> represents the lead-out type;
        /// movement carried out by the tool in order to exit the machined piece.</value>
		public LeadInOutType Tou { get; set; } = LeadInOutType.Curve ;

        /// <value>Property <c>Aou</c> represents the lead-out angle of the tool.
        /// The type of angle to be entered will vary according to the type of lead-out selected.</value>
		public int Aou { get; set; } = 45 ;

        /// <value>Property <c>Cou</c> enables correction in air.
        /// When the correction in air is enabled, the tool corrects its position at the end of the re-rise,
        /// generating a short linear course parallel to the face. If the values entered in the Zs and Ze propeties
        /// are other than zero, this data item is managed as if it were an extension of the geometry/machining operation.</value>
		public bool Cou { get; set; } = false ;

		/// <value>Property <c>Din</c> represents the transfer of the machining operation point of origin
        /// forwards or back along the same trajectory.</value>
		public double Din { get; set; } = 0 ;

        /// <value>Property <c>Dou</c> represents the  distance between the lead-in and lead-out points
        /// of the tool from the piece, to extend machining operation.</value>
		public double Dou { get; set; } = 0 ;

        /// <value>Property <c>Sds</c> represents the distance between the tool slowdown point and the point at which the geometry ends.
        /// Slowdown takes place both when the tool approaches the end of the geometry, and when it moves away from that point.</value>
		public double Sds { get; set; } = 0 ;

        /// <value>Property <c>Prp</c> represents the percentage value to modify the lead-in and lead-out radius.</value>
		public int Prp { get; set; } = 0 ;

		/// <value>Property <c>Spi</c> represents the spindle of the boring unit or the electrospindle with which to
		/// carry out the machining operation.</value>
		public string Spi { get; set; } = "" ;

		/// <value>Property <c>Shp</c> represents the hood position during machining operation.</value>
		public int Shp { get; set; } = 0 ;

		/// <value>Property <c>Udt</c> enables or disables the use of properties <c>A21</c> and <c>S21</c>.</value>
		public bool Ea21 { get; set; } = false;

		/// <value>Property <c>Cen</c> represents the identification code for the machine work centre
		/// to be used for the machining operation.</value> 
		public string Cen { get; set; } = "" ;

		/// <value>Property <c>Agg</c> represents the identification code for the aggregate.</value>
		public string Agg { get; set; } = "" ;

		/// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "POCK" ;

		/// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Az { get; set; } = 0 ;

        /// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Ar { get; set; } = 0 ;

		/// <value>Property <c>Cka</c> represents the inclination/rotation type.</value>
		public InclinationRotationType Cka { get; set; } = InclinationRotationType.azrNO ;

		/// <value>Property <c>Bfc</c> enables or disables the use of the blower to remove from the piece
		/// the chips eliminated during machining operations.</value>
		public bool Bfc { get; set; } = false ;

        /// <value>Property <c>Etb</c> enables or disables the internal tool blow purge.</value>
		public bool Etb { get; set; } = false;

        /// <value>Property <c>Sdsf</c> represents the slowdown feed.</value>
		public int Sdsf { get; set; } = 0 ;

        /// <summary>This constructor initializes the new Pock
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Pock()
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
			sb.Append(" \"" + Gid + "\"");
			sb.Append(",");
			sb.Append(" \"" + Isl + "\"");
			sb.Append(",");
			sb.Append(" " + Dia.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dp.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" \"" + Iso + "\"");
			sb.Append(",");
            if (Opt)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + ((int)Typ).ToString());
			sb.Append(",");
			sb.Append(" " + Dlt.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + N.ToString());
			sb.Append(",");
			sb.Append(" " + A.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
            if (Tc)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
            sb.Append(",");
            if (Cki)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Zst.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
            if (Rv)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			if (Rrv)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			if (Cow)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Ovm.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + A21.ToString());
			sb.Append(",");
			sb.Append(" " + Z.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
            if (Tos)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + S21.ToString());
			sb.Append(",");
			sb.Append(" \"" + Id + "\"");
			sb.Append(",");
			sb.Append(" " + Dsp.ToString());
			sb.Append(",");
			sb.Append(" " + Rsp.ToString());
			sb.Append(",");
			sb.Append(" " + Ios.ToString());
			sb.Append(",");
			sb.Append(" " + Wsp.ToString());
			sb.Append(",");
			sb.Append(" \"" + Tnm + "\"");
			sb.Append(",");
			sb.Append(" " + Ttp.ToString());
			sb.Append(",");
			sb.Append(" " + Tcl.ToString());
			sb.Append(",");
			sb.Append(" " + ((int)Tin).ToString());
			sb.Append(",");
			sb.Append(" " + Ain.ToString());
			sb.Append(",");
            if (Cin)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + ((int)Tou).ToString());
			sb.Append(",");
			sb.Append(" " + Aou.ToString());
			sb.Append(",");
            if (Cou)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Din.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dou.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Sds.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Prp.ToString());
			sb.Append(",");
			sb.Append(" \"" + Spi + "\"");
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
            if (Ea21)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Cen + "\"");
			sb.Append(",");
			sb.Append(" \"" + Agg + "\"");
			sb.Append(",");
			sb.Append(" \"" + Lay + "\"");
			sb.Append(",");
			sb.Append(" " + Az.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ar.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Cka).ToString());
			sb.Append(",");
            if (Bfc)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
            if (Etb)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Sdsf.ToString());
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=POCK");
			sb.AppendLine("	PARAM,NAME=GID,VALUE=\"" + Gid + "\"");
			sb.AppendLine("	PARAM,NAME=ISL,VALUE=\"" + Isl + "\"");
			sb.AppendLine("	PARAM,NAME=DIA,VALUE=" + Dia.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			sb.Append("	PARAM,NAME=OPT,VALUE=");
            if (Opt)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=TYP,VALUE=" + Typ.ToString());
			sb.AppendLine("	PARAM,NAME=DLT,VALUE=" + Dlt.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=N,VALUE=" + N.ToString());
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString(CultureInfo.InvariantCulture));
			sb.Append("	PARAM,NAME=TC,VALUE=");
            if (Tc)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.Append("	PARAM,NAME=CKI,VALUE=");
            if (Cki)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=ZST,VALUE=" + Zst.ToString(CultureInfo.InvariantCulture));
			sb.Append("	PARAM,NAME=RV,VALUE=");
            if (Rv)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.Append("	PARAM,NAME=RRV,VALUE=");
            if (Rrv)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.Append("	PARAM,NAME=COW,VALUE=");
            if (Cow)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=OVM,VALUE=" + Ovm.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=A21,VALUE=" + A21.ToString());
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.Append("	PARAM,NAME=TOS,VALUE=");
            if (Tos)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");} 
			sb.AppendLine("	PARAM,NAME=S21,VALUE=" + S21.ToString());
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=DSP,VALUE=" + Dsp.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm + "\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=TIN,VALUE=" + ((int)Tin).ToString());
			sb.AppendLine("	PARAM,NAME=AIN,VALUE=" + Ain.ToString());
			sb.Append("	PARAM,NAME=CIN,VALUE=");
            if (Cin)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=TOU,VALUE=" + ((int)Tou).ToString());
			sb.AppendLine("	PARAM,NAME=AOU,VALUE=" + Aou.ToString());
			sb.Append("	PARAM,NAME=COU,VALUE=");
            if (Cou)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=DIN,VALUE=" + Din.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DOU,VALUE=" + Dou.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SDS,VALUE=" + Sds.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PRP,VALUE=" + Prp.ToString());
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			sb.Append("	PARAM,NAME=EA21,VALUE=");
            if (Ea21)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");} 
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AR,VALUE=" + Ar.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + Cka.ToString());
			sb.Append("	PARAM,NAME=BFC,VALUE=");
            if (Bfc)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");} 
			sb.Append("	PARAM,NAME=ETB,VALUE=");
            if (Etb)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=SDSF,VALUE=" + Sdsf.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}