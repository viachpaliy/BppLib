using System;
using Jurassic;

namespace Fusion360PostProcessor
{
    public enum MovementType
    {
		/// <summary> Standard cutting motion. </summary>
		MOVEMENT_CUTTING,
		/// <summary> Extended movement type. Not common. </summary>
		MOVEMENT_EXTENDED,
		/// <summary> Finish cutting motion. </summary>
		MOVEMENT_FINISH_CUTTING,
		/// <summary> Movement at high feedrate. Not typically used. Rapid moves 
        /// output using a linear move at the high feedrate will use the <c>MOVEMENT_RAPID</c>  type.</summary>
		MOVEMENT_HIGH_FEED,
		/// <summary> Lead-in motion. </summary>
		MOVEMENT_LEAD_IN,
		/// <summary> Lead-out motion. </summary>
		MOVEMENT_LEAD_OUT,
		/// <summary> Direction (non-cutting) linking move. </summary>
		MOVEMENT_LINK_DIRECT,
		/// <summary> Transition (cutting) linking move. </summary>
		MOVEMENT_LINK_TRANSITION,
		/// <summary> Plunging move. </summary>
		MOVEMENT_PLUNGE,
		/// <summary> Predrilling motion. </summary>
		MOVEMENT_PREDRILL,
		/// <summary> Ramping entry motion. </summary>
		MOVEMENT_RAMP,
		/// <summary> Helical ramping motion. </summary>
		MOVEMENT_RAMP_HELIX,
		/// <summary> Profile ramping motion. </summary>
		MOVEMENT_RAMP_PROFILE,
		/// <summary> Zig-Zag ramping motion. </summary>
		MOVEMENT_RAMP_ZIG_ZAG,
		/// <summary> Rapid movement. </summary>
		MOVEMENT_RAPID,
		/// <summary> Reduced cutting motion. </summary>
		MOVEMENT_REDUCED
    }
}