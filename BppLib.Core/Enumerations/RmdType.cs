using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Rmd</c> property of boring classes.</summary>
    public enum RmdType
    {
        /// <summary> Models the "rmdAuto" value of  the "RMD" parameter.</summary>
        rmdAuto = -1,

        /// <summary> Models the "rmdComplete" value of  the "RMD" parameter.</summary>
        rmdComplete = 1,

        /// <summary> Models the "rmdPartial" value of  the "RMD" parameter.</summary>
        rmdPartial = 2,

        /// <summary> Models the "rmdQuote" value of  the "RMD" parameter.</summary>
        rmdQuote = 3
    }
}