using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Osl</c> property.</summary>
    public enum OffsetSelectionType
    {
        /// <summary>the tangential parts following on from the selected geometry are also copied.</summary>
        oslTan = 0,

        /// <summary>only the selected geometry part is copied.</summary>
        oslSel = 1
    }

}