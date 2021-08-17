using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.Core
{
    /// <summary>Class <c>ProgramSection</c> models the program section of Biesse CNC programme.</summary>
    public class ProgramSection : IBppCode
    {
        /// <value>Property <c>BiesseEntities</c> represents the list of Biesse entities which program is consisted.</value>
        public List<IBppCode> BiesseEntities { get; set; } = new List<IBppCode>();

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[PROGRAM]");
            if (BiesseEntities.Count > 0)
            {
                foreach(var item in BiesseEntities)
                {
                    sb.Append("\r\n" + item.AsBppCode());
                }
            }
            return sb.ToString();
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
             StringBuilder sb = new StringBuilder();
            if (BiesseEntities.Count > 0)
            {
                for(int i = 0; i < BiesseEntities.Count; i++)
                {
                    var item = BiesseEntities[i];
                    if (i < BiesseEntities.Count - 1)
                        {sb.AppendLine("\r\n" + item.AsCixCode());}
                    else 
                        {sb.Append("\r\n" + item.AsCixCode());}
                }
            }
            return sb.ToString();
        }
    }
}