using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>MacroDataSection</c> models the Macro Data section of Biesse CNC programme.</summary>
    public class MacroDataSection : IBppCode
    {
        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.Append("[MACRODATA]");
             return sb.ToString();
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
            return "";
        }
    }
}