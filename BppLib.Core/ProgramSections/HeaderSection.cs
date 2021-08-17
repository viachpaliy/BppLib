using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>HeaderSection</c> models the header section of Biesse CNC programme.</summary>
    public class HeaderSection : IBppCode
    {
         /// <value>Property <c>Typ</c> represents the type of Biesse CNC programme.</value>
        public string Typ { get ; set; } = "BPP" ;

        /// <value>Property <c>Version</c> represents the version of Bpp programme.</value>
        public string Version { get ; set; } = "150" ;

        /// <value>Property <c>Release</c> represents the release of Cix programme.</value>
        public string Release { get ; set; } = "5.0" ;

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            return String.Format("[HEADER]\r\nTYPE={0}\r\nVER={1}",Typ,Version);
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
            return String.Format("BEGIN ID CID3\r\n\tREL= {0}\r\nEND ID",Release);
        }

    }

}