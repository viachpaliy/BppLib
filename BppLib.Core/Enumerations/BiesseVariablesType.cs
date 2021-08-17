using System;
using System.Text;

namespace BppLib.Core
{
    public enum BiesseVariablesType
    {
        /// <summary> General.</summary>
        General = 0,

        /// <summary> Whole number.</summary>
        Integer = 1,

        /// <summary> Real number.</summary>
        Real = 2,

        /// <summary> String.</summary>
        String = 3,

        /// <summary> Distance in mm.</summary>
        Distance = 4, 

        /// <summary> Velocity in mm/min.</summary>
        Velocity = 5,

        /// <summary> Angle in degrees.</summary>
        Angle = 6,

        /// <summary> Time in seconds.</summary>
        Time = 7,

        /// <summary> Percentage.</summary>
        Percentage = 8

    }
}