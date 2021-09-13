using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Typ</c> property of <see cref="Pock"/> class.</summary>
    public enum PocketType
    {
        /// <summary>Pocketing by machining in parallel lines.</summary>
        ptZIG = 0,

        /// <summary>Pocketing by continuous machining in parallel lines.</summary>
        ptZZ = 1,

        /// <summary>Pocketing using concentric profiles that go from the outside of the profile inwards.</summary>
        ptIN = 2,

        /// <summary>Pocketing using concentric profiles that go from the inside of the profile outwards.</summary>
        ptOUT = 3,

        /// <summary>Profile finishing.</summary>
        ptFSH = 4
    }
}