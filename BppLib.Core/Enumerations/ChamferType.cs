using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Ct</c> property of figures.</summary>
    public enum  ChamferType
    {
        /// <summary>No chamfering.</summary>
        cmfNO = 0,

        /// <summary>Straight chamfering.</summary>
        cmfLIN = 1,

        /// <summary>Rounded chamfering.</summary>
        cmfCIR = 2
    }
}