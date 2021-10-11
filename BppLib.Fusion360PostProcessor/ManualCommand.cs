using System;
using Jurassic;

namespace Fusion360PostProcessor
{
    public enum ManualCommand
    {
		/// <summary> Activate threading mode </summary>
		COMMAND_ACTIVATE_SPEED_FEED_SYNCHRONIZATION,
		/// <summary> Alarm </summary>
		COMMAND_ALARM,
		/// <summary> Alert </summary>
		COMMAND_ALERT,
		/// <summary> Tool break control </summary>
		COMMAND_BREAK_CONTROL,
		/// <summary> Run calibration cycle </summary>
		COMMAND_CALIBRATE,
		/// <summary> Change pallet </summary>
		COMMAND_CHANGE_PALLET,
		/// <summary> Run cleaning cycle </summary>
		COMMAND_CLEAN,
		/// <summary> Close primary door </summary>
		COMMAND_CLOSE_DOOR,
		/// <summary> Coolant off (M09) </summary>
		COMMAND_COOLANT_OFF,
		/// <summary> Coolant on (M08) </summary>
		COMMAND_COOLANT_ON,
		/// <summary> Deactivate threading mode </summary>
		COMMAND_DEACTIVATE_SPEED_FEED_SYNCHRONIZATION,
		/// <summary> Program end (M02) </summary>
		COMMAND_END,
		/// <summary> Exact stop </summary>
		COMMAND_EXACT_STOP,
		/// <summary> Tool change (M06) </summary>
		COMMAND_LOAD_TOOL,
		/// <summary> Locks the rotary axes </summary>
		COMMAND_LOCK_MULTI_AXIS,
		/// <summary> Close main chuck </summary>
		COMMAND_MAIN_CHUCK_CLOSE,
		/// <summary> Open main chuck </summary>
		COMMAND_MAIN_CHUCK_OPEN,
		/// <summary> Open primary door </summary>
		COMMAND_OPEN_DOOR,
		/// <summary> Optional program stop (M01) </summary>
		COMMAND_OPTIONAL_STOP,
		/// <summary> Orientate spindle (M19) </summary>
		COMMAND_ORIENTATE_SPINDLE,
		/// <summary> Power off </summary>
		COMMAND_POWER_OFF,
		/// <summary> Power on </summary>
		COMMAND_POWER_ON,
		/// <summary> Close secondary chuck </summary>
		COMMAND_SECONDARY_CHUCK_CLOSE,
		/// <summary> Open secondary chuck </summary>
		COMMAND_SECONDARY_CHUCK_OPEN,
		/// <summary> Activate spindle synchronization </summary>
		COMMAND_SECONDARY_SPINDLE_SYNCHRONIZATION_ACTIVATE,
		/// <summary> Deactivate spindle synchronization </summary>
		COMMAND_SECONDARY_SPINDLE_SYNCHRONIZATION_DEACTIVATE,
		/// <summary> Clockwise spindle direction (M03) </summary>
		COMMAND_SPINDLE_CLOCKWISE,
		/// <summary> Counter-clockwise spindle direction (M04)</summary>
		COMMAND_SPINDLE_COUNTERCLOCKWISE,
		/// <summary> Start chip conveyor </summary>
		COMMAND_START_CHIP_TRANSPORT,
		/// <summary> Start spindle in previous direction </summary>
		COMMAND_START_SPINDLE,
		/// <summary> Program stop (M00) </summary>
		COMMAND_STOP,
		/// <summary> Stop chip conveyor </summary>
		COMMAND_STOP_CHIP_TRANSPORT,
		/// <summary> Stop spindle (M05) </summary>
		COMMAND_STOP_SPINDLE,
		/// <summary> Measure tool </summary>
		COMMAND_TOOL_MEASURE,
		/// <summary> Unlocks the rotary axes </summary>
		COMMAND_UNLOCK_MULTI_AXIS,
		/// <summary> Verify path/tool/machine integrity </summary>
		COMMAND_VERIFY
    }
}