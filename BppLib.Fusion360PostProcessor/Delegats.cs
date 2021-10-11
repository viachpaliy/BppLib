using System;
using Jurassic;
using System.Globalization;

namespace Fusion360PostProcessor
{
    /// <summary> Class <c>Fu360PostProcessor</c> models post processor for the Fusion 360.</summary>
    public partial class Fu360PostProcessor
    {
		public delegate void onCircular(bool clockwise, double cx, double cy, double cz, double x, double y, double z, int feed); // Circular move
		public delegate void onClose(); // End of post processing
		public delegate void onCommand(ManualCommand value); // Manual NC command not handled in its own function
		public delegate void onComment(string message); // Comment Manual NC command
		public delegate void onCycle(); // Start of a cycle
		public delegate void onCycleEnd(); // End of a cycle
		public delegate void onCyclePoint(double x, double y, double z); // Each cycle point
		public delegate void onDwell(double seconds); // Dwell Manual NC command
		public delegate void onLinear(double x, double y, double z, int feed); // 3-axis cutting move
		public delegate void onLinear5D(double x, double y, double z, double a, double b, double c, int feed); // 5-axis cutting move
		public delegate void onMachine(); // Machine configuration changes
		public delegate void onManualNC(); // Manual NC commands
		public delegate void onMovement(MovementType movement); // Movement type changes
		public delegate void onOpen(); // Post processor initialization
		public delegate void onOrientateSpindle(double angle); // Spindle orientation is requested
		public delegate void onParameter(string name,string value); // Each parameter setting
		public delegate void onPassThrough(string text); // Pass through Manual NC command
		public delegate void onPower(bool value); // Power mode for water/plasma/laser changes
		public delegate void onRadiusCompensation(); // Radius compensation mode changes
		public delegate void onRapid(double x, double y, double z); // 3-axis Rapid move
		public delegate void onRapid5D(double x, double y, double z, double a, double b, double c); // 5-axis Rapid move
		public delegate void onRewindMachine(double a, double b, double c); // Rotary axes limits are exceeded
		public delegate void onSection(); // Start of an operation
		public delegate void onSectionEnd(); // End of an operation
		public delegate void onSectionEndSpecialCycle(); // End of a special cycle operation
		public delegate void onSectionSpecialCycle(); // Start of a special cycle operation (Stock Transfer)
        public delegate void onSpindleSpeed(int speed); // Spindle speed changes
		public delegate void onTerminate(); // Post processing has completed, output files are closed
        public delegate void onToolCompensation(int value); // Tool compensation mode changes

		///<summary> Circular move </summary>
		public onCircular Circular = delegate{};
		///<summary> End of post processing </summary>
		public onClose Close = delegate{};
		///<summary> Manual NC command not handled in its own function </summary>
		public onCommand Command = delegate{};
		///<summary> Comment Manual NC command </summary>
		public onComment Comment = delegate{};
		///<summary> Start of a cycle </summary>
		public onCycle Cycle = delegate{};
		///<summary> End of a cycle </summary>
		public onCycleEnd CycleEnd = delegate{};
		///<summary> Each cycle point </summary>
		public onCyclePoint CyclePoint = delegate{};
		///<summary> Dwell Manual NC command </summary>
		public onDwell Dwell = delegate{};
		///<summary> 3-axis cutting move </summary>
		public onLinear Linear = delegate{};
		///<summary> 5-axis cutting move </summary>
		public onLinear5D Linear5D = delegate{};
		///<summary> Machine configuration changes </summary>
		public onMachine Machine = delegate{};
		///<summary> Manual NC commands </summary>
		public onManualNC ManualNC = delegate{};
		///<summary> Movement type changes </summary>
		public onMovement Movement = delegate{};
		///<summary> Post processor initialization </summary>
		public onOpen Open = delegate{};
		///<summary> Spindle orientation is requested </summary>
		public onOrientateSpindle OrientateSpindle = delegate{};
		///<summary> Each parameter setting </summary>
		public onParameter Parameter = delegate{};
		///<summary> Pass through Manual NC command </summary>
		public onPassThrough PassThrough = delegate{};
		///<summary> Power mode for water/plasma/laser changes </summary>
		public onPower Power = delegate{};
		///<summary> Radius compensation mode changes </summary>
		public onRadiusCompensation RadiusCompensation = delegate{};
		///<summary> 3-axis Rapid move </summary>
		public onRapid Rapid = delegate{};
		///<summary> 5-axis Rapid move </summary>
		public onRapid5D Rapid5D = delegate{};
		///<summary> Rotary axes limits are exceeded </summary>
		public onRewindMachine RewindMachine = delegate{};
		///<summary> Start of an operation </summary>
		public onSection Section = delegate{};
		///<summary> End of an operation </summary>
		public onSectionEnd SectionEnd = delegate{};
		///<summary> End of a special cycle operation </summary>
		public onSectionEndSpecialCycle SectionEndSpecialCycle = delegate{};
		///<summary> Start of a special cycle operation (Stock Transfer) </summary>
		public onSectionSpecialCycle SectionSpecialCycle = delegate{};
        ///<summary> Spindle speed changes </summary>
		public onSpindleSpeed SpindleSpeed = delegate{};
		///<summary> Post processing has completed, output files are closed </summary>
		public onTerminate Terminate = delegate{};
        ///<summary> Tool compensation mode changes </summary>
		public onToolCompensation ToolCompensation = delegate{};


		public void SetDelegats()
		{
		 
		 if (engine.Evaluate<bool>("onCircular != undefined ? true : false ;"))
			{Circular=delegate(bool clockwise, double cx, double cy, double cz, double x, double y, double z, int feed)
				{engine.CallGlobalFunction("onCircular", clockwise, cx, cy, cz, x, y, z, feed);};
			}
		 
		 if (engine.Evaluate<bool>("onClose != undefined ? true : false ;"))
			{Close=delegate(){engine.CallGlobalFunction("onClose");};}
		 
		 if (engine.Evaluate<bool>("onCommand != undefined ? true : false ;"))
			{Command=delegate(ManualCommand value){engine.CallGlobalFunction("onCommand", value);};}
		 
		 if (engine.Evaluate<bool>("onComment != undefined ? true : false ;"))
			{Comment=delegate(string message){engine.CallGlobalFunction("onComment", message);};}
		 
		 if (engine.Evaluate<bool>("onCycle != undefined ? true : false ;"))
			{Cycle=delegate(){engine.CallGlobalFunction("onCycle");};}
		 
		 if (engine.Evaluate<bool>("onCycleEnd != undefined ? true : false ;"))
			{CycleEnd=delegate(){engine.CallGlobalFunction("onCycleEnd");};}
		 
		 if (engine.Evaluate<bool>("onCyclePoint != undefined ? true : false ;"))
			{CyclePoint=delegate(double x, double y, double z){engine.CallGlobalFunction("onCyclePoint", x, y, z);};}
		 
		 if (engine.Evaluate<bool>("onDwell != undefined ? true : false ;"))
			{Dwell=delegate(double seconds){engine.CallGlobalFunction("onDwell", seconds);};}
		 
		 if (engine.Evaluate<bool>("onLinear != undefined ? true : false ;"))
			{Linear=delegate(double x, double y, double z, int feed){engine.CallGlobalFunction("onLinear", x, y, z, feed);};}
		 
		 if (engine.Evaluate<bool>("onLinear5D != undefined ? true : false ;"))
			{Linear5D=delegate(double x, double y, double z, double a, double b, double c, int feed){engine.CallGlobalFunction("onLinear5D", x, y, z, a, b, c, feed);};}
		 
		 if (engine.Evaluate<bool>("onMachine != undefined ? true : false ;"))
			{Machine=delegate(){engine.CallGlobalFunction("onMachine");};}
		 
		 if (engine.Evaluate<bool>("onManualNC != undefined ? true : false ;"))
			{ManualNC=delegate(){engine.CallGlobalFunction("onManualNC");};}
		 
		 if (engine.Evaluate<bool>("onMovement != undefined ? true : false ;"))
			{Movement=delegate(MovementType movement){engine.CallGlobalFunction("onMovement", movement);};}
		 
		 if (engine.Evaluate<bool>("onOpen != undefined ? true : false ;"))
			{Open=delegate(){engine.CallGlobalFunction("onOpen");};}
		 
		 if (engine.Evaluate<bool>("onOrientateSpindle != undefined ? true : false ;"))
			{OrientateSpindle=delegate(double angle){engine.CallGlobalFunction("onOrientateSpindle", angle);};}
		 
		 if (engine.Evaluate<bool>("onParameter != undefined ? true : false ;"))
			{Parameter=delegate(string name,string value){engine.CallGlobalFunction("onParameter", name, value);};}
		 
		 if (engine.Evaluate<bool>("onPassThrough != undefined ? true : false ;"))
			{PassThrough=delegate(string text){engine.CallGlobalFunction("onPassThrough", text);};}
		 
		 if (engine.Evaluate<bool>("onPower != undefined ? true : false ;"))
			{Power=delegate(bool value){engine.CallGlobalFunction("onPower", value);};}
		 
		 if (engine.Evaluate<bool>("onRadiusCompensation != undefined ? true : false ;"))
			{RadiusCompensation=delegate(){engine.CallGlobalFunction("onRadiusCompensation");};}
		 
		 if (engine.Evaluate<bool>("onRapid != undefined ? true : false ;"))
			{Rapid=delegate(double x, double y, double z){engine.CallGlobalFunction("onRapid", x, y, z);};}
		 
		 if (engine.Evaluate<bool>("onRapid5D != undefined ? true : false ;"))
			{Rapid5D=delegate(double x, double y, double z, double a, double b, double c){engine.CallGlobalFunction("onRapid5D", x, y, z, a, b, c);};}
		 
		 if (engine.Evaluate<bool>("onRewindMachine != undefined ? true : false ;"))
			{RewindMachine=delegate(double a, double b, double c){engine.CallGlobalFunction("onRewindMachine");};}
		 
		 if (engine.Evaluate<bool>("onSection != undefined ? true : false ;"))
			{Section=delegate(){engine.CallGlobalFunction("onSection");};}
		 
		 if (engine.Evaluate<bool>("onSectionEnd != undefined ? true : false ;"))
			{SectionEnd=delegate(){engine.CallGlobalFunction("onSectionEnd");};}
		 
		 if (engine.Evaluate<bool>("onSectionEndSpecialCycle != undefined ? true : false ;"))
			{SectionEndSpecialCycle=delegate(){engine.CallGlobalFunction("onSectionEndSpecialCycle");};}
		 
		 if (engine.Evaluate<bool>("onSectionSpecialCycle != undefined ? true : false ;"))
			{SectionSpecialCycle=delegate(){engine.CallGlobalFunction("onSectionSpecialCycle");};}
         
		 if (engine.Evaluate<bool>("onSpindleSpeed != undefined ? true : false ;"))
			{SpindleSpeed=delegate(int speed){engine.CallGlobalFunction("onSpindleSpeed", speed);};}
		 
		 if (engine.Evaluate<bool>("onTerminate != undefined ? true : false ;"))
			{Terminate=delegate(){engine.CallGlobalFunction("onTerminate");};}
         
		 if (engine.Evaluate<bool>("onToolCompensation != undefined ? true : false ;"))
			{ToolCompensation=delegate(int value){engine.CallGlobalFunction("onToolCompensation", value);};}
		}


    }
}