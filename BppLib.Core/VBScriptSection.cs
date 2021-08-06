using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>VBScriptSection</c> models the VBScript section of Biesse CNC programme.</summary>
    public class VBScriptSection : IBppCode
    {
        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.Append("[VBSCRIPT]");
             return sb.ToString();
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN VB");
            sb.AppendLine("	VBLINE=\"" + "\"");
            sb.Append("END VB");
             return sb.ToString();
        }
    }
}