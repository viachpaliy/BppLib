using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;

namespace BppLib.Core
{
    /// <summary>Class <c>BiesseProgram</c> models the Biesse CNC programme.</summary>
    public class BiesseProgram : IBppCode
    {
        /// <value>Property <c>Header</c> represents the header section of Biesse CNC programme.</value>
        public HeaderSection Header { get; set; } = new HeaderSection();

        /// <value>Property <c>Description</c> represents the description section of Biesse CNC programme.</value>
        public DescriptionSection Description { get; set; } = new DescriptionSection();

        /// <value>Property <c>MainData</c> represents the main data section of Biesse CNC programme.</value>
        public MainDataSection MainData { get; set; } = new MainDataSection();

        /// <value>Property <c>PublicVars</c> represents the public variables section of Biesse CNC programme.</value>
        public PublicVarsSection PublicVars { get; set; } = new PublicVarsSection();

        /// <value>Property <c>PrivateVars</c> represents the private variables section of Biesse CNC programme.</value>
        public PrivateVarsSection PrivateVars { get; set; } = new PrivateVarsSection();

        /// <value>Property <c>ProgramSec</c> represents the program section of Biesse CNC programme.</value>
        public ProgramSection ProgramSec { get; set; } = new ProgramSection();

        /// <value>Property <c>VBScriptSec</c> represents the VBScript section of Biesse CNC programme.</value>
        public VBScriptSection VBScriptSec { get; set; } = new VBScriptSection();

        /// <value>Property <c>MacroData</c> represents the Macro Data section of Biesse CNC programme.</value>
        public MacroDataSection MacroData { get; set; } = new MacroDataSection();

        /// <value>Property <c>TDCodes</c> represents the TDCode section of Biesse CNC programme.</value>
        public TDCodesSection TDCodes { get; set; } = new TDCodesSection();

        /// <value>Property <c>PcfSec</c> represents the PCF section of Biesse CNC programme.</value>
        public PCFSection PcfSec { get; set; } = new PCFSection();

        /// <value>Property <c>ToolingSec</c> represents the tooling section of Biesse CNC programme.</value>
        public ToolingSection ToolingSec { get; set; } = new ToolingSection();

        /// <value>Property <c>SubProgsSec</c> represents the sub programmes section of Biesse CNC programme.</value>
        public SubProgsSection SubProgsSec { get; set; } = new SubProgsSection();

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Header.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(Description.AsBppCode());
            sb.AppendLine("");
            sb.Append(MainData.AsBppCode());
            sb.Append(PublicVars.AsBppCode());
            sb.AppendLine(PrivateVars.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(ProgramSec.AsBppCode());
            sb.AppendLine("\r\n");
            sb.AppendLine(VBScriptSec.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(MacroData.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(TDCodes.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(PcfSec.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(ToolingSec.AsBppCode());
            sb.AppendLine("");
            sb.AppendLine(SubProgsSec.AsBppCode());
            sb.AppendLine("");
            return sb.ToString();
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Header.AsCixCode());
            sb.AppendLine("");
            sb.Append(MainData.AsCixCode());
            sb.Append(PublicVars.AsCixCode());
            sb.Append(PrivateVars.AsCixCode());
            sb.AppendLine("");
            sb.AppendLine(ProgramSec.AsCixCode());
            sb.AppendLine("");
            sb.AppendLine(VBScriptSec.AsCixCode());
            sb.AppendLine("");
            return sb.ToString();
        }
    }
}