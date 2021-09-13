using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Sht</c> property of  <see cref="Rout"/> and  <see cref="RoutG"/> classes.</summary>
    public enum ShtType
    {
        /// <summary> Models the "spByPos" value of  the "SHT" parameter.</summary>
        spByPos = 0,

        /// <summary> Models the "spByDist" value of  the "SHT" parameter.</summary>
        spByDist = 1,

        /// <summary> Models the "spByPost" value of  the "SHT" parameter.</summary>
        spByPost = 99
    }
}