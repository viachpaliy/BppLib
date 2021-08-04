using System;
using System.Text;

namespace BppLib.Core
{
	/// <summary>Class <c>Bcl</c> models the bore with C axis on straigh side operation.</summary> 
	public class Bcl: IBppCode
	{
		/// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "BCL" ;

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

		/// <value>Property <c>Z</c> represents the translation position of the plane to be worked compared with the main plane of the piece.</value>
		public double Z { get; set; } = 0 ;

		/// <value>Property <c>Dp</c> represents the depth of the bore or the perforation offset value for through bores.</value>
		public double Dp { get; set; } = 10 ;

		/// <value>Property <c>Dia</c> represents the tool diameter.</value>
		public double Dia { get; set; } = 5 ;

		/// <value>Property <c>Thr</c> represents if needing to execute a through bore.</value>
		public int Thr { get; set; } = BppLib.NO ;

		/// <value>Property <c>Dia</c> represents the type of repeats.</value>
		public int Rty { get; set; } = BppLib.RpNO ;

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
		public int Opt { get; set; } = BppLib.YES ;

		/// <value>Property <c>Az</c> represents the angle of inclination of the spindle axis of rotation with respect to the plane X, Y.</value> 
		public double Az { get; set; } = 0 ;

		/// <value>Property <c>Ar</c> represents the angle of rotation of the spindle axis on plane X, Y.</value>
		public double Ar { get; set; } = 0 ;

		public int Ap { get; set; } = BppLib.NO ;

		/// <value>Property <c>Cka</c> represents the inclination/rotation type.</value>
		public int Cka { get; set; } = BppLib.AzrNO ;

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

		public int Er { get; set; } = BppLib.YES ;

		public int Md { get; set; } = BppLib.NO ;

		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public int Cow { get; set; } = BppLib.NO ;

		public int A21 { get; set; } = 0 ;

		/// <value>Property <c>Tos</c> enables or disables the translation position of the plane to be worked compared with the main plane of the piece.
		/// When the <c>Tos = BppLib.YES</c> , during the calculation to establish the safety position, the
		/// value set in field Z is ignored, i.e., it is created starting from the surface of the piece. When the <c>Tos</c>
		/// is left disabled, the position defined in field Z is considered as a start point to position the tool at the safety position.</value>
		public int Tos { get; set; } = BppLib.NO ;

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
		public int Bfc { get; set; } = BppLib.NO ;

		/// <value>Property <c>Shp</c> represents the hood position during machining operation.</value>
		public int Shp { get; set; } = 0 ;

		public int Ea21 { get; set; } = BppLib.NO ;

		/// <value>Property <c>Cen</c> represents the identification code for the machine work centre
		/// to be used for the machining operation.</value> 
		public string Cen { get; set; } = "" ;

		/// <value>Property <c>Agg</c> represents the identification code for the aggregate.</value>
		public string Agg { get; set; } = "" ;

		/// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "BCL" ;

		/// <value>Property <c>Prs</c> enables or disables the use of the presser.</value> 
		public int Prs { get; set; } = BppLib.NO ;

		/// <value>Property <c>Etb</c> enables or disables the tool inner blowing.</value>
		public int Etb { get; set; } = BppLib.NO ;

		/// <value>Property <c>Kdt</c> enables or disables the deflector.</value>
		public int Kdt { get; set; } = BppLib.NO ;

		/// <value>Property <c>Kdt</c> enables or disables the execute probing.</value>
		public int Dtas { get; set; } = BppLib.NO ;

		public int Rmd { get; set; } = BppLib.RmdAuto ;

		public int Dqt { get; set; } = 0 ;

		public int Erdw { get; set; } = BppLib.NO ;

		public int Dfw { get; set; } = 0 ;

		/// <summary>This constructor initializes the new Bcl
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Bcl()
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
			sb.Append(" " + X.ToString());
			sb.Append(",");
			sb.Append(" " + Y.ToString());
			sb.Append(",");
			sb.Append(" " + Z.ToString());
			sb.Append(",");
			sb.Append(" " + Dp.ToString());
			sb.Append(",");
			sb.Append(" " + Dia.ToString());
			sb.Append(",");
			sb.Append(" " + Thr.ToString());
			sb.Append(",");
			sb.Append(" " + Rty.ToString());
			sb.Append(",");
			sb.Append(" " + Dx.ToString());
			sb.Append(",");
			sb.Append(" " + Dy.ToString());
			sb.Append(",");
			sb.Append(" " + R.ToString());
			sb.Append(",");
			sb.Append(" " + A.ToString());
			sb.Append(",");
			sb.Append(" " + Da.ToString());
			sb.Append(",");
			sb.Append(" " + Nrp.ToString());
			sb.Append(",");
			sb.Append(" \"" + Iso +"\"");
			sb.Append(",");
			sb.Append(" " + Opt.ToString());
			sb.Append(",");
			sb.Append(" " + Az.ToString());
			sb.Append(",");
			sb.Append(" " + Ar.ToString());
			sb.Append(",");
			sb.Append(" " + Ap.ToString());
			sb.Append(",");
			sb.Append(" " + Cka.ToString());
			sb.Append(",");
			sb.Append(" " + Xrc.ToString());
			sb.Append(",");
			sb.Append(" " + Yrc.ToString());
			sb.Append(",");
			sb.Append(" " + Arp.ToString());
			sb.Append(",");
			sb.Append(" " + Lrp.ToString());
			sb.Append(",");
			sb.Append(" " + Er.ToString());
			sb.Append(",");
			sb.Append(" " + Md.ToString());
			sb.Append(",");
			sb.Append(" " + Cow.ToString());
			sb.Append(",");
			sb.Append(" " + A21.ToString());
			sb.Append(",");
			sb.Append(" " + Tos.ToString());
			sb.Append(",");
			sb.Append(" " + Vtr.ToString());
			sb.Append(",");
			sb.Append(" " + S21.ToString());
			sb.Append(",");
			sb.Append(" \"" + Id +"\"");
			sb.Append(",");
			sb.Append(" " + Azs.ToString());
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
			sb.Append(" " + Dds.ToString());
			sb.Append(",");
			sb.Append(" " + Dsp.ToString());
			sb.Append(",");
			sb.Append(" " + Bfc.ToString());
			sb.Append(",");
			sb.Append(" " + Shp.ToString());
			sb.Append(",");
			sb.Append(" " + Ea21.ToString());
			sb.Append(",");
			sb.Append(" \"" + Cen +"\"");
			sb.Append(",");
			sb.Append(" \"" + Agg +"\"");
			sb.Append(",");
			sb.Append(" \"" + Lay +"\"");
			sb.Append(",");
			sb.Append(" " + Prs.ToString());
			sb.Append(",");
			sb.Append(" " + Etb.ToString());
			sb.Append(",");
			sb.Append(" " + Kdt.ToString());
			sb.Append(",");
			sb.Append(" " + Dtas.ToString());
			sb.Append(",");
			sb.Append(" " + Rmd.ToString());
			sb.Append(",");
			sb.Append(" " + Dqt.ToString());
			sb.Append(",");
			sb.Append(" " + Erdw.ToString());
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
			sb.AppendLine("	NAME=BCL");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=CRN,VALUE=\"" + Crn + "\"");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString());
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString());
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString());
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString());
			sb.AppendLine("	PARAM,NAME=DIA,VALUE=" + Dia.ToString());
			sb.AppendLine("	PARAM,NAME=THR,VALUE=" + ConvertOnOff(Thr));
			sb.AppendLine("	PARAM,NAME=RTY,VALUE=" + ConvertRty(Rty));
			sb.AppendLine("	PARAM,NAME=DX,VALUE=" + Dx.ToString());
			sb.AppendLine("	PARAM,NAME=DY,VALUE=" + Dy.ToString());
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString());
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString());
			sb.AppendLine("	PARAM,NAME=DA,VALUE=" + Da.ToString());
			sb.AppendLine("	PARAM,NAME=NRP,VALUE=" + Nrp.ToString());
			sb.AppendLine("	PARAM,NAME=ISO,VALUE=\"" + Iso + "\"");
			sb.AppendLine("	PARAM,NAME=OPT,VALUE=" + ConvertOnOff(Opt));
			sb.AppendLine("	PARAM,NAME=AZ,VALUE=" + Az.ToString());
			sb.AppendLine("	PARAM,NAME=AR,VALUE=" + Ar.ToString());
			sb.AppendLine("	PARAM,NAME=AP,VALUE=" + ConvertOnOff(Ap));
			sb.AppendLine("	PARAM,NAME=CKA,VALUE=" + ConvertCka(Cka));
			sb.AppendLine("	PARAM,NAME=XRC,VALUE=" + Xrc.ToString());
			sb.AppendLine("	PARAM,NAME=YRC,VALUE=" + Yrc.ToString());
			sb.AppendLine("	PARAM,NAME=ARP,VALUE=" + Arp.ToString());
			sb.AppendLine("	PARAM,NAME=LRP,VALUE=" + Lrp.ToString());
			sb.AppendLine("	PARAM,NAME=ER,VALUE=" + ConvertOnOff(Er));
			sb.AppendLine("	PARAM,NAME=MD,VALUE=" + ConvertOnOff(Md));
			sb.AppendLine("	PARAM,NAME=COW,VALUE=" + ConvertOnOff(Cow));
			sb.AppendLine("	PARAM,NAME=A21,VALUE=" + A21.ToString());
			sb.AppendLine("	PARAM,NAME=TOS,VALUE=" + ConvertOnOff(Tos));
			sb.AppendLine("	PARAM,NAME=VTR,VALUE=" + Vtr.ToString());
			sb.AppendLine("	PARAM,NAME=S21,VALUE=" + S21.ToString());
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=AZS,VALUE=" + Azs.ToString());
			sb.AppendLine("	PARAM,NAME=MAC,VALUE=\"" + Mac + "\"");
			sb.AppendLine("	PARAM,NAME=TNM,VALUE=\"" + Tnm + "\"");
			sb.AppendLine("	PARAM,NAME=TTP,VALUE=" + Ttp.ToString());
			sb.AppendLine("	PARAM,NAME=TCL,VALUE=" + Tcl.ToString());
			sb.AppendLine("	PARAM,NAME=RSP,VALUE=" + Rsp.ToString());
			sb.AppendLine("	PARAM,NAME=IOS,VALUE=" + Ios.ToString());
			sb.AppendLine("	PARAM,NAME=WSP,VALUE=" + Wsp.ToString());
			sb.AppendLine("	PARAM,NAME=SPI,VALUE=\"" + Spi + "\"");
			sb.AppendLine("	PARAM,NAME=DDS,VALUE=" + Dds.ToString());
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
			sb.AppendLine("	PARAM,NAME=RMD,VALUE=" + ConvertRmd(Rmd));
			sb.AppendLine("	PARAM,NAME=DQT,VALUE=" + Dqt.ToString());
			sb.AppendLine("	PARAM,NAME=ERDW,VALUE=" + ConvertOnOff(Erdw));
			sb.AppendLine("	PARAM,NAME=DFW,VALUE=" + Dfw.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

		string ConvertOnOff(int value)
		{
			if (value == 1)
				{return "YES";}
			return "NO";
		}

		string ConvertRty(int value)
		{
			switch (value)	
			{
				case -1 :
					return "rpNO";
			
				case 0 :
					return "rpX";
					
				case 1 :
					return "rpY";
					
				case 2 :
					return "rpXY";
					
				case 3 :
					return "rpCIR";
					
				case 5 :
					return "rpAL";
					
				default :
					return "rpNO";
					
			}
		}

		string ConvertCka(int value)
		{
			switch (value)	
			{
				case 0 :
					return "azrNO";
					
				case 1 :
					return "azrABS";
					
				case 2 :
					return "azrINC";

				default :
					return "azrNO";
					
			}
		}

		string ConvertRmd(int value)
		{
			switch (value)	
			{
				case -1 :
					return "rmdAuto";
					
				case 1 :
					return "rmdComplete";
					
				case 2 :
					return "rmdPartial";

				case 3 :
					return "rmdQuote";

				default :
					return "rmdAuto";
					
			}
		}

	}
}