using System;
using System.Text;

namespace BppLib.Core
{
    public class BiesseVariable
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public  BiesseVariablesType Typ { get; set; } = BiesseVariablesType.General ;
    }
}