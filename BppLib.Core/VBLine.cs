using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>VBLine</c> models the VBScript code line in Biesse CNC programme.</summary>
    public class VBLine : IBppCode
    {
        ///<value> Property <c>Code</c> represents the line of VBScript code.</value>
        public string Code { get; set; } 

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.Append(Code);
             return sb.ToString();
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN VB");
            string[] strs = Code.Replace("\r","").Split('\n');
            if (strs.Length >0)
            {
                foreach(var item in strs)
                {
                   {sb.AppendLine("	VBLINE=\"" + item + "\"");} 
                }
            }
            else
                {sb.AppendLine("	VBLINE=\"" + "\"");}
            sb.Append("END VB");
             return sb.ToString();
        }
    }
}