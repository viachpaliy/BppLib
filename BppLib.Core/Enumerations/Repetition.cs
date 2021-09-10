using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Rty</c> property of geometry,boring,cutting and milling classes.</summary>
    public enum Repetition
    {
        /// <summary>Repeats along the angled straight line.</summary>
        rpAL = 5,

        /// <summary>Repeats along the circumference.</summary>
        rpCIR = 3,

        /// <summary> Repetitions disabled.</summary>
        rpNO = -1,

        /// <summary>Repeats along the X-axis.</summary>
        rpX = 0,

        /// <summary>Repeats along the X-Y step.</summary>
        rpXY = 2,

        /// <summary> Repeats along the Y-axis.</summary>
        rpY = 1

    }
}