using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Tech</c> models Tech section in Biesse CID program.</summary>
    public class Tech
    {
        ///<value> Property <c>Cat</c> represents the category of operation.</value>
        public int Cat {get; set;} = 0;

        ///<value> Property <c>Typ</c> represents the type of tool.</value>
        public int Typ {get; set;} = 0;

        ///<value> Property <c>ToolName</c> represents the name of tool.</value>
        public string ToolName {get; set;} = "";

        ///<value> Property <c>Diam</c> represents the diameter of tool.</value>
        public double Diam {get; set;} = 5;

        ///<value> Property <c>DepthStart</c> represents the depth of the start point of the operation.</value>
        public double DepthStart {get; set;} = 0;

        ///<value> Property <c>DepthEnd</c> represents the depth of the end point of the operation.</value>
        public double DepthEnd {get; set;} = 0;

        /// <value>Property <c>WorkSpeed</c> represents the speed at which the tool makes the operation.</value>
        public double WorkSpeed {get; set;} = 0;

        /// <value>Property <c>RotSpeed</c> represents the tool  rotation speed.</value> 
        public double RotSpeed {get; set;} = 0;
		
        /// <value>Property <c>DesSpeed</c> represents the speed of the tool during the phases of the piece collapse,
		/// usable only for through machining operations.</value>
        public double DesSpeed {get; set;} = 0;
		
        /// <value>Property <c>ToolCorTyp</c> represents the tool correction.</value>
        public string ToolCorTyp {get; set;} = "";
		
        public double Ang0 {get; set;} = 0;

        public double Ang1 {get; set;} = 0;

		/// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("	BEGIN TECH");
            sb.AppendLine("		CAT=" + Cat.ToString());
            if (Cat != 0)
                {
                  sb.AppendLine("		TYP=" + Typ.ToString()); 
                  if (ToolName != "") sb.AppendLine("		TOOLNAME=" + ToolName);
                  sb.AppendLine("		DIAM=" + Diam.ToString("F4", CultureInfo.InvariantCulture));
                  if ((Cat == 1) || (Cat == 3))
                    {sb.AppendLine("		DEPTH=" + DepthStart.ToString("F4", CultureInfo.InvariantCulture) + "," + DepthEnd.ToString("F4", CultureInfo.InvariantCulture));}
                  if ((WorkSpeed != 0) || (Cat == 2) || (Cat == 3))  sb.AppendLine("		WORKSPEED=" + WorkSpeed.ToString("F4", CultureInfo.InvariantCulture));
                  if ((RotSpeed != 0) || (Cat == 2) || (Cat == 3))  sb.AppendLine("		ROTSPEED=" + RotSpeed.ToString("F4", CultureInfo.InvariantCulture));
                  if ((DesSpeed != 0) || (Cat == 2) || (Cat == 3))  sb.AppendLine("		DESSPEED=" + DesSpeed.ToString("F4", CultureInfo.InvariantCulture));
		    	  if (ToolCorTyp != "") sb.AppendLine("		TOOLCORTYP=" + ToolCorTyp);
                  sb.AppendLine("		ANG=" + Ang0.ToString("F4", CultureInfo.InvariantCulture) + "," + Ang1.ToString("F4", CultureInfo.InvariantCulture));  
                }
            sb.Append("	END TECH");
            return sb.ToString();
        }
    }
}