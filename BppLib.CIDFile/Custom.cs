using System;
using System.Text;
using System.Globalization;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>Custom</c> represents boring operation in the CID program.</summary>
    public class Custom : IBlock
    {
        /// <value>Property <c>TechBlock</c> represents the techical data of the boring operation.</value>
        public Tech TechBlock {get; set;} = new Tech();

        /// <value>Property <c>RefPoint</c> represents the corner of the piece which positioned the system of coordinate.</value>
        public int RefPoint {get; set;} = 2;

        /// <value>Property <c>StartPoint</c> represents the start point of machining hole.</value>
        public Point StartPoint {get; set;} = new Point();

        /// <value>Property <c>X</c> represents the X-axis co-ordinate of the centre of the machining hole.</value>
        public double X 
        {
            get { return StartPoint.X; }
            set { StartPoint.X = value;}
        } 

        /// <value>Property <c>Y</c> represents the Y-axis co-ordinate of the centre of the machining hole.</value>
        public double Y
        {
            get { return StartPoint.Y; }
            set { StartPoint.Y = value;}
        }

        /// <value>Property <c>Z</c> represents the Z-axis co-ordinate of the centre of the machining hole.</value>
        public double Z 
        {
            get { return StartPoint.Z; }
            set { StartPoint.Z = value;}
        }

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("  BEGIN CUSTOM");
            sb.AppendLine(TechBlock.AsCidCode());
            sb.AppendLine("	REFPOINT=" + RefPoint.ToString() +" ");
            sb.AppendLine(StartPoint.AsCidCode());
            sb.Append("  END CUSTOM");
            return sb.ToString();
        } 

        /// <summary>This method turns the <c>Custom</c> into "BLOCK".</summary>
        public string AsCidBlock()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN BLOCK");
            sb.AppendLine("  NAME=WRK");
            sb.AppendLine(this.AsCidCode());
            sb.Append("END BLOCK");
            return sb.ToString();
        }
    }
}