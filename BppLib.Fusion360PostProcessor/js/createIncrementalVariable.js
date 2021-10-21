function createIncrementalVariable(specifiers, format) {
                class createIncrementalVariableClass{
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
                        if (specifiers["first"] != undefined)
                            {this.currentValue = specifiers["first"];}
                    }
                    format(value){
                        this.prevValue = this.currentValue;
                        this.currentValue = value;
                        if (!this.enabled)
                            {return "";}
                        if (this.force)
                            {return this.varFormat.format(this.currentValue - this.prevValue);}
                        else if ((this.prevValue - this.currentValue) != 0)
                            {return this.varFormat.format(this.currentValue - this.prevValue);}
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
            return new createIncrementalVariableClass(specifiers, format);
            }