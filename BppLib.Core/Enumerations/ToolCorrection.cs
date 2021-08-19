using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with the <c>Crc</c> property.</summary>
    public enum ToolCorrection 
    {
        ///<summary>Positions the tool axis at the centre of the trajectory.</summary>
        Central = 0,

        ///<summary>Positions the tool axis to the right of the trajectory, or
        /// positions the trajectory to the right of the tool.</summary>
        Right = 1,

        ///<summary>Positions the tool axis to the left of the trajectory, or
        /// positions the trajectory to the left of the tool.</summary>
        Left = 2,

        ///<summary>Positions the tool axis using the settings defined in the geometry
        /// indicated in the <c>Gid</c> property.</summary>
        FromGeometry = 7
    }
}