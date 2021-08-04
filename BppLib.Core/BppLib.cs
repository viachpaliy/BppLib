using System;
using System.Text;

namespace BppLib.Core
{
    public class BppLib
    {
        /// <summary> Anticlockwise direction. Constant of the <c>Dir</c> parameter.</summary>
        public const int DirCCW = 2;

        /// <summary> Clockwise direction. Constant of the <c>Dir</c> parameter.</summary>
        public const int DirCW = 1;

        /// <summary> Solution 1. Constant of the <c>Sc</c> parameter of the commands to create the drawing.</summary>
        public const int Sc1 = 1;
        
        /// <summary> Solution 2. Constant of the <c>Sc</c> parameter of the commands to create the drawing.</summary>
        public const int Sc2 = 2;

        /// <summary> Option disabled. Constant of the <c>Sc</c> parameter.</summary>
        public const int ScOFF = 0;

        /// <summary> Option enabled. Constant of the <c>Sc</c> parameter.</summary>
        public const int ScOn = 1;

         /// <summary> Inclination/rotation type -abs . Constant of the <c>Cka</c> parameter.</summary>
        public const int AzrABS = 1;

        /// <summary> Inclination/rotation type -incr . Constant of the <c>Cka</c> parameter.</summary>
        public const int AzrINC = 2;

        /// <summary> Inclination disabled. Constant of the <c>Cka</c> parameter.</summary>
        public const int AzrNO = 0 ;

        /// <summary> Option disabled.</summary>
        public const int NO = 0;

        /// <summary> Option enabled.</summary>
        public const int YES = 1;

        /// <summary> Constant of the <c>Rty</c> parameter.
        /// Repeats along the angled straight line.</summary>
        public const int RpAL = 5;

        /// <summary> Constant of the <c>Rty</c> parameter.
        /// Repeats along the circumference.</summary>
        public const int RpCIR = 3;

        /// <summary> Constant of the <c>Rty</c> parameter.</summary>
        public const int RpNO = -1;

        /// <summary> Constant of the <c>Rty</c> parameter.
        /// Repeats along the X-axis.</summary>
        public const int RpX = 0;

        /// <summary> Constant of the <c>Rty</c> parameter.
        /// Repeats along the X-Y step.</summary>
        public const int RpXY = 2;

        /// <summary> Constant of the <c>Rty</c> parameter.
        /// Repeats along the Y-axis.</summary>
        public const int RpY = 1;

        /// <summary> Constant of the <c>Rmd</c> parameter.</summary>
        public const int RmdAuto = -1;

        /// <summary> Constant of the <c>Rmd</c> parameter.</summary>
        public const int RmdComplete = 1;

        /// <summary> Constant of the <c>Rmd</c> parameter.</summary>
        public const int RmdPartial = 2;

        /// <summary> Constant of the <c>Rmd</c> parameter.</summary>
        public const int RmdQuote = 3;

    }
}