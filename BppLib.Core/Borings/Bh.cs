using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>Bh</c> models the boring operation using the horizontal spindle.</summary> 
	public class Bh: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "BH" ;
        
        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

		/// <value>Property <c>Side</c> represents the piece side.</value>
		public int Side { get; set; } = 1 ;

		/// <value>Property <c>Crn</c> represents the piece reference corner.</value>
		public string Crn { get; set; } = "1" ;

		/// <value>Property <c>X</c> represents the X-axis co-ordinate for the centre of the bore.</value>
		public double X { get; set; } = 0 ;

		/// <value>Property <c>Y</c> represents the Y-axis co-ordinate for the centre of the bore.</value>
		public double Y { get; set; } = 0 ;

		/// <value>Property <c>Z</c> represents the translation position of the plane to be worked compared with the main plane of the piece.</value>
		public double Z { get; set; } = 0 ;

		/// <value>Property <c>Dp</c> represents the depth of the bore or the perforation offset value for through bores.</value>
		public double Dp { get; set; } = 10 ;

		/// <value>Property <c>Dia</c> represents the tool diameter.</value>
		public double Dia { get; set; } = 5 ;

		/// <value>Property <c>Thr</c> represents if needing to execute a through bore.</value>
		public bool Thr { get; set; } = false ;

		/// <value>Property <c>Rty</c> represents the type of repeats.</value>
		public Repetition Rty { get; set; } = Repetition.rpNO ;

		/// <value>Property <c>Dx</c> represents the distance between centres along the X-axis that defines the distance between bores.</value>
		public double Dx { get; set; } = 32 ;

		/// <value>Property <c>Dy</c> represents the distance between centres along the Y-axis that defines the distance between bores.</value>
		public double Dy { get; set; } = 32 ;

		/// <value>Property <c>R</c> represents the radius of the circumference around which the repeats are carried out.</value>
		public double R { get; set; } = 50 ;

		/// <value>Property <c>A</c> represents the angle from which to leave to carry out the repetitions.</value>
		public double A { get; set; } = 0 ;

		/// <value>Property <c>Da</c> represents the angular step that must be left between one repeat and the next one.</value>
		public double Da { get; set; } = 45 ;

		/// <value>Property <c>Nrp</c> represents the number of repeats required.</value>
		public int Nrp { get; set; } = 0 ;

		/// <value>Property <c>Nrp</c> represents the entered ISO instruction.</value> 
		public string Iso { get; set; } = "" ;

		/// <value>Property <c>Opt</c> represents the optimisation of the machining operation.</value>
		public bool Opt { get; set; } = true ;

        /// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Az { get; set; } = 0 ;

		/// <value>Property <c>Ar</c> represents the angle of rotation of the spindle axis on plane X, Y.</value>
		public double Ar { get; set; } = 0 ;

		public bool Ap { get; set; } = false ;

		/// <value>Property <c>Cka</c> represents the inclination/rotation type.</value>
		public InclinationRotationType Cka { get; set; } = InclinationRotationType.azrNO ;

		/// <value>Property <c>Xrc</c> represents the X position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public double Xrc { get; set; } = 0 ;

		/// <value>Property <c>Yrc</c> represents the Y position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public double Yrc { get; set; } = 0 ;

		/// <value>Property <c>Arp</c> represents the angle of the straight line along which the repeats are carried out.</value>
		public double Arp { get; set; } = 0 ;

		/// <value>Property <c>Lrp</c> represents the distance between bores.</value> 
		public double Lrp { get; set; } = 0 ;

		public bool Er { get; set; } = true ;

		public bool Md { get; set; } = false ;

		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public bool Cow { get; set; } = false ;

		public int A21 { get; set; } = 0 ;

		/// <value>Property <c>Tos</c> enables or disables the translation position of the plane to be worked compared with the main plane of the piece.
		/// When the <c>Tos = BppLib.YES</c> , during the calculation to establish the safety position, the
		/// value set in field Z is ignored, i.e., it is created starting from the surface of the piece. When the <c>Tos</c>
		/// is left disabled, the position defined in field Z is considered as a start point to position the tool at the safety position.</value>
		public bool Tos { get; set; } = false ;

		/// <value>Property <c>Vtr</c> represents the number of passages that influence the depth of the programmed machining.</value>
		public int Vtr { get; set; } = 0 ;

		public int S21 { get; set; } = -1 ;

		/// <value>Property <c>Id</c> represents the description of the type of machining operation for each individual bore.</value> 
		public string Id { get; set; } = "P1001" ;

		/// <value>Property <c>Azs</c> represents the safety value along the Z axis,
		/// to be applied when the inclined machining operations
		/// are carried out using, for example, the tilting axis.</value>
		public double Azs { get; set; } = 0 ;

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

		public bool Ea21 { get; set; } = false ;

		/// <value>Property <c>Cen</c> represents the identification code for the machine work centre
		/// to be used for the machining operation.</value> 
		public string Cen { get; set; } = "" ;

		/// <value>Property <c>Agg</c> represents the identification code for the aggregate.</value>
		public string Agg { get; set; } = "" ;

		/// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "BH" ;

		/// <value>Property <c>Prs</c> enables or disables the use of the presser.</value> 
		public bool Prs { get; set; } = false ;

		/// <value>Property <c>Etb</c> enables or disables the tool inner blowing.</value>
		public bool Etb { get; set; } = false ;

		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public bool Kdt { get; set; } = false ;

		/// <value>Property <c>Kdt</c> enables or disables the execute probing.</value>
		public bool Dtas { get; set; } = false ;

		public RmdType Rmd { get; set; } = RmdType.rmdAuto ;

		public int Dqt { get; set; } = 0 ;

		public bool Erdw { get; set; } = false ;

		public int Dfw { get; set; } = 0 ;

		/// <summary>This constructor initializes the new Bh
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Bh()
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
			sb.Append(" \"" + Crn + "\"");
			sb.Append(",");
			sb.Append(" " + X.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Y.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Z.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Dp.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Dia.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Thr));
			sb.Append(",");
			sb.Append(" " + ((int)Rty).ToString());
			sb.Append(",");
			sb.Append(" " + Dx.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Dy.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + R.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + A.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Da.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Nrp.ToString());
			sb.Append(",");
			sb.Append(" \"" + Iso + "\"");
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Opt));
			sb.Append(",");
			sb.Append(" " + Az.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Ar.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Ap));
			sb.Append(",");
			sb.Append(" " + ((int)Cka).ToString());
			sb.Append(",");
			sb.Append(" " + Xrc.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Yrc.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Arp.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Lrp.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Er));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Md));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Cow));
			sb.Append(",");
			sb.Append(" " + A21.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Tos));
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			sb.Append(" " + S21.ToString());
			sb.Append(",");
			sb.Append(" \"" + Id + "\"");
			sb.Append(",");
			sb.Append(" " + Azs.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" \"" + Mac + "\"");
			sb.Append(",");
			sb.Append(" \"" + Tnm + "\"");
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
			sb.Append(" \"" + Spi + "\"");
			sb.Append(",");
			sb.Append(" " + Dds.ToString().Replace(",","."));
			sb.Append(",");
			sb.Append(" " + Dsp.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Bfc));
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Ea21));
			sb.Append(",");
			sb.Append(" \"" + Cen + "\"");
			sb.Append(",");
			sb.Append(" \"" + Agg + "\"");
			sb.Append(",");
			sb.Append(" \"" + Lay + "\"");
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Prs));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Etb));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Kdt));
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Dtas));
			sb.Append(",");
			sb.Append(" " + ((int)Rmd).ToString());
			sb.Append(",");
			sb.Append(" " + Dqt.ToString());
			sb.Append(",");
			sb.Append(" " + ConvertBoolOnOff(Erdw));
			sb.Append(",");
			sb.Append(" " + Dfw.ToString());
			return sb.ToString();
		}

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=BH");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=CRN,VALUE=\"" + Crn + "\"");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DIA,VALUE=" + Dia.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=THR,VALUE=" + ConvertOnOff(Thr));
			sb.AppendLine("	PARAM,NAME=RTY,VALUE=" + Rty.ToString());
			sb.AppendLine("	PARAM,NAME=DX,VALUE=" + Dx.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DY,VALUE=" + Dy.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DA,VALUE=" + Da.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=NRP,VALUE=" + Nrp.ToString());
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			sb.AppendLine("	PARAM,NAME=OPT,VALUE=" + ConvertOnOff(Opt));
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=AR,VALUE=" + Ar.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=AP,VALUE=" + ConvertOnOff(Ap));
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + Cka.ToString());
			sb.AppendLine("	PARAM,NAME=XRC,VALUE=" + Xrc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=YRC,VALUE=" + Yrc.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ARP,VALUE=" + Arp.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=LRP,VALUE=" + Lrp.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=ER,VALUE=" + ConvertOnOff(Er));
			sb.AppendLine("	PARAM,NAME=MD,VALUE=" + ConvertOnOff(Md));
			sb.AppendLine("	PARAM,NAME=COW,VALUE=" + ConvertOnOff(Cow));
			sb.AppendLine("	PARAM,NAME=A21,VALUE=" + A21.ToString());
			sb.AppendLine("	PARAM,NAME=TOS,VALUE=" + ConvertOnOff(Tos));
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			sb.AppendLine("	PARAM,NAME=S21,VALUE=" + S21.ToString());
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=AZS,VALUE=" + Azs.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=MAC,VALUE=\"" + Mac + "\"");
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm + "\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			sb.AppendLine("	PARAM,NAME=DDS,VALUE=" + Dds.ToString().Replace(",","."));
			sb.AppendLine("	PARAM,NAME=DSP,VALUE=" + Dsp.ToString());
			sb.AppendLine("	PARAM,NAME=BFC,VALUE=" + ConvertOnOff(Bfc));
			sb.AppendLine("	PARAM,NAME=SHP,VALUE=" + Shp.ToString());
			sb.AppendLine("	PARAM,NAME=EA21,VALUE=" + ConvertOnOff(Ea21));
			sb.AppendLine("	PARAM,NAME=CEN,VALUE=\"" + Cen + "\"");
			sb.AppendLine("	PARAM,NAME=AGG,VALUE=\"" + Agg + "\"");
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=PRS,VALUE=" + ConvertOnOff(Prs));
			sb.AppendLine("	PARAM,NAME=ETB,VALUE=" + ConvertOnOff(Etb));
			sb.AppendLine("	PARAM,NAME=KDT,VALUE=" + ConvertOnOff(Kdt));
			sb.AppendLine("	PARAM,NAME=DTAS,VALUE=" + ConvertOnOff(Dtas));
			sb.AppendLine("	PARAM,NAME=RMD,VALUE=" + Rmd.ToString());
			sb.AppendLine("	PARAM,NAME=DQT,VALUE=" + Dqt.ToString());
			sb.AppendLine("	PARAM,NAME=ERDW,VALUE=" + ConvertOnOff(Erdw));;
			sb.AppendLine("	PARAM,NAME=DFW,VALUE=" + Dfw.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

        string ConvertBoolOnOff(bool value)
		{
			if (value)
				{return "1";}
			return "0";
		}

		string ConvertOnOff(bool value)
		{
			if (value)
				{return "YES";}
			return "NO";
		}

		
	}
}