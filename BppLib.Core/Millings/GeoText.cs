using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>GeoText</c> models the text geometry.</summary>
	public class GeoText: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "GEOTEXT" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

        /// <value>Property <c>Id</c> represents the description of the geometry definition.</value> 
		public string Id { get; set; } = "P1001" ;

        /// <value>Property <c>Side</c> represents the piece side.</value>
		public int Side { get; set; } = 0 ;

        /// <value>Property <c>Crn</c> represents the piece reference corner.</value>
		public string Crn { get; set; } = "2" ;

        /// <value>Property <c>Txt</c> represents the text.</value>
		public string Txt { get; set; } = "Hello World" ;

        /// <value>Property <c>X</c> represents the X-axis co-ordinate of the start point of the text.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate of the start point of the text.</value>
		public double Y { get; set; } = 0 ;

        /// <value>Property <c>Z</c> represents the depth reached by the tool at the initial machining operation point.
		/// The value indicated in this property is added to that indicated in the property <c>Dp</c> of <see cref="RoutG"/> class.</value>
		public double Z { get; set; } = 0 ;

        /// <value>Property <c>Ang</c> represents the angle of rotation of the text on plane X, Y.</value>
		public double Ang { get; set; } = 0 ;

        /// <value>Property <c>Vrs</c> represents the direction of the text based on the start point.</value>
		public TextDirection Vrs { get; set; } = TextDirection.LeftToRight ;

        /// <value>Property <c>Aln</c> represents the alignment of the text, based on the start point.</value>
		public TextAlignment Aln { get; set; } = TextAlignment.Central ;

        /// <value>Property <c>Acc</c> represents the character precision index.</value>
		public int Acc { get; set; } = 0 ;

        /// <value>Property <c>Cir</c> used to define the type of path to be followed by the text;
        /// ; i.e. a straight path (<c>Cir = false</c>) or a circular path(<c>Cir = true</c>).</value> 
		public bool Cir { get; set; } = false ;

        /// <value>Property <c>Rds</c> represents the radius of the circular path(<c>Cir = true</c>).</value> 
		public double Rds { get; set; } = 0 ;

        /// <value>Property <c>Pst</c> used to indicate the position of the text applied to the circle.</value>
		public TextPosition Pst { get; set; } = TextPosition.txtExt ;

        /// <value>Property <c>Fnt</c> represents the font name.</value>
		public string Fnt { get; set; } = "Arial" ;

        /// <value>Property <c>Sze</c> represents the e height of the word.</value>
		public double Sze { get; set; } = 20 ;

		/// <value>Property <c>Bol</c>  used to set bold characters, to make the text more evident.</value>
		public bool Bol { get; set; } = false ;

		/// <value>Property <c>Itl</c> used to change the text to italics.</value>
		public bool Itl { get; set; } = false ;

		/// <value>Property <c>Udl</c>  used to underline the text.</value>
		public bool Udl { get; set; } = false ;

		/// <value>Property <c>Str</c> used to mark the text with a bar.</value>
		public bool Str { get; set; } = false ;

		/// <value>Property <c>Wgh</c> used to define the extension of the word in length.</value>
		public double Wgh { get; set; } = 1 ;

		/// <value>Property <c>Chs</c> models the "CHS" parameter of the "GEOTEXT" macro.
		/// The exact meaning of the parameter is unknown. Default value is 0.</value> 
		public int Chs { get; set; } = 0 ;

		/// <value>Property <c>Rty</c> represents the type of repeats.</value>
		public Repetition Rty { get; set; } = Repetition.rpNO ;

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

        /// <value>Property <c>Nrp</c> represents the number of repeats required.</value>
		public int Nrp { get; set; } = 0 ;

        /// <value>Property <c>Xrc</c> represents the X position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public int Xrc { get; set; } = 0 ;

        /// <value>Property <c>Yrc</c> represents the Y position of the centre of rotation of the circumference
		/// around which the repeats arecarried out.</value>
		public int Yrc { get; set; } = 0 ;

        /// <value>Property <c>Arp</c> represents the angle of the straight line along which the repeats are carried out.</value>
		public int Arp { get; set; } = 0 ;

        /// <value>Property <c>Lrp</c> represents the distance between bores.</value> 
		public int Lrp { get; set; } = 0 ;

		/// <value>Property <c>Er</c> enables the first element as the initial element in the repeat (focal repeats)
        /// eliminating the property <c>A</c> and the property <c>R</c>.</value> 
		public bool Er { get; set; } = true ;

		/// <value>Property <c>Rdl</c>  enables radial repeats.</value>
        public bool Rdl { get; set; } = true ;

        /// <value>Property <c>Lay</c> represents the Dxf layer.</value>
		public string Lay { get; set; } = "GEOTEXT" ;

        /// <summary>This constructor initializes the new GeoText
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public GeoText()
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
			sb.Append(" \"" + Txt + "\"");
			sb.Append(",");
			sb.Append(" " + X.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Y.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Z.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ang.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Vrs).ToString());
			sb.Append(",");
			sb.Append(" " + ((int)Aln).ToString());
			sb.Append(",");
			sb.Append(" " + Acc.ToString());
			sb.Append(",");
            if (Cir)
			    {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Rds.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Pst).ToString());
			sb.Append(",");
			sb.Append(" \"" + Fnt + "\"");
			sb.Append(",");
			sb.Append(" " + Sze.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
            if (Bol)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
            if (Itl)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
            if (Udl)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
            if (Str)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Wgh.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Chs.ToString());
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
			sb.Append(" " + Nrp.ToString());
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
            if (Rdl)
                {sb.Append(" 1");}
            else 
                {sb.Append(" 0");}
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
			sb.AppendLine("	NAME=GEOTEXT");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=SIDE,VALUE=" + Side.ToString());
			sb.AppendLine("	PARAM,NAME=CRN,VALUE=\"" + Crn + "\"");
			sb.AppendLine("	PARAM,NAME=TXT,VALUE=\"" + Txt + "\"");
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=Z,VALUE=" + Z.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ANG,VALUE=" + Ang.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=VRS,VALUE=" + ((int)Vrs).ToString());
			sb.AppendLine("	PARAM,NAME=ALN,VALUE=" + ((int)Aln).ToString());
			sb.AppendLine("	PARAM,NAME=ACC,VALUE=" + Acc.ToString());
			sb.Append("	PARAM,NAME=CIR,VALUE=");
            if (Cir)
			    {sb.AppendLine("1");}
            else 
                {sb.AppendLine("0");}
			sb.AppendLine("	PARAM,NAME=RDS,VALUE=" + Rds.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PST,VALUE=" + Pst.ToString());
			sb.AppendLine("	PARAM,NAME=FNT,VALUE=\"" + Fnt + "\"");
			sb.AppendLine("	PARAM,NAME=SZE,VALUE=" + Sze.ToString(CultureInfo.InvariantCulture));
			sb.Append("	PARAM,NAME=BOL,VALUE=");
            if (Bol)
			    {sb.AppendLine("1");}
            else 
                {sb.AppendLine("0");}
			sb.Append("	PARAM,NAME=ITL,VALUE=");
            if (Itl)
			    {sb.AppendLine("1");}
            else 
                {sb.AppendLine("0");} 
			sb.Append("	PARAM,NAME=UDL,VALUE=");
			if (Udl)
			    {sb.AppendLine("1");}
            else 
                {sb.AppendLine("0");}
			sb.Append("	PARAM,NAME=STR,VALUE=");
			if (Str)
			    {sb.AppendLine("1");}
            else 
                {sb.AppendLine("0");}
			sb.AppendLine("	PARAM,NAME=WGH,VALUE=" + Wgh.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=CHS,VALUE=" + Chs.ToString());
			sb.AppendLine("	PARAM,NAME=RTY,VALUE=" + Rty.ToString());
			sb.AppendLine("	PARAM,NAME=DX,VALUE=" + Dx.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DY,VALUE=" + Dy.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=R,VALUE=" + R.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=DA,VALUE=" + Da.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=NRP,VALUE=" + Nrp.ToString());
			sb.AppendLine("	PARAM,NAME=XRC,VALUE=" + Xrc.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=YRC,VALUE=" + Yrc.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ARP,VALUE=" + Arp.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=LRP,VALUE=" + Lrp.ToString(CultureInfo.InvariantCulture));
			sb.Append("	PARAM,NAME=ER,VALUE=");
			if (Er)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.Append("	PARAM,NAME=RDL,VALUE=");
			if (Rdl)
			    {sb.AppendLine("YES");}
            else 
                {sb.AppendLine("NO");}
			sb.AppendLine("	PARAM,NAME=LAY,VALUE=\"" + Lay + "\"");
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}