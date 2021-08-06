using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>DescriptionSection</c> models the description section of Biesse CNC programme.</summary>
    public class DescriptionSection : IBppCode
    {
         /// <value>Property <c>DescText</c> represents the text of description of Biesse CNC programme.</value>
        public string DescText { get ; set; } = "" ;

       /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[DESCRIPTION]");
            string s = DescText;
            if (!String.IsNullOrEmpty(s))
            {
                string [] subs = s.Split('\n');
                for(int i = 0; i < subs.Length; i++)
                {
                    var item = subs[i];
                    if ( i < subs.Length - 1) 
                        {sb.AppendLine("|" + item.TrimEnd('\r'));}
                    else
                        {sb.Append("|" + item.TrimEnd('\r'));}
                }
            }
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