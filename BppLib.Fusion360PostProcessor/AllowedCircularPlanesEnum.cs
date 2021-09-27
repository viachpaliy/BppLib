using System;
using Jurassic;

namespace Fusion360PostProcessor
{
    public enum AllowedCircularPlanesEnum
    {
        /// <summary> Disable circular interpolation.</summary>
        DisableCircularInterpolation = 0,

        /// <summary> Allow circular interpolation in XY plane.</summary>
        PlaneXY = 1, 
        
        /// <summary> Allow circular interpolation in YZ plane.</summary>
        PlaneYZ = 2, 

        /// <summary> Allow circular interpolation in XY and YZ plane.</summary>
        PlaneXYandYZ = 3,
        
        /// <summary> Allow circular interpolation in ZX plane.</summary>
        PlaneZX = 4,

        /// <summary> Allow circular interpolation in XY and ZX plane.</summary>
        PlaneXYandZX = 5,

        /// <summary> Allow circular interpolation in YZ and ZX plane.</summary>
        PlaneYZandZX = 6,

        /// <summary> Allow circular interpolation in all three planes.</summary>
        Undefined = 7
    }
}