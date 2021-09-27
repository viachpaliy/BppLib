using System;
using Jurassic;

namespace Fusion360PostProcessor
{
    public enum CapabilitiesEnum
    {
		CapabilityMilling = 1,
		CapabilityTurning = 2,
		CapabilityJet = 4,
		CapabilitySetupSheet = 8,
		CapabilityIntermediate = 16
    }
}