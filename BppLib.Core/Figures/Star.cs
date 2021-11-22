using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
	/// <summary>Class <c>Star</c> models the star.</summary>.
	public class Star: IBppCode
	{
		private bool _startFromHalfSide = true;
        private double _sd;

		/// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "STAR" ;

		/// <value>Property <c>Id</c> represents the unique identifier an object of BiesseWorks.</value>
		public int Id { get; set; } 

		/// <value>Property <c>Xc</c> represents the X-axis co-ordinate of the centre of the star.</value>
		public double Xc { get; set; } = 0 ;

		/// <value>Property <c>Yc</c> represents the Y-axis co-ordinate of the centre of the star.</value>
		public double Yc { get; set; } = 0 ;

		/// <value>Property <c>Er</c> represents the radius of the circle outside the star.</value>
		public double Er { get; set; } = 100 ;

		/// <value>Property <c>Ir</c> represents the radius of the circle inside the star.</value>
		public double Ir { get; set; } = 25 ;

		/// <value>Property <c>Ps</c> represents the number of bits in the star.</value>
		public int Ps { get; set; } = 5 ;

		/// <value>Property <c>Dir</c> represents direction of the geometry;
        /// set dirCCW to indicate an anticlockwise direction, or set
        /// dirCW to indicate a clockwise direction.</value>
		public CircleDirection Dir { get; set; } = CircleDirection.dirCW ;

		/// <value>Property <c>Ct</c> represents the type of chamfering the angles of the rectangle.</value>
		public ChamferType Ct { get; set; } = ChamferType.cmfNO ;

		/// <value>Property <c>Cd</c> represents the chamfer dimension.</value>
        public double Cd { get; set; } = 0 ;

        /// <value>Property <c>Ss</c> represents the side of the rectangle from which to start when carrying out the machining operation.</value>
		public int Ss { get; set; } = 1 ;

        /// <value> True is start point on the centre of the side.</value>
        public bool StartFromHalfSide
         { get => _startFromHalfSide;
          set => _startFromHalfSide = value; }

        /// <value>Property <c>Sd</c> represents the value for the start point of the side of the rectangle
        /// set above from which to start the machining operation.</value>
		public double Sd
         { get
           {
               return _sd;
           } 
           set
           {
               _startFromHalfSide = false;
               _sd = value;
           } 
        } 

        /// <value>Property <c>A</c> represents the angle of rotation of the rectangle 
        /// with respect to the centre of the rectangle itself.</value>
		public double A { get; set; } = 0 ;

        /// <value>Property <c>Zs</c> represents value of the increase in machining depth in the initial part of the element.</value>
		public double Zs { get; set; } = 0 ;

        /// <value>Property <c>Ze</c> represents value of the increase in machining depth in the final part of the element.</value>
		public double Ze { get; set; } = 0 ;

        /// <value>Property <c>Sc</c> set sharp corner. Select one of the possible options to indicate that the point of
        /// intersection between the arc and the next element must be machined leaving a sharp corner.</value>
		 public SharpCorner Sc { get; set; } = SharpCorner.scOFF ;

        /// <value>Property <c>Fd</c> represents tool speed of advance value.</value>
		public int Fd { get; set; } = 0 ;

        /// <value>Property <c>Sp</c> represents tool rotation speed value.</value>
		public int Sp { get; set; } = 0 ;

		/// <summary>This constructor initializes the new Star
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public Star()
		{
			Id = GetHashCode();
		}

		/// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("@ " + BppName + ", \"\", \"\", ");
			sb.Append(Id.ToString());
			sb.Append(", \"\", 0 :");
			sb.Append(" " + Xc.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Yc.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Er.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ir.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ps.ToString());
			sb.Append(",");
			sb.Append(" " + ((int)Dir).ToString());
			sb.Append(",");
			sb.Append(" " + ((int)Ct).ToString());
			sb.Append(",");
			sb.Append(" " + Cd.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ss.ToString());
			sb.Append(",");
            if (StartFromHalfSide)
                {sb.Append(" HALF");}
            else
			    {sb.Append(" " + Sd.ToString(CultureInfo.InvariantCulture));}
			sb.Append(",");
			sb.Append(" " + A.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Zs.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + Ze.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + ((int)Sc).ToString());
			sb.Append(",");
			sb.Append(" " + Fd.ToString());
			sb.Append(",");
			sb.Append(" " + Sp.ToString());
			return sb.ToString();
		}

		/// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=STAR");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=" + Id.ToString());
			sb.AppendLine("	PARAM,NAME=XC,VALUE=" + Xc.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=YC,VALUE=" + Yc.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ER,VALUE=" + Er.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=IR,VALUE=" + Ir.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=PS,VALUE=" + Ps.ToString());
			sb.AppendLine("	PARAM,NAME=DIR,VALUE=" + Dir.ToString());
			sb.AppendLine("	PARAM,NAME=CT,VALUE=" + Ct.ToString());
			sb.AppendLine("	PARAM,NAME=CD,VALUE=" + Cd.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SS,VALUE=" + Ss.ToString());
            if (StartFromHalfSide)
                {sb.AppendLine("	PARAM,NAME=SD,VALUE=HALF");}
            else                
			    {sb.AppendLine("	PARAM,NAME=SD,VALUE=" + Sd.ToString(CultureInfo.InvariantCulture));}
			sb.AppendLine("	PARAM,NAME=A,VALUE=" + A.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZS,VALUE=" + Zs.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=ZE,VALUE=" + Ze.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SC,VALUE=" + Sc.ToString());
			sb.AppendLine("	PARAM,NAME=FD,VALUE=" + Fd.ToString());
			sb.AppendLine("	PARAM,NAME=SP,VALUE=" + Sp.ToString());
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}