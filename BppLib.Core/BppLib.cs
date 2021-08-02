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
    }
}