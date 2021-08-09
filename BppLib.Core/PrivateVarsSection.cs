using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.Core
{
    /// <summary>Class <c>PrivateVarsSection</c> models the private variables section of Biesse CNC programme.</summary>
    public class PrivateVarsSection : IBppCode
    {
        /// <value>Property <c>PrivateVariables</c> represents the list of private variables.</value>
        public List<BiesseVariable> PrivateVariables { get; set; } = new List<BiesseVariable>();

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            if (PrivateVariables.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < PrivateVariables.Count; i++)
                {
                    var item = PrivateVariables[i];
                    if (item.Typ == BiesseVariablesType.String)
                    {
                        sb.Append("LOC=" + item.Name + "|\"" + item.Value + "\"|" + item.Description + "|" + ((int)item.Typ).ToString() + "|");
                    }
                    else
                        {sb.Append("LOC=" + item.Name + "|" + item.Value + "|" + item.Description + "|" + ((int)item.Typ).ToString() + "|");}
                    if (i < PrivateVariables.Count - 1)
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
             if (PrivateVariables.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("BEGIN PRIVATEVARS");
                foreach(var item in PrivateVariables)
                {
                    if (item.Typ == BiesseVariablesType.String)
                    {
                        sb.AppendLine("\tPARAM, NAME=" + item.Name + ", VALUE=\"" + item.Value + "\", DESCRIPTION=\"" + item.Description + "\", TYPE=" + ((int)item.Typ).ToString().Replace(",","."));
                    }
                    else
                        {sb.AppendLine("\tPARAM, NAME=" + item.Name + ", VALUE=" + item.Value + ", DESCRIPTION=\"" + item.Description + "\", TYPE=" + ((int)item.Typ).ToString().Replace(",","."));}
                }
                sb.Append("END PRIVATEVARS");
                return sb.ToString();
            }
            else return "";
        }
    }
}