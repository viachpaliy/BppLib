using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with <c>Tin</c> and <c>Tou</c> properties of milling classes.</summary>
    public enum LeadInOutType
    {
        None = 0,
        Curve = 1,
        Line = 2,
        TgLineCurve = 3,
        Helix = 5,
        Curve3DLine = 6,
        Corrected3DLine = 7,
        Corrected3DCurve = 8,
        CorrectedLine = 9,
        Profile3D = 14
    }
}