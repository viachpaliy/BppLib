using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Class <c>BiesseVariable</c> models the variables which can be modified
    /// from the dialogue box "Program variables" of the "BiesseWorks" software.</summary>
    public class BiesseVariable
    {
        /// <value>Property <c>Name</c> represents the name of the variable.</value>
        public string Name { get; set; }

        /// <value>Property <c>Value</c> represents the value of the variable.</value>
        public string Value { get; set; }

        /// <value>Property <c>Description</c> represents the description of the variable.</value>
        public string Description { get; set; }

        /// <value>Property <c>Typ</c> represents the type of the variable.</value>
        public  BiesseVariablesType Typ { get; set; } = BiesseVariablesType.General ;
    }
}