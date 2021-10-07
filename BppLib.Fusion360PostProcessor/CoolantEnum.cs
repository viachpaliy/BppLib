using System;
using Jurassic;

namespace Fusion360PostProcessor
{
    public enum CoolantEnum
    {
        COOLANT_FLOOD = 1,
		COOLANT_MIST = 2,
		COOLANT_THROUGH_TOOL = 3,
		COOLANT_AIR = 4,
		COOLANT_AIR_THROUGH_TOOL = 5,
		COOLANT_SUCTION = 6,
		COOLANT_FLOOD_MIST = 7,
		COOLANT_FLOOD_THROUGH_TOOL = 8,
		COOLANT_OFF = 0
    }
}