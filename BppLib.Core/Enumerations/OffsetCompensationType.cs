using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Crt</c> property.</summary>
    public enum OffsetCompensationType
    {
        /// <summary>Positions the tool axis using the settings defined in the geometry.</summary>
        FromGeometry = 0,

        /// <summary>A positive value in the propery <c>Ofs</c> is the same as <c>ToolCorrection.Left</c>
        /// A negative value in the propery <c>Ofs</c> is the same as <c>ToolCorrection.Right</c>.</summary>
        LeftRight = 1,

        /// <summary>A positive value in the propery <c>Ofs</c> - positions the axis of the tool at the outside of the closed profile.
        /// A negative value in the propery <c>Ofs</c> - positions the axis of the tool at the inside of the closed profile.</summary> 
        InternalExternal = 2
    }

}