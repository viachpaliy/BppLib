using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.Core
{
    /// <summary>Class <c>PublicVarsSection</c> models the public variables section of Biesse CNC programme.</summary>
    public class PublicVarsSection : IBppCode
    {
        /// <value>Property <c>PublicVariables</c> represents the list of public variables.</value>
        public List<BiesseVariable> PublicVariables { get; set; } = new List<BiesseVariable>();

         /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            if (PublicVariables.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < PublicVariables.Count; i++)
                {
                    var item = PublicVariables[i];
                    if (item.Typ == BiesseVariablesType.String)
                    {
                        sb.Append("GLB=" + item.Name + "|\"" + item.Value + "\"|" + item.Description + "|" + ((int)item.Typ).ToString() + "|");
                    }
                    else
                        {sb.Append("GLB=" + item.Name + "|" + item.Value + "|" + item.Description + "|" + ((int)item.Typ).ToString() + "|");}
                    if (i < PublicVariables.Count - 1)
                        {sb.AppendLine("");}
                }
                return sb.ToString();
            }
            else return "";
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
             if (PublicVariables.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("BEGIN PUBLICVARS");
                foreach(var item in PublicVariables)
                {
                    if (item.Typ == BiesseVariablesType.String)
                    {
                        sb.AppendLine("\tPARAM, NAME=" + item.Name + ", VALUE=\"" + item.Value + "\", DESCRIPTION=\"" + item.Description + "\", TYPE=" + ((int)item.Typ).ToString().Replace(",","."));
                    }
                    else
                        {sb.AppendLine("\tPARAM, NAME=" + item.Name + ", VALUE=" + item.Value + ", DESCRIPTION=\"" + item.Description + "\", TYPE=" + ((int)item.Typ).ToString().Replace(",","."));}
                }
                sb.Append("END PUBLICVARS");
                return sb.ToString();
            }
            else return "";
        }
    }
}