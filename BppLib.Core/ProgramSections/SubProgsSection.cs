using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>SubProgsSection</c> models the sub programmes section of Biesse CNC programme.</summary>
    public class SubProgsSection : IBppCode
    {
        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.Append("[SUBPROGS]");
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