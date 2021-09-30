using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
       
        public void SetCreateReferenceVariable()
        {
            engine.Evaluate(@"function createReferenceVariable(specifiers, format) {
                class createReferenceVariableClass{
                    constructor(specifiers, format){
                        this.currentValue = undefined;
                        this.prevValue = undefined;
                        this.enabled = true;
                        this.varFormat = format;
                        if (specifiers[""prefix""] != undefined) 
                            {this.varFormat.prefix = specifiers[""prefix""]; }
                        if (specifiers[""force""] != undefined)
                            {this.force = specifiers[""force""];}
                        else
                            {this.force = false;}
                    }
                    format(value){
                        this.prevValue = this.currentValue;
                        this.currentValue = value;
                        if (!this.enabled)
                            {return """";}
                        if (this.varFormat.areDifferent(this.prevValue, this.currentValue))
                            {return this.varFormat.format(value);}
                        return """";
                    }
                    disable(){this.enabled = false;}
                    enable(){this.enabled = true;}
                    isEnabled(){return this.enabled;}
                    setPrefix(prefixText){this.varFormat.prefix = prefixText;}
                }
            return new createReferenceVariableClass(specifiers, format);
            }");

        }
    }
}