using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>Geo</c> models the geometry definition.</summary>
	public class Geo: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "GEO" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Id</c> represents the description of the geometry definition.</value> 
		public string Id { get; set; } = "P1001" ;

        /// <value>Property <c>Side</c> represents the piece side.</value>
		public int Side { get; set; } = 0 ;

        /// <value>Property <c>Crn</c> represents the piece reference corner.</value>
		public string Crn { get; set; } = "1" ;

        /// <value>Property <c>Dp</c> represents the the distance between the top side of the piece and the top side
        /// of the island, if the geometry is used as an island.</value>
		public double Dp { get; set; } = 0 ;

        /// <value>Property <c>Rty</c> represents the type of repeats.</value>
		public Repetition Rty { get; set; } = Repetition.rpNO ;

		/// <value>Property <c>Xrc</c> represents the X position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public double Xrc { get; set; } = 0 ;

        /// <value>Property <c>Yrc</c> represents the Y position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public double Yrc { get; set; } = 0 ;

        /// <value>Property <c>Dx</c> represents the distance between centres along the X-axis that defines the distance between the geometric elements.</value>
		public double Dx { get; set; } = 32 ;

        /// <value>Property <c>Dy</c> represents the distance between centres along the Y-axis that defines the distance between the geometric elements.</value>
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

        /// <value>Property <c>Arp</c> represents the angle of the straight line along which the repeats are carried out.</value>
		public int Arp { get; set; } = 0 ;

        /// <value>Property <c>Lrp</c> represents the distance between bores.</value> 
		public int Lrp { get; set; } = 0 ;

        /// <value>Property <c>Er</c> enables the first element as the initial element in the repeat (focal repeats)
        /// eliminating the property <c>A</c> and the property <c>R</c>.</value> 
		public bool Er { get; set; } = true ;

        /// <value>Property <c>Rv</c> reverses the direction of the programmed geometrical profile;
        /// the initial point of the geometry thus becomes the final point.</value>
		public bool Rv { get; set; } = false ;

		/// <value>Property <c>Cow</c> used to enable the machining operation also on the face opposite
		/// the programmed one, using both operating sections.</value>
		public bool Cow { get; set; } = false ;

        /// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "GEO" ;

        /// <value>Property <c>Crc</c> represents the correction(position of the tool with respect to the working trajectory).</value>
		public int Crc { get; set; } = 0 ;

        /// <summary>This constructor initializes the new Geo
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Geo()
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
			sb.Append(" \"" + Id + "\"");
			sb.Append(",");
			sb.Append(" " + Side.ToString());
			sb.Append(",");
			sb.Append(" \"" + Crn + "\"");
			sb.Append(",");
			sb.Append(" " + Dp.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + ((int)Rty).ToString());
			sb.Append(",");
			sb.Append(" " + Xrc.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Yrc.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Dx.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Dy.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + R.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + A.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Da.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Rdl));
			sb.Append(",");
			sb.Append(" " + Nrp.ToString());
			sb.Append(",");
			sb.Append(" " + Arp.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + Lrp.ToString().Replace(',','.'));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Er));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Rv));
			sb.Append(",");
			sb.Append(" " + ConvertBoolToInt(Cow));
			sb.Append(",");
			sb.Append(" \"" + Lay + "\"");
			sb.Append(",");
			sb.Append(" " + Crc.ToString());
			return sb.ToString();
		}

		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=GEO");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=CRN,VALUE=\"" + Crn + "\"");
			sb.AppendLine("	PARAM,NAME=DP,VALUE=" + Dp.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=RTY,VALUE=" + Rty.ToString());
			sb.AppendLine("	PARAM,NAME=XRC,VALUE=" + Xrc.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=YRC,VALUE=" + Yrc.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=DX,VALUE=" + Dx.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=DY,VALUE=" + Dy.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=DA,VALUE=" + Da.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=RDL,VALUE=" + ConvertBoolToYesNo(Rdl));
			sb.AppendLine("	PARAM,NAME=NRP,VALUE=" + Nrp.ToString());
			sb.AppendLine("	PARAM,NAME=ARP,VALUE=" + Arp.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=LRP,VALUE=" + Lrp.ToString().Replace(',','.'));
			sb.AppendLine("	PARAM,NAME=ER,VALUE=" + ConvertBoolToYesNo(Er));
			sb.AppendLine("	PARAM,NAME=RV,VALUE=" + ConvertBoolToYesNo(Rv));
			sb.AppendLine("	PARAM,NAME=COW,VALUE=" + ConvertBoolToYesNo(Cow));
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.AppendLine("	PARAM,NAME=CRC,VALUE=" + Crc.ToString());
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