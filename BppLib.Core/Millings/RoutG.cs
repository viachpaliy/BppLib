using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>RoutG</c> models the milling operation with “generic” geometric profile.</summary>
	public class RoutG: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "ROUTG" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Gid</c> represents the identification code of the drawing to be called up.</value>
		public string Gid { get; set; } = "" ;

        /// <value>Property <c>Id</c> represents the description of machining operation.</value> 
		public string Id { get; set; } = "P1001" ;

		/// <value>Property <c>Nu</c> models <c>Rout</c> property which not used in <c>RoutG</c>.</value> 
        int Nu { get; set; } = 0 ;

        /// <value>Property <c>Z</c> represents the depth reached by the tool at the initial machining operation point.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c>.</value>
		public double Z { get; set; } = 0 ;

        /// <value>Property <c>Dp</c> represents the depth of the machining operation or
        /// of the perforation offset for through machining operations.</value>
		public double Dp { get; set; } = 10 ;

		/// <value>Property <c>Iso</c> represents the entered ISO instruction.</value> 
		public string Iso { get; set; } = "" ;

        /// <value>Property <c>Opt</c> represents the optimisation of the machining operation.</value>
		public bool Opt { get; set; } = true ;
		
        /// <value>Property <c>Dia</c> represents the tool diameter.</value>
		public double Dia { get; set; } = 18 ;
		
		/// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Az { get; set; } = 0 ;

        /// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Ar { get; set; } = 0 ;

        /// <value>Property <c>Zs</c> represents the depth reached by the tool at the initial machining operation point.
        /// The value indicated in this field is added to that indicated in the field Depth.</value>
		public double Zs { get; set; } = 0 ;

        /// <value>Property <c>Ze</c> represents the depth reached by the tool at the final machining operation point.
        /// The value indicated in this field is added to that indicated in the field Depth.</value>
		public double Ze { get; set; } = 0 ;

		/// <value>Property <c>Cka</c> represents the inclination/rotation type.</value>
		public InclinationRotationType Cka { get; set; } = InclinationRotationType.azrNO ;

        /// <value>Property <c>Thr</c> represents if needing to execute a through operation.</value>
		public bool Thr { get; set; } = false ;

		/// <value>Property <c>Rv</c> forces the blade to reverse its direction of movement.</value>
		public bool Rv { get; set; } = false ;

        /// <value>Property <c>Ckt</c> enables the C axis to carry out interpolated milling operations
        /// with the tool at right angles to the profile to be machined.</value>
		public bool Ckt { get; set; } = false ;
		
		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public bool Cow { get; set; } = false ;

		/// <value>Property <c>Sil</c> allows to define a list of IDs - separated by a comma - in
		/// order to identify the single geometric parts you need to work on(e.g. <code>Sil = "59891, 59802, 59896"</code>).</value>
		public string Sil { get; set; } = "" ;

		/// <value>Property <c>Ovm</c> represents the value of the excess material that you wish to leave during the operation.</value>
		public double Ovm { get; set; } = 0 ;
		
        /// <value>Property <c>A21</c> represents the Aggr21 angle.
		/// (For programming milling operations using the AGGRE81 aggregate)
		///The angle related to the corner on which the machining operation is programmed.</value>
		public int A21 { get; set; } = 0 ;

        /// <value>Property <c>Lng</c> represents the portion of the entire profile that is to be worked starting from an initial point of the
        /// geometry. The unit or measurement applied to the value entered in this field must be defined in <c>Lpr</c> property.</value>
        public double Lng { get; set; } = 0 ;

        /// <value>Property <c>Lpr</c> represents the unit or measurement applied to the <c>Lng</c> property.
        /// true = the value of <c>Lng</c> is a percentage; false = the value of <c>Lng</c> is in mm/inches.</value>
		public bool Lpr { get; set; } = false ;

		/// <value>Property <c>Tos</c> enables or disables the translation position of the plane to be worked compared with the main plane of the piece.
		/// When the <c>Tos = true</c> , during the calculation to establish the safety position, the
		/// value set in field Z is ignored, i.e., it is created starting from the surface of the piece. When the <c>Tos</c>
		/// is left disabled, the position defined in field Z is considered as a start point to position the tool at the safety position.</value>
		public bool Tos { get; set; } = false ;

		/// <value>Property <c>Vtr</c> represents the number of passages that influence the depth of the programmed machining.</value>
		public int Vtr { get; set; } = 0 ;

        /// <value>Property <c>Dvr</c> represents the depth that the tool must reach during the last pass in the case of more than one pass.</value>
		public double Dvr { get; set; } = 0 ;

        /// <value>Property <c>Otr</c> represents the number of runs to be carried out
        /// horizontally or vertically on the surface of the programmed face.</value>
		public int Otr { get; set; } = 0 ;

        /// <value>Property <c>Svr</c> represents the step between runs indicated in the property <c>Otr</c>, that is to say the
        /// distance between one run and the next , starting from the programmed geometry position.</value> 
		public double Svr { get; set; } = 0 ;

        /// <value>Property <c>Cof</c> used to choose whether to generate the finishing operation.</value>
		public bool Cof { get; set; } = false ;

        /// <value>Property <c>Dof</c> represents the depth of the finishing operation,
        /// if this type of machining operation has been enabled (Cof = true).</value>
		public double Dof { get; set; } = 0 ;

		/// <value>Property <c>Gip</c> used to indicate at what depth the system should consider the profile (GEO) to obtain the
		/// machining operation. The "true" value indicates that the profile start point is on the piece
		/// surface ; in this case, it is the position that indicates the tool lead-in point corresponding to
		/// the profile start point. The "false" value indicates that the profile start point has been moved along the Z-axis 
		/// and, therefore, it is not obtained from the X/Y co-ordinates alone but from the X/Y/Z coordinates,
		/// where the data item referring to Z is the machining operation depth.</value> 
		public bool Gip { get; set; } = true ;

		/// <value>Property <c>Lsv</c> models the "LSV" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.</value> 
		public int Lsv { get; set; } = 0 ;

        /// <value>Property <c>S21</c> represents the Aggr21 face.
		/// (For programming milling operations using the AGGRE81 aggregate)
		/// The number of the face towards which the aggregate is directed to enter the piece.</value>
		public int S21 { get; set; } = -1 ;

		/// <value>Property <c>Azs</c> represents the safety value along the Z axis,
		/// to be applied when the inclined machining operations
		/// are carried out using, for example, the tilting axis.</value>
		public double Azs { get; set; } = 0 ;

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

        /// <value>Property <c>Crc</c> represents the correction(position of the tool with respect to the working trajectory).</value>
		public ToolCorrection Crc { get; set; } = ToolCorrection.Left ;

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

        /// <value>Property <c>Gin</c> represents the distance in millimetres from the lead-in point of the machining operation to move the
        /// tool sideways in such a way that it makes a slightly inclined descent. This data on can only be
        /// used with lead-ins of the Corrected3DLine type or the Corrected3DCurve type.</value>
		public double Gin { get; set; } = 0 ;

		/// <value>Property <c>Tbi</c> enables generation a linear translation of the tool inside the lead-in trajectory of
        /// the tool into the piece, in order to create a short step, that can be calculated on the depth  of the
        /// programmed machining operation.</value>
        public bool Tbi { get; set; } = false;

        /// <value>Property <c>Tli</c> represents the linear length of the segment for translating the tool (if Tbi = true).</value>
		public double Tli { get; set; } = 0 ;

        /// <value>Property <c>Tqi</c> represents the position (mm) to establish the initial translation point that can be calculated
        /// by starting from the Z co-ordinate of the final point of the milling.</value>
		public double Tqi { get; set; } = 0 ;

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

        /// <value>Property <c>Gou</c> represents the distance in millimetres from the lead-out point
        /// of the machining operation to move the tool sideways in such a way that it makes a slightly inclined rise.
        /// This data on can only be used with lead-ins of the Corrected3DLine type or the Corrected3DCurve type.</value>
		public int Gou { get; set; } = 0 ;

        /// <value>Property <c>Tbo</c> enables generation e a linear translation of the tool inside the
        /// lead-out trajectory of the tool from the piece, in order to create a short step, that can be calculated
        /// on the depth of the programmed machining operation . This data item can only be
        /// used with lead-outs of the type: Corrected3DLine, Profile3D, Corrected3DCurve.</value>
		public bool Tbo { get; set; } = false ;

        /// <value>Property <c>Tlo</c> represents the linear length of the segment for translating the tool.</value>
		public double Tlo { get; set; } = 0 ;

        /// <value>Property <c>Tqo</c> represents the position (mm) to establish the initial translation point that can be calculated
        /// by starting from the Z co-ordinate of the final point of the milling.</value>
		public double Tqo { get; set; } = 0 ;

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

        /// <value>Property <c>Bdr</c> authorises the tool to work in alternate directions when carrying out successive
        /// runs. The tool changes direction each time it makes a new movement.</value>
		public bool Bdr { get; set; } = false ;

		/// <value>Property <c>Spi</c> represents the spindle of the boring unit or the electrospindle with which to
		/// carry out the machining operation.</value>
		public string Spi { get; set; } = "" ;

        /// <value>Property <c>Sc</c> enables sharp corners.</value>
		public bool Sc { get; set; } = false ;

        /// <value>Property <c>Swi</c> enables or disables the use of the copier 
        /// or other similar devices (e.g.. aggregates with copier).</value>
		public bool Swi { get; set; } = false ;

        /// <value>Property <c>Blw</c> enables or disables the use of the blower to clean the piece
        /// whenever the copier or the presser is used.</value>
		public bool Blw { get; set; } = false ;

        /// <value>Property <c>Prs</c> enables or disables the use of the presser.</value>
		public bool Prs { get; set; } = false ;

		/// <value>Property <c>Bfc</c> enables or disables the use of the blower to remove from the piece
		/// the chips eliminated during machining operations.</value>
		public bool Bfc { get; set; } = false ;

        /// <value>Property <c>Shp</c> represents the hood position during machining operation.</value>
		public int Shp { get; set; } = 0 ;

		/// <value>Property <c>Swp</c> models the "SWP" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Swp { get; set; } = false ;
        
		/// <value>Property <c>Csp</c> represents the  speed at which the sharp corner must be executed.</value>
		public int Csp { get; set; } = 0 ;

		#region Chip Deflector properties

		/// <value>Property <c>Udt</c> enables or disables the use of the chip deflector.</value>
		public bool Udt { get; set; } = false;

		/// <value>Property <c>Tdt</c> represents the name of the deflector.</value>
		public string Tdt { get; set; } = "" ;

		/// <value>Property <c>Ddt</c> represents the safety distance between the chip deflector 
		/// and the surface of the piece being machined or to machine.</value>
		public double Ddt { get; set; } = 5 ;

		/// <value>Property <c>Sdt</c> represents the  thickness of material removed.</value>
		public double Sdt { get; set; } = 0 ;

		/// <value>Property <c>Idt</c> represents the distance between the point of geometrical discontinuity on the machining path
		/// and the point in which the chip deflector must start turning.</value>
		public double Idt { get; set; } = 20 ;

		/// <value>Property <c>Fdt</c> represents the distance between the point of geometrical discontinuity on the machining path and
		/// the point in which the chip deflector must stop turning.</value>
		public double Fdt { get; set; } = 80 ;

		/// <value>Property <c>Rdt</c> represents the rotation of the chip deflector effected
		/// from the beginning point of the rotation to the point of geometric break in the machining trajectory,
		/// expressed as percentage of the total rotation necessary to turn around the break.</value>
		public int Rdt { get; set; } = 60 ;

		#endregion

		/// <value>Property <c>Udt</c> enables or disables the use of properties <c>A21</c> and <c>S21</c>.</value>
		public bool Ea21 { get; set; } = false;

		/// <value>Property <c>Cen</c> represents the identification code for the machine work centre
		/// to be used for the machining operation.</value> 
		public string Cen { get; set; } = "" ;

		/// <value>Property <c>Agg</c> represents the identification code for the aggregate.</value>
		public string Agg { get; set; } = "" ;

		/// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "ROUTG" ;

		#region Electronic copier properties

		/// <value>Property <c>Eecs</c> used to enable the data fields to program the position of the ZE
		/// axis that can be reached by the electronic copier in the copying start and end phases.</value>
		public int Eecs { get; set; } = 0 ;

		/// <value>Property <c>Pdin</c> represents the distance from the machining operation start position 
        /// to allow the electronic copier to position itself correctly at the copying start point.</value>
		public double Pdin { get; set; } = 1 ;

		/// <value>Property <c>Pdu</c> represents the distance from the machining operation end position 
		/// to allow the electronic copier to position itself correctly at the copying end point.</value>
		public double Pdu { get; set; } = 1 ;

		/// <value>Property <c>Pcin</c> represents the correction of initial depth.</value>
		public double Pcin { get; set; } = 0 ;

		/// <value>Property <c>Pcu</c> represents the correction of end depth.</value>
		public double Pcu { get; set; } = 0 ;

		/// <value>Property <c>Pmol</c> represents the reduction or increase in the speed of the Z axis, to position the
		/// electronic copier at the copying start point.</value>
		public int Pmol { get; set; } = 0 ;

		#endregion

		/// <value>Property <c>Aux</c> used to define the position of the auxiliary tables.</value>
		public int Aux { get; set; } = 0 ;

		/// <value>Property <c>Crr</c> reduces the rotation speed of the chip deflector near rounded corners.</value>
		public bool Crr { get; set; } = false;

		/// <value>Property <c>Nebs</c> used to avoids output between the vertical runs(<c>Vtr</c> > 1).
		/// In this way, at the end of each step, the tool carries out the following one without being extracted from the panel.</value>
		public bool Nebs { get; set; } = false;

		/// <value>Property <c>Etb</c> enables or disables the internal tool blow purge.</value>
		public bool Etb { get; set; } = false;
		
		/// <value>Property <c>Fxd</c> models the "FXD" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Fxd { get; set; } = false;

		/// <value>Property <c>Fxda</c> models the "FXDA" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.</value>
		public int Fxda { get; set; } = 0 ;
		
		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public bool Kdt { get; set; } = false;

		/// <value>Property <c>Eml</c> models the "EML" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Eml { get; set; } = false;

		/// <value>Property <c>Etg</c> models the "ETG" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Etg { get; set; } = false;

		/// <value>Property <c>Rtas</c> models the "RTAS" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Rtas { get; set; } = false;

		/// <value>Property <c>Rdin</c> models the "RDIN" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Rdin { get; set; } = false;

		/// <value>Property <c>Ims</c> models the "IMS" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.</value>
		public int Ims { get; set; } = 0 ;

		/// <value>Property <c>Sdsf</c> represents the slowdown feed.</value>
		public int Sdsf { get; set; } = 0 ;

		/// <value>Property <c>Incstp</c> models the "INCSTP" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Incstp { get; set; } = false;

		/// <value>Property <c>Etgt</c> models the "ETGT" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.1 </value>
		public double Etgt { get; set; } = 0.1 ;

		/// <value>Property <c>Ajt</c> models the "AJT" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Ajt { get; set; } = false;

		/// <value>Property <c>Ion</c> models the "ION" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Ion { get; set; } = false;

		/// <value>Property <c>Lubmnz</c> models the "LUBMNZ" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is false("NO").</value>
		public bool Lubmnz { get; set; } = false;

		/// <value>Property <c>Sht</c> models the "SHT" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is "spByPost".</value>
		public ShtType Sht { get; set; } = ShtType.spByPost ;

		/// <value>Property <c>Shd</c> models the "SHD" parameter of the "ROUTG" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.</value>
		public int Shd { get; set; } = 0 ;

        /// <summary>This constructor initializes the new RoutG
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public RoutG()
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
			sb.Append(" \"" + Id +"\"");
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Z.ToString(CultureInfo.InvariantCulture));
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
			sb.Append(" " + Dia.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Az.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ar.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Zs.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ze.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Cka).ToString());
			sb.Append(",");
			if (Thr)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Rv)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Ckt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			if (Cow)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Sil + "\"");
			sb.Append(",");
			sb.Append(" " + Ovm.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + A21.ToString());
			sb.Append(",");
			sb.Append(" " + Lng.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Lpr)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Tos)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			sb.Append(" " + Dvr.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Otr.ToString());
			sb.Append(",");
			sb.Append(" " + Svr.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Cof)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Dof.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Gip)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Lsv.ToString());
			sb.Append(",");
			sb.Append(" " + S21.ToString());
			sb.Append(",");
			sb.Append(" " + Azs.ToString(CultureInfo.InvariantCulture));
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
			sb.Append(" " + ((int)Crc).ToString());
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
			sb.Append(" " + Gin.ToString());
			sb.Append(",");
			if (Tbi)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Tli.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Tqi.ToString(CultureInfo.InvariantCulture));
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
			sb.Append(" " + Gou.ToString());
			sb.Append(",");
			if (Tbo)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Tlo.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Tqo.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Din.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dou.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Sds.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Prp.ToString());
			sb.Append(",");
			if (Bdr)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Spi + "\"");
			sb.Append(",");
			if (Sc)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Swi)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Blw)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Prs)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Bfc)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			if (Swp)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Csp.ToString());
			sb.Append(",");
			if (Udt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Tdt + "\"");
			sb.Append(",");
			sb.Append(" " + Ddt.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Sdt.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Idt.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Fdt.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Rdt.ToString());
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
			sb.Append(" " + Eecs.ToString());
			sb.Append(",");
			sb.Append(" " + Pdin.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Pdu.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Pcin.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Pcu.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Pmol.ToString());
			sb.Append(",");
			sb.Append(" " + Aux.ToString());
			sb.Append(",");
			if (Crr)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Nebs)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Etb)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Fxd)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Fxda.ToString());
			sb.Append(",");
			if (Kdt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Eml)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Etg)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Rtas)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Rdin)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Ims.ToString());
			sb.Append(",");
			sb.Append(" " + Sdsf.ToString());
			sb.Append(",");
			if (Incstp)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Etgt.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Ajt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Ion)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Lubmnz)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
            sb.Append(" " + ((int)Sht).ToString());
			sb.Append(",");
			sb.Append(" " + Shd.ToString());
			return sb.ToString();
		}

		/// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=ROUTG");
			sb.AppendLine("	PARAM,NAME=GID,VALUE=\"" + Gid + "\"");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			if (Opt)
				{sb.AppendLine("	PARAM,NAME=OPT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=OPT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=DIA,VALUE=" + Dia.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AR,VALUE=" + Ar.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + Cka.ToString());
			if (Thr)
				{sb.AppendLine("	PARAM,NAME=THR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=THR,VALUE=NO");}
			if (Rv)
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=NO");}
			if (Ckt)
				{sb.AppendLine("	PARAM,NAME=CKT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=CKT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			if (Cow)
				{sb.AppendLine("	PARAM,NAME=COW,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=COW,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=SIL,VALUE=\"" + Sil + "\"");
			sb.AppendLine("	PARAM,NAME=OVM,VALUE=" + Ovm.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=A21,VALUE=" + A21.ToString());
			sb.AppendLine("	PARAM,NAME=LNG,VALUE=" + Lng.ToString(CultureInfo.InvariantCulture));
			if (Lpr)
				{sb.AppendLine("	PARAM,NAME=LPR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=LPR,VALUE=NO");}
			if (Tos)
				{sb.AppendLine("	PARAM,NAME=TOS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=TOS,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			sb.AppendLine("	PARAM,NAME=DVR,VALUE=" + Dvr.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=OTR,VALUE=" + Otr.ToString());
			sb.AppendLine("	PARAM,NAME=SVR,VALUE=" + Svr.ToString(CultureInfo.InvariantCulture));
			if (Cof)
				{sb.AppendLine("	PARAM,NAME=COF,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=COF,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=DOF,VALUE=" + Dof.ToString(CultureInfo.InvariantCulture));
			if (Gip)
				{sb.AppendLine("	PARAM,NAME=GIP,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=GIP,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=LSV,VALUE=" + Lsv.ToString());
			sb.AppendLine("	PARAM,NAME=S21,VALUE=" + S21.ToString());
			sb.AppendLine("	PARAM,NAME=AZS,VALUE=" + Azs.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DSP,VALUE=" + Dsp.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm +"\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=CRC,VALUE=" + ((int)Crc).ToString());
			sb.AppendLine("	PARAM,NAME=TIN,VALUE=" + ((int)Tin).ToString());
			sb.AppendLine("	PARAM,NAME=AIN,VALUE=" + Ain.ToString());
			if (Cin)
				{sb.AppendLine("	PARAM,NAME=CIN,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=CIN,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=GIN,VALUE=" + Gin.ToString());
			if (Tbi)
				{sb.AppendLine("	PARAM,NAME=TBI,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=TBI,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=TLI,VALUE=" + Tli.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=TQI,VALUE=" + Tqi.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=TOU,VALUE=" + ((int)Tou).ToString());
			sb.AppendLine("	PARAM,NAME=AOU,VALUE=" + Aou.ToString());
			if (Cou)
				{sb.AppendLine("	PARAM,NAME=COU,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=COU,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=GOU,VALUE=" + Gou.ToString());
			if (Tbo)
				{sb.AppendLine("	PARAM,NAME=TBO,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=TBO,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=TLO,VALUE=" + Tlo.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=TQO,VALUE=" + Tqo.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DIN,VALUE=" + Din.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DOU,VALUE=" + Dou.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SDS,VALUE=" + Sds.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PRP,VALUE=" + Prp.ToString());
			if (Bdr)
				{sb.AppendLine("	PARAM,NAME=BDR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=BDR,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			if (Sc)
				{sb.AppendLine("	PARAM,NAME=SC,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=SC,VALUE=NO");}
			if (Swi)
				{sb.AppendLine("	PARAM,NAME=SWI,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=SWI,VALUE=NO");}
			if (Blw)
				{sb.AppendLine("	PARAM,NAME=BLW,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=BLW,VALUE=NO");}
			if (Prs)
				{sb.AppendLine("	PARAM,NAME=PRS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=PRS,VALUE=NO");}
			if (Bfc)
				{sb.AppendLine("	PARAM,NAME=BFC,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=BFC,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			if (Swp)
				{sb.AppendLine("	PARAM,NAME=SWP,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=SWP,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=CSP,VALUE=" + Csp.ToString());
			if (Udt)
				{sb.AppendLine("	PARAM,NAME=UDT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=UDT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=TDT,VALUE=\"" + Tdt + "\"");
			sb.AppendLine("	PARAM,NAME=DDT,VALUE=" + Ddt.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SDT,VALUE=" + Sdt.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=IDT,VALUE=" + Idt.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=FDT,VALUE=" + Fdt.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=RDT,VALUE=" + Rdt.ToString());
			if (Ea21)
				{sb.AppendLine("	PARAM,NAME=EA21,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=EA21,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=EECS,VALUE=" + Eecs.ToString());
			sb.AppendLine("	PARAM,NAME=PDIN,VALUE=" + Pdin.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PDU,VALUE=" + Pdu.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PCIN,VALUE=" + Pcin.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PCU,VALUE=" + Pcu.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PMOL,VALUE=" + Pmol.ToString());
			sb.AppendLine("	PARAM,NAME=AUX,VALUE=" + Aux.ToString());
			if (Crr)
				{sb.AppendLine("	PARAM,NAME=CRR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=CRR,VALUE=NO");}
			if (Nebs)
				{sb.AppendLine("	PARAM,NAME=NEBS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=NEBS,VALUE=NO");}
			if (Etb)
				{sb.AppendLine("	PARAM,NAME=ETB,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=ETB,VALUE=NO");}
			if (Fxd)
				{sb.AppendLine("	PARAM,NAME=FXD,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=FXD,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=FXDA,VALUE=" + Fxda.ToString());
			if (Kdt)
				{sb.AppendLine("	PARAM,NAME=KDT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=KDT,VALUE=NO");}
			if (Eml)
				{sb.AppendLine("	PARAM,NAME=EML,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=EML,VALUE=NO");}
			if (Etg)
				{sb.AppendLine("	PARAM,NAME=ETG,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=ETG,VALUE=NO");}
			if (Rtas)
				{sb.AppendLine("	PARAM,NAME=RTAS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RTAS,VALUE=NO");}
			if (Rdin)
				{sb.AppendLine("	PARAM,NAME=RDIN,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RDIN,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=IMS,VALUE=" + Ims.ToString());
			sb.AppendLine("	PARAM,NAME=SDSF,VALUE=" + Sdsf.ToString());
			if (Incstp)
				{sb.AppendLine("	PARAM,NAME=INCSTP,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=INCSTP,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=ETGT,VALUE=" + Etgt.ToString(CultureInfo.InvariantCulture));
			if (Ajt)
				{sb.AppendLine("	PARAM,NAME=AJT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=AJT,VALUE=NO");}
			if (Ion)
				{sb.AppendLine("	PARAM,NAME=ION,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=ION,VALUE=NO");}
			if (Lubmnz)
				{sb.AppendLine("	PARAM,NAME=LUBMNZ,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=LUBMNZ,VALUE=NO");}
            sb.AppendLine("	PARAM,NAME=SHT,VALUE=" + Sht.ToString());
			sb.AppendLine("	PARAM,NAME=SHD,VALUE=" + Shd.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

		string ConvertBoolToNum(bool value)
		{
			if (value)
				{return "1";}
			return "0";
		}

		string ConvertBoolToYesNo(bool value)
		{
			if (value)
				{return "YES";}
			return "NO";
		}

	}
}