using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>PutProg</c> models the “PUTPROG” instruction.
    /// The “PUTPROG” instruction is used to insert sub-programs in the open document, in order to save
    /// it as a machining program containing several machining profiles.</summary>
	public class PutProg: IBppCode
	{
        /// <value>Property <c>BppName</c> represents the name of BiesseWorks type.</value>
		public string BppName { get; } = "PUTPROG" ;

        /// <value>Property <c>IntId</c> represents the unique identifier an object of BiesseWorks.</value>
		public int IntId { get; set; }

		/// <value>Property <c>Id</c> represents the description of machining operation.</value> 
		public string Id { get; set; } = "P1001" ;

        /// <value>Property <c>SpName</c> represents the name of the program to be inserted in the active document,
        /// and which will be considered a “subprogram” as it will be inside another program.</value>
		public string SpName { get; set; } = "" ;

        /// <value>Property <c>SpLpx</c> represents the X dimension of the piece of the sub-program.
        /// Leaving “-1”, the dimension indicated in the subprogram is automatically used.</value>
		public double SpLpx { get; set; } = -1 ;

        /// <value>Property <c>SpLpy</c> represents the Y dimension of the piece of the sub-program.
        /// Leaving “-1”, the dimension indicated in the subprogram is automatically used.</value>
		public double SpLpy { get; set; } = -1 ;

        /// <value>Property <c>SpLpz</c> represents the Z dimension of the piece of the sub-program.
        /// Leaving “-1”, the dimension indicated in the subprogram is automatically used.</value>
		public double SpLpz { get; set; } = -1 ;

        /// <value>Property <c>SymY</c> used to horizontally flip the piece of the sub-program.
        /// In this case, the overturned piece will mirror the previous one.</value>
		public bool SymY { get; set; } = false ;

        /// <value>Property <c>Rot</c> represents the angle of rotation of the piece of the sub-program,
        /// starting from the corner indicated in the <c>SpCrn</c> property.</value>
		public double Rot { get; set; } = 0 ;

        /// <value>Property <c>SpCrn</c> represents the corner of the piece of the sub-program.
        /// The corner indicated is the point of reference in order to position the piece in the graphics area.</value>
		public int SpCrn { get; set; } = 1 ;

        /// <value>Property <c>SpCrn</c> represents the type of reference for positioning the piece of the sub-program,
        /// starting from the corner defined in the <c>SpCrn</c> property:
        /// <c>Rft = 1</c> - Positioning on the origin
        /// <c>Rft = 2</c>- Positioning on piece corner.</value>
		public int Rft { get; set; } = 1 ;

        /// <value>Property <c>Ref</c> indicates :
        /// if <c>Rft = 1</c> - which machine origin the piece of the sub-program should be positioned on.
        /// if <c>Rft = 2</c> - which corner of the piece of the active document the piece of the
        /// sub-program should be positioned on.</value>
		public int Ref { get; set; } = 1 ;

        /// <value>Property <c>Bck</c> used to position the piece of the sub-program,
        /// using the rear part of the front stops(if <c>Rft = 1</c>).</value>
		public int Bck { get; set; } = 0 ;

        /// <value>Property <c>X</c> indicates :
        /// if <c>Rft = 1</c> - the distance in X between the origin chosen in the <c>Ref</c> property and the
        ///                    corner of the piece of the sub-program indicated in the <c>SpCrn</c> property.
        /// if <c>Rft = 2</c> - the distance in X between the corner chosen in the <c>Ref</c> property and
        ///                     the corner of the piece of the sub-program indicated in the <c>SpCrn</c> property.</value>
		public double X { get; set; } = 0 ;

        /// <value>Property <c>Y</c> indicates :
        /// if <c>Rft = 1</c> - the distance in Y between the origin chosen in the <c>Ref</c> property and the
        ///                    corner of the piece of the sub-program indicated in the <c>SpCrn</c> property.
        /// if <c>Rft = 2</c> - the distance in Y between the corner chosen in the <c>Ref</c> property and
        ///                     the corner of the piece of the sub-program indicated in the <c>SpCrn</c> property.</value>
		public double Y { get; set; } = 0 ;
        
		/// <value>Property <c>Pav</c> used to choose whether the profile of the piece of the sub-program inserted in the document
		///should be considered during the semi-automatic positioning of the objects on the table:
		/// if <c>Pav = true</c> - during the positioning, consider both the geometry in the sub-program and the piece profile.
		///							(In this case, the suction cups will lock the piece containing the geometry as well.)
		/// if <c>Pav = false</c> - during the positioning, consider only the geometry in the sub-program, without the piece profile.
		///                         (In this case, the suction cups will only lock the geometry.)</value>
		public bool Pav { get; set; } = false ;

		/// <value>Property <c>Pav</c> used to r to modify the variables. The creation or elimination of
		/// variables is not allowed. The modifications made will not alter the file of origin -
		/// they will be stored in the active document only.</value>
		public string Vars { get; set; } = "" ;

		 /// <summary>This constructor initializes the new instance of the class
   	    ///  with Id which equal a hash code of the C# object.</summary>
		public PutProg()
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
			sb.Append(" \"" + SpName + "\"");
			sb.Append(",");
			sb.Append(" " + SpLpx.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + SpLpy.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + SpLpz.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
            if (SymY)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" " + Rot.ToString(CultureInfo.InvariantCulture));
			sb.Append(",");
			sb.Append(" " + SpCrn.ToString());
			sb.Append(",");
			sb.Append(" " + Rft.ToString());
			sb.Append(",");
			sb.Append(" " + Ref.ToString());
			sb.Append(",");
			sb.Append(" " + Bck.ToString());
			sb.Append(",");
			sb.Append(" " + X.ToString());
			sb.Append(",");
			sb.Append(" " + Y.ToString());
			sb.Append(",");
			if (Pav)
			    {sb.Append(" 1");}
            else
                {sb.Append(" 0");}
			sb.Append(",");
			sb.Append(" \"" + Vars + "\"");
			return sb.ToString();
		}

		/// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("BEGIN MACRO");
			sb.AppendLine("	NAME=PUTPROG");
			sb.AppendLine("	PARAM,NAME=ID,VALUE=\"" + Id + "\"");
			sb.AppendLine("	PARAM,NAME=SPNAME,VALUE=\"" + SpName + "\"");
			sb.AppendLine("	PARAM,NAME=SPLPX,VALUE=" + SpLpx.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SPLPY,VALUE=" + SpLpy.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SPLPZ,VALUE=" + SpLpz.ToString(CultureInfo.InvariantCulture));
            if (SymY)
                {sb.AppendLine("	PARAM,NAME=SYMY,VALUE=YES");}
            else
                {sb.AppendLine("	PARAM,NAME=SYMY,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=ROT,VALUE=" + Rot.ToString(CultureInfo.InvariantCulture));
			sb.AppendLine("	PARAM,NAME=SPCRN,VALUE=" + SpCrn.ToString());
			sb.AppendLine("	PARAM,NAME=RFT,VALUE=" + Rft.ToString());
			sb.AppendLine("	PARAM,NAME=REF,VALUE=" + Ref.ToString());
			sb.AppendLine("	PARAM,NAME=BCK,VALUE=" + Bck.ToString());
			sb.AppendLine("	PARAM,NAME=X,VALUE=" + X.ToString());
			sb.AppendLine("	PARAM,NAME=Y,VALUE=" + Y.ToString());
			if (Pav)
				{sb.AppendLine("	PARAM,NAME=PAV,VALUE=YES");}
			else
				{sb.AppendLine("	PARAM,NAME=PAV,VALUE=NO");}
			sb.AppendLine("	PARAM,NAME=VARS,VALUE=\"" + Vars + "\"");
			sb.Append("END MACRO");
			return sb.ToString();
		}

	}
}