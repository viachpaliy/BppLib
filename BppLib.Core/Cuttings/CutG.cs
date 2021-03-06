using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>GutG</c> models the generic cutting operation.</summary> 
	public class CutG: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "CUT_G" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Side</c> represents the piece side.</value>
		public int Side { get; set; } = 0 ;

        /// <value>Property <c>Crn</c> represents the piece reference corner.</value>
		public string Crn { get; set; } = "1" ;

        /// <value>Property <c>X</c> represents the X-axis co-ordinate of the cut start point.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate of the cut start point.</value>
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Z</c> represents the depth reached by the tool at the initial machining operation point.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c>.</value>
		public double Z { get; set; } = 0 ;

        /// <value>Property <c>Dp</c> represents the depth of the cut or of the perforation offset for through cuts.</value>
		public double Dp { get; set; } = 10 ;

        /// <value>Property <c>Typ</c> represents the type of machining operation for each individual cut.</value>
        public CuttingType Typ { get; set; } = CuttingType.cutXY ;

        /// <value>Property <c>L</c> represents the cut length value.</value>
		public double L { get; set; } = 0 ;

        /// <value>Property <c>Ang</c> represents the  cut angle.</value>
		public double Ang { get; set; } = 0 ;

        /// <value>Property <c>Xe</c> represents the X-axis co-ordinate of the cut end point.</value>
		public double Xe { get; set; } = 400 ;

        /// <value>Property <c>Ye</c> represents the Y-axis co-ordinate of the cut end point.</value>
		public double Ye { get; set; } = 400 ;

		/// <value>Property <c>Ze</c> represents the depth reached by the tool at the final machining operation point.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c>.</value>
		public double Ze { get; set; } = 0 ;

		/// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Az { get; set; } = 0 ;

		/// <value>Property <c>Iso</c> represents the entered ISO instruction.</value> 
		public string Iso { get; set; } = "" ;

		/// <value>Property <c>Opt</c> represents the optimisation of the machining operation.</value>
		public bool Opt { get; set; } = true ;
		
		/// <value>Property <c>Th</c> represents the blade thickness.</value>
		public double Th { get; set; } = 4 ;

		/// <value>Property <c>Rty</c> represents the type of repeats.</value>
		public Repetition Rty { get; set; } = Repetition.rpNO ;
		
		/// <value>Property <c>Dx</c> represents the distance between centres along the X-axis that defines the distance between cuts.</value>
		public double Dx { get; set; } = 32 ;

		/// <value>Property <c>Dy</c> represents the distance between centres along the Y-axis that defines the distance between cuts.</value>
		public double Dy { get; set; } = 32 ;

		/// <value>Property <c>R</c> represents the radius of the circumference around which the repeats are carried out.</value>
		public double R { get; set; } = 50 ;

		/// <value>Property <c>A</c> represents the angle from which to leave to carry out the repetitions.</value>
		public double A { get; set; } = 0 ;

		/// <value>Property <c>Da</c> represents the angular step that must be left between one repeat and the next one.</value>
		public double Da { get; set; } = 45 ;

		/// <value>Property <c>Rdl</c>  enables radial repeats.</value>
		public bool Rdl { get; set; } = true ;

		/// <value>Property <c>Nrp</c> represents the number of repeats required.</value>
		public int Nrp { get; set; } = 0 ;

		/// <value>Property <c>Cka</c> represents the inclination/rotation type.</value>
		public InclinationRotationType Cka { get; set; } = InclinationRotationType.azrNO ;

		/// <value>Property <c>Thr</c> represents if needing to execute a through cuts.</value>
		public bool Thr { get; set; } = false ;

		/// <value>Property <c>Rv</c> forces the blade to reverse its direction of movement.</value>
		public bool Rv { get; set; } = false ;

		/// <value>Property <c>Xrc</c> represents the X position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public double Xrc { get; set; } = 0 ;

		/// <value>Property <c>Yrc</c> represents the Y position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public double Yrc { get; set; } = 0 ;
		
		/// <value>Property <c>Arp</c> represents the angle of the straight line along which the repeats are carried out.</value>
		public double Arp { get; set; } = 0 ;

		/// <value>Property <c>Lrp</c> represents the distance between cuts.</value> 
		public double Lrp { get; set; } = 0 ;

		/// <value>Property <c>Er</c> enables the first element as the initial element in the repeat (focal repeats)
        /// eliminating the property <c>A</c> and the property <c>R</c>.</value> 
		public bool Er { get; set; } = true ;

		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public bool Cow { get; set; } = false ;

		/// <value>Property <c>Ttk</c> represents the total cut thickness.</value>
		public double Ttk { get; set; } = 0 ;

		/// <value>Property <c>Ovm</c> represents the value of the excess material that you wish to leave during the cut.</value>
		public double Ovm { get; set; } = 0 ;

		/// <value>Property <c>Tos</c> enables or disables the translation position of the plane to be worked compared with the main plane of the piece.
		/// When the <c>Tos = true</c> , during the calculation to establish the safety position, the
		/// value set in field Z is ignored, i.e., it is created starting from the surface of the piece. When the <c>Tos</c>
		/// is left disabled, the position defined in field Z is considered as a start point to position the tool at the safety position.</value>
		public bool Tos { get; set; } = false ;

		/// <value>Property <c>Vtr</c> represents the number of passages that influence the depth of the programmed machining.</value>
		public int Vtr { get; set; } = 0 ;

		/// <value>Property <c>Gip</c> used to indicate at what depth the system should consider the profile (GEO) to obtain the
		/// machining operation. The "true" value indicates that the profile start point is on the piece
		/// surface ; in this case, it is the position that indicates the tool lead-in point corresponding to
		/// the profile start point. The "false" value indicates that the profile start point has been moved along the Z-axis 
		/// and, therefore, it is not obtained from the X/Y co-ordinates alone but from the X/Y/Z coordinates,
		/// where the data item referring to Z is the machining operation depth.</value> 
		public bool Gip { get; set; } = true ;
		
		/// <value>Property <c>Id</c> represents the description of the type of machining operation for each individual bore.</value> 
		public string Id { get; set; } = "P1001" ;

		/// <value>Property <c>Tnm</c> represents the tool code from the predefined list of the tools present in the database.</value> 
		public string Tnm { get; set; } = "" ;

		/// <value>Property <c>Ttp</c> represents the tool type from the predefined list of the tool types present in the database.</value>
		public int Ttp { get; set; } = 200 ;

		/// <value>Property <c>Tcl</c> represents the tool class from the predefined list of the tool classes present in the database.</value>
		public int Tcl { get; set; } = 2 ;

		/// <value>Property <c>Rsp</c> represents the tool  rotation speed.</value> 
		public int Rsp { get; set; } = 0 ;

		/// <value>Property <c>Ios</c> represents the speed at which the tool moves from the safety position to the surface of the piece.</value>
		public int Ios { get; set; } = 0 ;

		/// <value>Property <c>Wsp</c> represents the speed at which the speed at which the blade makes the cut.</value>
		public int Wsp { get; set; } = 0 ;

		/// <value>Property <c>Spi</c> used to indicate the electrospindle with which the machining operation is to be carried out.</value> 
		public string Spi { get; set; } = "" ;

		/// <value>Property <c>Bfc</c> enables or disables the use of the blower to remove from the piece
		/// the chips eliminated during machining operations.</value>
		public bool Bfc { get; set; } = false ;

		/// <value>Property <c>Shp</c> represents the hood position during machining operation.</value>
		public int Shp { get; set; } = 0 ;

		/// <value>Property <c>Brc</c> enables or disables the correction of the lead-in and lead-out blade radius from the piece.</value>
		public int Brc { get; set; } = 0 ;

		/// <value>Property <c>Bdr</c> authorises the tool to work in alternate directions when carrying out successive runs.</value>
		public bool Bdr { get; set; } = false ;

		/// <value>Property <c>Prv</c> enables a change in the blade direction of movement.</value>
		public bool Prv { get; set; } = true ;

		/// <value>Property <c>Nrv</c> forces the blade to make the cut reversing 
		/// its direction of movement , known as the ???default direction???.</value> 
		public bool Nrv { get; set; } = false;

		/// <value>Property <c>Din</c> represents the distance from the initial position of the cut,
		/// used to anticipate the start point of the machining operation.</value> 
		public double Din { get; set; } = 0 ;

		/// <value>Property <c>Dou</c> represents the distance from the final position of the cut, used to extend the machining operation.</value>
		public double Dou { get; set; } = 0 ;

		/// <value>Property <c>Crc</c> represents the correction(position of the tool with respect to the working trajectory).</value>
		public ToolCorrection Crc { get; set; } = ToolCorrection.Central ;

		/// <value>Property <c>Dsp</c> represents the speed of the bit during the phases of the piece collapse,
		/// usable only for through machining operations.</value>
		public int Dsp { get; set; } = 0 ;

		/// <value>Property <c>Cen</c> represents the identification code for the machine work centre
		/// to be used for the machining operation.</value> 
		public string Cen { get; set; } = "" ;

		/// <value>Property <c>Agg</c> represents the identification code for the aggregate.</value>
		public string Agg { get; set; } = "" ;

		/// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "CUT_G" ;

		/// <value>Property <c>Dvr</c> represents the depth that the tool must reach during the last pass in the case of more than one pass.</value>
		public double Dvr { get; set; } = 0 ;

		/// <value>Property <c>Etb</c> enables or disables the tool inner blowing.</value>
		public bool Etb { get; set; } = false ;

		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public bool Kdt { get; set; } = false ;

		/// <value>Property <c>Ims</c> models the "IMS" parameter of the "CUT_G" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.</value> 
		public int Ims { get; set; } = 0 ;

        /// <summary>This constructor initializes the new CutG
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public CutG()
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
			sb.Append(" " + Side.ToString());
			sb.Append(",");
			sb.Append(" \"" + Crn +"\"");
			sb.Append(",");
			sb.Append(" " + X.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Y.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Z.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dp.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Typ).ToString());
			sb.Append(",");
			sb.Append(" " + L.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ang.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Xe.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ye.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ze.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Az.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" \"" + Iso +"\"");
			sb.Append(",");
			if (Opt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Th.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Rty).ToString());
			sb.Append(",");
			sb.Append(" " + Dx.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dy.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + R.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + A.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Da.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Rdl)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Nrp.ToString());
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
			sb.Append(" " + Xrc.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Yrc.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Arp.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Lrp.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Er)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Cow)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Ttk.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ovm.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Tos)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			if (Gip)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Id +"\"");
			sb.Append(",");
			sb.Append(" \"" + Tnm +"\"");
			sb.Append(",");
			sb.Append(" " + Ttp.ToString());
			sb.Append(",");
			sb.Append(" " + Tcl.ToString());
			sb.Append(",");
			sb.Append(" " + Rsp.ToString());
			sb.Append(",");
			sb.Append(" " + Ios.ToString());
			sb.Append(",");
			sb.Append(" " + Wsp.ToString());
			sb.Append(",");
			sb.Append(" \"" + Spi +"\"");
			sb.Append(",");
			if (Bfc)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			sb.Append(" " + Brc.ToString());
			sb.Append(",");
			if (Bdr)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Prv)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Nrv)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Din.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dou.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Crc).ToString());
			sb.Append(",");
			sb.Append(" " + Dsp.ToString());
			sb.Append(",");
			sb.Append(" \"" + Cen +"\"");
			sb.Append(",");
			sb.Append(" \"" + Agg +"\"");
			sb.Append(",");
			sb.Append(" \"" + Lay +"\"");
			sb.Append(",");
			sb.Append(" " + Dvr.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Etb)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			if (Kdt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Ims.ToString());
			return sb.ToString();
		}

		/// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=CUT_G");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=CRN,VALUE=\"" + Crn + "\"");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=TYP,VALUE=" + Typ.ToString());
			sb.AppendLine("	PARAM,NAME=L,VALUE=" + L.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ANG,VALUE=" + Ang.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=XE,VALUE=" + Xe.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=YE,VALUE=" + Ye.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			if (Opt)
				{sb.AppendLine("	PARAM,NAME=OPT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=OPT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=TH,VALUE=" + Th.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=RTY,VALUE=" + Rty.ToString());
			sb.AppendLine("	PARAM,NAME=DX,VALUE=" + Dx.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DY,VALUE=" + Dy.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DA,VALUE=" + Da.ToString(CultureInfo.InvariantCulture));
			if (Rdl)
				{sb.AppendLine("	PARAM,NAME=RDL,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RDL,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=NRP,VALUE=" + Nrp.ToString());
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + Cka.ToString());
			if (Thr)
				{sb.AppendLine("	PARAM,NAME=THR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=THR,VALUE=NO");}
			if (Rv)
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=RV,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=XRC,VALUE=" + Xrc.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=YRC,VALUE=" + Yrc.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ARP,VALUE=" + Arp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=LRP,VALUE=" + Lrp.ToString(CultureInfo.InvariantCulture));
			if (Er)
				{sb.AppendLine("	PARAM,NAME=ER,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=ER,VALUE=NO");}
			if (Cow)
				{sb.AppendLine("	PARAM,NAME=COW,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=COW,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=TTK,VALUE=" + Ttk.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=OVM,VALUE=" + Ovm.ToString(CultureInfo.InvariantCulture));
			if (Tos)
				{sb.AppendLine("	PARAM,NAME=TOS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=TOS,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			if (Gip)
				{sb.AppendLine("	PARAM,NAME=GIP,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=GIP,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm + "\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			if (Bfc)
				{sb.AppendLine("	PARAM,NAME=BFC,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=BFC,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			sb.AppendLine("	PARAM,NAME=BRC,VALUE=" + Brc.ToString());
			if (Bdr)
				{sb.AppendLine("	PARAM,NAME=BDR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=BDR,VALUE=NO");}
			if (Prv)
				{sb.AppendLine("	PARAM,NAME=PRV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=PRV,VALUE=NO");}
			if (Nrv)
				{sb.AppendLine("	PARAM,NAME=NRV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=NRV,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=DIN,VALUE=" + Din.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DOU,VALUE=" + Dou.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=CRC,VALUE=" + ((int)Crc).ToString());
			sb.AppendLine("	PARAM,NAME=DSP,VALUE=" + Dsp.ToString());
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=DVR,VALUE=" + Dvr.ToString(CultureInfo.InvariantCulture));
			if (Etb)
				{sb.AppendLine("	PARAM,NAME=ETB,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=ETB,VALUE=NO");}
			if (Kdt)
				{sb.AppendLine("	PARAM,NAME=KDT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=KDT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=IMS,VALUE=" + Ims.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}