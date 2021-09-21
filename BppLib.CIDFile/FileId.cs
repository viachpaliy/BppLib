using System;
using System.Text;

namespace BppLib.CIDFile
{
    ///<summary>Class <c>FileId</c> models ID section in the CID program.</summary>
    public class FileId
    {
        ///<value> Property <c>FileName</c> represents the name of the CID program.</value>
        public string FileName { get; set; } = "Panel";

        ///<value>Property <c>Rel</c> represents the release of CID programme.</value>
        public string Rel { get; set; } = "3.0";

        ///<value>Property <c>Axis</c> represents the machine axes direction.</value>
        public string Axis { get; set; } = "x+,y-,z-";

        /// <summary>This method serializes an object as Cid code.</summary>
		/// <returns>A string  is coded as Cid code.</returns>
        public string AsCidCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN ID CID3");
            sb.AppendLine("'\"" + FileName + "\"");
            sb.AppendLine("  REL= " + Rel);
            sb.AppendLine("  AXIS=" + Axis);
            sb.Append("END ID");
            return sb.ToString();
        }
    }
}
