using System;
using Jurassic;
using System.Globalization;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
        /// <value>Property <c>Description</c> represents the short description of post processor.</value>
        public string Description {get; set;} = "";

        /// <value>Property <c>Vendor</c> represents the name of the machine tool manufacturer.</value>
        public string Vendor {get; set;} = "";

        /// <value>Property <c>VendorUrl</c> represents the URL of the machine tool manufacturer's web site.</value>
        public string VendorUrl {get; set;} = "";

        /// <value>Property <c>Legal</c> represents the legal notice of company that authored the post processor.</value>
        public string Legal {get; set;} = "";

        /// <value>Property <c>CertificationLevel</c> represents the certification level of the post configuration
        /// used to determine if the post processor is certified to run against the post engine.</value>
        public int CertificationLevel {get; set;} 

        /// <value>Property <c>MinimumRevision</c> represents the minimum revision of the Fusion 360 post kernel
        /// that is supported by the post processor.</value>
        public int MinimumRevision {get; set;} 

        /// <value>Property <c>LongDescription</c> represents the long description of post processor.</value>
		public string LongDescription{get; set;} = "";

        /// <value>Property <c>Extension</c> represents the output NC file extension.</value>
		public string Extension{get; set;} = "";

        /// <value>Property <c>CodePage</c> represents the code page used for the NC file.</value>
		public string CodePage{get; set;} = "ascii";

        /// <value>Property <c>Capabilities</c> defines the capabilities of the post processor.</value>
		public int Capabilities{get; set;} 

        /// <value>Property <c>Tolerance</c> specifies the tolerance used to linearize circular moves
        /// that are expanded into a series of linear moves. </value>
        public double Tolerance {get; set;} = 0.001;

		/// <value>Property <c>MinimumChordLength</c> specifies the minimum delta movement allowed for circular interpolation.</value>
		public double MinimumChordLength {get; set;}

		/// <value>Property <c>MinimumCircularRadius</c> specifies the minimum radius of circular moves 
        /// that can be output as circular interpolation.</value>
		public double MinimumCircularRadius {get; set;}

		/// <value>Property <c>MaximumCircularRadius</c> specifies the maximum radius of circular moves
        /// that can be output as circular interpolation.</value>
		public double MaximumCircularRadius {get; set;}

		/// <value>Property <c>MinimumCircularSweep</c> specifies the minimum circular sweep of circular moves
        /// that can be output as circular interpolation.</value>
		public double MinimumCircularSweep {get; set;}

		/// <value>Property <c>MaximumCircularSweep</c> specifies the maximum circular sweep of circular moves
        /// that can be output as circular interpolation.</value>
		public double MaximumCircularSweep {get; set;}

        /// <value>Property <c>AllowedCircularPlanes</c> defines the standard planes that circular interpolation is allowed in.</value>
        public AllowedCircularPlanesEnum AllowedCircularPlanes {get; set;} = AllowedCircularPlanesEnum.DisableCircularInterpolation ;

        /// <value>Property <c>AllowHelicalMoves</c> allowes a helical interpolation. Helical moves are linearized if set to false.</value>
        public bool AllowHelicalMoves {get; set;}

        /// <value>Property <c>AllowSpiralMoves</c> allowes a spiral interpolation.
        /// Spiral interpolation is defined as circular moves that have a different
        /// starting radius than ending radius and can be enabled by setting this
        /// property to true. Spiral moves are linearized if set to false.</value>
        public bool AllowSpiralMoves {get; set;}

        /// <value>Property <c>Unit</c> contains the output units of the post processor.</value>
        public double Unit {get; set;} = 1.0;

        /// <summary> JavaScript engine. </summary>
        public static Jurassic.ScriptEngine engine = new Jurassic.ScriptEngine();

        /// <value>Property <c>UserDefinedProperties</c> specifies the user defined properties.</value>
        public Jurassic.Library.ObjectInstance UserDefinedProperties {get; set;} = engine.Object.Construct();

        
        /// <summary> Initializes a new instance of the <c>Fu360PostProcessor</c> class.</summary>
        /// <param name="postFile">The path to the post processor file.</param>
        public Fu360PostProcessor(string postFile)
        {
            SetJsVariables();

            SetJsFunction();

            engine.ExecuteFile(postFile);

            SetProperties();

            #if DEBUG
                WritelnProperties();
			#endif
        }

        /// <summary> Initializes a new instance of the <c>Fu360PostProcessor</c> class.</summary>
        /// <param name="postCode"> The string with a code of the post processor file.</param>
        /// <param name="displayProperties"> If true - outputs to console properties.</param>
        public Fu360PostProcessor (string postCode, bool displayProperties)
        {
            SetJsVariables();

            SetJsFunction();

            engine.Execute(postCode);

            SetProperties();

            if (displayProperties) 
                WritelnProperties();

        }

        public void SetJsVariables()
        {
            engine.SetGlobalValue("properties", UserDefinedProperties);
            engine.SetGlobalValue("description", "");
            engine.SetGlobalValue("vendor", "");
            engine.SetGlobalValue("vendorUrl", "");
            engine.SetGlobalValue("legal", "");
            engine.SetGlobalValue("certificationLevel", 0);
            engine.SetGlobalValue("minimumRevision", 0);
            engine.SetGlobalValue("longDescription", "");
			engine.SetGlobalValue("extension", "");
            engine.SetGlobalValue("capabilities", "");
			engine.SetGlobalValue("CAPABILITY_MILLING", (int)CapabilitiesEnum.CapabilityMilling);
			engine.SetGlobalValue("CAPABILITY_TURNING", (int)CapabilitiesEnum.CapabilityTurning);
			engine.SetGlobalValue("CAPABILITY_JET", (int)CapabilitiesEnum.CapabilityJet);
			engine.SetGlobalValue("CAPABILITY_SETUP_SHEET", (int)CapabilitiesEnum.CapabilitySetupSheet);
			engine.SetGlobalValue("CAPABILITY_INTERMEDIATE", (int)CapabilitiesEnum.CapabilityIntermediate);
            engine.SetGlobalValue("MM", 1.0);
            engine.SetGlobalValue("IN", 25.4);
            engine.SetGlobalValue("DEG",(180/Math.PI));
            engine.SetGlobalValue("tolerance", Tolerance);
			engine.SetGlobalValue("minimumChordLength", MinimumChordLength);
			engine.SetGlobalValue("minimumCircularRadius", MinimumCircularRadius);
			engine.SetGlobalValue("maximumCircularRadius", MaximumCircularRadius);
			engine.SetGlobalValue("minimumCircularSweep", MinimumCircularSweep);
			engine.SetGlobalValue("maximumCircularSweep", MaximumCircularSweep);
            engine.SetGlobalValue("allowedCircularPlanes", (int)AllowedCircularPlanes);
            engine.SetGlobalValue("allowHelicalMoves", AllowHelicalMoves);
            engine.SetGlobalValue("allowSpiralMoves", AllowSpiralMoves);
            engine.SetGlobalValue("unit",Unit);			
            engine.SetGlobalValue("COOLANT_FLOOD", 1);
            engine.SetGlobalValue("COOLANT_MIST", 2);
            engine.SetGlobalValue("COOLANT_THROUGH_TOOL", 3);
            engine.SetGlobalValue("COOLANT_AIR", 4);
            engine.SetGlobalValue("COOLANT_AIR_THROUGH_TOOL", 5);
            engine.SetGlobalValue("COOLANT_SUCTION", 6);
            engine.SetGlobalValue("COOLANT_FLOOD_MIST", 7);
            engine.SetGlobalValue("COOLANT_FLOOD_THROUGH_TOOL", 8);			
            engine.SetGlobalValue("COOLANT_OFF", 0);
        }

        public void SetJsFunction()
        {
            engine.SetGlobalFunction("setCodePage", new Action<string>((a) => this.CodePage = a));
            engine.SetGlobalFunction("spatial", new Func<double, double, double>((a, b) => a * b));
            engine.SetGlobalFunction("toRad", new Func<double, double>((a) => (Math.PI / 180) * a));
            engine.SetGlobalFunction("toPreciseUnit", new Func<double, double, double>((a, b) => a * b));
            engine.SetGlobalFunction("round", new Func<double, int, double>((a,b) => (Math.Round(a, b, MidpointRounding.AwayFromZero))));
            engine.Evaluate(@"function getProperty(name) {
                return properties[name].value;
            }");
           SetVector();      
           SetCreateFormat();
           SetCreateVariable();
           SetCreateModal();
           SetCreateModalGroup();
           SetCreateReferenceVariable();
           SetCreateIncrementalVariable();
           SetForceOutput();
           SetWriteFunction();
           
        }

        public void SetProperties()
        {
            engine.Evaluate(@"function getAllowedCircularPlanes() {
                if (typeof allowedCircularPlanes == 'undefined')
                    {allowedCircularPlanes = 7;}
                 return  allowedCircularPlanes}");

            UserDefinedProperties = engine.GetGlobalValue<Jurassic.Library.ObjectInstance>("properties");
            AllowedCircularPlanes = (AllowedCircularPlanesEnum)engine.CallGlobalFunction<int>("getAllowedCircularPlanes");
			Vendor = engine.GetGlobalValue<string>("vendor");
			VendorUrl = engine.GetGlobalValue<string>("vendorUrl");
			Legal = engine.GetGlobalValue<string>("legal");
			CertificationLevel = engine.GetGlobalValue<int>("certificationLevel");
			MinimumRevision = engine.GetGlobalValue<int>("minimumRevision");
			LongDescription = engine.GetGlobalValue<string>("longDescription");
			Extension = engine.GetGlobalValue<string>("extension");
            Description = engine.GetGlobalValue<string>("description");
            Capabilities = engine.GetGlobalValue<int>("capabilities");
            Tolerance = engine.GetGlobalValue<double>("tolerance");
			MinimumChordLength = engine.GetGlobalValue<double>("minimumChordLength");
			MinimumCircularRadius = engine.GetGlobalValue<double>("minimumCircularRadius");
			MaximumCircularRadius = engine.GetGlobalValue<double>("maximumCircularRadius");
			MinimumCircularSweep = engine.GetGlobalValue<double>("minimumCircularSweep");
			MaximumCircularSweep = engine.GetGlobalValue<double>("maximumCircularSweep");
            AllowHelicalMoves = engine.GetGlobalValue<bool>("allowHelicalMoves");
            AllowSpiralMoves = engine.GetGlobalValue<bool>("allowSpiralMoves");
        }

        
        public void WritelnProperties()
        {
            Console.WriteLine("Vendor = " + Vendor);
			Console.WriteLine("VendorUrl = " + VendorUrl);
			Console.WriteLine("Legal = " + Legal);
			Console.WriteLine("CertificationLevel = " + CertificationLevel.ToString());
			Console.WriteLine("MinimumRevision = " + MinimumRevision.ToString());
			Console.WriteLine("LongDescription = " + LongDescription);
			Console.WriteLine("Extension = " + Extension);
            Console.WriteLine("Description = " + Description);
            Console.WriteLine("CodePage = " + CodePage);
            Console.WriteLine("Capabilities = " + Capabilities.ToString());
            Console.WriteLine("Tolerance = " + Tolerance.ToString("F4", CultureInfo.InvariantCulture));
			Console.WriteLine("MinimumChordLength = " + MinimumChordLength.ToString());
			Console.WriteLine("MinimumCircularRadius = " + MinimumCircularRadius.ToString());
			Console.WriteLine("MaximumCircularRadius = " + MaximumCircularRadius.ToString());
			Console.WriteLine("MinimumCircularSweep = " + MinimumCircularSweep.ToString());
			Console.WriteLine("MaximumCircularSweep = " + MaximumCircularSweep.ToString());
            Console.WriteLine("AllowedCircularPlanes = " + AllowedCircularPlanes.ToString());
            Console.WriteLine("AllowHelicalMoves = " + AllowHelicalMoves.ToString());
            Console.WriteLine("AllowSpiralMoves = " + AllowSpiralMoves.ToString()); 

        }
    }
}