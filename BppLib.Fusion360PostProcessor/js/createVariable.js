function createVariable(specifiers, format) {
                class createVariableClass{
                    constructor(specifiers, format){
                        this.currentValue = undefined;
                        this.prevValue = undefined;
                        this.enabled = true;
                        this.varFormat = format;
                        if (specifiers["prefix"] != undefined) 
                            {this.varFormat.prefix = specifiers["prefix"]; }
                        if (specifiers["force"] != undefined)
                            {this.force = specifiers["force"];}
                        else
                            {this.force = false;}
                        if (specifiers["onchange"]!= undefined)
                            {this.onchange = function(){specifiers["onchange"]();}}
                        else
                            {this.onchange = undefined;}
                    }
                    format(value){
                        if (this.onchange != undefined)
                            {this.onchange();}
                        this.prevValue = this.currentValue;
                        this.currentValue = value;
                        if (!this.enabled)
                            {return "";}
                        if (this.force)
                            {return this.varFormat.format(value);}
                        else if (this.prevValue != this.currentValue)
                            {return this.varFormat.format(value);}
                        return "";
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
            }