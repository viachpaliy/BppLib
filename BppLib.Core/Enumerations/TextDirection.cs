using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Vrs</c> property of <see cref="GeoText"/> class.</summary>
    public enum TextDirection
    {
        /// <summary>From right to left.</summary>
        RightToLeft = 1,

        /// <summary>From left to right</summary>
        LeftToRight = 0,

        /// <summary>From top to bottom.</summary>
        TopToBottom = 2,

        /// <summary>From bottom to top</summary>
        BottomToTop = 3
    }
}