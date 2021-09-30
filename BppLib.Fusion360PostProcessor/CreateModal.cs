using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
       
        public void SetCreateModal()
        {
            engine.Evaluate(@"function createModal(specifiers, format) {
                class createModalClass{
                    constructor(specifiers, format){
                        this.currentValue = undefined;
                        this.prevValue = undefined;
                        this.varFormat = format;
                        if (specifiers[""prefix""] != undefined) 
                            {this.varFormat.prefix = specifiers[""prefix""]; }
                        if (specifiers[""suffix""] != undefined) 
                            {this.varFormat.suffix = specifiers[""suffix""]; }
                        if (specifiers[""force""] != undefined)
                            {this.force = specifiers[""force""];}
                        else
                            {this.force = false;}
                        if (specifiers[""onchange""]!= undefined)
                            {this.onchange = function(){specifiers[""onchange""]();}}
                        else
                            {this.onchange = undefined;}
                    }
                    format(value){
                        if (this.onchange != undefined)
                            {this.onchange();}
                        this.prevValue = this.currentValue;
                        this.currentValue = value;
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
                    getCurrent(){return this.currentValue;} 
                    setPrefix(prefixText){this.varFormat.prefix = prefixText;}
                    setSuffix(suffixText){this.varFormat.suffix = suffixText;}
                }
            return new createModalClass(specifiers, format);
            }");

        }
    }
}