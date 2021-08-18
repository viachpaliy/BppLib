using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>GutF</c> models the squaring operation centred on the top or bottom side of the piece.</summary>
	public class CutF: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "CUT_F" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Side</c> represents the piece side.</value>
		public int Side { get; set; } = 0 ;

        /// <value>Property <c>X</c> represents the distance in X from the edge of the piece.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the distance in Y from the edge of the piece.</value>
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Nrp</c> represents the entered ISO instruction.</value> 
		public string Iso { get; set; } = "" ;

		/// <value>Property <c>Opt</c> represents the optimisation of the machining operation.</value>
		public bool Opt { get; set; } = true ;
		
		/// <value>Property <c>Th</c> represents the blade thickness.</value>
		public double Th { get; set; } = 4 ;

        /// <value>Property <c>Dp</c> represents the depth of the cut or of the perforation offset for through cuts.</value>
		public double Dp { get; set; } = 10 ;

        /// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Az { get; set; } = 0 ;

		/// <value>Property <c>Cka</c> represents the inclination/rotation type.</value>
		public InclinationRotationType Cka { get; set; } = InclinationRotationType.azrNO ;
        
        /// <value>Property <c>Thr</c> represents if needing to execute a through cuts.</value>
		public bool Thr { get; set; } = false ;

		/// <value>Property <c>Rv</c> forces the blade to reverse its direction of movement.</value>
		public bool Rv { get; set; } = false ;

		/// <value>Property <c>Ttk</c> represents the total cut thickness.</value>
		public double Ttk { get; set; } = 0 ;

		/// <value>Property <c>Ovm</c> represents the value of the excess material that you wish to leave during the cut.</value>
		public double Ovm { get; set; } = 0 ;

		/// <value>Property <c>Vtr</c> represents the number of passages that influence the depth of the programmed machining.</value>
		public int Vtr { get; set; } = 0 ;

		/// <value>Property <c>Gip</c> used to indicate at what depth the system should consider the profile (GEO) to obtain the
		/// machining operation. The "true" value indicates that the profile start point is on the piece
		/// surface ; in this case, it is the position that indicates the tool lead-in point corresponding to
		/// the profile start point. The "false" value indicates that the profile start point has been moved along the Z-axis 
		/// and, therefore, it is not obtained from the X/Y co-ordinates alone but from the X/Y/Z coordinates,
		/// where the data item referring to Z is the machining operation depth.</value> 
		public bool Gip { get; set; } = true ;

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
		/// its direction of movement , known as the “default direction”.</value> 
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
		public string Lay { get; set; } = "CUT_F" ;

		/// <value>Property <c>Etb</c> enables or disables the tool inner blowing.</value>
		public bool Etb { get; set; } = false ;

		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public bool Kdt { get; set; } = false ;

        /// <summary>This constructor initializes the new CutF
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public CutF()
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
			sb.Append(" " + X.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Y.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" \"" + Iso +"\"");
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Opt));
			sb.Append(",");
			sb.Append(" " + Th.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Dp.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Az.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + ((int)Cka).ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Thr));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Rv));
			sb.Append(",");
			sb.Append(" " + Ttk.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Ovm.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Gip));
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
			sb.Append(" " + ConvertBoolToInt(Bfc));
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			sb.Append(" " + Brc.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Bdr));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Prv));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Nrv));
			sb.Append(",");
			sb.Append(" " + Din.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Dou.ToString().Replace(',','.'));
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
			sb.Append(" " + ConvertBoolToInt(Etb));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Kdt));
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=CUT_F");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			sb.AppendLine("	PARAM,NAME=OPT,VALUE=" + ConvertBoolToYesNo(Opt));
			sb.AppendLine("	PARAM,NAME=TH,VALUE=" + Th.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + Cka.ToString());
			sb.AppendLine("	PARAM,NAME=THR,VALUE=" +  ConvertBoolToYesNo(Thr));
			sb.AppendLine("	PARAM,NAME=RV,VALUE=" + ConvertBoolToYesNo(Rv));
			sb.AppendLine("	PARAM,NAME=TTK,VALUE=" + Ttk.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=OVM,VALUE=" + Ovm.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			sb.AppendLine("	PARAM,NAME=GIP,VALUE=" + ConvertBoolToYesNo(Gip));
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm + "\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			sb.AppendLine("	PARAM,NAME=BFC,VALUE=" + ConvertBoolToYesNo(Bfc));
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			sb.AppendLine("	PARAM,NAME=BRC,VALUE=" + Brc.ToString());
			sb.AppendLine("	PARAM,NAME=BDR,VALUE=" + ConvertBoolToYesNo(Bdr));
			sb.AppendLine("	PARAM,NAME=PRV,VALUE=" + ConvertBoolToYesNo(Prv));
			sb.AppendLine("	PARAM,NAME=NRV,VALUE=" + ConvertBoolToYesNo(Nrv));
			sb.AppendLine("	PARAM,NAME=DIN,VALUE=" + Din.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=DOU,VALUE=" + Dou.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=CRC,VALUE=" + ((int)Crc).ToString());
			sb.AppendLine("	PARAM,NAME=DSP,VALUE=" + Dsp.ToString());
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=ETB,VALUE=" + ConvertBoolToYesNo(Etb));
			sb.AppendLine("	PARAM,NAME=KDT,VALUE=" + ConvertBoolToYesNo(Kdt));
			sb.Append("END MACRO");
			return sb.ToString();
		}

        string ConvertBoolToInt(bool value)
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