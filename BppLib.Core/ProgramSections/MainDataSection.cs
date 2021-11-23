using System;
using System.Text;
using System.Globalization;

namespace BppLib.Core
{
    /// <summary>Class <c>MainDataSection</c> models the main data section of Biesse CNC programme.</summary>
    public class MainDataSection : IBppCode
    {
        /// <value>Property <c>Lpx</c> represents the piece width (X dimension of the piece).</value>
        public double Lpx { get; set; } = 800 ;

        /// <value>Property <c>Lpy</c> represents the piece height (Y dimension of the piece).</value>
        public double Lpy { get; set; } = 500 ;

        /// <value>Property <c>Lpz</c> represents the thickness of the piece.</value>
        public double Lpz { get; set; } = 30 ;

        /// <value>Property <c>OrLst</c> represents the origins list.</value>
        public string OrLst { get; set; } = "1" ;

        /// <value>Property <c>Simmetry</c> enables/disables program symmetry.</value>
        public bool Simmetry { get; set; } = true ; 

        /// <value>Property <c>TlChk</c> models the "TLCHK" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is 0.</value>
        public int TlChk { get; set; } = 0 ;

        /// <value>Property <c>Tooling</c> represents the number of the machine data configuration
        /// saved in the appropriate numerical control environment, to be used to work the piece.</value>
        public string Tooling { get; set; } = "";

        /// <value>Property <c>CustStr</c> represents the data fields in window Customised panel parameters.</value>
        public string CustStr { get; set; } = "";

        /// <value>Property <c>Fcn</c> represents the dimension multiplier.</value> 
        public double Fcn { get; set; } = 1 ; 

        /// <value>Property <c>XCut</c> represents the position in X beyond which the system interrupts the machining,
        /// automatically inserting a suspension with translation in X to allow the piece to be translated onto the mirror origin.</value> 
        public double XCut { get; set; } = 0 ;

        /// <value>Property <c>YCut</c> represents the position in Y beyond which the system interrupts the machining,
        /// automatically inserting a suspension with translation in Y to allow the piece to be translated onto the mirror origin.</value> 
        public double YCut { get; set; } = 0 ;

        /// <value>Property <c>JigTh</c> represents the jig thickness.</value>
        public double JigTh { get; set; } = 0 ;

        /// <value>Property <c>Ckop</c> enables the use of the keyboard on the machine in order to move the origin.</value>
        public int Ckop { get; set; } = 0 ;

        /// <value>Property <c>Unique</c> enables use of a single origin in the working area.</value>
        public bool Unique { get; set; } = false ;

        /// <value>Property <c>Material</c> represents the image to identify the piece during simulation of the
        /// machining operation and tooling of the work table with the WorkTableTooling application.</value>
        public string Material { get; set; } = "wood" ;

        /// <value>Property <c>PutLst</c> models the "TLCHK" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is "".</value>
	    public string PutLst { get; set; } = "";
        
        /// <value>Property <c>Oppwkrs</c> represents the specific data field for the “Skipper” machine.
        /// Used when working two overlapping pieces with both operating sections.</value>
    	public int Oppwkrs { get; set; } = 0 ;

        /// <value>Property <c>UniClamp</c> enables the use of Uniclamps(to use the shapeable suction cups, disable).</value>
        public bool	UniClamp { get; set; } = false ;

        /// <value>Property <c>ChkColl</c>  activates the positioning control of the moving parts of the work table
        /// (shapeable suction cups and mobile supports) in order to prevent interference with the objects on
        /// the work table or the tools.</value> 
        public bool ChkColl { get; set; } = false ;

        /// <value>Property <c>WtPiani</c> used to choose the type of independent locking zone configuration.</value>
        public int WtPiani { get; set; } = 0 ;
	
        /// <value>Property <c>CollTool</c> ; used to determine the type of check on the tool dimensions, to avoid collisions.</value> 
        public int CollTool { get; set; } = 0 ;
	
        /// <value>Property <c>CalcEdTh</c> models the "CALCEDTH" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is 0.</value>
        public int CalcEdTh { get; set; } = 0 ;

        /// <value>Property <c>EnableLabel</c> is only visible for machines equipped with a label printer and/or a
        /// labelling machine. Used to generate - in the ISO file - the instruction for applying the labels.</value>  
        public bool EnableLabel { get; set; } = false ;
	
        /// <value>Property <c>LockWaste</c> enables the locking - via the special devices (shapeable suction cups, etc.) - of
        /// all those piece areas considered as waste.</value> 
        public bool LockWaste { get; set; } = false ;
	
        /// <value>Property <c>LoadEdgeOpt</c> models the "LOADEDGEOPT" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is 0.</value>
        public int LoadEdgeOpt { get; set; } = 0 ;
	
        /// <value>Property <c>ItlType</c> represents the type of optimisation of the machinings of the sub-programs
        /// inserted in the active document.</value>
        public int ItlType { get; set; } = 0 ;
	
        /// <value>Property <c>RunPav</c> used to enable the optimisation of the suction cups so that, during the
        /// program execution phase, the objects are positioned semi-automatically on the work table.</value>
        public bool RunPav { get; set; } = false ;
	
        /// <value>Property <c>FlipEnd</c> models the "FLIPEND" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is 0.</value>
        public int FlipEnd { get; set; } = 0 ;
	
        /// <value>Property <c>EnableMachLinks</c> models the "ENABLEMACHLINKS" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is false(0).</value>
        public bool EnableMachLinks { get; set; } = false ;
	
        /// <value>Property <c>EnablePursuits</c> models the "ENABLEPURSUITS" variable of the "MAINDATA" section of the ".cix" program.
		/// The exact meaning of the variable is unknown. Default value is false(0).</value>
        public bool EnablePursuits { get; set; } = false ;

        /// <value>Property <c>EnableFastVertBorings</c> used to enable vertical borings anticipation.</value>
        public bool EnableFastVertBorings { get; set; } = false ;
	
        /// <value>Property <c>FastVertBoringsValue</c> represents the vertical borings anticipation value.</value>
        public int FastVertBoringsValue { get; set; } = 0 ;
	

        /// <summary>This method serializes an object as Bpp code.</summary>
		/// <returns>A string  is coded as Bpp code.</returns>
		public string AsBppCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[VARIABLES]");
            sb.AppendLine("PAN=LPX|" + Lpx.ToString(CultureInfo.InvariantCulture) + "||4|");
            sb.AppendLine("PAN=LPY|" + Lpy.ToString(CultureInfo.InvariantCulture) + "||4|");
            sb.AppendLine("PAN=LPZ|" + Lpz.ToString(CultureInfo.InvariantCulture) + "||4|");
            sb.AppendLine("PAN=ORLST|\"" + OrLst + "\"||3|");
            sb.AppendLine("PAN=SIMMETRY|" + ConvBoolToInt(Simmetry) + "||1|");
            sb.AppendLine("PAN=TLCHK|" + TlChk.ToString() + "||1|");
            sb.AppendLine("PAN=TOOLING|\"" + Tooling + "\"||3|");
            sb.AppendLine("PAN=CUSTSTR|$B$KBsExportToNcRvA.XncExtraPanelData$V\"" + CustStr +"\"||3|");
            sb.AppendLine("PAN=FCN|" + Fcn.ToString("F6", CultureInfo.InvariantCulture) + "||2|");
            sb.AppendLine("PAN=XCUT|" + XCut.ToString(CultureInfo.InvariantCulture) + "||4|");
            sb.AppendLine("PAN=YCUT|" + YCut.ToString(CultureInfo.InvariantCulture) + "||4|");
            sb.AppendLine("PAN=JIGTH|" + JigTh.ToString(CultureInfo.InvariantCulture) + "||4|");
            sb.AppendLine("PAN=CKOP|" + Ckop.ToString() + "||1|");
            sb.AppendLine("PAN=UNIQUE|" + ConvBoolToInt(Unique) + "||1|");
            sb.AppendLine("PAN=MATERIAL|\"" + Material + "\"||3|");
            sb.AppendLine("PAN=PUTLST|\"" + PutLst + "\"||3|");
            sb.AppendLine("PAN=OPPWKRS|" + Oppwkrs.ToString() + "||1|");
            sb.AppendLine("PAN=UNICLAMP|" + ConvBoolToInt(UniClamp) + "||1|");
            sb.AppendLine("PAN=CHKCOLL|" + ConvBoolToInt(ChkColl) + "||1|");
            sb.AppendLine("PAN=WTPIANI|" + WtPiani.ToString() + "||1|");
            sb.AppendLine("PAN=COLLTOOL|" + CollTool.ToString() + "||1|");
            sb.AppendLine("PAN=CALCEDTH|" + CalcEdTh.ToString() + "||1|");
            sb.AppendLine("PAN=ENABLELABEL|" + ConvBoolToInt(EnableLabel) + "||1|");
            sb.AppendLine("PAN=LOCKWASTE|" + ConvBoolToInt(LockWaste) + "||1|");
            sb.AppendLine("PAN=LOADEDGEOPT|" + LoadEdgeOpt.ToString() + "||1|");
            sb.AppendLine("PAN=ITLTYPE|" + ItlType.ToString() + "||1|");
            sb.AppendLine("PAN=RUNPAV|" + ConvBoolToInt(RunPav) + "||1|");
            sb.AppendLine("PAN=FLIPEND|" + FlipEnd.ToString() + "||1|");
            sb.AppendLine("PAN=ENABLEMACHLINKS|" + ConvBoolToInt(EnableMachLinks) + "||1|");
            sb.AppendLine("PAN=ENABLEPURSUITS|" + ConvBoolToInt(EnablePursuits) + "||1|");
            sb.AppendLine("PAN=ENABLEFASTVERTBORINGS|" + ConvBoolToInt(EnableFastVertBorings) + "||1|");
            sb.Append("PAN=FASTVERTBORINGSVALUE|" + FastVertBoringsValue.ToString() + "||4|");
            return sb.ToString();
        }

        /// <summary>This method serializes an object as Cix code.</summary>
		/// <returns>A string  is coded as Cix code.</returns>
		public string AsCixCode()
		{
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BEGIN MAINDATA");
            sb.AppendLine("\tLPX=" + Lpx.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tLPY=" + Lpy.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tLPZ=" + Lpz.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tORLST=\"" +  OrLst + "\"");
	        sb.AppendLine("\tSIMMETRY=" + ConvBoolToInt(Simmetry));
	        sb.AppendLine("\tTLCHK=" + TlChk.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tTOOLING=\"" + Tooling + "\"");
	        sb.AppendLine("\tCUSTSTR=$B$KBsExportToNcRvA.XncExtraPanelData$V\"" + CustStr + "\"");
	        sb.AppendLine("\tFCN=" + Fcn.ToString("F6", CultureInfo.InvariantCulture));
	        sb.AppendLine("\tXCUT=" + XCut.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tYCUT=" + YCut.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tJIGTH=" + JigTh.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tCKOP=" + Ckop.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tUNIQUE=" + ConvBoolToInt(Unique));
	        sb.AppendLine("\tMATERIAL=\"" + Material + "\"");
	        sb.AppendLine("\tPUTLST=\"" + PutLst + "\""); 
	        sb.AppendLine("\tOPPWKRS=" + Oppwkrs.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tUNICLAMP=" + ConvBoolToInt(UniClamp));
	        sb.AppendLine("\tCHKCOLL=" + ConvBoolToInt(ChkColl));
	        sb.AppendLine("\tWTPIANI=" + WtPiani.ToString(CultureInfo.InvariantCulture)); 
	        sb.AppendLine("\tCOLLTOOL=" + CollTool.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tCALCEDTH=" + CalcEdTh.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tENABLELABEL=" + ConvBoolToInt(EnableLabel));
	        sb.AppendLine("\tLOCKWASTE=" + ConvBoolToInt(LockWaste));
	        sb.AppendLine("\tLOADEDGEOPT=" + LoadEdgeOpt.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tITLTYPE=" + ItlType.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tRUNPAV=" + ConvBoolToInt(RunPav));
	        sb.AppendLine("\tFLIPEND=" + FlipEnd.ToString(CultureInfo.InvariantCulture));
	        sb.AppendLine("\tENABLEMACHLINKS=" + ConvBoolToInt(EnableMachLinks));
	        sb.AppendLine("\tENABLEPURSUITS=" + ConvBoolToInt(EnablePursuits));
	        sb.AppendLine("\tENABLEFASTVERTBORINGS=" + ConvBoolToInt(EnableFastVertBorings));
	        sb.AppendLine("\tFASTVERTBORINGSVALUE=" + FastVertBoringsValue.ToString(CultureInfo.InvariantCulture));
            sb.Append("END MAINDATA");
            return sb.ToString();
        }

        string ConvBoolToInt(bool value)
        {
            if (value)
                {return "1";}
            return "0";
        }

    } 
}