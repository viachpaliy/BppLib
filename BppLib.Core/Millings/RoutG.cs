using System;
using System.Text;

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

		/// <value>Property <c>Nrp</c> represents the entered ISO instruction.</value> 
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
		/// order to identify the single geometric parts you need to work on(e.g. <code>Sil = "59891, 59802, 59896"</code>)
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

        /// <value>Property <c>Tlo</c> represents the linear length of the segment for translating the tool.
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
        /// Slowdown takes place both when the tool approaches the end of the geometry, and when it moves away from that point.
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
		/// In this way, at the end of each step, the tool carries out the following one without being extracted from the panel.
		public bool Nebs { get; set; } = false;

		public bool Etb { get; set; } = false;
		
		public bool Fxd { get; set; } = false;

		public int Fxda { get; set; } = 0 ;
		
		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public bool Kdt { get; set; } = false;

		public bool Eml { get; set; } = false;

		public bool Etg { get; set; } = false;

		public bool Rtas { get; set; } = false;

		public bool Rdin { get; set; } = false;

		public int Ims { get; set; } = 0 ;

		public int Sdsf { get; set; } = 0 ;

		public bool Incstp { get; set; } = false;

		public double Etgt { get; set; } = 0.1 ;

		public bool Ajt { get; set; } = false;

		public bool Ion { get; set; } = false;

		public bool Lubmnz { get; set; } = false;

		public ShtType Sht { get; set; } = ShtType.spByPost ;

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
			sb.Append(" " + Z.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Dp.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" \"" + Iso + "\"");
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Opt));
			sb.Append(",");
			sb.Append(" " + Dia.ToString().Replace(",","."));
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
			sb.Append(" " + Az.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Ar.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Zs.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Ze.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ((int)Cka).ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Thr));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Rv));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Ckt));
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + Nu.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Cow));
			sb.Append(",");
			sb.Append(" \"" + Sil + "\"");
			sb.Append(",");
			sb.Append(" " + Ovm.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + A21.ToString());
			sb.Append(",");
			sb.Append(" " + Lng.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Lpr));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Tos));
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			sb.Append(" " + Dvr.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Otr.ToString());
			sb.Append(",");
			sb.Append(" " + Svr.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Cof));
			sb.Append(",");
			sb.Append(" " + Dof.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Gip));
			sb.Append(",");
			sb.Append(" " + Lsv.ToString());
			sb.Append(",");
			sb.Append(" " + S21.ToString());
			sb.Append(",");
			sb.Append(" " + Azs.ToString().Replace(",","."));
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
			sb.Append(" " + ConvertBoolToNum(Cin));
			sb.Append(",");
			sb.Append(" " + Gin.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Tbi));
			sb.Append(",");
			sb.Append(" " + Tli.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Tqi.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ((int)Tou).ToString());
			sb.Append(",");
			sb.Append(" " + Aou.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Cou));
			sb.Append(",");
			sb.Append(" " + Gou.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Tbo));
			sb.Append(",");
			sb.Append(" " + Tlo.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Tqo.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Din.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Dou.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Sds.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Prp.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Bdr));
			sb.Append(",");
			sb.Append(" \"" + Spi + "\"");
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Sc));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Swi));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Blw));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Prs));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Bfc));
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Swp));
			sb.Append(",");
			sb.Append(" " + Csp.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Udt));
			sb.Append(",");
			sb.Append(" \"" + Tdt + "\"");
			sb.Append(",");
			sb.Append(" " + Ddt.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Sdt.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Idt.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Fdt.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Rdt.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Ea21));
			sb.Append(",");
			sb.Append(" \"" + Cen + "\"");
			sb.Append(",");
			sb.Append(" \"" + Agg + "\"");
			sb.Append(",");
			sb.Append(" \"" + Lay + "\"");
			sb.Append(",");
			sb.Append(" " + Eecs.ToString());
			sb.Append(",");
			sb.Append(" " + Pdin.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Pdu.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Pcin.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Pcu.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Pmol.ToString());
			sb.Append(",");
			sb.Append(" " + Aux.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Crr));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Nebs));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Etb));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Fxd));
			sb.Append(",");
			sb.Append(" " + Fxda.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Kdt));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Eml));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Etg));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Rtas));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Rdin));
			sb.Append(",");
			sb.Append(" " + Ims.ToString());
			sb.Append(",");
			sb.Append(" " + Sdsf.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Incstp));
			sb.Append(",");
			sb.Append(" " + Etgt.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Ajt));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Ion));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToNum(Lubmnz));
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
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			sb.AppendLine("	PARAM,NAME=OPT,VALUE=" + ConvertBoolToYesNo(Opt));
			sb.AppendLine("	PARAM,NAME=DIA,VALUE=" + Dia.ToString().Replace(",","."));
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
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=AR,VALUE=" + Ar.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + Cka.ToString());
			sb.AppendLine("	PARAM,NAME=THR,VALUE=" + ConvertBoolToYesNo(Thr));
			sb.AppendLine("	PARAM,NAME=RV,VALUE=" + ConvertBoolToYesNo(Rv));
			sb.AppendLine("	PARAM,NAME=CKT,VALUE=" + ConvertBoolToYesNo(Ckt));
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=NU,VALUE=" + Nu.ToString());
			sb.AppendLine("	PARAM,NAME=COW,VALUE=" + ConvertBoolToYesNo(Cow));
			sb.AppendLine("	PARAM,NAME=SIL,VALUE=\"" + Sil + "\"");
			sb.AppendLine("	PARAM,NAME=OVM,VALUE=" + Ovm.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=A21,VALUE=" + A21.ToString());
			sb.AppendLine("	PARAM,NAME=LNG,VALUE=" + Lng.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=LPR,VALUE=" + ConvertBoolToYesNo(Lpr));
			sb.AppendLine("	PARAM,NAME=TOS,VALUE=" + ConvertBoolToYesNo(Tos));
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			sb.AppendLine("	PARAM,NAME=DVR,VALUE=" + Dvr.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=OTR,VALUE=" + Otr.ToString());
			sb.AppendLine("	PARAM,NAME=SVR,VALUE=" + Svr.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=COF,VALUE=" + ConvertBoolToYesNo(Cof));
			sb.AppendLine("	PARAM,NAME=DOF,VALUE=" + Dof.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=GIP,VALUE=" + ConvertBoolToYesNo(Gip));
			sb.AppendLine("	PARAM,NAME=LSV,VALUE=" + Lsv.ToString());
			sb.AppendLine("	PARAM,NAME=S21,VALUE=" + S21.ToString());
			sb.AppendLine("	PARAM,NAME=AZS,VALUE=" + Azs.ToString().Replace(",","."));
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
			sb.AppendLine("	PARAM,NAME=CIN,VALUE=" + ConvertBoolToYesNo(Cin));
			sb.AppendLine("	PARAM,NAME=GIN,VALUE=" + Gin.ToString());
			sb.AppendLine("	PARAM,NAME=TBI,VALUE=" + ConvertBoolToYesNo(Tbi));
			sb.AppendLine("	PARAM,NAME=TLI,VALUE=" + Tli.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=TQI,VALUE=" + Tqi.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=TOU,VALUE=" + ((int)Tou).ToString());
			sb.AppendLine("	PARAM,NAME=AOU,VALUE=" + Aou.ToString());
			sb.AppendLine("	PARAM,NAME=COU,VALUE=" + ConvertBoolToYesNo(Cou));
			sb.AppendLine("	PARAM,NAME=GOU,VALUE=" + Gou.ToString());
			sb.AppendLine("	PARAM,NAME=TBO,VALUE=" + ConvertBoolToYesNo(Tbo));
			sb.AppendLine("	PARAM,NAME=TLO,VALUE=" + Tlo.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=TQO,VALUE=" + Tqo.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DIN,VALUE=" + Din.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DOU,VALUE=" + Dou.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SDS,VALUE=" + Sds.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=PRP,VALUE=" + Prp.ToString());
			sb.AppendLine("	PARAM,NAME=BDR,VALUE=" + ConvertBoolToYesNo(Bdr));
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + ConvertBoolToYesNo(Sc));
			sb.AppendLine("	PARAM,NAME=SWI,VALUE=" + ConvertBoolToYesNo(Swi));
			sb.AppendLine("	PARAM,NAME=BLW,VALUE=" + ConvertBoolToYesNo(Blw));
			sb.AppendLine("	PARAM,NAME=PRS,VALUE=" + ConvertBoolToYesNo(Prs));
			sb.AppendLine("	PARAM,NAME=BFC,VALUE=" + ConvertBoolToYesNo(Bfc));
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			sb.AppendLine("	PARAM,NAME=SWP,VALUE=" + ConvertBoolToYesNo(Swp));
			sb.AppendLine("	PARAM,NAME=CSP,VALUE=" + Csp.ToString());
			sb.AppendLine("	PARAM,NAME=UDT,VALUE=" + ConvertBoolToYesNo(Udt));
			sb.AppendLine("	PARAM,NAME=TDT,VALUE=\"" + Tdt + "\"");
			sb.AppendLine("	PARAM,NAME=DDT,VALUE=" + Ddt.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=SDT,VALUE=" + Sdt.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=IDT,VALUE=" + Idt.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=FDT,VALUE=" + Fdt.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=RDT,VALUE=" + Rdt.ToString());
			sb.AppendLine("	PARAM,NAME=EA21,VALUE=" + ConvertBoolToYesNo(Ea21));
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=EECS,VALUE=" + Eecs.ToString());
			sb.AppendLine("	PARAM,NAME=PDIN,VALUE=" + Pdin.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=PDU,VALUE=" + Pdu.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=PCIN,VALUE=" + Pcin.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=PCU,VALUE=" + Pcu.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=PMOL,VALUE=" + Pmol.ToString());
			sb.AppendLine("	PARAM,NAME=AUX,VALUE=" + Aux.ToString());
			sb.AppendLine("	PARAM,NAME=CRR,VALUE=" + ConvertBoolToYesNo(Crr));
			sb.AppendLine("	PARAM,NAME=NEBS,VALUE=" + ConvertBoolToYesNo(Nebs));
			sb.AppendLine("	PARAM,NAME=ETB,VALUE=" + ConvertBoolToYesNo(Etb));
			sb.AppendLine("	PARAM,NAME=FXD,VALUE=" + ConvertBoolToYesNo(Fxd));
			sb.AppendLine("	PARAM,NAME=FXDA,VALUE=" + Fxda.ToString());
			sb.AppendLine("	PARAM,NAME=KDT,VALUE=" + ConvertBoolToYesNo(Kdt));
			sb.AppendLine("	PARAM,NAME=EML,VALUE=" + ConvertBoolToYesNo(Eml));
			sb.AppendLine("	PARAM,NAME=ETG,VALUE=" + ConvertBoolToYesNo(Etg));
			sb.AppendLine("	PARAM,NAME=RTAS,VALUE=" + ConvertBoolToYesNo(Rtas));
			sb.AppendLine("	PARAM,NAME=RDIN,VALUE=" + ConvertBoolToYesNo(Rdin));
			sb.AppendLine("	PARAM,NAME=IMS,VALUE=" + Ims.ToString());
			sb.AppendLine("	PARAM,NAME=SDSF,VALUE=" + Sdsf.ToString());
			sb.AppendLine("	PARAM,NAME=INCSTP,VALUE=" + ConvertBoolToYesNo(Incstp));
			sb.AppendLine("	PARAM,NAME=ETGT,VALUE=" + Etgt.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=AJT,VALUE=" + ConvertBoolToYesNo(Ajt));
			sb.AppendLine("	PARAM,NAME=ION,VALUE=" + ConvertBoolToYesNo(Ion));
			sb.AppendLine("	PARAM,NAME=LUBMNZ,VALUE=" + ConvertBoolToYesNo(Lubmnz));
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