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
                        this.currentValue = undefined;
                        this.prevValue = undefined;
                        this.enabled = true;
                        this.force = false;
                        this.varFormat = format;
                        if (specifiers[""prefix""] != undefined) 
                            {this.varFormat.prefix = specifiers[""prefix""]; }
                    }
                    format(value){
                        this.prevValue = this.currentValue;
                        this.currentValue = value;
                        if (!this.enabled)
                            {return """";}
                        if (this.force)
                            {return this.varFormat.format(value);}
                        else if (this.prevValue != this.currentValue)
                            {return this.varFormat.format(value);}
                        return """";
                    }
                    reset(){
                        this.currentValue = undefined;
                        this.prevValue = undefined;
                    }
                    disable(){this.enabled = false;}
                    enable(){this.enabled = true;}
                    isEnabled(){return this.enabled;}
                    getCurrent(){return this.currentValue;} 
                    setPrefix(prefixText){this.varFormat.prefix = prefixText;}
                }
            return new createVariableClass(specifiers, format);
            }");

        }
    }
}