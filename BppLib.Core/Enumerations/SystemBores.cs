using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with <c>Typ</c> property of the <see cref="S32"/> class.</summary>
    public enum SystemBores
    {
        /// <summary>Boring “centre correction type”.</summary>
        sysCorr = 0,

        /// <summary>Boring “centre-bore type”.</summary>
        sysHole = 1,

        /// <summary>Boring “centre-space type”.</summary>
        sysSpace = 2,

        /// <summary>Boring “correction with movement type”.</summary>
        sysOffset = 3

    }
}