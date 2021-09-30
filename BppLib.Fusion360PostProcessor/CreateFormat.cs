using System;
using Jurassic;
using System.Globalization;
using System.Text;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
       
        public void SetCreateFormat()
        {
            engine.Evaluate(@"function createFormat(specifiers) {
            return {
            prefix : (specifiers[""prefix""] != undefined ? specifiers[""prefix""] : """"),
            suffix : (specifiers[""suffix""] != undefined ? specifiers[""suffix""] : """"),
            decimals : (specifiers[""decimals""] != undefined ? specifiers[""decimals""] : 6),
            forceDecimal : (specifiers[""forceDecimal""] != undefined ? specifiers[""forceDecimal""] : false),
            forceSign : (specifiers[""forceSign""] != undefined ? specifiers[""forceSign""] : false),
            width : (specifiers[""width""] != undefined ? specifiers[""width""] : 0),
            zeropad : (specifiers[""zeropad""] != undefined ? specifiers[""zeropad""] : false),
            trim : (specifiers[""trim""] != undefined ? specifiers[""trim""] : true),
            trimLeadZero : (specifiers[""trimLeadZero""] != undefined ? specifiers[""trimLeadZero""] : false),
            scale : (specifiers[""scale""] != undefined ? specifiers[""scale""] : 1.0),
            offset : (specifiers[""offset""] != undefined ? specifiers[""offset""] : 0.0),
            separator : (specifiers[""separator""] != undefined ? specifiers[""separator""] : "".""),

            format : function(value) {
                sb = this.prefix;
                val = (value + this.offset) * this.scale;
                if ((this.forceSign) && (val > 0)) sb = sb + ""+"";
                strVal = val.toFixed(this.decimals);
                parts = strVal.split('.');
                intPart = parts[0]; 
                fractPart = """"; 
                if (parts.length > 1) fractPart = parts[1];
                if (this.trimLeadZero)
                {
                    while(intPart.startsWith('0'))
                    {
                        if (intPart.length > 1)
                            { intPart = intPart.substring(1);}
                        else
                            { intPart = """";}
                        if (intPart == """") break;
                    }
                }
                if (this.trim)
                {
                    while(fractPart.endsWith('0'))
                    {
                        if (fractPart.length > 1)
                            { fractPart = fractPart.substring(0,fractPart.length - 1);}
                        else
                            { fractPart = """";}
                        if (fractPart == """") break;
                    }
                }
                if (this.zeropad)
			    {	
				while(intPart.length < (this.width - fractPart.length))
				{
					intPart = ""0"" + intPart;
				}
			    }
                sb = sb + intPart;
                if (this.forceDecimal) {sb = sb + this.separator;}
                else if (fractPart !="""")
                    {sb = sb + this.separator;}
                sb = sb + fractPart;
                sb = sb + this.suffix;
                return sb;
                },

            areDifferent : function(a, b) {return (round(a, this.decimals) != round(b, this.decimals));},

            getMinimumValue : function() {return Math.pow(10, -this.decimals);},

            getError : function(value) {return  (value - round(value, this.decimals));},

            getResultingValue : function(value) {return  round(value, this.decimals);},

            isSignificant : function(value) {return (round(value, this.decimals) > 0);}
            
            };
      
            } ");

                     
        }


    }
}