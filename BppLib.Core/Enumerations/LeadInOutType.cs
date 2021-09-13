using System;
using System.Text;

namespace BppLib.Core
{
    /// <summary>Uses with <c>Tin</c> and <c>Tou</c> properties of milling classes.</summary>
    public enum LeadInOutType
    {
        /// <summary> Lead-in : the tool descends perpendicularly and reaches the machining operation start point directly.
        /// Lead-out : the tool leaves the piece directly at the end of machining point rising perpendicularly to the face.</summary>
        None = 0,

        /// <summary> Lead-in : the tool descends travelling along a line perpendicular to the face and enters the piece
        /// directly reaching the machining start point performing a short arc shaped course along which it corrects its position.
        /// When <c>Cin = true</c> the tool corrects its position before descending, thereby generating a short linear course parallel to the face.
        /// Lead-out : the tool leaves the piece along a short arc-like course along which it corrects its position and a rise perpendicular to the face.
        /// When <c>Cou = true</c> the tool corrects its position at the end of the re-rise, generating a short linear course parallel to the face.
        /// If the values entered in the <c>Zs != 0</c> and <c>Ze != 0</c> this data item is managed as if it were an extension of the geometry/machining operation.</summary>
        Curve = 1,

        /// <summary> Lead-in : the tool descends travelling along a line perpendicular to the face and enters the piece
        /// directly reaching the machining start point performing a short linear course along which it corrects its position.
        /// When <c>Cin = true</c> the tool corrects its position before descending, thereby generating a short linear course parallel to the face.
        /// Lead-out : the tool leaves the piece along a short linear course along which it corrects its position and a rise perpendicular to the face.
        /// When <c>Cou = true</c> the tool corrects its position at the end of the re-rise, generating a short linear course parallel to the face.
        /// If the values entered in the <c>Zs != 0</c> and <c>Ze != 0</c> this data item is managed as if it were an extension of the geometry/machining operation.</summary>
        Line = 2,

        /// <summary> Lead-in : the tool descends travelling along a line perpendicular to the face and enters
        /// the piece reaching the machining start point directly forming a line and a tangential arc along which it corrects its position.
        /// Lead-out : the tool leaves the piece forming a line and a tangential arc along which it corrects its position, and rises travelling along a line perpendicular to the face.</summary>
        TgLineCurve = 3,

        /// <summary> Lead-in : the tool generates a line in the air parallel to the face along which it carries out the correction, 
        /// it descends and moves along a spiral course and enters the piece directly reaching the machining operation start point.
        /// Lead-out : the tool leaves the piece along a spiral path and a line parallel to the face.</summary>
        Helix = 5,

        /// <summary> Lead-in : the tool descends travelling along an inclined line and enters the piece reaching
        /// the machining operation start point performing a short arc along which it corrects its position.
        /// Lead-out : the tool leaves forming a short arc-like course along which it corrects its position and rises following an inclined line.</summary>
        Curve3DLine = 6,

        /// <summary> Lead-in : the tool generates a line in the air parallel to the face along which it carries out the correction,
        /// it descends and moves along an inclined line and enters the piece directly reaching the machining operation start point.
        /// Lead-out : the tool leaves the piece in an inclined rise and follows a line parallel to the face, along which it corrects its position.</summary>
        Corrected3DLine = 7,

        /// <summary> Lead-in : the tool generates a line in the air parallel to the face along which it carries out the correction,
        /// it descends and moves along an arc shaped course and enters the piece directly reaching the machining operation start point.
        /// Lead-out : the tool leaves the piece in an arc-like rise and follows a line parallel to the face, along which it corrects its position.</summary>
        Corrected3DCurve = 8,

        /// <summary> Lead-in : the tool generates a line in the air parallel to the face along which it carries out the correction,
        /// it descends and moves along a line perpendicular to the plane and enters the piece directly reaching the machining operation start point.
        /// Lead-out : the tool leaves the piece in a rise perpendicular to the face and follows a line parallel to the face, along which it corrects its position.</summary>
        CorrectedLine = 9,

        /// <summary> Lead-in : the tool descends travelling along an inclined line and enters the piece directly reaching the machining operation start point.
        /// Lead-out : the tool leaves the piece directly at the end of machining point and rises following an inclined line.
        /// The use of this type of entrance is only allowed with closed profiles.</summary>
        Profile3D = 14
    }
}