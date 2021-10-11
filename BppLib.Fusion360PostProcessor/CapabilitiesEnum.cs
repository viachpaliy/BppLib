using System;
using Jurassic;

namespace Fusion360PostProcessor
{
    public enum CapabilitiesEnum
    {
		CAPABILITY_MILLING = 1,
		CAPABILITY_TURNING = 2,
		CAPABILITY_JET = 4,
		CAPABILITY_SETUP_SHEET = 8,
		CAPABILITY_INTERMEDIATE = 16
    }
}