using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
       
        public void SetCreateVariable()
        {
            engine.Evaluate(@"function createVariable(specifiers, format) {
                class createVariableClass{
                    constructor(specifiers, format){
                        this.varFormat = format;
                        if (specifiers[""prefix""] != undefined) 
                            {this.varFormat.prefix = specifiers[""prefix""]; }
                    }
                    format(value){
                        return this.varFormat.format(value);
                    }
                }
            return new createVariableClass(specifiers, format);
            }");

        }
    }
}