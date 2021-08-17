using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Typ</c> property.</summary>
    public enum CuttingType
    {
        /// <summary>The angled cut using the endpoint co-ordinates a reference values.</summary>
        cutXY = 2,

        /// <summary>The angled cut using the X co-ordinate of the endpoint and the angle as reference values.</summary>
        cutXA = 3,

        /// <summary>The angled cut using the Y co-ordinate of the endpoint and the angle as reference values.</summary>
        cutYA = 4,

        /// <summary>The angled cut using the the length and the angle as reference values.</summary>
        cutLA = 5
    }
}