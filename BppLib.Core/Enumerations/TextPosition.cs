using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Pst</c> property of <see cref="GeoText"/> class.</summary>
    public enum TextPosition
    {
        /// <summary>The text is engraved following the external profile of the circle.</summary>
        txtExt = 0,

        /// <summary>The text is engraved following the internal profile of the circle.</summary>
        txtInt = 1
    }
}