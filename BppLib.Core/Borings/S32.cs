using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>S32</c> models the repeated boring operation in which the parameters are set on side zero and side
    /// five of the piece, to be machined using the vertical spindle.</summary> 
	public class S32 : IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "S32" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

		/// <value>Property <c>Side</c> represents the piece side.</value>
		public int Side { get; set; } = 0 ;

		/// <value>Property <c>Crn</c> represents the piece reference corner.</value>
		public string Crn { get; set; } = "1" ;

		/// <value>Property <c>X</c> represents the X-axis co-ordinate for the centre of the bore.</value>
		public double X { get; set; } = 0 ;

		/// <value>Property <c>Y</c> represents the Y-axis co-ordinate for the centre of the bore.</value>
		public double Y { get; set; } = 0 ;

		/// <value>Property <c>Z</c> represents the translation position of the plane to be worked compared with the main plane of the piece.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c>.</value>
		public double Z { get; set; } = 0 ;

		/// <value>Property <c>Dp</c> represents the depth of the bore or the perforation offset value for through bores.</value>
		public double Dp { get; set; } = 10 ;

		/// <value>Property <c>Dia</c> represents the tool diameter.</value>
		public double Dia { get; set; } = 5 ;

		/// <value>Property <c>Thr</c> represents if needing to execute a through bore.</value>
		public bool Thr { get; set; } = false ;
        
        /// <value>Property <c>Dir</c> represents the direction of repeats.</value>
		public Direction Dir { get; set; } = Direction.drX ;

        /// <value>Property <c>Stp</c> represents the distance between centres along the direction of repeats .</value>
		public double Stp { get; set; } = 32 ;

        /// <value>Property <c>Dst</c> represents the distance between centres perpendicular to the direction of repeats .</value>
		public double Dst { get; set; } = 0 ;

        /// <value>Property <c>Typ</c> represents the type of boring operation.</value>
		public SystemBores Typ { get; set; } = SystemBores.sysCorr ;

		/// <value>Property <c>Iso</c> represents the entered ISO instruction.</value> 
		public string Iso { get; set; } = "" ;

		/// <value>Property <c>Opt</c> represents the optimisation of the machining operation.</value>
		public bool Opt { get; set; } = true ;

		/// <value>Property <c>Xmi</c> represents the "minimum X" - distance from the last bore to the end of the piece.</value>
		public double Xmi { get; set; } = 0 ;

		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public bool Cow { get; set; } = false ;

        /// <value>Property <c>Vtr</c> represents the number of passages that influence the depth of the programmed machining.</value>
		public int Vtr { get; set; } = 0 ;

		/// <value>Property <c>Mac</c> represents the name of machine on which the machining operation is to be carried out.
		/// This data item is only used if there are several machines arranged in a work line.</value>
		public string Mac { get; set; } = "" ;

		/// <value>Property <c>Tnm</c> represents the tool code from the predefined list of the tools present in the database.</value> 
		public string Tnm { get; set; } = "" ;

		/// <value>Property <c>Ttp</c> represents the tool type from the predefined list of the tool types present in the database.</value>
		public int Ttp { get; set; } = 0 ;

		/// <value>Property <c>Tcl</c> represents the tool class from the predefined list of the tool classes present in the database.</value>
		public int Tcl { get; set; } = 0 ;

		/// <value>Property <c>Rsp</c> represents the tool  rotation speed.</value> 
		public int Rsp { get; set; } = 0 ;

		/// <value>Property <c>Ios</c> represents the speed at which the tool moves from the safety position to the surface of the piece.</value>
		public int Ios { get; set; } = 0 ;

		/// <value>Property <c>Ios</c> represents the speed at which the tool makes the bore.</value>
		public int Wsp { get; set; } = 0 ;

		/// <value>Property <c>Spi</c> represents the spindle of the boring unit or the electrospindle with which to
		/// carry out the machining operation.</value>
		public string Spi { get; set; } = "" ;
        
		/// <value>Property <c>Dds</c> represents the position (mm) at which the bit must begin slowing down
		/// before finishing the boring operation.</value> 
		public double Dds { get; set; } = 3 ;

		/// <value>Property <c>Dsp</c> represents the speed of the bit during the phases of the piece collapse,
		/// usable only for through machining operations.</value>
		public int Dsp { get; set; } = 1500 ;

		/// <value>Property <c>Bfc</c> enables or disables the use of the blower to remove from the piece
		/// the chips eliminated during machining operations.</value>
		public bool Bfc { get; set; } = false ;

		/// <value>Property <c>Shp</c> represents the hood position during machining operation.</value>
		public int Shp { get; set; } = 0 ;

		/// <value>Property <c>Udt</c> enables or disables the use of properties <c>A21</c> and <c>S21</c>.</value>
		public bool Ea21 { get; set; } = false ;

		/// <value>Property <c>Cen</c> represents the identification code for the machine work centre
		/// to be used for the machining operation.</value> 
		public string Cen { get; set; } = "" ;

		/// <value>Property <c>Agg</c> represents the identification code for the aggregate.</value>
		public string Agg { get; set; } = "" ;

		/// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "S32" ;

		/// <value>Property <c>Prs</c> enables or disables the use of the presser.</value> 
		public bool Prs { get; set; } = false ;

		/// <value>Property <c>Etb</c> enables or disables the tool inner blowing.</value>
		public bool Etb { get; set; } = false ;

		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public bool Kdt { get; set; } = false ;

		/// <value>Property <c>Kdt</c> enables or disables the execute probing.</value>
		public bool Dtas { get; set; } = false ;


        /// <summary>This constructor initializes the new S32
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public S32()
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
			sb.Append(" " + Dia.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Thr)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + ((int)Dir).ToString());
			sb.Append(",");
			sb.Append(" " + Stp.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dst.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Typ).ToString());
			sb.Append(",");
			sb.Append(" \"" + Iso +"\"");
			sb.Append(",");
			if (Opt)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Xmi.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			if (Cow)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			sb.Append(" \"" + Mac +"\"");
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
			sb.Append(" " + Dds.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Dsp.ToString());
			sb.Append(",");
			if (Bfc)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			if (Ea21)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Cen +"\"");
			sb.Append(",");
			sb.Append(" \"" + Agg +"\"");
			sb.Append(",");
			sb.Append(" \"" + Lay +"\"");
			sb.Append(",");
			if (Prs)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
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
			if (Dtas)
				{sb.Append(" 1");}
			else
				{sb.Append(" 0");}
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=S32");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=CRN,VALUE=\"" + Crn + "\"");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DIA,VALUE=" + Dia.ToString(CultureInfo.InvariantCulture));
			if (Thr)
				{sb.AppendLine("	PARAM,NAME=THR,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=THR,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
			sb.AppendLine("	PARAM,NAME=STP,VALUE=" + Stp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DST,VALUE=" + Dst.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=TYP,VALUE=" + Typ.ToString());
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			if (Opt)
				{sb.AppendLine("	PARAM,NAME=OPT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=OPT,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=XMI,VALUE=" + Xmi.ToString(CultureInfo.InvariantCulture));
			if (Cow)
				{sb.AppendLine("	PARAM,NAME=COW,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=COW,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			sb.AppendLine("	PARAM,NAME=MAC,VALUE=\"" + Mac + "\"");
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm + "\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			sb.AppendLine("	PARAM,NAME=DDS,VALUE=" + Dds.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DSP,VALUE=" + Dsp.ToString());
			if (Bfc)
				{sb.AppendLine("	PARAM,NAME=BFC,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=BFC,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			if (Ea21)
				{sb.AppendLine("	PARAM,NAME=EA21,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=EA21,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			if (Prs)
				{sb.AppendLine("	PARAM,NAME=PRS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=PRS,VALUE=NO");}
			if (Etb)
				{sb.AppendLine("	PARAM,NAME=ETB,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=ETB,VALUE=NO");}
			if (Kdt)
				{sb.AppendLine("	PARAM,NAME=KDT,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=KDT,VALUE=NO");}
			if (Dtas)
				{sb.AppendLine("	PARAM,NAME=DTAS,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=DTAS,VALUE=NO");}
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}